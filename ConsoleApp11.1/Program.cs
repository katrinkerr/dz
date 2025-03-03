// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
string word = "собака";
char[] guessedWord = new string(' ', word.Length).ToCharArray();
int attemptsLeft = 6;
List<char> guessedLetters = new List<char>();

Console.WriteLine("Вітаємо! Спробуйте вгадати зашифроване слово!");
Console.WriteLine($"Кількість літер у слові: {word.Length}");
Console.WriteLine($"Кількість можливих невірних спроб: {attemptsLeft}\n");

while (attemptsLeft > 0 && new string(guessedWord) != word)
{
    Console.Write("Введіть вашу літеру: ");
    char input = Console.ReadKey().KeyChar;
    Console.WriteLine();

    if (guessedLetters.Contains(input))
    {
        Console.WriteLine("Ви вже вводили цю літеру!");
        continue;
    }

    guessedLetters.Add(input);

    if (word.Contains(input))
    {
        Console.Write("Така літера є у слові! Позиція літери: ");
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == input)
            {
                guessedWord[i] = input;
                Console.Write((i + 1) + " ");
            }
        }
        Console.WriteLine();
    }
    else
    {
        attemptsLeft--;
        Console.WriteLine($"Такої літери немає! Залишилось спроб: {attemptsLeft}");
    }

    Console.WriteLine("Поточний стан слова: " + new string(guessedWord));
    Console.WriteLine();
}

if (new string(guessedWord) == word)
{
    Console.WriteLine($"Вітаємо, ви вгадали слово! Зашифроване слово: {word}.");
}
else
{
    Console.WriteLine($"Ви програли! Правильне слово: {word}.");
}
Console.WriteLine("Дякуємо за гру!");