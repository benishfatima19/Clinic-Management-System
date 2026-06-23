# 🏥 Clinic Management System

A desktop application built in C# Windows Forms for managing 
clinic operations — medicine inventory, patient records, and 
billing — all from a single application.

Developed as a semester project for Visual Programming (CS-412) 
at University of Agriculture Faisalabad.

## Features

- 🔐 Secure admin login with BCrypt password hashing
- 💊 Medicine inventory management with stock tracking
- 👤 Patient record management with search
- 🧾 Automated billing system with auto-calculated totals
- 📊 Dashboard with live statistics (medicines, patients, bills, revenue, low stock alerts)
- 📈 Reports with billing history and color-coded inventory status

## Tech Stack

- **Language:** C#
- **UI Framework:** Windows Forms (.NET Framework 4.7.2)
- **Database:** SQLite (Microsoft.Data.Sqlite)
- **Security:** BCrypt.Net-Next
- **Architecture:** 3-Tier Architecture with Repository Pattern
- **Version Control:** Git

## Architecture

The project follows a clean 3-tier architecture:

```
Forms/      → UI layer (zero SQL — calls Repository methods only)
Database/   → DatabaseHelper + Repository classes (all SQL here)
Models/     → Simple data carrier classes
```

This separation means form files have no direct database queries — all data access logic lives in dedicated Repository classes (UserRepository, MedicineRepository, PatientRepository, BillRepository).

## How to Run

1. Clone or download this repository
2. Open `Clinic System.sln` in Visual Studio 2022
3. Build → Rebuild Solution (NuGet packages restore automatically)
4. Press F5 to run
5. The database (`clinic.db`) is created automatically on first run

**Default Login:**
- Username: `admin`
- Password: `1234`

## Database Schema

| Table | Description |
|-------|-------------|
| Users | Admin login credentials (BCrypt hashed) |
| Medicines | Medicine inventory with stock and pricing |
| Patients | Patient records |
| Bills | Generated bills linked to patients |
| BillItems | Individual medicine line items per bill |

## What I Learned

The most valuable part of this project wasn't writing the CRUD operations — it was refactoring the entire codebase midway through development to follow proper Repository pattern instead of having SQL scattered across form files. This taught me a lot about separation of concerns and why clean architecture matters even in smaller projects.

## Author

**Benish Fatima**  
BSCS Student, University of Agriculture Faisalabad
