# Compilar e publicar o Lunarune

Este guia é para quem quer desenvolver ou gerar a própria compilação. O guia para quem só quer baixar e usar está no README.

## Requisitos

- Windows x64
- SDK .NET 10 (não basta instalar somente o Runtime): https://dotnet.microsoft.com/en-us/download/dotnet/10.0
- Git

## Obter o código e compilar

```powershell
git clone https://github.com/SadRivensz/Lunarune.git
cd Lunarune
dotnet --version
dotnet publish .\Lunarune.csproj -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true -o .\publish
```

O executável final fica em `publish\Lunarune.exe`. A publicação `self-contained` inclui o runtime do .NET; quem receber o arquivo não precisa instalar o SDK.

## Publicar uma nova versão

O workflow `.github/workflows/release.yml` compila o app no GitHub e cria uma Release com o executável e um ZIP quando uma tag iniciada por `v` é enviada.

1. Atualize `<Version>` em `Lunarune.csproj` (por exemplo, `0.1.1`).
2. Faça commit e envie as alterações para `main`.
3. Crie e envie uma tag correspondente:

```powershell
git tag v0.1.1
git push origin v0.1.1
```

Acompanhe a compilação na aba **Actions**. Quando terminar, a versão e os arquivos para download aparecerão em **Releases**.
