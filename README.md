# TaskFlow.API

TaskFlow.API is a reference implementation of the **CQRS (Command Query Responsibility Segregation)** pattern combined with **Clean Architecture** principles in .NET Core.

It is designed as an example for **[CQR Library](https://www.nuget.org/packages/CQR)** (Which is an alternative to MediateR)

## 📖 Overview

This project demonstrates how to:

* Implement CQRS by separating read and write operations.

* Use CQR Library to handle commands and queries in a decoupled manner.

* Apply Clean Architecture to enforce boundaries between layers.

* Utilize Entity Framework Core (or Dapper) for persistence.

* Apply Repository Pattern to abstract data access.

The domain chosen is a simple Task Management System, where users can create, update, delete, and query tasks.

## 🏛️ Architecture

The solution follows Clean Architecture principles with distinct layers:
- API
- Application
- Infrastructure
- Domain

### Key Principles:

**API Layer:** Only exposes endpoints and delegates work to the application layer.

**Application Layer:** Contains all use-cases (commands/queries) and enforces CQRS.

**Domain Layer:** Pure business models and logic, independent of any framework.

**Infrastructure Layer:** Handles persistence and external concerns.

## ⚙️ Tech Stack

- .NET 7 / .NET Core

- CQR – request/response and pipeline handling

- Entity Framework Core or Dapper – persistence layer

- AutoMapper – DTO ↔ Entity mapping

## 🚀 Getting Started
### Prerequisites

- .NET SDK 7.0+
-  CQR - latest version

### Setup

Clone the repository:

`git clone https://github.com/SandunPushpika/TaskFlow.CQRS.git`

`cd TaskFlow.CQRS`

`dotnet run --project TaskFlow.API`

Navigate to Swagger UI:

https://localhost:5001/swagger


## 🎯 Purpose

This project is not intended for production use.

It serves as a learning and reference guide for:

- Developers new to CQRS and MediatR.
- Practitioners who want to explore Clean Architecture in .NET.
- Teams looking for a scaffold to kickstart enterprise-ready applications.

## 📌 Future Improvements

- Add Authentication & Authorization (JWT).
- Introduce Event Sourcing.
- Add caching layer (Redis).
- Deploy with Docker & Kubernetes.
