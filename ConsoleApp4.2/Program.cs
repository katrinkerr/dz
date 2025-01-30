// See https://aka.ms/new-console-template for more information
Console.Write("Введіть перше число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введіть друге число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введіть операцію (+, -, *, /): ");
int operation =Convert.ToInt32(Console.ReadLine());
int result;
switch (operation)
{
    case 1:
        result = num1 + num2;
        Console.WriteLine($"Результат: {result}");
        break;

    case 2:
        result = num1 - num2;
        Console.WriteLine($"Результат: {result}");
        break;

    case 3:
        result = num1 * num2;
        Console.WriteLine($"Результат: {result}");
        break;

    case 4:
        if (num2 != 0)
        {
            double dresult = (double)num1 / num2;
            Console.WriteLine($"Результат:{dresult}");
        }
        else
        {
            Console.WriteLine("Помилка: ділення на нуль!");
        }
        break;
    default:
        Console.WriteLine("Невірна операція");
        break;
}


    

