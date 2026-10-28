using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using ShapePath = System.Windows.Shapes.Path;
using Microsoft.Win32;

namespace Lunarune;

public partial class MainWindow : Window
{
    private static readonly string SettingsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Lunarune");
    private static readonly string SettingsFile = Path.Combine(SettingsFolder, "settings.json");
    private Settings _settings = new();
    private bool _ready;

    private static readonly Dictionary<string, UiText> Texts = new()
    {
        ["pt-BR"] = new("Português", "Companheiro do RuneLite", "SUA AVENTURA", "Perfis locais", "Pastas encontradas no diretório configurado.", "O painel permanece aberto enquanto você joga.", "ABRIR OUTRA INSTÂNCIA", "Abrir pasta de perfis", "Localizar RuneLite.exe...", "Localizar pasta credentials...", "RE:ZERO | EMILIA", "Uma nova aventura começa aqui.", "Lunarune | seu launcher pessoal", "Selecione a pasta credentials para listar perfis.", "Nenhum perfil encontrado.", "Selecione RuneLite.exe para continuar.", "RuneLite aberto.", "Não foi possível abrir: "),
        ["en-US"] = new("English", "RuneLite companion", "YOUR ADVENTURE", "Local profiles", "Folders found in the configured directory.", "The panel stays open while you play.", "OPEN ANOTHER INSTANCE", "Open profiles folder", "Locate RuneLite.exe...", "Locate credentials folder...", "RE:ZERO | EMILIA", "A new journey starts here.", "Lunarune | your personal game launcher", "Select the credentials folder to list profiles.", "No profiles found.", "Select RuneLite.exe to continue.", "RuneLite opened.", "Could not open: "),
        ["es-ES"] = new("Español", "Compañero de RuneLite", "TU AVENTURA", "Perfiles locales", "Carpetas del directorio configurado.", "El panel permanece abierto mientras juegas.", "ABRIR OTRA INSTANCIA", "Abrir carpeta de perfiles", "Buscar RuneLite.exe...", "Buscar carpeta credentials...", "RE:ZERO | EMILIA", "Una nueva aventura comienza aquí.", "Lunarune | tu launcher personal", "Selecciona credentials para listar perfiles.", "No se encontraron perfiles.", "Selecciona RuneLite.exe para continuar.", "RuneLite abierto.", "No se pudo abrir: "),
        ["fr-FR"] = new("Français", "Compagnon RuneLite", "VOTRE AVENTURE", "Profils locaux", "Dossiers du répertoire configuré.", "Le panneau reste ouvert pendant le jeu.", "OUVRIR UNE AUTRE INSTANCE", "Ouvrir le dossier des profils", "Localiser RuneLite.exe...", "Choisir le dossier credentials...", "RE:ZERO | EMILIA", "Une nouvelle aventure commence ici.", "Lunarune | votre lanceur personnel", "Choisissez credentials pour lister les profils.", "Aucun profil trouvé.", "Choisissez RuneLite.exe pour continuer.", "RuneLite est ouvert.", "Impossible d’ouvrir : "),
        ["de-DE"] = new("Deutsch", "RuneLite-Begleiter", "DEIN ABENTEUER", "Lokale Profile", "Ordner im ausgewählten Verzeichnis.", "Das Fenster bleibt beim Spielen geöffnet.", "WEITERE INSTANZ ÖFFNEN", "Profilordner öffnen", "RuneLite.exe suchen...", "credentials-Ordner suchen...", "RE:ZERO | EMILIA", "Ein neues Abenteuer beginnt hier.", "Lunarune | dein persönlicher Game-Launcher", "Wähle den credentials-Ordner zum Anzeigen der Profile.", "Keine Profile gefunden.", "Wähle RuneLite.exe aus.", "RuneLite wurde geöffnet.", "Öffnen fehlgeschlagen: "),
        ["ja-JP"] = new("日本語", "RuneLite コンパニオン", "冒険へようこそ", "ローカルプロフィール", "設定したフォルダー内の項目です。", "ゲーム中もパネルは開いたままです。", "別のインスタンスを開く", "プロフィールフォルダーを開く", "RuneLite.exe の場所...", "credentials フォルダーの場所...", "RE:ZERO | エミリア", "新しい冒険がここから始まる。", "Lunarune | あなた専用ランチャー", "プロフィールを表示するには credentials を選択してください。", "プロフィールが見つかりません。", "RuneLite.exe を選択してください。", "RuneLite を起動しました。", "起動できませんでした: ")
    };

