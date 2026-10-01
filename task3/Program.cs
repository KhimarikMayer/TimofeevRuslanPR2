using System;
using System.Collections.Generic;

class Task3
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        HashSet<int> seen = new HashSet<int>();

        Console.WriteLine("Вводите числа (введите число, которое уже было — программа остановится):");

        while (true)
        {
            Console.Write("Число: ");
            int num = int.Parse(Console.ReadLine());

            if (seen.Contains(num))
            {
                Console.WriteLine($"Число {num} уже встречалось. Остановка.");
                break;
            }

            seen.Add(num);
            numbers.Add(num);
        }

        Console.WriteLine("\nВведённые числа:");
        foreach (int x in numbers)
            Console.Write(x + " ");
        Console.WriteLine();
    }
}