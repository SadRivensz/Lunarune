# Lunarune

**Un compañero visual para abrir RuneLite y consultar carpetas de perfiles en Windows.**

**Leer en:** [Português](README.md) · [English](README.en.md) · [Français](README.fr.md) · [Deutsch](README.de.md) · [日本語](README.ja.md)

## Descargar

- [Descargar el Lunarune.exe más reciente](https://github.com/SadRivensz/Lunarune/releases/latest/download/Lunarune.exe)
- [Ver todas las versiones y sus notas](https://github.com/SadRivensz/Lunarune/releases)

El ejecutable publicado es para Windows x64 e incluye el runtime necesario de .NET. No hace falta instalar el SDK de .NET. Lunarune es portátil: descarga el archivo y ábrelo; no hay asistente de instalación. Si quieres, puedes crear un acceso directo en el escritorio o en el menú Inicio.

Como la aplicación aún no tiene firma digital, Windows puede mostrar un aviso de seguridad. Comprueba que el archivo venga de la página oficial de Releases antes de abrirlo.

## Configuración inicial

1. Abre Lunarune.
2. Pulsa **Buscar RuneLite.exe...** y selecciona el ejecutable de RuneLite instalado en tu equipo.
3. Pulsa **Buscar carpeta credentials...** y selecciona la carpeta que contiene las carpetas de perfiles.
4. Elige un idioma en el selector de la parte superior.

La lista muestra las subcarpetas del directorio seleccionado. Si no aparece ningún perfil, comprueba que elegiste la carpeta correcta. El botón de carpeta abre esa ubicación en el Explorador de archivos.

## Al abrir RuneLite

**Abrir otra instancia** inicia el ejecutable de RuneLite seleccionado y deja Lunarune abierto. Seleccionar una fila solo resalta un perfil; no cambia de cuenta ni inicia sesión automáticamente. La autenticación sigue gestionándose en RuneLite mediante sus métodos oficiales.

## Privacidad y datos locales

Lunarune no lee el contenido de los archivos de autenticación, no copia ni modifica credenciales y no guarda contraseñas, tokens, nombres de cuenta ni el perfil seleccionado.

Las únicas preferencias guardadas localmente son las rutas de RuneLite y de la carpeta de perfiles que elijas, además del idioma. Se guardan en:

**%LOCALAPPDATA%\\Lunarune\\settings.json**

Los nombres de las carpetas se muestran mientras la aplicación está abierta, pero no se guardan en las preferencias. La aplicación no envía estos datos por internet. La carpeta credentials permanece en tu equipo: **no la subas a GitHub ni compartas archivos de autenticación.**

## Idiomas

Portugués, inglés, español, francés, alemán y japonés. La elección se guarda con las demás preferencias locales.

## Actualizaciones

Consulta las versiones disponibles en la página de [Releases](https://github.com/SadRivensz/Lunarune/releases). Descarga el ejecutable más reciente para actualizar. Tus preferencias se guardan por separado.
