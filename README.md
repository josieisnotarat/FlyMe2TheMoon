# ✈️ FlyMe2TheMoon — Final Project (Programming 2)

## ⚠️ DISCLAIMER:
This project was completed independently as part of a college course and is shared here to showcase my personal skills in Visual Basic and SQL.

Please do **not** copy or submit this work as your own. Doing so may violate your institution’s academic integrity or plagiarism policies, which can lead to serious consequences such as suspension or expulsion.

I do **not** condone academic dishonesty and am **not responsible** for any misuse of this code by others.


## 📋 Overview
**FlyMe2theMoon** is a complete CRUD-based airline management system built in **Visual Basic** with a **SQL Server** backend. Designed for Programming 2’s final project, it features secure logins, role-based menus, flight bookings, and dynamic pricing logic. 

---

## 🚀 Skills Utilized
This project demonstrates:
- CRUD operations
- Role-based access control
- Stored procedure integration
- SQL + VB interoperability

---

## 🧠 Features

### 🔐 Login System
- Separate **Passenger** and **Employee** login forms
- Secure authentication via `LoginID` and `Password`
- Role-based menu navigation:
  - **Customer** (Passenger)
  - **Pilot**
  - **Attendant**
  - **Admin**
- Logged-in user ID stored using global variables for personalized access

### 🧍 Passenger Portal
- Register or update profile (includes login credentials + DOB)
- Book future flights with confirmation prompts
- Dynamic pricing system based on:
  - Base cost + mileage
  - Passenger age discounts
  - Loyalty discounts (based on flight history)
  - Seat type
  - Plane type
  - Destination airport fees
  - Passenger count modifiers
- View past/future flights
- Total miles flown displayed for each

### 👩‍✈️ Pilot & Attendant Menus
- Update profile and credentials
- View past and future flight assignments
- Total miles flown tracked and displayed

### 🛠 Admin Dashboard
- Add, update, and delete **Pilots** and **Attendants**
- Assign staff to future flights
- Create new **Future Flights** with full validation (date check, required fields)
- View system-wide statistics:
  - Total customers
  - Total flights taken
  - Average miles flown
  - Per-employee mileage breakdowns

---

## 🧾 Stored Procedures
Used to meet final project requirements for demonstrating SQL proficiency.

Stored procs were used for:
- `SELECT`
- `INSERT`
- `UPDATE`
- `DELETE`

📁 Stored procedures are included in the `StoredProcedures.sql` file.

---

## 💾 Tech Stack
- **Language:** Visual Basic (.NET Framework)
- **Database:** Microsoft SQL Server
- **Architecture:** 
  - Modular forms per user role
  - Global variables for state tracking
  - Data validation and confirmation on all key actions

---

## 📎 Submission Package Includes
- ✅ Full Visual Basic Project Files (`.sln`, `.vb`, `.resx`)
- ✅ SQL Server Scripts (tables, data, stored procedures)
- ✅ Screenshots of major functionality (login, booking, stats, admin tools)
- ✅ This README!

---

## 📝 Notes
- All former combo box login logic has been replaced with secure login forms
- Global variables stored in a standard module (`modGlobals.vb`)
- Dynamic flight cost logic coded directly in booking form logic
- Future flights and staff assignment handled with proper foreign key logic



