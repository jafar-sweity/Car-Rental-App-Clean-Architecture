## 🚗 Car Rental Web Application – ASP.NET Core

### 📌 Overview

This is a **Car Rental Web Application** built using **ASP.NET Core** and **Clean Architecture principles**. The app allows users to sign up, log in, and view available cars for rental. It demonstrates core backend skills like **authentication**, **authorization**, **validation**, **Entity Framework Core**, **repository and service patterns**, and **JWT-based session management**.

---

### 🧱 Architecture

This application is built with a **Clean Architecture** structure:

```
CarRentalApp/
│
├── Application/          // Business logic (DTOs, services interfaces, validators)
├── Core/                 // Domain layer (entities, repository interfaces)
├── Infrastructure/       // Data access (EF Core DbContext, repositories)
├── Web/                  // API layer (controllers, startup configuration)
```

---

### 🚀 Features

#### ✅ Authentication & Authorization

- 🔒 JWT-based login and secure session management
- ✍️ Register (Sign Up) with full user details and hashed password
- 🔐 Role-based authorization (customer, admin – _admin role is optional/bonus_)
- 🧠 Unique email validation
- 🔁 Forgot password flow (bonus – to be implemented)

#### 🧍 User Registration

Collects:

- First Name, Last Name
- Email (must be unique)
- Password + confirmation
- Phone number
- Date of birth _(optional)_
- Full Address (Line1, Line2, City, Country)
- Driver’s License Number

#### 🔑 Login

- Email + password
- Returns a **JWT token** on successful login

#### 🏠 User Dashboard (Main Page)

- List of **available cars**
- Search cars by preferences (location, date, etc.)
- _(Bonus)_ Manage bookings, profile info

---

### 🧪 Technologies Used

- **ASP.NET Core Web API**
- **Entity Framework Core**
- **JWT Authentication**
- **FluentValidation**
- **SQL Server** (with EF migrations)
- **AutoMapper**
- **Swagger (OpenAPI)**
- **BCrypt** for password hashing

---

### 🛠️ How to Run the Project

1. **Clone the repo:**

   ```bash
   git clone https://github.com/yourusername/CarRentalApp.git
   cd CarRentalApp
   ```

2. **Set up your database:**

   - Update your connection string in `appsettings.json`
   - Run migrations:

     ```bash
     dotnet ef database update
     ```

3. **Configure JWT Settings:**
   In `appsettings.json`, add:

   ```json
   "Jwt": {
     "Key": "your_super_secret_key",
     "Issuer": "yourdomain.com",
     "Audience": "yourdomain.com"
   }
   ```

   ```

   ```

---

### 📂 Key Project Files

| Layer            | Description                                    |
| ---------------- | ---------------------------------------------- |
| `Application`    | DTOs, Services interfaces, Validators          |
| `Core`           | Entities and Repository Interfaces             |
| `Infrastructure` | EF Core Context, Repositories implementations  |
| `Web`            | Controllers, DI setup, Auth Config, Program.cs |

---
