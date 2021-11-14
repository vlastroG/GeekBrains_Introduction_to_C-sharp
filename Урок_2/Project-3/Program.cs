using System;


namespace Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите целое число:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("Вы ввели ноль.");
            }
            else if ((number % 2) == 0)
            {
                Console.WriteLine("Введенное число - четное.");
            }
            else if (System.Math.Abs((number % 2)) == 1)
            {
                Console.WriteLine("Введенное число - нечетное.");
            }
           
        }
    }
}
