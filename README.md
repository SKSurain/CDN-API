# ASP.NET Core User Management API

This project is an ASP.NET Core Web API designed for managing user data. It demonstrates the implementation of a RESTful API, integrating Dapper as a micro-ORM for efficient data operations. The project covers essential CRUD (Create, Read, Update, Delete) operations.

## Features

- RESTful API endpoints for user management.
- Integration with SQL Server using Dapper for data access.
- CRUD operations: Add, Retrieve, Update, and Delete users.
- Error handling and logging for robustness.

## Getting Started

### Prerequisites

- .NET Core 3.1 or later
- SQL Server (LocalDB or Express)
- Visual Studio or preferred IDE with C# support
- Postman for testing API endpoints

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/SKSurain/CDN-API.git
2. Open the solution in Visual Studio or your preferred IDE.
3. Restore the NuGet packages.
4. Update the appsettings.json with your SQL Server connection string.
5. Run the application.

###Usage

Run the application, and use Postman or any API client to test the following endpoints:

GET /api/User: Retrieve all users.
GET /api/User/{id}: Retrieve a user by ID.
POST /api/User: Create a new user.
PUT /api/User/{id}: Update an existing user.
DELETE /api/User/{id}: Delete a user.

###Contributing

Contributions to enhance this project are welcome. Please follow these steps to contribute:

Fork the repository.
Create a new branch (git checkout -b feature-branch).
Make your changes and commit (git commit -am 'Add some feature').
Push to the branch (git push origin feature-branch).
Create a new Pull Request.

###License

This project is licensed under the MIT License - see the LICENSE file for details.

###Acknowledgments

ASP.NET Core Team for the framework.
Dapper contributors for the ORM.
All contributors and reviewers of this project.
