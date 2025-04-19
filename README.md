# Schedule-1-Change-Console-Bind
A simple mod for [Schedule I](https://store.steampowered.com/app/3164500/Schedule_I/) using [MelonLoader](https://melonwiki.xyz/) that lets you customize the key used to open the in-game console.

## 🔧 Features

- Manually toggle the console UI with a custom key.
- Change the console key at runtime (default is `F1`).
- Press `F10` in-game to rebind the key.
- Preferences are saved automatically.

## 📦 Requirements

- **MelonLoader** installed on Schedule I.
- .NET Framework 4.7.2 or higher (for building).
- Visual Studio 2019 or newer (recommended).

## 🚀 Installation

1. Make sure **MelonLoader** is installed correctly in `Schedule I`.
2. Build the project or download `changeConsoleShortcut.dll`.
3. Place the DLL inside the `Mods/` folder under the game's root directory.
4. Launch the game. You should see the log message:  
`changeConsoleShortcut Initialized. Console key set to F1`

## 🕹️ How to Use

- Press `F1` to open the in-game console.
- Press `F10` at any time to rebind the console key.
- After pressing `F10`, press any key you want to assign.

## 📁 Config File

Preferences are saved automatically to:
%AppData%..\LocalLow\TVGS\Schedule I\MelonLoader\Preferences.cfg
You’ll see a category named `[ConsoleShortcut]` with your saved key.

