// See https://aka.ms/new-console-template for more information
using System.Text;
class Program
{
    static void Main()
    {
        StringBuilder myStringBuilder = new StringBuilder();
        Console.WriteLine("Введіть рядок ");
        string substring =Console.ReadLine();
        string result = substring.Replace(" ", "");
        Console.WriteLine(result);
    }
}