    private UiText T => Texts.GetValueOrDefault(_settings.Language, Texts["pt-BR"]);

    public MainWindow()
    {
        InitializeComponent();
        _settings = LoadSettings();
        LanguagePicker.ItemsSource = Texts.Select(kv => new LanguageItem(kv.Key, kv.Value.Language)).ToList();
        LanguagePicker.DisplayMemberPath = nameof(LanguageItem.Name);
        LanguagePicker.SelectedValuePath = nameof(LanguageItem.Code);
        LanguagePicker.SelectedValue = Texts.ContainsKey(_settings.Language) ? _settings.Language : "pt-BR";
        ApplyLanguage();
        _ready = true;
        RefreshProfiles();
        UpdatePaths();
        StartAnimations();
    }

    private static Settings LoadSettings()
    {
        try { if (File.Exists(SettingsFile)) return JsonSerializer.Deserialize<Settings>(File.ReadAllText(SettingsFile)) ?? new(); }
        catch { }
        return new();
    }

    private void SaveSettings()
    {
        Directory.CreateDirectory(SettingsFolder);
        File.WriteAllText(SettingsFile, JsonSerializer.Serialize(_settings, new JsonSerializerOptions { WriteIndented = true }));
    }

    private void ApplyLanguage()
    {
        var t = T;
        Title = $"Lunarune | {t.Subtitle}"; Subtitle.Text = t.Subtitle; Section.Text = t.Section;
        Description.Text = t.Description; KeepOpen.Text = t.KeepOpen; Launch.Content = t.Launch;
        OpenFolder.Content = t.OpenFolder; SelectRune.Content = t.SelectRune; SelectProfiles.Content = t.SelectProfiles;
        Eyebrow.Text = t.Eyebrow; HeroTitle.Text = t.HeroTitle; HeroCaption.Text = t.HeroCaption;
        Count.Text = $"{t.Count} | {Profiles.Items.Count}";
        if (string.IsNullOrWhiteSpace(_settings.ProfilesDirectory)) ProfilePath.Text = t.SelectProfiles;
    }

    private void UpdatePaths()
    {
        ProfilePath.Text = string.IsNullOrWhiteSpace(_settings.ProfilesDirectory) ? T.SelectProfiles : _settings.ProfilesDirectory;
        RunePath.Text = string.IsNullOrWhiteSpace(_settings.RuneLiteExe) ? T.SelectRune : $"RuneLite: {Path.GetDirectoryName(_settings.RuneLiteExe)}";
    }

    private void RefreshProfiles()
    {
        Profiles.Items.Clear();
        if (!string.IsNullOrWhiteSpace(_settings.ProfilesDirectory) && Directory.Exists(_settings.ProfilesDirectory))
            foreach (var dir in Directory.EnumerateDirectories(_settings.ProfilesDirectory).OrderBy(Path.GetFileName, StringComparer.CurrentCultureIgnoreCase))
                Profiles.Items.Add(Path.GetFileName(dir));
        Count.Text = $"{T.Count} | {Profiles.Items.Count}";
        if (Profiles.Items.Count == 0) Status.Text = string.IsNullOrWhiteSpace(_settings.ProfilesDirectory) ? T.SelectProfiles : T.Empty;
    }

