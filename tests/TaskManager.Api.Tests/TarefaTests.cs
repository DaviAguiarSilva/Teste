using TaskManager.Api.Models;

namespace TaskManager.Api.Tests;

public class TarefaTests
{
    [Fact]
    public void Records_com_mesmos_valores_sao_iguais()
    {
        var a = new Tarefa(1, "Estudar", Concluida: false);
        var b = new Tarefa(1, "Estudar", Concluida: false);

        Assert.Equal(a, b); // records comparam por valor, não por referência
    }

    [Fact]
    public void With_cria_uma_copia_alterada_sem_mudar_a_original()
    {
        var original = new Tarefa(1, "Estudar", Concluida: false);

        var concluida = original with { Concluida = true };

        Assert.False(original.Concluida);
        Assert.True(concluida.Concluida);
    }
}
