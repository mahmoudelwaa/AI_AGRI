# Backend (.NET)

ASP.NET Core Web API with a layered structure. It serves the REST API in `docs/API_CONTRACT.md` and runs the ONNX model in-process with ONNX Runtime.

## Folder structure

```
backend/
├── src/
│   ├── AgriAI.Api/             # controllers, middleware, Program.cs, Swagger
│   ├── AgriAI.Application/     # services, DTOs, interfaces (the use cases)
│   ├── AgriAI.Domain/          # entities and enums: User, Crop, Disease, Diagnosis
│   └── AgriAI.Infrastructure/
│       ├── Persistence/        # DbContext, EF Core migrations
│       ├── Repositories/
│       ├── Auth/               # JWT, password hashing
│       ├── Storage/            # image storage
│       └── MachineLearning/    # ONNX Runtime classifier, preprocessing, Models/ (the .onnx file)
├── tests/AgriAI.Tests/
├── docker/                     # Dockerfile, docker-compose
└── scripts/
```

## Who owns what

| Role | Works in |
|------|----------|
| Backend 1 | `Auth/`, `Persistence/`, `Domain/` (users, schema, migrations) |
| Backend 2 | disease and diagnosis-history controllers, services and repositories, Swagger |
| Backend 3 | `MachineLearning/`, `Storage/`, upload endpoint, `docker/`, deployment |

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
