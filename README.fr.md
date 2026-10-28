# Lunarune

**Un compagnon visuel pour ouvrir RuneLite et consulter les dossiers de profils sous Windows.**

**Lire dans une autre langue :** [Português](README.md) · [English](README.en.md) · [Español](README.es.md) · [Deutsch](README.de.md) · [日本語](README.ja.md)

## Télécharger

- [Télécharger la dernière version de Lunarune.exe](https://github.com/SadRivensz/Lunarune/releases/latest/download/Lunarune.exe)
- [Voir toutes les versions et leurs notes](https://github.com/SadRivensz/Lunarune/releases)

L’exécutable publié est destiné à Windows x64 et inclut le runtime .NET nécessaire. Il n’est pas nécessaire d’installer le SDK .NET. Lunarune est portable : téléchargez le fichier et lancez-le, sans assistant d’installation. Vous pouvez créer un raccourci sur le bureau ou dans le menu Démarrer.

L’application n’étant pas encore signée numériquement, Windows peut afficher un avertissement de sécurité. Vérifiez que le fichier provient de la page officielle des Releases avant de l’ouvrir.

## Première configuration

1. Ouvrez Lunarune.
2. Cliquez sur **Localiser RuneLite.exe...** et sélectionnez l’exécutable RuneLite installé sur votre ordinateur.
3. Cliquez sur **Choisir le dossier credentials...** et sélectionnez le dossier contenant les dossiers de profils.
4. Choisissez une langue avec le sélecteur en haut de la fenêtre.

La liste affiche les sous-dossiers du répertoire choisi. Si aucun profil n’apparaît, vérifiez le dossier sélectionné. Le bouton du dossier ouvre cet emplacement dans l’Explorateur de fichiers.

## Trouver les dossiers sous Windows

Ouvrez l’Explorateur de fichiers avec **Win + E**. Pour accéder directement à un dossier, appuyez sur **Ctrl + L**, collez le chemin ci-dessous dans la barre d’adresse, puis appuyez sur **Entrée**.

- **Dossier RuneLite :** `%LOCALAPPDATA%\RuneLite`. Dans la fenêtre de sélection de Lunarune, recherchez et choisissez `RuneLite.exe` dans ce dossier. Le chemin complet ressemble généralement à `C:\Users\votre-utilisateur-Windows\AppData\Local\RuneLite`.
- **Dossier des profils :** `%USERPROFILE%\.runelite\credentials`. Sélectionnez ce dossier avec le bouton de recherche du dossier credentials dans Lunarune. Le chemin complet ressemble généralement à `C:\Users\votre-utilisateur-Windows\.runelite\credentials`.

Windows remplace `%LOCALAPPDATA%` et `%USERPROFILE%` par les chemins de votre compte ; vous n’avez pas à modifier `votre-utilisateur-Windows`. Le dossier `.runelite` peut être masqué, mais le chemin complet collé dans la barre d’adresse permet de l’ouvrir. Si l’un des dossiers se trouve ailleurs, choisissez son emplacement réel dans Lunarune.

## Ouverture de RuneLite

**Ouvrir une autre instance** lance l’exécutable RuneLite sélectionné et laisse Lunarune ouvert. La sélection d’une ligne ne fait que mettre un profil en surbrillance ; elle ne change pas de compte et ne connecte pas automatiquement. L’authentification reste gérée par RuneLite et ses moyens officiels.

## Confidentialité et données locales

Lunarune ne lit pas le contenu des fichiers d’authentification, ne copie ni ne modifie les identifiants et n’enregistre pas les mots de passe, jetons, noms de compte ou profils sélectionnés.

Les seules préférences enregistrées localement sont les chemins RuneLite et profils que vous choisissez, ainsi que la langue. Elles sont stockées ici :

**%LOCALAPPDATA%\\Lunarune\\settings.json**

Les noms des dossiers sont affichés pendant l’exécution, mais ne sont pas enregistrés dans les préférences. L’application n’envoie pas ces données sur Internet. Votre dossier credentials reste sur votre ordinateur : **ne le téléversez pas sur GitHub et ne partagez pas les fichiers d’authentification.**

## Langues

Portugais, anglais, espagnol, français, allemand et japonais. Le choix est enregistré avec les autres préférences locales.

## Mises à jour

Consultez les versions disponibles dans la page [Releases](https://github.com/SadRivensz/Lunarune/releases). Téléchargez le dernier exécutable pour mettre à jour. Vos préférences restent séparées de l’application.
