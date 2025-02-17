using System.Data.Common;
using System.Data.SqlTypes;
using Layout;
using Tarefas;
namespace GerenciarTarefa
{
    class Gerenciador
    {
        private List<Tarefa> ListaDeTarefas = new List<Tarefa>();
        private int contadorId = 1;

        

        public void AdicionarTarefa(string descricao)
        {
            ListaDeTarefas.Add(new Tarefa(contadorId, descricao));
            contadorId++;
        }

        public void ListarTarefas()
        {
            if (ListaDeTarefas.Count == 0)
            {
                Formatacao.Cor("Não há tarefas cadastradas.", ConsoleColor.Yellow);
                return;
            }

            foreach (var tarefa in ListaDeTarefas)
            {
               tarefa.ExibirTarefa();
            }
        }

        public void ConcluirTarefa()
        {
            
            if (int.TryParse(Console.ReadLine(), out int id))
            
            { Console.Clear();
                var tarefa = ListaDeTarefas.FirstOrDefault(t => t.Id == id);
                if (tarefa != null)
                {
                    tarefa.Concluido = true;
                    Formatacao.Cor("Tarefa concluída!", ConsoleColor.Green);
                }
                else
                {
                    Formatacao.Cor("Tarefa não encontrada!", ConsoleColor.Red);
                }

            }
            else
            {
                Formatacao.Cor("ID inválido.", ConsoleColor.Red);
            }
        }

        public void RemoverTarefas()
        {
          
            if (int.TryParse(Console.ReadLine(), out int id))
            {Console.Clear();
                int removidas = ListaDeTarefas.RemoveAll(t => t.Id == id);

                if (removidas > 0)
                {
                    Formatacao.Cor("Tarefa removida com sucesso!", ConsoleColor.Red);
                }
                else
                {
                    Formatacao.Cor("Nenhuma tarefa encontrada com esse ID.", ConsoleColor.Yellow);
                }
            }
            else
            {
                Formatacao.Cor("ID inválido.", ConsoleColor.Red);
            }
        }
    }
}