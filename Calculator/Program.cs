
internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.WriteLine("------------------------");
        Console.WriteLine("MENU\nDigite uma opção: \n1-Somar\n2-Subtrair\n3-Dividir\n4-Multriplicar\n5-Sair");
        Console.WriteLine("------------------------");
        int opcao = Int32.Parse(Console.ReadLine());

        switch(opcao)
        {
            case 1: Somar(); break;
            case 2: Subtrair(); break;
            case 3: Dividir(); break;
            case 4: Multiplicar(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;
        }
    }

    static void Somar()
    {
        Console.WriteLine("Digite o primeiro valor: ");
        double valor1 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        double valor2 = Int32.Parse(Console.ReadLine());

        double resultado = valor1 + valor2;

        Console.WriteLine($"\nO resultado é {resultado}\n");
        Menu();
    }

    static void Subtrair()
    {
        Console.WriteLine("Digite o primeiro valor: ");
        double valor1 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        double valor2 = Int32.Parse(Console.ReadLine());

        double resultado = valor1 - valor2;

        Console.WriteLine($"\nO resultado é {resultado}\n");
        Menu();
    }

    static void Dividir()
    {
        Console.WriteLine("Digite o primeiro valor: ");
        double valor1 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        double valor2 = Int32.Parse(Console.ReadLine());

        double resultado = valor1 / valor2;

        Console.WriteLine($"\nO resultado é {resultado}\n");
        Menu();
    }

    static void Multiplicar()
    {
        Console.WriteLine("Digite o primeiro valor: ");
        double valor1 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        double valor2 = Int32.Parse(Console.ReadLine());

        double resultado = valor1 * valor2;

        Console.WriteLine($"\nO resultado é {resultado}\n");
        Menu();
    }
    
}
