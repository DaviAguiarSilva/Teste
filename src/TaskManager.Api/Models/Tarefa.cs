namespace TaskManager.Api.Models;

// "record" = tipo imutável, ótimo para representar dados (DTOs, modelos simples).
public record Tarefa(int Id, string Titulo, bool Concluida);
