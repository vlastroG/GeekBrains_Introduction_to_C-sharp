using System;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new string[5, 2];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Введите имя {i + 1} контакта:");
                array[i, 0] = Console.ReadLine();
                Console.WriteLine($"Введите номер/e-mail {i + 1} контакта:");
                array[i, 1] = Console.ReadLine();
            }
            Console.WriteLine("\nСписок контактов:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{array[i, 0]}\t тел./e-mail: {array[i, 1]}");
                Console.WriteLine();
            }
        }
    }
}
