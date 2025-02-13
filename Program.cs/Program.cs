using Layout;
using Tarefas;
using GerenciarTarefa;

var Gerenciador = new Gerenciador ();

Formatacao.ImprimirCabecalho();

Console.WriteLine("1 - Adicionar Tarefa");
Console.WriteLine("2 - Listar Tarefas  ");
Console.WriteLine("3 - Concluir Tarefa");
Console.WriteLine("4 - Remover Tarefa ");
Console.WriteLine("0 - Sair");
Console.WriteLine("Escolha uma opção:");

if (!int.TryParse(Console.ReadLine(), out int resposta))
{
    Formatacao.Cor("Insira uma resposta válida.", ConsoleColor.Red);
}

Console.Clear();

        switch (resposta) 
{
    case 1:
        Console.Clear();
        Console.Write("Escreva a descrição da tarefa que deseja realizar: ");
        string descricao = Console.ReadLine()?.Trim() ?? ""; 
       
        if (!string.IsNullOrEmpty(descricao)) 
        {
            Gerenciador.AdicionarTarefa(descricao);
        }
        else
        {
            Console.WriteLine("A descrição da tarefa não pode ser vazia!");
        }
        break;

    case 2:
        Console.Clear();
        Gerenciador.ListarTarefas();
    break;
    
    case 3:
        Console.Clear();
        Console.Write("Digite o ID da tarefa concluída: ");
        Gerenciador.ConcluirTarefa();
    break;

    case 4:
        Console.Clear();
        Console.Write("Digite o ID da tarefa que deseja remover");
    break;

    case 0:
        Console.WriteLine("Saindo....");
    break;   
}

   

    