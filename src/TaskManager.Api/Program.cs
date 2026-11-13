using TaskManager.Api.Models;

var builder = WebApplication.CreateBuilder(args);

// ---------------------------------------------------------------
// 1) SERVIÇOS (Dependency Injection container)
//    Tudo que é registrado aqui pode ser "pedido" depois pelos endpoints.
//    Você vai aprofundar isso na Fase 2 (Scoped / Transient / Singleton).
// ---------------------------------------------------------------
builder.Services.AddOpenApi();

var app = builder.Build();

// ---------------------------------------------------------------
// 2) PIPELINE HTTP (Middlewares)
//    Cada requisição passa por estes middlewares, na ordem em que aparecem.
// ---------------------------------------------------------------
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi(); // documento OpenAPI em /openapi/v1.json
}

app.UseHttpsRedirection();

// ---------------------------------------------------------------
// 3) ENDPOINTS (Minimal APIs)
//    Por enquanto os dados ficam em memória (uma lista).
//    Na Fase 3 isso vira um banco de verdade com Entity Framework Core.
// ---------------------------------------------------------------
var tarefas = new List<Tarefa>
{
    new(1, "Estudar o protocolo HTTP", Concluida: false),
    new(2, "Instalar o .NET SDK", Concluida: true),
};

app.MapGet("/health", () => Results.Ok(new { status = "ok" }));

app.MapGet("/tarefas", () => Results.Ok(tarefas));

app.MapGet("/tarefas/{id:int}", (int id) =>
{
    var tarefa = tarefas.FirstOrDefault(t => t.Id == id);

    // 200 OK quando encontra, 404 Not Found quando não existe.
    return tarefa is null ? Results.NotFound() : Results.Ok(tarefa);
});

app.Run();

// Torna a classe Program visível para os testes de integração (WebApplicationFactory, Fase 4).
public partial class Program;
