# Library Management System

A desktop application built with C# and Windows Forms for managing library operations with SQL Server database integration.

## Overview

This project is a **Library Management System** designed as a DBMS (Database Management System) application. It provides a graphical user interface for library staff to manage library resources and operations with data persistence using SQL Server.

## Project Structure

```
├── Form1.cs / Form1.Designer.cs      # Login form interface
├── Form1.resx                         # Resources for login form
├── AppBody.cs / AppBody.Designer.cs   # Main application interface
├── AppBody.resx                       # Resources for main interface
├── Program.cs                         # Application entry point
├── App.config                         # Configuration file
├── Database10.mdf                     # SQL Server database file
├── Database10_log.ldf                 # SQL Server database log file
└── Library Management System.csproj   # Project file
```

## Key Features

- **User Authentication**: Login system with username and password verification
- **Database Integration**: SQL Server (LocalDB) integration for persistent data storage
- **Windows Forms UI**: Desktop application with graphical user interface
- **Library Management**: Tools for managing library resources and operations

## Technology Stack

- **Language**: C#
- **UI Framework**: Windows Forms (.NET)
- **Database**: SQL Server (LocalDB)
- **IDE**: Visual Studio (inferred)

## Getting Started

### Prerequisites

- .NET Framework (or .NET Core/5+)
- SQL Server LocalDB or SQL Server Express
- Visual Studio or Visual Studio Community Edition

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/PR3S1D3NT/DBMS_project.git
   cd DBMS_project
   ```

2. Open the project in Visual Studio:
   ```bash
   Visual Studio "Library Management System.csproj"
   ```

3. Restore NuGet packages if necessary

4. Build the project:
   ```
   Build → Build Solution
   ```

5. Run the application:
   ```
   Debug → Start Debugging (F5)
   ```

## Database Setup

The application uses a SQL Server LocalDB instance with the following database file:
- **Database**: `Database10.mdf`
- **Log File**: `Database10_log.ldf`

The database includes a `system` table containing:
- `Property` column: Stores property names (e.g., 'username', 'password')
- `Value` column: Stores corresponding values

### Connection String

```csharp
Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="|DataDirectory|\Database10.mdf";Integrated Security=True
```

## Usage

### Login

1. Launch the application
2. Enter your username and password on the login form
3. Click the login button to authenticate
4. Upon successful authentication, the main application window (AppBody) will open

### Main Application

The main interface (AppBody) provides access to library management features.

## File Descriptions

| File | Purpose |
|------|---------|
| `Program.cs` | Application entry point, initializes and runs the main form |
| `Form1.cs` | Login form with authentication logic |
| `AppBody.cs` | Main application form with library management features |
| `App.config` | Application configuration settings |
| `.csproj` | Visual Studio project file with build configuration |


## License

This project is public and available on GitHub.

## Author

Created by PR3S1D3NT

---

For more information or issues, please visit the [GitHub repository](https://github.com/PR3S1D3NT/DBMS_project).
