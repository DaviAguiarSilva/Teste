# TaskManager API

Projeto de estudo para seguir o roadmap de **ASP.NET Core** (roadmap.sh), construindo uma única API
de gerenciamento de tarefas que evolui a cada fase.

## Como rodar

```bash
dotnet run --project src/TaskManager.Api
```

API em `http://localhost:5039`. Use o arquivo `src/TaskManager.Api/TaskManager.Api.http` para testar os endpoints.

```bash
dotnet test
```

## Estrutura

```
TaskManager.slnx
src/TaskManager.Api/          -> a API (Minimal APIs)
tests/TaskManager.Api.Tests/  -> testes (xUnit)
```

## Progresso no roadmap

### Fase 1: Base
- [x] .NET CLI (`dotnet new`, `sln`, `add reference`, `run`, `test`)
- [ ] Git: commits, branches, merge, push para o GitHub
- [ ] HTTP: métodos (GET/POST/PUT/DELETE), status codes, headers
- [ ] SQL básico e modelagem do banco (PostgreSQL ou SQL Server)

### Fase 2: ASP.NET Core
- [ ] CRUD completo de tarefas (POST, PUT, DELETE)
- [ ] Middlewares (criar um middleware próprio)
- [ ] Configuração (`appsettings.json`, Options pattern)
- [ ] Injeção de dependência: Scoped / Transient / Singleton

### Fase 3: Dados
- [ ] EF Core: Code First + Migrations
- [ ] Relacionamentos (Projeto → Tarefas)
- [ ] Eager / Lazy / Explicit loading, Change Tracker

### Fase 4: Qualidade
- [ ] Testes unitários (xUnit, NSubstitute, Shouldly, Bogus)
- [ ] Testes de integração (WebApplicationFactory, Testcontainers)

### Fase 5: Produção
- [ ] Logs com Serilog
- [ ] Validação com FluentValidation
- [ ] Cache (Memory Cache e Redis)
- [ ] Tarefas em background (BackgroundService / Hangfire)
- [ ] Resiliência com Polly
- [ ] Docker + GitHub Actions (CI)

### Fase 6: Avançado
- [ ] Mensageria: RabbitMQ + MassTransit
- [ ] Tempo real: SignalR
- [ ] gRPC
- [ ] .NET Aspire
- [ ] Arquitetura (Clean Architecture, DDD, CQRS)
