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
        private int id;

        public void AdicionarTarefa(string descricao)
        {
            ListaDeTarefas.Add(new Tarefa(contadorId, descricao));
            contadorId++;

        }
        public void ListarTarefas()
        {
            foreach (var Tarefa in ListaDeTarefas)
            {
                Tarefa.ExibirTarefa();
            }
        }
        public void ConcluirTarefa()
        {
            foreach (var Tarefa in ListaDeTarefas)
            {
                if (Tarefa.Id == id)
                {
                    Tarefa.Concluido = true;

                }
            }
            Console.WriteLine("Tarefa não encontrada!\n");
        }
        public void RemoverTarefas()
        {
            int removidas = ListaDeTarefas.RemoveAll(t => t.Id == id);

            if (removidas > 0)
            {
                Formatacao.Cor("Tarefa removida!", ConsoleColor.Green);
            }
            else
            {
                Formatacao.Cor("Nenhuma tarefa encontrada com esse ID.", ConsoleColor.Yellow);
            }

        }

    }
}
