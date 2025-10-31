int n = 0;
int maximo;

Console.Write("Digite o valor máximo: ");
maximo = Convert.ToInt32(Console.ReadLine());

while (n <= maximo)
{
    Console.ForegroundColor = (ConsoleColor)(n % 16);
    Console.Write($"{n} ");
    n = n + 1;
    Thread.Sleep(200);
}

Console.ResetColor();