
Menu();


static void Menu()
{
    Console.Clear();
    Console.WriteLine("Selecione a opção que deseja:\n1 - Abrir o arquivo\n2 - Criar novo arquivo\n0 - Sair");
    int op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 0: Environment.Exit(0); break;
        case 1: Abrir(); break;
        case 2: Criar(); break;
        default: Menu(); break;
    }
}

static void Abrir()
{
    Console.Clear();
    Console.WriteLine("Qual caminho do arquivo?");
    string caminho = Console.ReadLine();

    using (var arquivo = new StreamReader(caminho))
    {
        string texto = arquivo.ReadToEnd();
        Console.WriteLine(texto);
    }

    Console.WriteLine("");
    Console.ReadLine();
    Menu();
}

static void Criar()
{
    Console.Clear();
    Console.WriteLine("Digite o seu texto abaixo: (ESC para sair)\n");
    string texto = "";
    do
    {
        texto += Console.ReadLine();
        texto += Environment.NewLine;
    }
    while (Console.ReadKey().Key != ConsoleKey.Escape);

    Salvar(texto);
}

static void Salvar(string texto)
{
    Console.Clear();
    Console.WriteLine("Qual caminho para salvar o arquivo?");
    var caminho = Console.ReadLine();

    using (var arquivo = new StreamWriter(caminho))
    {
        arquivo.Write(texto);
    }

    System.Console.WriteLine($"Arquivo {caminho} salvo com sucesso!");
    Console.ReadLine();
    Menu();
}
