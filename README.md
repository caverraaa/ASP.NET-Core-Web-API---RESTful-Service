# ASP.NET Core Web API - RESTful Service

A specialized RESTful service designed for managing confectionery manufacturing data. This project demonstrates the implementation of a backend API layer using **ASP.NET Core**, focusing on resource-oriented architecture and efficient data retrieval.

## 🚀 Key Features
- **RESTful Architecture:** Full support for standard HTTP methods (GET, POST, DELETE) to manage resources.
- **Dynamic Search Engine:** Implementation of a case-insensitive search algorithm for product filtering.
- **Automated Resource Management:** Built-in logic for unique ID generation and data integrity within the service.
- **JSON Data Exchange:** Optimized for seamless integration with modern frontend frameworks via structured JSON responses.

## 🛠 Tech Stack
- **Framework:** ASP.NET Core Web API
- **Language:** C#
- **Documentation:** Swagger

## API Endpoints
- `GET /api/candies` — Retrieve all inventory items.
- `GET /api/candies/search/{query}` — Search products by name.
- `POST /api/candies` — Add a new product to the factory records.
- `DELETE /api/candies/{id}` — Remove an item by its unique identifier.

