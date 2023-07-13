# Firewall Manager

Firewall Manager is a powerful and user-friendly application for managing firewall rules and user access control. It provides an intuitive interface for creating, updating, and deleting firewall rules, as well as managing user authentication and role-based access control.

## Features

- User Registration and Authentication: Users can register an account and authenticate themselves using their username and password.

- Role-Based Access Control: User roles can be assigned to control access to different features and functionalities within the application.

- Firewall Rule Management: Users can create, update, and delete firewall rules based on source and destination addresses, ports, protocols, actions, and descriptions.

- Validation and Conflict Resolution: Firewall rules are validated for correctness and conflicts before being added or updated in the system, ensuring consistent and effective rule enforcement.

- Logging and Auditing: The application uses the NLog library to log important events and actions, providing an audit trail for monitoring and troubleshooting purposes.

## Getting Started

### Prerequisites

- .NET Framework 7.0.0 or higher
- Any compatible IDE (e.g., Visual Studio)

### Installation

1. Clone the repository: `git clone https://github.com/your-username/firewall-manager.git`
2. Open the solution in your preferred IDE.
3. Build the solution to restore dependencies.

### Configuration

1. Open the `appsettings.json` file.
2. Update the database connection string and other configuration settings as per your environment.

### Usage

**. Just Run the application.

### Unit Tests

This project includes comprehensive unit tests to ensure the correctness of the implemented functionality. To run the unit tests, follow these steps:

1. Open the solution in your IDE.
2. Build the solution to restore dependencies.
3. Open the Test Explorer or equivalent test runner in your IDE.
4. Run all the unit tests to validate the functionality.

### Contributing

Contributions are welcome! If you'd like to contribute to the Firewall Manager project, please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and ensure that the tests pass.
4. Commit your changes and push them to your forked repository.
5. Submit a pull request detailing your changes and their benefits.

### License

This project is licensed under the [MIT License](LICENSE). Feel free to modify and distribute the code as per the license terms.

### Acknowledgments

- The [NLog](https://github.com/NLog/NLog) library for logging and auditing functionality.
- The [Entity Framework](https://github.com/dotnet/efcore) for database operations.
- Other open-source libraries and frameworks used in this project (list any additional dependencies or acknowledgments here).

### Contact

For any questions or inquiries, please contact [Amir Karimi](mailto:Karimika13.ka@gmail.com).

