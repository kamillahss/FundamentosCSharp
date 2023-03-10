namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Start(int tempo)
        {
            int tempoAtual = 0;

            while(tempoAtual != tempo)
            {
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("StopWatch finalizado.");
            Menu();
        }

        static void PreStart(int time)
        {
            Console.Clear();
            System.Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            System.Console.WriteLine("Set...");
            Thread.Sleep(1000);
            System.Console.WriteLine("Gooo!");
            Thread.Sleep(2000);

            Start(time);
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Quanto tempo deseja contar:\nSegundos => ex: 10s\nMinutos => ex: 1m\n0s - Sair");
            
            string dado = Console.ReadLine().ToLower();
            char tipo = char.Parse(dado.Substring(dado.Length-1,1));
            int tempo = int.Parse(dado.Substring(0, dado.Length-1));

            int multiplicador = 1;

            if(tipo == 'm')
                multiplicador = 60;
            
            if(tempo == 0)
                System.Environment.Exit(0);

            PreStart(tempo * multiplicador);
        }
    }
}




