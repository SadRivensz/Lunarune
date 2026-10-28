# Lunarune

**Um companheiro visual para abrir o RuneLite e consultar suas pastas de perfil no Windows.**

## Baixar

- [Baixar o Lunarune.exe da versão mais recente](https://github.com/SadRivensz/Lunarune/releases/latest/download/Lunarune.exe)
- [Ver todas as versões e notas de atualização](https://github.com/SadRivensz/Lunarune/releases)

O executável publicado é para Windows x64 e inclui o runtime necessário. Não é preciso instalar o SDK .NET. O Lunarune é portátil: baixe o arquivo e abra-o; não há assistente de instalação. Se preferir, fixe o executável na área de trabalho ou no menu Iniciar.

Como o aplicativo ainda não tem assinatura digital, o Windows pode exibir um aviso de segurança ao abrir. Confira se o arquivo veio da página oficial de Releases do projeto antes de executá-lo.

## Configuração inicial

1. Abra o Lunarune.
2. Clique em **Localizar RuneLite.exe...** e selecione o executável do RuneLite instalado no seu computador.
3. Clique em **Localizar pasta credentials...** e selecione a pasta que contém as pastas de perfil.
4. Escolha o idioma no seletor no topo da janela.

A lista mostra as subpastas encontradas no diretório selecionado. Se não aparecer nenhum perfil, confira se você escolheu a pasta correta. O botão para abrir a pasta leva ao diretório selecionado no Explorador de Arquivos.

## O que acontece ao abrir o RuneLite

**Abrir outra instância** inicia o executável RuneLite selecionado e deixa o Lunarune aberto. A seleção de uma linha serve para destacar um perfil na lista; ela não troca a conta nem realiza login automático. A autenticação continua sendo feita pelo próprio RuneLite e pelos meios oficiais.

## Privacidade e armazenamento

O Lunarune não lê o conteúdo dos arquivos de autenticação, não copia nem altera credenciais e não salva senhas, tokens, nomes de conta ou o perfil selecionado.

As únicas preferências gravadas localmente são os caminhos que você escolheu para o RuneLite e para a pasta de perfis, além do idioma. Elas ficam em:

`%LOCALAPPDATA%\Lunarune\settings.json`

Os nomes das subpastas são exibidos na lista durante o uso, mas não são gravados nas preferências. O aplicativo não envia esses dados pela internet. A pasta `credentials` permanece no seu computador: **não a envie para o GitHub nem compartilhe seus arquivos de autenticação**.

## Idiomas

Português, inglês, espanhol, francês, alemão e japonês. A escolha fica salva localmente junto às outras preferências.

## Atualizações

As versões disponíveis ficam na página [Releases](https://github.com/SadRivensz/Lunarune/releases). Baixe o executável da versão mais recente para atualizar. As preferências permanecem separadas do aplicativo.
