// See https://aka.ms/new-console-template for more information
double a, b;
Console.WriteLine("Введіть перше число: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введіть друге число: ");
b= Convert.ToDouble(Console.ReadLine());
try
{
    Console.WriteLine(a / b);
}
catch(DivideByZeroException) 
{
    
}
Console.WriteLine("Ділення на 0 заборонено");