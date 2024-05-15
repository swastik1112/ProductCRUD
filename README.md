Product CRUD Web Application
This is a simple CRUD (Create, Read, Update, Delete) web application built using ASP.NET Core and Dapper. It allows users to manage a list of products by performing CRUD operations.

Features
View a list of products with their names and prices.
Add a new product to the list.
Edit the details of an existing product.
Delete a product from the list.
Responsive user interface.
Technologies Used
ASP.NET Core
Dapper (Micro ORM)
HTML, CSS (Bootstrap)
JavaScript (jQuery)
Setup Instructions
Clone the Repository:

bash
Copy code
git clone https://github.com/your-username/product-crud.git
Navigate to the Project Directory:

bash
Copy code
cd product-crud
Open the Project in Visual Studio or Visual Studio Code:
Open the project folder in your preferred IDE.

Database Setup:

Ensure you have SQL Server installed.
Open SQL Server Management Studio and run the SQL script provided in the database.sql file to create the necessary database schema and tables.
Update Connection String:

In the appsettings.json file, update the connection string under "ConnectionStrings" to point to your SQL Server database.
Run the Application:

Press F5 or use the appropriate command to run the application in your IDE.
Access the Application:

Open your web browser and navigate to http://localhost:<port> (replace <port> with the port number specified in your launch settings).
Folder Structure
Controllers: Contains the controller classes responsible for handling HTTP requests and serving views.
Views: Contains the Razor views (UI) for the application.
Models: Contains the model classes representing entities in the application.
Data: Contains the database context and repository classes for interacting with the database.
Additional Notes
This project is a basic demonstration of CRUD operations using ASP.NET Core and Dapper. You can extend it further by adding authentication, validation, and other features as needed.
Make sure to handle error cases and edge cases appropriately, such as validation errors, database errors, and security vulnerabilities.
License
This project is licensed under the MIT License - see the LICENSE file for details.
