// See https://aka.ms/new-console-template for more information
Console.Write("Введіть число: ");
string a = Console.ReadLine();
try
{
    double number = Convert.ToDouble(a);
    Console.WriteLine($"Ви ввели число: {number}");
}
catch (FormatException)
{
    Console.WriteLine("Помилка: введене значення не є числом.");
}
catch (Exception ex)
{
    Console.WriteLine($"Сталася помилка: {ex.Message}");
}


