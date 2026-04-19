# Building-a-Simple-API-with-Copilot

This project is a simple **ASP.NET Core Web API** built as part of the **Microsoft Back-End Development with .NET** course.  
The API demonstrates how Microsoft Copilot can assist with **code generation, debugging, and middleware implementation**.

The final result is a fully functional User Management API with CRUD operations, validation, error handling, authentication, and logging.

---

## 🚀 Project Overview

The User Management API allows internal teams to:

- Create users
- Retrieve all users or a user by ID
- Update user information
- Delete users
- Secure endpoints using token-based authentication
- Log requests and responses
- Handle errors consistently

This project was completed in **three activities**, each focusing on a different development phase with Copilot assistance.

---

## 🧩 Activity 1: Writing and Enhancing API Code

**Goal:** Build the core API functionality using Copilot.

### Features Implemented
- ASP.NET Core Web API setup
- User model
- CRUD endpoints:
  - `GET /api/users`
  - `GET /api/users/{id}`
  - `POST /api/users`
  - `PUT /api/users/{id}`
  - `DELETE /api/users/{id}`
- In-memory data storage
- Swagger UI for testing

**Copilot Contribution**
- Generated controller and model templates
- Suggested dependency injection patterns
- Helped scaffold CRUD endpoints efficiently

---

## 🐞 Activity 2: Debugging API Code with Copilot

**Goal:** Identify and fix bugs in the existing API.

### Improvements Made
- Added input validation using data annotations
- Improved error handling for non-existent users
- Prevented application crashes using try-catch blocks
- Returned meaningful HTTP status codes and error messages

**Copilot Contribution**
- Identified missing validation and error-handling gaps
- Suggested fixes for edge cases and exceptions
- Improved API reliability and robustness

---

## 🔐 Activity 3: Implementing and Managing Middleware

**Goal:** Implement middleware for security, logging, and error handling.

### Middleware Implemented
- **Error Handling Middleware**
  - Catches unhandled exceptions
  - Returns consistent JSON error responses
- **Authentication Middleware**
  - Validates token-based authentication
  - Returns `401 Unauthorized` for invalid tokens
- **Logging Middleware**
  - Logs HTTP method, request path, and response status code

### Middleware Pipeline Order
1. Error handling middleware
2. Authentication middleware
3. Logging middleware

**Copilot Contribution**
- Generated middleware templates
- Suggested best practices for middleware order
- Helped configure the middleware pipeline correctly

---

## 🧪 Testing the API

The API can be tested using **Swagger** or **Postman**.


---

## 🛠 Technologies Used

- ASP.NET Core Web API
- C#
- Microsoft Copilot
- Swagger / OpenAPI

---

## 📌 Notes

- Data is stored in memory (no database)
- Token authentication is simplified for learning purposes
- This project is intended for educational and portfolio use

---

## 📚 Course

**Microsoft Back-End Development with .NET**  
Coursera Practice & Project Assignments

---

## 👤 Author

Menna Allah Mohamed Farag Mahmoud

