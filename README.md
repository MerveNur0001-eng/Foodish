# 🍽️ Foodish – Modern Food Ordering & Management System

Foodish is a **modern and fully responsive food ordering and restaurant management web application** built using **ASP.NET Core MVC** and **C#**. It features a clean, professional design and a robust **N-Tier Architecture** for scalability and maintainability.



## 💡 Key Technologies & Architecture

This project follows a professional layered architecture and utilizes modern Microsoft development tools.

| Layer / Feature | Technology |
| :--- | :--- |
| **Backend** | **ASP.NET Core 8.0**, C# |
| **Database** | **Microsoft SQL Server (MSSQL)** |
| **ORM** | Entity Framework Core |
| **Architecture** | **N-Tier Architecture** (Entity, DAL, Business, Presentation) |
| **Frontend** | HTML5, CSS3, **Bootstrap** |
| **Tools** | AutoMapper, ViewComponents |
| **Version Control** | Git & GitHub |

## 📌 Features

Foodish includes essential management features for a modern food service application:

* **✔️ Category Management:** Comprehensive **CRUD** (Create, Read, Update, Delete) operations for managing food categories.
* **✔️ Product Management:** Functionality to add, update, list, and delete products, including mapping them to specific categories.
* **✔️ Slider Management:** Dynamic management of homepage sliders with content stored in the database.
* **✔️ Review Section:** Displays customer reviews dynamically using a **ViewComponent**.
* **✔️ Content Management:** Dynamic homepage sections (About & Features) are editable via the admin panel.

## 🏗️ Layered Architecture Breakdown

The application is structured into five distinct projects to enforce separation of concerns:

| Layer | Description |
| :--- | :--- |
| `Foodish.EntityLayer` | Contains the **Core Entities** (POCO classes) that represent the database tables. |
| `Foodish.DataAccessLayer` | The **Data Access Layer (DAL)**. Implements **EF Core Repositories** for all database operations. |
| `Foodish.BusinessLayer` | Manages the **Business Rules and Validation Logic**. Acts as the intermediary between the Presentation and Data layers. |
| `Foodish.DtoLayer` | Contains **Data Transfer Objects (DTOs)** used for data mapping between layers, often utilizing **AutoMapper**. |
| `Foodish.PresentationLayer` | The **User Interface Layer**. Contains the **ASP.NET Core MVC** structure, Controllers, Views, and ViewComponents. |

## 🚀 How to Run the Project

Follow these steps to set up and run the Foodish application locally.

📌 1. Clone the Repository

Clone the repository and navigate into the project directory:

git clone https://github.com/MerveNur0001-eng/Foodish.git
cd Foodish

📌 2. Open in Visual Studio

Open the solution file in Visual Studio 2022 or later:

Foodish.sln

📌 3. Configure the Database

Update the SQL Server connection string inside the following file to point to your local database:

Foodish.DataAccessLayer/Context/FoodishContext.cs

Example Connection String (C#)
optionsBuilder.UseSqlServer(
    "Server=YOUR_SERVER;Database=FoodishDB;Trusted_Connection=True;TrustServerCertificate=True;");


Note:
Replace YOUR_SERVER with your actual SQL Server instance (e.g., (localdb)\\mssqllocaldb or your custom instance name).

📌 4. Run Migrations

Open the Package Manager Console:
View > Other Windows > Package Manager Console

Make sure Foodish.DataAccessLayer is selected as the Default Project.

Run:

Update-Database

📌 5. Run the Project

Set Foodish.PresentationLayer as the Startup Project:
Right-click the project → Set as Startup Project

Run the application using:

Press F5, or

Click the ▶ Run button in Visual Studio

Your project will start at a URL similar to:

https://localhost:xxxx

🤝 Contributing

Contributions, issues, and feature requests are welcome!