    private void LanguagePicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (!_ready || LanguagePicker.SelectedValue is not string code || !Texts.ContainsKey(code)) return;
        _settings.Language = code;
        ApplyLanguage(); RefreshProfiles(); UpdatePaths(); SaveSettings();
    }

    private void Profiles_SelectionChanged(object sender, SelectionChangedEventArgs e) { }

    private void Launch_Click(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_settings.RuneLiteExe) || !File.Exists(_settings.RuneLiteExe)) { Status.Text = T.SelectRune; return; }
        try { Process.Start(new ProcessStartInfo(_settings.RuneLiteExe) { UseShellExecute = true }); Status.Text = T.Launched; }
        catch (Exception ex) { Status.Text = T.LaunchError + ex.Message; }
    }

    private void SelectRune_Click(object sender, RoutedEventArgs e)
    {
        var dialog = new OpenFileDialog { Title = T.SelectRune, Filter = "RuneLite.exe|RuneLite.exe", FileName = "RuneLite.exe", CheckFileExists = true };
        if (dialog.ShowDialog(this) != true) return;
        _settings.RuneLiteExe = dialog.FileName; SaveSettings(); UpdatePaths(); Status.Text = string.Empty;
    }

    private void SelectProfiles_Click(object sender, RoutedEventArgs e)
    {
        var dialog = new OpenFolderDialog { Title = T.SelectProfiles, Multiselect = false };
        if (!string.IsNullOrWhiteSpace(_settings.ProfilesDirectory) && Directory.Exists(_settings.ProfilesDirectory)) dialog.InitialDirectory = _settings.ProfilesDirectory;
        if (dialog.ShowDialog(this) != true) return;
        _settings.ProfilesDirectory = dialog.FolderName; SaveSettings(); RefreshProfiles(); UpdatePaths();
    }

    private void OpenFolder_Click(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_settings.ProfilesDirectory) || !Directory.Exists(_settings.ProfilesDirectory)) { Status.Text = T.SelectProfiles; return; }
        Process.Start(new ProcessStartInfo("explorer.exe", $"\"{_settings.ProfilesDirectory}\"") { UseShellExecute = true });
    }

    private void StartAnimations()
    {
        var glow = new DoubleAnimation(0.10, 0.32, TimeSpan.FromSeconds(2.8)) { AutoReverse = true, RepeatBehavior = RepeatBehavior.Forever };
        Glow.BeginAnimation(OpacityProperty, glow);
        var random = new Random();
        for (var i = 0; i < 36; i++)
        {
            var petal = new ShapePath { Data = Geometry.Parse("M 7,0 C 14,2 13,13 7,17 C 1,13 0,2 7,0 Z"), Fill = new SolidColorBrush(Color.FromArgb(220,255,(byte)random.Next(170,226),(byte)random.Next(205,246))), Stroke = Brushes.White, StrokeThickness = .4, Width = 17, Height = 22, Opacity = .7 };
            var rotate = new RotateTransform(); var move = new TranslateTransform(random.Next(0,480), -30-random.Next(0,700));
            var group = new TransformGroup(); group.Children.Add(rotate); group.Children.Add(move); petal.RenderTransformOrigin = new Point(.5,.5); petal.RenderTransform = group; Sakura.Children.Add(petal);
            move.BeginAnimation(TranslateTransform.YProperty, new DoubleAnimation(-25,720,TimeSpan.FromSeconds(random.Next(22,39))) { BeginTime=TimeSpan.FromSeconds(random.Next(0,18)), RepeatBehavior=RepeatBehavior.Forever });
            move.BeginAnimation(TranslateTransform.XProperty, new DoubleAnimation(move.X-18,move.X+18,TimeSpan.FromSeconds(random.Next(5,10))) { AutoReverse=true, RepeatBehavior=RepeatBehavior.Forever });
            rotate.BeginAnimation(RotateTransform.AngleProperty, new DoubleAnimation(-30,30,TimeSpan.FromSeconds(random.Next(8,17))) { AutoReverse=true, RepeatBehavior=RepeatBehavior.Forever });
        }
    }

    private sealed class Settings
    {
        public string RuneLiteExe { get; set; } = "";
        public string ProfilesDirectory { get; set; } = "";
        public string Language { get; set; } = "pt-BR";
    }
    private sealed record LanguageItem(string Code, string Name);
    private sealed record UiText(string Language, string Subtitle, string Section, string Count, string Description, string KeepOpen, string Launch, string OpenFolder, string SelectRune, string SelectProfiles, string Eyebrow, string HeroTitle, string HeroCaption, string Empty, string RuneMissing, string Launched, string LaunchError);
}
