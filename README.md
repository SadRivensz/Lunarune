# Lunarune

Aplicativo Windows em C# WPF para listar diretórios de perfil e abrir o RuneLite. Selecione o executável e a pasta de perfis pela interface; o repositório não inclui caminhos pessoais configurados.

## Privacidade e comportamento

As preferências locais guardam apenas os caminhos escolhidos e o idioma. O Lunarune não lê, copia, importa ou modifica arquivos de autenticação, tokens, senhas ou dados de contas. A lista de perfis mostra os nomes das subpastas apenas durante a execução. O app abre o executável RuneLite escolhido e permanece aberto.

O script PowerShell anterior está fora deste projeto e não é alterado por ele.

## Idiomas

Português, inglês, espanhol, francês, alemão e japonês. A seleção é salva localmente em `%LOCALAPPDATA%\Lunarune\settings.json`.

## Compilar no Windows

Instale o SDK .NET 10 e execute:

```powershell
dotnet publish .\Lunarune.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true -o .\publish
```

O projeto usa `WinExe`, ícone da Emilia e imagem incorporada. Para downloads públicos, publique o código no GitHub e anexe o ZIP da pasta `publish` a uma Release. Atualização automática ainda precisa ser integrada.
