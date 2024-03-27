# Student Management System

This is a simple Student Management System implemented using ASP.NET Core MVC with CRUD (Create, Read, Update, Delete) operations. It utilizes .NET 7 and Entity Framework Core for database operations.

## Features

- Create new student records
- Read existing student records
- Update student records
- Delete student records

## Technologies Used

- ASP.NET Core MVC
- .NET 7
- Entity Framework Core
- SQL Server Management Studio (for managing the local database)

## Getting Started

1. Clone the repository:

   ```
   git clone https://github.com/Rajaramkarki/StudentMgmtSystem.git
   ```

2. Open the project in Visual Studio or your preferred code editor.
3. Ensure you have SQL Server Management Studio installed for managing the local database.
4. Navigate to the appsettings.json file and update the connection string under "ConnectionStrings" if needed:
```
"ConnectionStrings": {
    "StudentMgmt": "Server = LAPTOP-4ND79MJ9\\PROJECTS; Database = StudentMgmtDB; Trusted_Connection = True; TrustServerCertificate = True"
}
```
4. Run the project and navigate to the specified URL in your web browser to access the application.