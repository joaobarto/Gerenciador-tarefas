namespace Layout
{
    class Formatacao
    {
        public static void Cor(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
        public static void ImprimirCabecalho()
        {
           // int larguraConsole = Console.WindowWidth;
          Console.WriteLine("╔════════════════════════════════════╗");
          Console.WriteLine("║       GERENCIADOR DE TAREFAS       ║");
          Console.WriteLine("╚════════════════════════════════════╝");

            //Console.WriteLine(CentralizarTexto(cabecalho, larguraConsole));
            //Console.WriteLine(CentralizarTexto(titulo, larguraConsole));
           // Console.WriteLine(CentralizarTexto(rodape, larguraConsole));
        }
        private static string CentralizarTexto(string texto, int larguraConsole)
        {
            int espaco = (larguraConsole - texto.Length) / 2;
            return new string(' ', espaco) + texto;
        }


    }

}
