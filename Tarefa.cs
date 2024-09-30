namespace GerenciadorTarefas;

public class Tarefa
{
    public int IdTarefa { get; set; }
    public required string Nome { get; set; }
    public string TarefaDescricao { get; set; } = string.Empty;
    public string Prioridade { get; set; } = string.Empty; // Você pode definir se tem prioridade alta, média ou baixa, por exemplo;
    public DateTime? DeadLine { get; set; } = DateTime.Now;
    public bool Status { get; set; }  // Você pode definir três status: concluída, em andamento e aguardando, por exemplo.
}
