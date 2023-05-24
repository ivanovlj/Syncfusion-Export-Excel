# ASP.NET Core Excel Generation

This is a sample project that demonstrates how to generate Excel files in ASP.NET Core using the Syncfusion.XlsIO library.

## Getting Started

### Prerequisites

- .NET 6.0 SDK or later
- Syncfusion.XlsIO (licensed version or trial version)

### Installation

1. Clone the repository or download the source code.
2. Restore the NuGet packages by running the following command in the project root directory:


Obtain the Syncfusion.XlsIO library:
If you have a license, download the licensed version from the Syncfusion website and follow the licensing instructions.

If you want to use the trial version, install the Syncfusion.XlsIO NuGet package by running the following command:

## 
dotnet add package Syncfusion.XlsIO

### Usage
Open the HomeController.cs file located in the Controllers folder.
Update the GenerateExcel action to customize the Excel file generation. You can modify the worksheet data, formatting, and other settings as per your requirements. Ensure that the action is decorated with the [HttpGet] attribute.

If you have a valid Syncfusion license, update the GenerateExcel action to register the license key using Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense method. Place your license file with a .lic extension in the "License" folder, and update the license file path accordingly.
Build and run the project.

### Generating Excel Files
Access the application on https://localhost:{port} (default port is 5001).
Click the "Generate Excel" button to generate and download an Excel file.
The generated Excel file will contain sample data and formatting based on the implementation in the GenerateExcel action.

### License
If you have a valid Syncfusion license, ensure that you have registered the license key as described in the "Usage" section. If you do not have a license, you can use the trial version of Syncfusion.XlsIO for testing and development purposes.

### Contributing
Contributions are welcome! If you have any improvements, bug fixes, or new features, feel free to submit a pull request.

### Issues
If you encounter any issues or have any questions, please open an issue on the GitHub repository.

### Acknowledgments

This project uses the Syncfusion.XlsIO library by Syncfusion for Excel file generation.
