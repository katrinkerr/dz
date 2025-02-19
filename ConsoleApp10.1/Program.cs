// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введіть ім'я та прізвище через пробіл:");
string substring = Console.ReadLine();
string[] p = substring.Split(' ');
string name = p[0];
string surname = p[1];
if ((name[0]) == (surname[0]))
{
    Console.WriteLine("Прізвище починається на ту ж літеру, як ім’я");
}
else
{
    Console.WriteLine("Прізвище не починається на ту ж літеру, як ім’я");
}