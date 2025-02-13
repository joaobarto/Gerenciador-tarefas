using System.Data.Common;
using System.Data.SqlTypes;
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
            foreach (var Tarefa in ListaDeTarefas)
            {
                Tarefa.ExibirTarefa();
            }
        }
        
        
    }
}
