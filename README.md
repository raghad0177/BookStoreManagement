# Bookstore Management MVC Project

This project is a simple ASP.NET Core MVC application for managing books in a bookstore. It provides basic CRUD (Create, Read, Update, Delete) functionality for managing books in a database.

## Getting Started

### Prerequisites

Make sure you have the following installed on your machine:

- **.NET SDK**: Download from [here](https://dotnet.microsoft.com/download).
- **Visual Studio 2022 or later**: Download from [here](https://visualstudio.microsoft.com/).
- **SQL Server**: This project uses Entity Framework Core, so make sure SQL Server is installed and running.

### Setup Instructions

1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-username/BookstoreManagement.git
   cd BookstoreManagement
2. **Database Setup**:
   - Open the project in Visual Studio.
   - Modify the `appsettings.json` file with your SQL Server connection string:
     ```json
     {
       "ConnectionStrings": {
         "DefaultConnection": "Server=your-server-name;Database=BookStoreDb;Trusted_Connection=True;MultipleActiveResultSets=true"
       }
     }
     ```

3. **Migrate the Database**:
   Open the **Package Manager Console** and run the following commands to create the database:
   ```bash
   Add-Migration InitialCreate
   Update-Database
4. **Run the Application**:
   - Press `F5` in Visual Studio to run the project.
   - The application should launch on your local server (e.g., `https://localhost:5001`).

## Using the CRUD Functionality

### 1. Create a New Book
   - Navigate to the `/Books/Create` page.
   - Fill out the book details (Title, Author, Genre, Price) and click "Submit".
   - If successful, you'll see a "Successfully Added!" message.

### 2. View All Books
   - Navigate to the `/Books/Index` page.
   - This page will list all the books currently stored in the database.

### 3. Edit an Existing Book
   - Navigate to the `/Books/Edit` page.
   - Enter the ID of the book you want to edit, update the fields, and submit the form.
   - If successful, you'll see a "Updated Successfully!" message.

### 4. Delete a Book
   - Navigate to the `/Books/Remove` page.
   - Enter the ID of the book you want to delete and click "Submit".
   - If successful, you'll see a "Successfully Deleted!" message.

### 5. View Book Details
   - Navigate to the `/Books/Details` page.
   - Enter the ID of the book you want to view and click "Submit" to see detailed information about the book.

## Technologies Used

- **ASP.NET Core MVC**
- **Entity Framework Core**
- **SQL Server**
- **C#**

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
