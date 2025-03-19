// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        Console.Write("Введіть номер числа Фібоначчі: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Число Фібоначчі {n}-го порядку: {Fibonacci.Calculate(n)}");
    }
}

static class Fibonacci
{
    public static int Calculate(int n)
    {
        if (n == 1) return 0;
        if (n == 2) return 1;
        return Calculate(n - 1) + Calculate(n - 2);
    }
}