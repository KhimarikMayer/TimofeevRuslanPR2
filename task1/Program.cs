using System;
using System.Linq;

class Task1r
{
    static void Main()
    {
        Console.Write("Введите размер массива N: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Элемент [{i}]: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nМассив в обратном порядке: ");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();

        double average = arr.Average();
        Console.WriteLine($"Среднее арифметическое: {average:F2}");

        int closest = arr[0];
        double minDiff = Math.Abs(arr[0] - average);

        for (int i = 1; i < n; i++)
        {
            double diff = Math.Abs(arr[i] - average);
            if (diff < minDiff)
            {
                minDiff = diff;
                closest = arr[i];
            }
        }

        Console.WriteLine($"Число, ближайшее к среднему: {closest}");
    }
}