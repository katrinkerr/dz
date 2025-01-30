// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введіть номер для тижня: ");
int dayNumber = int.Parse(Console.ReadLine());

switch (dayNumber)
{
    case 1:
        Console.WriteLine("Понеділок");
        break;
    case 2:
        Console.WriteLine("Вівторок");
        break;
    case 3:
        Console.WriteLine("Середа");
        break;
    case 4:
        Console.WriteLine("Четвер");
        break;
    case 5:
        Console.WriteLine("П'ятниця");
        break;
    case 6:
        Console.WriteLine("Субота");
        break;
    case 7:
        Console.WriteLine("Неділя");
        break;
    default:
        Console.WriteLine("Невірний номер дня. Введіть число від 1 до 7.");
        break;
}
