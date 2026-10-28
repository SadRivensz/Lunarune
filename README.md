# Lunarune

Aplicativo Windows em C# WPF para listar diretórios de perfil e abrir o RuneLite. O repositório começa sem caminhos pessoais ou dados de conta; selecione RuneLite.exe e a pasta credentials no próprio app.

## Privacidade e comportamento

As preferências locais guardam apenas os caminhos escolhidos pelo usuário e o idioma. O Lunarune não lê, copia, importa ou modifica arquivos de autenticação, tokens, senhas ou dados de contas. A lista de perfis mostra somente nomes de subpastas em memória. O launcher abre o executável RuneLite escolhido e mantém o painel aberto.

O script PowerShell anterior está fora deste projeto e permanece intacto.

## Idiomas

Português, inglês, espanhol, francês, alemão e japonês. A seleção é salva localmente em `%LOCALAPPDATA%\Lunarune\settings.json`.

## Compilar no Windows

Instale o SDK .NET 10 e execute na pasta do projeto:

```powershell
dotnet build -c Release
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -o publish
```

O projeto usa `WinExe`, ícone da Emilia e imagem incorporada. A atualização automática será adicionada depois que a primeira versão compilável estiver disponível; a proposta é usar Velopack com artefatos publicados em GitHub Releases ou hospedagem estática.
