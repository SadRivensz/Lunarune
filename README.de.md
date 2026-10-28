# Lunarune

**Ein visueller Begleiter zum Öffnen von RuneLite und Anzeigen lokaler Profilordner unter Windows.**

**Sprache:** [Português](README.md) · [English](README.en.md) · [Español](README.es.md) · [Français](README.fr.md) · [日本語](README.ja.md)

## Herunterladen

- [Neueste Lunarune.exe herunterladen](https://github.com/SadRivensz/Lunarune/releases/latest/download/Lunarune.exe)
- [Alle Versionen und Versionshinweise ansehen](https://github.com/SadRivensz/Lunarune/releases)

Die veröffentlichte Datei ist für Windows x64 und enthält die benötigte .NET-Laufzeit. Das .NET SDK muss nicht installiert werden. Lunarune ist portabel: Datei herunterladen und starten; ein Installationsassistent ist nicht erforderlich. Bei Bedarf können Sie eine Verknüpfung auf dem Desktop oder im Startmenü anlegen.

Da die App noch nicht digital signiert ist, kann Windows eine Sicherheitswarnung anzeigen. Prüfen Sie vor dem Start, ob die Datei von der offiziellen Releases-Seite stammt.

## Ersteinrichtung

1. Öffnen Sie Lunarune.
2. Klicken Sie auf **RuneLite.exe suchen...** und wählen Sie die installierte RuneLite-Datei aus.
3. Klicken Sie auf **credentials-Ordner suchen...** und wählen Sie den Ordner mit den Profilordnern aus.
4. Wählen Sie oben in der App eine Sprache aus.

Die Liste zeigt die Unterordner des ausgewählten Verzeichnisses. Wenn keine Profile erscheinen, prüfen Sie, ob Sie den richtigen Ordner gewählt haben. Die Schaltfläche für den Ordner öffnet den Speicherort im Datei-Explorer.

## Ordner unter Windows finden

Öffnen Sie den Datei-Explorer mit **Win + E**. Um direkt zu einem Ordner zu wechseln, drücken Sie **Strg + L**, fügen Sie den Pfad in die Adressleiste ein und drücken Sie **Enter**.

- **RuneLite-Ordner:** `%LOCALAPPDATA%\RuneLite`. Suchen Sie im Dateiauswahldialog von Lunarune dort nach `RuneLite.exe` und wählen Sie die Datei aus. Der vollständige Pfad lautet normalerweise `C:\Users\Ihr-Windows-Benutzer\AppData\Local\RuneLite`.
- **Profilordner:** `%USERPROFILE%\.runelite\credentials`. Wählen Sie diesen Ordner über die Schaltfläche zum Suchen des credentials-Ordners in Lunarune aus. Der vollständige Pfad lautet normalerweise `C:\Users\Ihr-Windows-Benutzer\.runelite\credentials`.

Windows ersetzt `%LOCALAPPDATA%` und `%USERPROFILE%` automatisch durch die Pfade Ihres Benutzerkontos. Sie müssen `Ihr-Windows-Benutzer` nicht manuell ändern. Der Ordner `.runelite` kann ausgeblendet sein; über den vollständigen Pfad in der Adressleiste lässt er sich trotzdem öffnen. Liegt ein Ordner an einem anderen Ort, wählen Sie in Lunarune den tatsächlichen Speicherort aus.

## RuneLite starten

**Weitere Instanz öffnen** startet die ausgewählte RuneLite-Datei und lässt Lunarune geöffnet. Eine Zeile auszuwählen hebt das Profil nur in der Liste hervor; dadurch wird weder das Konto gewechselt noch eine automatische Anmeldung ausgeführt. Die Anmeldung erfolgt weiterhin über RuneLite und dessen offizielle Wege.

## Datenschutz und lokale Daten

Lunarune liest nicht den Inhalt von Authentifizierungsdateien, kopiert oder verändert keine Zugangsdaten und speichert keine Passwörter, Tokens, Kontonamen oder ausgewählten Profile.

Lokal gespeichert werden nur die gewählten Pfade zu RuneLite und zum Profilordner sowie die Sprache. Die Einstellungen liegen hier:

**%LOCALAPPDATA%\\Lunarune\\settings.json**

Die Namen der Unterordner werden während der Nutzung angezeigt, aber nicht in den Einstellungen gespeichert. Die App sendet diese Daten nicht über das Internet. Der credentials-Ordner bleibt auf Ihrem Computer: **Laden Sie ihn nicht auf GitHub hoch und teilen Sie keine Authentifizierungsdateien.**

## Sprachen

Portugiesisch, Englisch, Spanisch, Französisch, Deutsch und Japanisch. Die Auswahl wird mit den anderen lokalen Einstellungen gespeichert.

## Aktualisierungen

Alle Versionen finden Sie auf der Seite [Releases](https://github.com/SadRivensz/Lunarune/releases). Laden Sie zum Aktualisieren die neueste ausführbare Datei herunter. Ihre Einstellungen bleiben getrennt von der App.
