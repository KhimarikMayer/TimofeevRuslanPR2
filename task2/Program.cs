using System;

class Task2
{
    static void Main()
    {
        Console.Write("Введите количество студентов (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите количество предметов (m): ");
        int m = int.Parse(Console.ReadLine());

        int[,] grades = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nСтудент №{i + 1}:");
            for (int j = 0; j < m; j++)
            {
                Console.Write($"  Оценка по предмету №{j + 1}: ");
                grades[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nСредние оценки студентов:");
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < m; j++)
                sum += grades[i, j];

            double average = (double)sum / m;
            Console.WriteLine($"Студент №{i + 1}: средний балл = {average:F2}");
        }
    }
}