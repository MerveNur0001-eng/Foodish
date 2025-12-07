🍽️ Foodish – Modern Food Ordering & Management System

Foodish is a modern and fully responsive food ordering and restaurant management web application built using ASP.NET Core MVC, C#, and Microsoft SQL Server.
It follows a clean layered architecture (Entity – Data Access – Business – Presentation) and includes dynamic content management, sliders, products, categories, reviews, and more.

| Layer / Feature | Technology                                                |
| --------------- | --------------------------------------------------------- |
| Backend         | **ASP.NET Core 8.0**, C#                                  |
| Database        | **Microsoft SQL Server (MSSQL)**                          |
| ORM             | Entity Framework Core                                     |
| Architecture    | N-Tier Architecture (Entity, DAL, Business, Presentation) |
| Frontend        | HTML5, CSS3, Bootstrap                                    |
| Tools           | AutoMapper, ViewComponents                                |
| Version Control | Git & GitHub                                              |

📌 Features
✔️ Category Management
CRUD operations for managing food categories.

✔️ Product Management
Add, update, list, and delete products with category mapping.

✔️ Slider Management
Dynamic homepage sliders using database-driven content.

✔️ Review Section
Displays reviews from the database using a ViewComponent.

✔️ About & Feature Sections
Dynamic homepage content editable from admin panel.

✔️ Layered Architecture
Entity Layer → Core entities
DAL Layer → EF Core Repositories
Business Layer → Validation & business rules
Presentation Layer → MVC, ViewComponents

Project Structure

Foodish/
 ├── Foodish.EntityLayer/
 ├── Foodish.DataAccessLayer/
 ├── Foodish.BusinessLayer/
 ├── Foodish.DtoLayer/
 └── Foodish.PresentationLayer/
## 🏗️ How to Run the Project

### 1️⃣ Clone the Repository
```bash
git clone https://github.com/MerveNur0001-eng/Foodish.git
cd Foodish
'''
2️⃣ Open in Visual Studio

Open Foodish.sln with Visual Studio 2022 (or later).

3️⃣ Configure the Database

Set your SQL Server connection string in:
'''bash
Foodish.DataAccessLayer/Context/FoodishContext.cs
'''

Example:
'''bash
optionsBuilder.UseSqlServer("Server=YOUR_SERVER;Database=FoodishDb;Trusted_Connection=True;TrustServerCertificate=True;");
'''
4️⃣ Run Migrations

Open Package Manager Console and run:
'''bash
Update-Database
'''
5️⃣ Run the Project

Set Foodish.PresentationLayer as the startup project.

Click Run ▶ or press F5.

The project will launch at a URL like:
'''bash
https://localhost:xxxx
'''
🤝 Contributing

Pull requests are welcome! For major changes, please open an issue first.
