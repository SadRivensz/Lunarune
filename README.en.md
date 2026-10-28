# Lunarune

**A visual companion for opening RuneLite and viewing profile folders on Windows.**

**Read this in:** [Português](README.md) · [Español](README.es.md) · [Français](README.fr.md) · [Deutsch](README.de.md) · [日本語](README.ja.md)

## Download

- [Download the latest Lunarune.exe](https://github.com/SadRivensz/Lunarune/releases/latest/download/Lunarune.exe)
- [Browse all versions and release notes](https://github.com/SadRivensz/Lunarune/releases)

The published executable is for Windows x64 and includes the required .NET runtime. You do not need to install the .NET SDK. Lunarune is portable: download and run the file; there is no installation wizard. You can create a desktop or Start menu shortcut if you like.

Because the app is not digitally signed, Windows may show a security warning. Make sure the file came from the project's official Releases page before running it.

## First-time setup

1. Open Lunarune.
2. Click **Locate RuneLite.exe...** and select the RuneLite executable installed on your computer.
3. Click **Locate credentials folder...** and select the folder that contains the profile folders.
4. Choose a language from the selector at the top of the window.

The list shows subfolders inside the selected directory. If no profiles appear, check that you selected the correct folder. The folder button opens that location in File Explorer.

## Opening RuneLite

**Open another instance** starts the selected RuneLite executable and leaves Lunarune open. Selecting a row only highlights a profile in the list; it does not switch accounts or sign in automatically. Authentication remains with RuneLite and its official sign-in flow.

## Privacy and local data

Lunarune does not read the contents of authentication files, copy or change credentials, or save passwords, tokens, account names, or the selected profile.

The only preferences saved locally are the RuneLite and profile-folder paths you choose and the selected language. They are stored in:

**%LOCALAPPDATA%\\Lunarune\\settings.json**

Profile-folder names are displayed while the app is running but are not saved in preferences. The app does not send this information over the internet. Your credentials folder stays on your computer: **never upload it to GitHub or share authentication files.**

## Languages

Portuguese, English, Spanish, French, German, and Japanese. Your choice is saved with the other local preferences.

## Updates

Find available versions on the [Releases page](https://github.com/SadRivensz/Lunarune/releases). Download the latest executable to update. Your preferences are stored separately from the app.
