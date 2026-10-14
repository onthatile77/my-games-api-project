# My Games API Project

A game management REST API built with **C# and .NET** as a hands-on way of learning how backend APIs work: routing, request handling, data modelling and clean project structure.

The API lives in the [`GameStore.Api`](./GameStore.Api) project.

## About the project

I built this to move beyond classroom exercises and understand how a real backend service is put together. A game store is a good fit because it needs the standard API building blocks: create, read, update and delete operations over a simple domain.

## Features

- RESTful endpoints for managing games
- [Genres or other related data, if included]
- [Input validation / DTOs, if included]
- [Database persistence, e.g. SQLite / PostgreSQL / SQL Server, if included]

## Tech stack

| Area | Tools |
| --- | --- |
| Language | C# |
| Framework | .NET [version] |
| Data | [e.g. Entity Framework Core + database] |
| Tooling | Git, GitHub, [VS Code / Visual Studio] |

## Getting started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) [version]

### Run locally

```bash
# Clone the repository
git clone https://github.com/onthatile77/my-games-api-project.git
cd my-games-api-project/GameStore.Api

# Restore dependencies and run
dotnet restore
dotnet run
```

The API will start on the URL printed in the console.

## API endpoints

> Update this table to match the endpoints in your code.

| Method | Endpoint | Description |
| --- | --- | --- |
| GET | `/games` | List all games |
| GET | `/games/{id}` | Get a single game |
| POST | `/games` | Create a game |
| PUT | `/games/{id}` | Update a game |
| DELETE | `/games/{id}` | Delete a game |

### Example request

```http
POST /games
Content-Type: application/json

{
  "name": "Example Game",
  "genre": "Adventure",
  "price": 299.99
}
```

## What I learned

- How HTTP verbs map to CRUD operations in a REST API
- Structuring a .NET API project and keeping endpoints organised
- [Add one or two lessons of your own, e.g. validation, DTOs, database access]

## Roadmap

- [ ] [Next improvement, e.g. authentication]
- [ ] [Next improvement, e.g. automated tests]

## Author

**Moila Leatile Onthatile**, BSc Information Technology, North-West University
GitHub: [@onthatile77](https://github.com/onthatile77) | Email: onthatile.0318@gmail.com
