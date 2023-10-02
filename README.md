# AFSTranslator

## Project Overview

Welcome to the .AFS Translator project! This document will guide you through setting up the project and running it successfully on your local machine.

## Prerequisites

Before you can run this project, make sure you have the following prerequisites installed on your local machine:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [PostgreSQL](https://www.postgresql.org/download/) database server

## Database Setup

To set up the database for this project, follow these steps:

1. **Install PostgreSQL**: If you haven't already, download and install PostgreSQL on your local machine. You can follow the installation instructions provided on the PostgreSQL website.

2. **Create a Database**: Once PostgreSQL is installed, open a command prompt or terminal and log in to PostgreSQL using the `psql` command. You can do this with the following command (replace `<your_username>` with your PostgreSQL username):

   ```bash
   psql -U <your_username>
   ```

3. **Create a Database**: After logging in, create a new database for the project. You can replace `<your_database_name>` with a suitable name for your database:

   ```sql
   CREATE DATABASE <your_database_name>;
   ```

4. **Configure Connection String**: In the project directory, locate the `appsettings.json` file and open it. Inside the file, find the `ConnectionStrings` section and update the `translator` connection string to match your PostgreSQL database configuration. Replace `<your_username>`, `<your_password>`, `<your_database_name>`, and `<your_host>` with your PostgreSQL credentials:

   ```json
   "ConnectionStrings": {
       "Translator": "Host=<your_host>;Database=<your_database_name>;Username=<your_username>;Password=<your_password>;"
   }
   ```

## Running Migrations

After setting up the database, you need to apply the database migrations to create the necessary tables. Follow these steps:

1. Open a command prompt or terminal and navigate to the project's root directory.

2. Run the following command to apply the migrations:

   ```bash
   dotnet ef database update
   ```

   This command will execute any pending migrations and create the required database schema.

## Running the Application

Now that you have set up the database and applied the migrations, you can run the application. Use the following command in the project's root directory:

```bash
dotnet run
```

This will start the application, and you should be able to access it by opening a web browser and navigating to `http://localhost:[PORT]` (or `https://localhost:[PORT]` if using HTTPS).

## Conclusion

You've successfully set up the AFS Translator .NEt project, configured the database, and applied migrations. You can now start working on and exploring the project. If you encounter any issues or have questions, please refer to the project's documentation or seek assistance from the project team. Happy coding!

## Contributor / Developer

Frank (GitHub username: @frankhn)
