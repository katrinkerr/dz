// See https://aka.ms/new-console-template for more information

//1
/*Random rnd = new Random();
int[] num = new int[10];
for (int i = 0; i < num.Length; i++)
{
    num[i] = rnd.Next(-10, 11);
}
Console.WriteLine("Елементи з парними індексами:");
for (int i = 0; i < num.Length; i += 2)
{
    Console.WriteLine($"Індекс {i}: {num[i]}");
}

//2
int sum = num.Sum();
if(sum > 0)
{
    Console.WriteLine("Сума не від'ємна");
}
else
{
    Console.WriteLine("Сума від'ємна");
}*/

//3
/*int[,] multiplicationTable = new int[9, 9];
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        multiplicationTable[i, j] = (i + 1) * (j + 1);
    }
}
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.Write(multiplicationTable[i, j].ToString()+ " ");
    }
    Console.WriteLine();
}*/

//4
/*int[,] array = {
            { 3,  8, -2,  4,  6 },
            { 7, -9,  5, 12,  1 },
            { 0, 11, -7,  2, 15 },
            {14, -3,  9, -6,  8 },
            {-1, 10, 13,  7, -4 }
        };

int min = array[0, 0], max = array[0, 0];
int minRow = 0, minCol = 0, maxRow = 0, maxCol = 0;

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (array[i, j] < min)
        {
            min = array[i, j]; minRow = i; minCol = j; 
        }
        if (array[i, j] > max) 
        {
            max = array[i, j]; maxRow = i; maxCol = j;
        }
    }
}
Console.WriteLine($"Максимум: {max} (індекс [{maxRow}, {maxCol}])");
Console.WriteLine($"Мінімум: {min} (індекс [{minRow}, {minCol}])");*/

//5
Console.Write("Введіть кількість днів: ");
int days = int.Parse(Console.ReadLine());
Console.WriteLine($"Через {days} днів буде: {(days)(days % 7)}");
enum days
{
    Monday,
    Tuesday,
    Wednesday, 
    Thursday,
    Friday,
    Saturday,
    Sunday,

};

    