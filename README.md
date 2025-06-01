# Tuition Centre Management System

This is a Windows Forms application for managing a tuition centre, supporting roles such as Receptionist, Tutor, Student, and Admin. The system provides features for student registration, subject enrollment, payment processing, class management, and profile management.

## Features

- **Receptionist**
  - Register new students
  - Manage student enrollments and subjects
  - Accept and update payments
  - View and process student requests
  - Update own profile

- **Tutor**
  - Add, edit, and delete class information
  - View student lists
  - Update own profile

- **Student**
  - View profile and timetable
  - Request subject changes
  - Update settings

- **Admin**
  - Register new receptionists
  - Update admin profile

## Project Structure

```
LoginInterface.sln
LoginInterface/
  ├── Receptionist/
  ├── Tutor/
  ├── Student/
  ├── Admin/
  ├── DBConnection.cs
  ├── Program.cs
  ├── App.config
  └── ...
```

## Getting Started

### Prerequisites

- Visual Studio 2019 or later
- .NET Framework 4.7.2 or later
- SQL Server (for the included `TuitionManagementSystem.mdf` database)

### Setup

1. **Clone the repository** or copy the project files.
2. **Open `LoginInterface.sln`** in Visual Studio.
3. **Restore NuGet packages** if prompted.
4. **Attach/restore the database**  
   - The database files `TuitionManagementSystem.mdf` and `TuitionManagementSystem_log.ldf` are included in the project.
   - Ensure your SQL Server instance can access these files.
5. **Build and run the project** (F5 in Visual Studio).

## Usage

- Log in with the appropriate credentials for Receptionist, Tutor, Student, or Admin.
- Use the navigation menus to access different features based on your role.

## Notes

- The UI uses custom controls and styling for a modern look.
- All data is stored in the included SQL Server database.

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License

This project is for educational purposes.

---

**Developed by: HEW WEN KANG**  
Degree Year 1, Second Semester Assignments
