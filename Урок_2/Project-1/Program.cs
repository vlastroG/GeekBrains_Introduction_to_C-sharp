using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите минимальную температуру за сутки:");
            int minTemp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напишите максимальную температуру за сутки:");
            int maxTemp = Convert.ToInt32(Console.ReadLine());
            double middTemp = Convert.ToDouble(minTemp + maxTemp) / 2;
            Console.WriteLine($"Среднесуточная температура: {middTemp}.");
        }
    }
}
