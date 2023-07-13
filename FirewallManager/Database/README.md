# Firewall Manager

Firewall Manager is a project that provides a user interface for managing firewall rules and user access control.

## Database Setup

This project requires a database to store firewall rules and user information. Follow the instructions below to set up the database.

### Prerequisites

- [Database Engine] - Install the required database engine (e.g., MySQL, PostgreSQL, SQLite).
- [Connection String] - Obtain the connection string for your database.

### Steps

1. Create a new database in your preferred database engine.

2. Execute the SQL script provided in the `Database/Scripts` folder to create the necessary tables and schema.

3. Update the connection string in the `appsettings.json` file located in the project's root directory. Replace the placeholder values with your actual database connection details.

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Your_Connection_String"
   }
   
1-Start the application, and it will automatically connect to the configured database.

Usage

Once the database is set up and the application is running, you can access the user interface to manage firewall rules and user access control.

1-    Visit the application in your web browser using the provided URL or local address.
2-    Log in with your user credentials. If you don't have an account, click on the "Register" link to create a new user.
3-    Navigate through the application's menus to manage firewall rules and user permissions.

Contributing

If you would like to contribute to this project, please follow the guidelines below:

1-    Fork the repository and clone it to your local machine.

2-    Create a new branch for your feature or bug fix.

3-    Make your changes and commit them with descriptive commit messages.

4-    Push your changes to your forked repository.

5-    Submit a pull request to the main repository, explaining the changes you have made.

License

This project is licensed under the [MIT License]. You are free to use, modify, and distribute this software.