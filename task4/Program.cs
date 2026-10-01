using System;
using System.Collections.Generic;

class Task4
{
    static void Main()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        Console.WriteLine("Телефонная книга. Команды: add, find, show, exit");

        while (true)
        {
            Console.Write("\nКоманда: ");
            string command = Console.ReadLine().ToLower();

            if (command == "exit" || command == "выход")
            {
                Console.WriteLine("Выход из программы.");
                break;
            }
            else if (command == "add" || command == "добавить")
            {
                Console.Write("Имя: ");
                string name = Console.ReadLine();
                Console.Write("Телефон: ");
                string phone = Console.ReadLine();

                phoneBook[name] = phone;
                Console.WriteLine($"Контакт {name} сохранён.");
            }
            else if (command == "find" || command == "найти")
            {
                Console.Write("Имя для поиска: ");
                string name = Console.ReadLine();

                if (phoneBook.TryGetValue(name, out string phone))
                    Console.WriteLine($"{name}: {phone}");
                else
                    Console.WriteLine("Контакт не найден.");
            }
            else if (command == "show" || command == "просмотр")
            {
                if (phoneBook.Count == 0)
                {
                    Console.WriteLine("Книга пуста.");
                    continue;
                }

                Console.WriteLine("Все контакты:");
                foreach (var pair in phoneBook)
                    Console.WriteLine($"  {pair.Key}: {pair.Value}");
            }
            else
            {
                Console.WriteLine("Неизвестная команда.");
            }
        }
    }
}