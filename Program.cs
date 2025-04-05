        int n1;
        int n2;
        int resposta;

    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.BackgroundColor = ConsoleColor.Cyan;

Console.WriteLine(" --- Calculo de soma --- ");

    Console.ResetColor();

Console.Write(@"
Digite um numero para fazer a soma: ");
n1 = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Digite um segundo numero para fazer a soma: ");
n2 = Convert.ToInt32(Console.ReadLine()!);

        resposta = n1 + n2;

Console.WriteLine($@"
A soma entre {n1} e {n2} é {resposta}!");
