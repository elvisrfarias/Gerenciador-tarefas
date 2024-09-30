using GerenciadorComunication.Enums;

namespace GerenciadorTarefas;

public class Tarefa
{
    public int IdTarefa { get; set; }
    public required string Nome { get; set; }
    public required string TarefaDescricao { get; set; }
    public PrioridadeTarefaEnum Prioridade { get; set; }
    public DateTime? DeadLine { get; set; } = DateTime.Now.AddDays(2);
    public StatusTarefaEnum Status { get; set; }
}
