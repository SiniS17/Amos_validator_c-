Package Decisions
Excel Processing
Selected: ClosedXML (v0.102.2+)

Reasons: Clean API, good performance, active maintenance, handles XLSX well
Alternative: EPPlus (requires commercial license for some uses)

Google Drive API
Selected: Google.Apis.Drive.v3 (latest stable)

Official Google library for .NET

Data Handling
Selected: Custom strongly-typed classes + LINQ

Reasons: Better performance than DataTable, type safety, easier testing
Note: No direct pandas equivalent - we'll build custom collections

Dependency Injection
Selected: Microsoft.Extensions.DependencyInjection

Standard .NET DI container

Configuration
Selected: Microsoft.Extensions.Configuration + System.Text.Json

For appsettings.json and user settings

Logging
Selected: Microsoft.Extensions.Logging + Serilog

Structured logging with file outputs

GUI Framework
Selected: WPF with CommunityToolkit.Mvvm

Modern MVVM helpers, source generators

Command-Line Parsing
Selected: System.CommandLine (preview)

Modern, type-safe CLI parsing

NuGet Package List
