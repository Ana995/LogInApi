Login and Register Project

Overview

This project implements a basic login and registration system using .NET 6 for the API development and Angular 17 for the front-end. It's designed as a starting point for web applications requiring user authentication.

Prerequisites:
- .NET 6 SDK
- Node.js (latest stable version)
- Angular CLI 17
- A preferred text editor or IDE (e.g., Visual Studio Code, Visual Studio)
  
Clone the Repository

git bash

git clone [repository-url]

Set Up the API (.NET 6)

Navigate to the API project directory:

cd [api-project-directory]

Restore the project dependencies:

dotnet restore

Run the API project:

dotnet run

Set Up the Front-End (Angular 17)
Navigate to the front-end project directory:

cd [front-end-directory]

npm install

Start the Angular server:

ng serve

Access the application at http://localhost:4200/.

Features:

- User registration
- User login
- Session management
- Input validation

API Endpoints
POST /api/register: Registers a new user.
POST /api/login: Authenticates a user.

Contributing
Contributions to the project are welcome. Please follow the standard fork-pull request workflow.
