using System;

namespace ДЗ_урок_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите свое имя:");
            string userName = Console.ReadLine();
            Console.WriteLine($"Привет, {userName}! Сегодня {DateTime.Today.ToShortDateString()}. Врывайся в этот день!");
        }
    }
}
