# Lunarune

**Um companheiro visual para abrir o RuneLite e consultar suas pastas de perfil no Windows.**

**Leia em:** [English](README.en.md) · [Español](README.es.md) · [Français](README.fr.md) · [Deutsch](README.de.md) · [日本語](README.ja.md)

## Baixar

- [Baixar o Lunarune.exe da versão mais recente](https://github.com/SadRivensz/Lunarune/releases/latest/download/Lunarune.exe)
- [Ver todas as versões e notas de atualização](https://github.com/SadRivensz/Lunarune/releases)

O executável publicado é para Windows x64 e inclui o runtime necessário. Não é preciso instalar o SDK .NET. O Lunarune é portátil: baixe o arquivo e abra-o; não há assistente de instalação. Se preferir, fixe o executável na área de trabalho ou no menu Iniciar.

Como o aplicativo ainda não tem assinatura digital, o Windows pode exibir um aviso de segurança ao abrir. Confira se o arquivo veio da página oficial de Releases do projeto antes de executá-lo.

### Análise no VirusTotal

O arquivo `Lunarune.dll` foi analisado pelo VirusTotal e, nessa análise, **0 de 67 mecanismos** o sinalizaram como malicioso: [ver relatório](https://www.virustotal.com/gui/file/39b88888d076aabce1b3f40c88b40a5711f33b0f2f48455e8701151979a224fa). O relatório corresponde somente ao arquivo identificado por esse hash; confira se o arquivo distribuído na Release é exatamente o mesmo antes de usar o resultado como referência. Uma análise sem detecções não garante risco zero.

## Configuração inicial

1. Abra o Lunarune.
2. Clique em **Localizar RuneLite.exe...** e selecione o executável do RuneLite instalado no seu computador.
3. Clique em **Localizar pasta credentials...** e selecione a pasta que contém as pastas de perfil.
4. Escolha o idioma no seletor no topo da janela.

A lista mostra as subpastas encontradas no diretório selecionado. Se não aparecer nenhum perfil, confira se você escolheu a pasta correta. O botão para abrir a pasta leva ao diretório selecionado no Explorador de Arquivos.

## Onde localizar as pastas no Windows

Abra o Explorador de Arquivos com **Win + E**. Para ir direto a uma pasta, pressione **Ctrl + L**, cole o caminho abaixo na barra de endereço e pressione **Enter**.

Você também pode pressionar **Win + R**, digitar `%USERPROFILE%\.runelite` e pressionar **Enter** para abrir a pasta de configuração do RuneLite. Dentro dela, procure `credentials`; essa é a pasta que deve ser selecionada no Lunarune. Se `credentials` não existir, conclua a configuração e a autenticação pelo RuneLite e pelos meios oficiais. O Lunarune apenas lista as pastas encontradas: ele não cria a pasta nem salva, importa ou altera credenciais.

- **Pasta do RuneLite:** `%LOCALAPPDATA%\RuneLite`. Nesse local, procure e selecione `RuneLite.exe` na janela do Lunarune. O caminho completo normalmente fica em `C:\Users\seu-usuário\AppData\Local\RuneLite`.
- **Pasta de perfis:** `%USERPROFILE%\.runelite\credentials`. Selecione essa pasta no botão de localizar a pasta credentials. O caminho completo normalmente fica em `C:\Users\seu-usuário\.runelite\credentials`.

O Windows substitui `%LOCALAPPDATA%` e `%USERPROFILE%` pelos caminhos do seu próprio usuário; não troque `seu-usuário` manualmente. A pasta `.runelite` pode estar oculta, mas colar o caminho completo na barra de endereço funciona mesmo assim. Se uma pasta não existir nesses locais, procure a instalação/perfis em outro local e selecione a pasta correta na janela do Lunarune.

## O que acontece ao abrir o RuneLite

**Abrir outra instância** inicia o executável RuneLite selecionado e deixa o Lunarune aberto. A seleção de uma linha serve para destacar um perfil na lista; ela não troca a conta nem realiza login automático. A autenticação continua sendo feita pelo próprio RuneLite e pelos meios oficiais.

## Privacidade e armazenamento

O Lunarune não lê o conteúdo dos arquivos de autenticação, não copia nem altera credenciais e não salva senhas, tokens, nomes de conta ou o perfil selecionado.

As únicas preferências gravadas localmente são os caminhos que você escolheu para o RuneLite e para a pasta de perfis, além do idioma. Elas ficam em:

`%LOCALAPPDATA%\Lunarune\settings.json`

Para reaproveitar preferências de uma versão anterior, use **Importar configuração anterior...** e selecione o arquivo JSON antigo. O Lunarune importa somente os caminhos do RuneLite e da pasta de perfis e o idioma; não importa arquivos de autenticação.

Os nomes das subpastas são exibidos na lista durante o uso, mas não são gravados nas preferências. O aplicativo não envia esses dados pela internet. A pasta `credentials` permanece no seu computador: **não a envie para o GitHub nem compartilhe seus arquivos de autenticação**.

## Idiomas

Português, inglês, espanhol, francês, alemão e japonês. A escolha fica salva localmente junto às outras preferências.

## Atualizações

As versões disponíveis ficam na página [Releases](https://github.com/SadRivensz/Lunarune/releases). Baixe o executável da versão mais recente para atualizar. As preferências permanecem separadas do aplicativo.
