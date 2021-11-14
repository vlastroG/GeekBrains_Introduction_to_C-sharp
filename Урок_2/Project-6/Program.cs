using System;

namespace Project_6
{

    class Program
    {
        [Flags]
        public enum Workdays
        {
            Sunday = 0b_0000001,
            Saturday = 0b_0000010,
            Friday = 0b_0000100,
            Thursday = 0b_0001000,
            Wednesday = 0b_0010000,
            Tuesday = 0b_0100000,
            Monday = 0b_1000000,
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите двоичное 7-мизначное число:");
            string inputDaysString = Console.ReadLine();
            int inputDaysBinary = Convert.ToInt32(inputDaysString, 2);

            Workdays allWorkDays = (Workdays)inputDaysBinary;

            Console.WriteLine($"The office work on: {allWorkDays}.");
        }

    }
}
