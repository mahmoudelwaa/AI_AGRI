# Backend (.NET)

ASP.NET Core Web API with a layered structure. It serves the REST API in `docs/API_CONTRACT.md` and runs the ONNX model in-process with ONNX Runtime.

## Folder structure

```
backend/
├── src/
│   ├── AgriAI.Api/             # controllers, middleware, Program.cs, Swagger
│   ├── AgriAI.Application/     # services, DTOs, interfaces (the use cases)
│   ├── AgriAI.Domain/          # entities and enums: User, Farm, Field, Crop, Disease, Diagnosis
│   └── AgriAI.Infrastructure/
│       ├── Persistence/        # DbContext, EF Core migrations, Seed/ (crops and diseases data)
│       ├── Repositories/
│       ├── Auth/               # JWT, password hashing
│       ├── Storage/            # image storage
│       └── MachineLearning/    # ONNX Runtime classifier, preprocessing, Models/ (the .onnx file)
├── tests/AgriAI.Tests/
├── uploads/                    # uploaded images on the local machine (not in git)
└── scripts/
```

## Who owns what

| Role | Works in |
|------|----------|
| Backend 1 | `Auth/`, `Persistence/`, `Domain/` (users, farms and fields, schema, migrations) |
| Backend 2 | disease and diagnosis-history controllers, services and repositories (history filters), `Persistence/Seed/`, Swagger |
| Backend 3 | `MachineLearning/`, `Storage/`, upload endpoint, the demo setup on one laptop |

## Creating the projects

The folders are ready; create the projects inside them (run in `backend/`):

```bash
dotnet new sln -n AgriAI
dotnet new webapi -n AgriAI.Api -o src/AgriAI.Api
dotnet new classlib -n AgriAI.Application -o src/AgriAI.Application
dotnet new classlib -n AgriAI.Domain -o src/AgriAI.Domain
dotnet new classlib -n AgriAI.Infrastructure -o src/AgriAI.Infrastructure
dotnet new xunit -n AgriAI.Tests -o tests/AgriAI.Tests
dotnet sln add src/*/*.csproj tests/*/*.csproj
```

Dependencies: Api, Application, Infrastructure; Application, Domain; Infrastructure, Application and Domain. Domain depends on nothing.

The preprocessing in `MachineLearning/` must follow `docs/MODEL_SPEC.md` exactly.

## Database (local PostgreSQL)

No Docker. Each backend developer installs PostgreSQL on their own machine, so everyone has a clean private database.

1. Install PostgreSQL from the official site and remember the `postgres` password.
2. Copy `src/AgriAI.Api/appsettings.Example.json` to `src/AgriAI.Api/appsettings.Development.json` and put your own password. This file is in `.gitignore`, never commit it.
3. Build the tables and load the crops and diseases data:

```bash
dotnet ef database update --project src/AgriAI.Infrastructure --startup-project src/AgriAI.Api
```

Migrations and the seed data are in git, so everyone gets the same schema. Changes to the schema go through Backend 1 and the repository owner. Images are saved in `uploads/`, and the database stores only their path.
