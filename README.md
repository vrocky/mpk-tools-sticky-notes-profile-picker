# StickyNotes Profile Picker

A WPF application for managing and launching StickyNotesApp with different profiles, designed to work with Windows virtual desktops.

## Overview

This tool allows you to:
- **Manage multiple StickyNotes profiles** in one centralized location
- **Launch profiles for specific virtual desktops** automatically
- **Switch between profiles** with a visual picker interface
- **Organize sticky notes** across different workspaces or projects

## Key Features

- **Virtual Desktop Integration**: Automatically detects your current Windows virtual desktop and can launch the appropriate profile
- **Profile Management**: Create and manage multiple isolated StickyNotes profiles
- **Visual Profile Picker**: Browse profiles with colored avatars and quick launch
- **Dark Theme UI**: Modern interface matching the StickyNotes aesthetic

## Usage

### Quick Launch Current Desktop
Click the green "Launch Current Desktop" button to open StickyNotes for your current virtual desktop. The profile will be created automatically if it doesn`'t exist yet.

### Launch Specific Profile
Click any profile card to launch StickyNotes with that specific profile.

### Settings
Click the gear icon (⚙) to configure:
- **Data Directory**: Where profiles are stored (default: `C:\StickyNotesProfiles`)
- **StickyNotesApp Executable**: Path to StickyNotesApp.exe (default: `C:\Program Files\StickyNotesApp\StickyNotesApp.exe`)

## Configuration

Settings are stored in the Windows Registry at:
```
HKEY_CURRENT_USER\Software\StickyNotesProfilePicker
```

## Profile Structure

Profiles are stored under the data directory in a `profiles` subdirectory:
```
C:\StickyNotesProfiles\
  profiles\
    virtual_desktop_1\
      .lock
      config.json
      notes.json
    virtual_desktop_2\
      ...
```

Each profile contains:
- `.lock`: Profile lock file (prevents multiple instances)
- `config.json`: Profile configuration
- `notes.json`: Sticky notes data

## Virtual Desktop Profiles

When using the "Launch Current Desktop" feature, profiles are automatically named as `virtual_desktop_N` where N is the virtual desktop number. This allows seamless integration with Windows virtual desktops.

## Technical Details

- Built with .NET 8.0-windows and WPF
- Uses `--profile` and `--data-dir` arguments to launch StickyNotesApp with isolated profiles
- Detects current virtual desktop via Windows Registry
- Profiles are automatically created when first launched

## Command Line Arguments

When launching StickyNotesApp, the picker uses:
```
StickyNotesApp.exe --profile "virtual_desktop_N" --data-dir "C:\StickyNotesProfiles"
```

## See Also

- [Launch-StickyNotes.ps1](C:\Scripts\StickyNotesProfiles) - PowerShell script for automated virtual desktop launching
- [VS Code Profile Picker](../vscode-profile-picker) - Similar tool for VS Code
- [Antigravity Profile Picker](../antigravity-profile-picker) - Similar tool for Antigravity editor
