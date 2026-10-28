# Lunarune

Aplicativo Windows em C# WPF para listar diretórios de perfil e abrir o RuneLite. Selecione o executável e a pasta de perfis pela interface; o repositório não inclui caminhos pessoais configurados.

## Privacidade e comportamento

As preferências locais guardam apenas os caminhos escolhidos e o idioma. O Lunarune não lê, copia, importa ou modifica arquivos de autenticação, tokens, senhas ou dados de contas. A lista de perfis mostra os nomes das subpastas apenas durante a execução. O app abre o RuneLite escolhido e permanece aberto.

O script PowerShell anterior está fora deste projeto e não é alterado por ele.

## Idiomas

Português, inglês, espanhol, francês, alemão e japonês. A seleção fica salva localmente em `%LOCALAPPDATA%\Lunarune\settings.json`.

## Compilar localmente

Instale o SDK .NET 10 e rode na pasta do projeto:

```powershell
dotnet publish .\Lunarune.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true -o .\publish
```

## Publicar uma versão no GitHub

O workflow em `.github/workflows/release.yml` cria automaticamente uma Release com o `.exe` e um ZIP independente quando uma tag `v*` é enviada. Exemplo para a primeira versão:

```powershell
git tag v0.1.0
git push origin v0.1.0
```

Cada tag aparece como uma versão separada na aba **Releases**. O executável é Windows x64 e inclui o runtime .NET. O seletor de atualizações automáticas dentro do app ainda não foi integrado; por ora, os usuários baixam a nova versão na Release.
