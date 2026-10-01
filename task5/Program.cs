using System;
using System.Collections.Generic;

class Task5
{
    static void Main()
    {
        Dictionary<string, int> counter = new Dictionary<string, int>();

        Console.WriteLine("Вводите слова (яблоко, банан и т.д.). Для выхода введите 'выход'.");

        while (true)
        {
            Console.Write("\nВведите слово: ");
            string word = Console.ReadLine().ToLower();

            if (word == "выход" || word == "exit")
            {
                Console.WriteLine("Завершение работы.");
                break;
            }

            if (counter.ContainsKey(word))
                counter[word]++;
            else
                counter[word] = 1;

            Console.WriteLine($"{word}:{counter[word]}");
        }

        Console.WriteLine("\nИтоговый словарь:");
        foreach (var pair in counter)
            Console.WriteLine($"  {pair.Key}:{pair.Value}");
    }
}