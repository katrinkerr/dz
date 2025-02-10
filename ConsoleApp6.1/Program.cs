// See https://aka.ms/new-console-template for more information

//1
/*Console.Write("Введіть кількість працівників: ");
int n = int.Parse(Console.ReadLine());
if (n <= 0)
{
    Console.WriteLine("Кількість працівників має бути більшою за 0.");
    return;
}
double zp = 0;
for (int i = 1; i <= n; i++)
{
    Console.Write($"Введіть зарплату працівника {i}: ");
    double zpOne;
    while (!double.TryParse(Console.ReadLine(), out zpOne) || zpOne < 0)
    {
        Console.Write("Некоректне значення. Введіть зарплату ще раз: ");
    }
    zp += zpOne;
}
double averageSalary = zp / n;
Console.WriteLine($"Середня зарплата: {averageSalary:F2}");*/


//2
/*Console.WriteLine("Введіть кількість рядків:");
int k;
while (!int.TryParse(Console.ReadLine(), out k) || k <= 0)
{
    Console.WriteLine("Введіть правильну кількість: ");
}
for(int i = 1; i <= k; i++)
{
    Console.WriteLine(new string('*',i));
}*/


//4
/*Console.Write("Введіть пароль: ");
string password = Console.ReadLine();
if (password.Length >= 8 &&password.Any(char.IsDigit) && password.Any(ch => "!@#$%^&*".Contains(ch)))
{
    Console.WriteLine("Пароль прийнятний!");
}
else
{
    Console.WriteLine("Пароль не відповідає вимогам.");
}*/
    



//5
/*int N;
Console.Write("Введіть кількість чисел Фібоначчі (N): ");
while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
{
    Console.Write("Некоректне значення. Введіть додатне ціле число: ");
} 
    long first = 0, second = 1, next;
    Console.WriteLine($"Перші {N} чисел Фібоначчі:");

    for (int i = 0; i < N; i++)
    {
        Console.Write(first + " ");
        next = first + second;
        first = second;
        second = next;
    }
    Console.WriteLine();*/


//6
/*double hoursWorked;
double hourlyrate;
Console.Write("Введіть кількість відпрацьованих годин за день: ");
while (!double.TryParse(Console.ReadLine(), out hoursWorked) || hoursWorked < 0)
{
    Console.Write("Некоректне значення");
}
Console.Write("Введіть годинну ставку: ");
while (!double.TryParse(Console.ReadLine(), out hourlyrate) || hourlyrate < 0)
{
    Console.Write("Некоректне значення. Введіть додатне число: ");
}
    double dailySalary = hoursWorked * hourlyrate;
    Console.WriteLine($"Оплата за день: {dailySalary:F2} грн");*/

//7
/*int number;
Console.Write("Введіть число для таблиці множення: ");
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.Write("Некоректне значення. Введіть ціле число: ");
}
    Console.WriteLine($"\nТаблиця множення для {number}:");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{number} x {i} = {number * i}");
    }*/



















