// See https://aka.ms/new-console-template for more information
//1
/*int[] nums = new int[] { 10, 3, 9, 8, 82, 17 };
int thelargest = int.MinValue;
int second = int.MinValue;
foreach (int num in nums)
{
    if (num > thelargest)
    {
        second = thelargest;
        thelargest = num;
    }
    else if (num > second && num < thelargest)
    {
       second = num;
    }
}
Console.WriteLine(second);*/

//2

/*int[,] array = {
            { 9, 7, 3 },
            { 4, 1, 8 },
            { 6, 2, 5 }};
int rows = array.GetLength(0);
int cols = array.GetLength(1);
int[] zrist = new int[rows * cols];
int index = 0;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        zrist[index++] = array[i, j];
    }    
}
Array.Sort(zrist);

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        array[i, j] = zrist[index++];
        rows = array.GetLength(0);
        rows = array.GetLength(1);

    }
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}*/

//3
/*int[] numbers = { 1, 2, 3, 4, 5 };
Console.WriteLine("Введіть індекс для видалення:");
if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < numbers.Length)
{
    int[] newArray = new int[numbers.Length-1];
    int newIndex = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i != index)
        {
            newArray[newIndex++] = numbers[i];
        }
    }
    Console.WriteLine("Оновлений масив:");
    foreach (var num in newArray)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}
else
{
    throw new Exception();
}*/

//4
/*int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
int size = array.GetLength(0);
int sum = 0;

for (int i = 0; i < size; i++)
{
    sum += array[i, i];
}
Console.WriteLine("Сума елементів по головній діагоналі: " + sum);*/
    