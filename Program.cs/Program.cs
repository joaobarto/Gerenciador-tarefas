using Layout;
using Tarefas;
using GerenciarTarefa;

Console.Clear();
Formatacao.ImprimirCabecalho();

Console.WriteLine("1 - Adicionar Tarefa");
Console.WriteLine("2 - Listar Tarefas  ");
Console.WriteLine("3 - Concluir Tarefa");
Console.WriteLine("4 - Remover Tarefa ");
Console.WriteLine("0 - Sair");

if (!int.TryParse(Console.ReadLine(), out int resposta))
{
    Formatacao.Cor("Insira uma resposta válida.", ConsoleColor.Red);
}

Console.Clear();

switch (resposta) 
{
    case 1:
    GerenciarTarefa.AdicionarTarefa();
    break;
    case 2:
    GerenciarTarefa.ListarTarefas();
    break;
    case 3:
    GerenciarTarefa.ConcluirTarefa();
    break;
    case 1:
    GerenciarTarefa.RemoverTarefa();
    break;


}
    

    