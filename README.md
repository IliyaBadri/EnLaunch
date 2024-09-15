# EnLaunch

EnLaunch is a simple and efficient Minecraft launcher developed using C# and Windows Forms. It utilizes the CmlLib.Core NuGet package to handle the complexities of launching Minecraft, providing users with a straightforward and user-friendly experience.

## Features

- **Simple Interface**: Easy-to-use Windows Forms interface. All features in one window.
- **Minecraft Version Management**: Supports multiple Minecraft versions.
- **External client support**: Added support for Fabric, Forge and any version you can imagine.
- **Robust account management**: Save multiple Microsoft accounts with ease.
- **Robust download system**: Automatically download and install Minecraft resources and Java runtimes.

## Installation
To install this product using the installer you can follow these steps:

1. **Head to releases page**: You can find the latest release installer [here](https://github.com/IliyaBadri/EnLaunch/releases/latest).
2.  **Download the installer**: Download the file named `EnLaunch_Installer.exe`.
3. **Run the installer**: After the download was complete open the executable file.
4. **Follow the instructions to install the program**: The installer will guide you through the installation process.
5. **Run the app for the first time**: The first time you open the launcher it will ask you to enter your game path. This could be a new folder anywhere in your computer (recommended) that you create or the default path of your previous launcher. After you have entered the path hit Continue.
6. **All done**: Now you can download and install a new vanilla version and sign in to your account and start playing.

## Open-Source Installation

To get started with EnLaunch, follow these steps:

1. **Clone the Repository**:
    ```bash
    git clone https://github.com/IliyaBadri/EnLaunch.git
    ```

2. **Open the Solution**:
    Open the `EnLaunch.sln` file in Visual Studio.

3. **Restore NuGet Packages**:
    Visual Studio should automatically restore the required NuGet packages, including CmlLib.Core If not, you can restore them manually via the NuGet Package Manager.

4. **Build the Solution**:
    Build the solution in Visual Studio by clicking on `Build > Build Solution` or by pressing `Ctrl+Shift+B`.

5. **Run the Application**:
    Start the application by clicking on `Debug > Start Debugging` or by pressing `F5`.
    

## Dependencies

- [.NET Framework 4.7.2 or later](https://dotnet.microsoft.com/download/dotnet-framework/net472)
- [CmlLib.Core NuGet package](https://www.nuget.org/packages/CmlLib.Core)

## Contributing

Contributions are welcome! If you have any suggestions or improvements, please create an issue or submit a pull request. For major changes, please open an issue first to discuss what you would like to change.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
