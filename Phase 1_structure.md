Create the Visual Studio Solution
AmosDocumentValidator.sln
AmosDocumentValidator/
├── AmosDocumentValidator.sln
├── src/
│   ├── AmosDocumentValidator.Core/           # Core business logic
│   ├── AmosDocumentValidator.Validation/     # Validation engine
│   ├── AmosDocumentValidator.Infrastructure/ # Excel, Drive, File I/O
│   ├── AmosDocumentValidator.Gui/            # WPF GUI application
│   ├── AmosDocumentValidator.Cli/            # Console application
│   └── AmosDocumentValidator.Shared/         # Shared models and interfaces
├── tests/
│   ├── AmosDocumentValidator.Tests.Unit/
│   ├── AmosDocumentValidator.Tests.Integration/
│   └── AmosDocumentValidator.Tests.RealWorld/
└── docs/
Project Types and Target Frameworks
AmosDocumentValidator.Core - Class Library

Target Framework: .NET 8.0
Purpose: Core business logic, processing pipelines

AmosDocumentValidator.Validation - Class Library

Target Framework: .NET 8.0
Purpose: Validation rules, patterns, helpers

AmosDocumentValidator.Infrastructure - Class Library

Target Framework: .NET 8.0
Purpose: Excel I/O, Google Drive, file operations

AmosDocumentValidator.Shared - Class Library

Target Framework: .NET 8.0
Purpose: DTOs, interfaces, enums, constants

AmosDocumentValidator.Gui - WPF Application

Target Framework: .NET 8.0-windows
Purpose: Desktop GUI

AmosDocumentValidator.Cli - Console Application

Target Framework: .NET 8.0
Purpose: Command-line interface

Test Projects - xUnit Test Projects

Target Framework: .NET 8.0
