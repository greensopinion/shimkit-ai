# macOS setup instructions for `shimkit-ai`

These steps assume you already have the following installed:

- Git
- Visual Studio Code
- Kiro

The remaining required tooling is:

- a current .NET SDK
- the recommended VSCode extensions for C# development:
  - `ms-dotnettools.csdevkit` (C# Dev Kit)
  - `ms-dotnettools.csharp` (C#)
  - `EditorConfig.EditorConfig` (EditorConfig for VS Code)

## 1. Confirm your existing tools are available

Open Terminal and run:

```bash
git --version
code --version
```

You should see version output for both commands.

If `code` is not found, open VSCode and enable the shell command from the Command Palette by searching for:

- `Shell Command: Install 'code' command in PATH`

Then close Terminal, open a new Terminal window, and run:

```bash
code --version
```

## 2. Install the .NET SDK

For `shimkit-ai`, install the .NET SDK rather than just the runtime. You need the SDK to create, build, test, and run C# projects.

### Recommended approach

1. Open the official .NET macOS install page from Microsoft:
   - https://learn.microsoft.com/en-us/dotnet/core/install/macos
2. Download the SDK installer for your Mac:
   - Arm64 if your Mac has Apple Silicon (M1, M2, M3, M4)
   - x64 if your Mac is Intel
3. Run the installer and complete the installation.

### Verify the install

After installation, restart Terminal and run:

```bash
dotnet --info
dotnet --list-sdks
```

You should see installed SDK versions listed.

### Recommendation for this repo

When you create the repo, pin the SDK in `global.json`. On your machine, install the SDK version that matches `global.json`. If that file does not exist yet, install the latest SDK first and then pin the repo to the version you want to standardize on.

## 3. Install the required VSCode extensions

Install these three extensions.

### Option A: install from Terminal

```bash
code --install-extension ms-dotnettools.csdevkit
code --install-extension ms-dotnettools.csharp
code --install-extension EditorConfig.EditorConfig
```

### Option B: install from VSCode UI

1. Open VSCode
2. Go to Extensions
3. Search for and install:
   - C# Dev Kit
   - C#
   - EditorConfig for VS Code

### Why these extensions

- C# Dev Kit adds solution/project management and integrated test discovery/execution for C# in VSCode.
- C# provides the core language support for C# in VSCode and is the base extension used with C# Dev Kit.
- EditorConfig for VS Code applies formatting and editor settings from `.editorconfig` files, which is useful for a shared team code style.

## 4. Restart VSCode

After installing the extensions, fully quit and reopen VSCode so the C# tooling loads cleanly.

## 5. Verify the VSCode tooling

Open Terminal and create a temporary test project:

```bash
mkdir -p ~/tmp/shimkit-dotnet-check
cd ~/tmp/shimkit-dotnet-check
dotnet new console -n HelloDotnet
code HelloDotnet
```

In VSCode:

1. Open `Program.cs`
2. Wait a few moments for the C# tooling to initialize
3. Confirm that:
   - syntax highlighting works
   - IntelliSense appears
   - no extension-install prompts remain for core C# support

You can also verify the project builds from Terminal:

```bash
cd ~/tmp/shimkit-dotnet-check/HelloDotnet
dotnet build
dotnet run
```

If everything is working, you should see a successful build and the default console output.
