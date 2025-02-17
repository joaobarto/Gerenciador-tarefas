using Layout;
using Tarefas;
using GerenciarTarefa;

internal class Program
{
    private static void Main(string[] args)
    {
        var Gerenciador = new Gerenciador();

        do
        {
            Formatacao.ImprimirCabecalho();

            Console.WriteLine("1 - Adicionar Tarefa");
            Console.WriteLine("2 - Listar Tarefas");
            Console.WriteLine("3 - Concluir Tarefa");
            Console.WriteLine("4 - Remover Tarefa");
            Console.WriteLine("0 - Sair");
            Console.Write("\nEscolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out int resposta))
            {
                Formatacao.Cor("Insira uma resposta válida.", ConsoleColor.Red);
            }

           

            switch (resposta)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Escreva a descrição da tarefa que deseja realizar: ");
                    string descricao = Console.ReadLine()?.Trim() ?? "";
                
                    if (!string.IsNullOrEmpty(descricao))
                    {
                        Gerenciador.AdicionarTarefa(descricao);
                        Formatacao.Cor("Tarefa adicionada com sucesso!", ConsoleColor.Green);
                        
                    }
                    else
                    {
                        Console.WriteLine("A descrição da tarefa não pode ser vazia!");
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                        Console.ReadKey();
                    }
                     
                    break;
                    
                case 2:
                    Console.Clear();
                    Gerenciador.ListarTarefas();
                    break;

                case 3:
                    Console.Clear();
                    Gerenciador.ListarTarefas();
                    Console.Write("\nDigite o ID da tarefa para ser concluída: ");
                    Gerenciador.ConcluirTarefa();
                    Gerenciador.ListarTarefas();
                    
                    break;

                case 4:
                    Console.Clear();
                    Gerenciador.ListarTarefas();
                    Console.Write("\nDigite o ID da tarefa que deseja remover: ");

                    Gerenciador.RemoverTarefas();
                    break;

                case 0:
                    Console.Clear();
                    Formatacao.Cor("Saindo....", ConsoleColor.Red);
                    return;

                default:
                    Console.WriteLine("Opção inválida. Pressione qualquer tecla para voltar ao menu.");
                    Console.ReadKey();
                    break;
            }

        } while (true);
    }
}