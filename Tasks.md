# .NET Backend Learning Checklist

## 1. Project Setup
- [ ] Create new ASP.NET Core Web API project (`dotnet new webapi`)
- [ ] Create folder structure: `Controllers/`, `Services/`, `Repositories/`, `Models/`, `Dtos/`, `Data/`, `Migrations/`, `Tests/`
- [ ] Add `appsettings.Development.json`
- [ ] Verify project builds and default endpoint runs

## 2. Configure EF Core
- [ ] Add EF Core + SQL provider NuGet packages
- [ ] Create `AppDbContext` with DbSet properties
- [ ] Register DbContext in DI (`AddDbContext`)
- [ ] Add connection string in `appsettings.json`

## 3. Add Initial Models & Migrations
- [ ] Create `User` and `Product` models
- [ ] Run `dotnet ef migrations add InitialCreate`
- [ ] Apply migration to database (`dotnet ef database update`)

## 4. Product CRUD Endpoints
- [ ] Create `ProductsController`
- [ ] Implement CRUD endpoints
- [ ] Use async EF Core queries
- [ ] Return correct status codes

## 5. Introduce DTOs + AutoMapper
- [ ] Create DTOs
- [ ] Add AutoMapper profiles
- [ ] Update controller to use DTOs

## 6. Add Validation
- [ ] Add data annotations
- [ ] Ensure invalid requests return `400 Bad Request`

## 7. Repository Pattern
- [ ] Add repository interfaces
- [ ] Add concrete repositories
- [ ] Register in DI

## 8. Service Layer
- [ ] Create services
- [ ] Move business logic to services

## 9. Unit Testing
- [ ] Add test project
- [ ] Mock repositories using Moq
- [ ] Add unit tests

## 10. Error Handling + Logging
- [ ] Create global error handler middleware
- [ ] Add logging using ILogger

## 11. Pagination, Sorting, Filtering
- [ ] Add query parameters
- [ ] Implement pagination logic
- [ ] Add paged response DTO

## 12. Auditing + Soft Delete
- [ ] Add audit fields
- [ ] Implement soft delete
- [ ] Add global query filter

## 13. Relationship Mapping
- [ ] Add Category (1-to-many)
- [ ] Add Tag (many-to-many)
- [ ] Update migrations

## 14. JWT Authentication
- [ ] Add login endpoint
- [ ] Issue JWT
- [ ] Protect endpoints using [Authorize]

## 15. Refresh Tokens + Secure Passwords
- [ ] Hash passwords
- [ ] Add refresh token model
- [ ] Add refresh endpoint

## 16. CORS + Rate Limiting
- [ ] Add CORS policy
- [ ] Add rate limiting

## 17. API Documentation (Swagger)
- [ ] Enable Swagger + XML comments
- [ ] Add JWT auth support

## 18. Health Checks
- [ ] Add health checks middleware
- [ ] Add DB readiness checks

## 19. Docker Support
- [ ] Add Dockerfile
- [ ] Add docker-compose
- [ ] Run API + DB in containers

## 20. CI Pipeline
- [ ] Add GitHub Actions / GitLab CI
- [ ] Build + test pipeline
