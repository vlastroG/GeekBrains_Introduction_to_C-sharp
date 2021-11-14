using System;

namespace Project_4
{
    class Program
    {
        static void Main(string[] args)//Выводит число Фибоначчи в консоль по его порядковому номеру
        {
            var FibonacciNumber = GetIntFromUser("Напишите порядковый номер числа Фибоначчи:");
            var FibonacciValue = GetFibonacciValueFromNumber(FibonacciNumber);
            Console.WriteLine($"Значение числа Фибоначчи с порядковым номером {FibonacciNumber} равно {FibonacciValue}");
        }
        static int GetFibonacciValueFromNumber(int FibonacciNumber)//Возвращает значение числа Фибоначчи по его порядковому номеру
        {
            if ((FibonacciNumber == 1) || (FibonacciNumber == 2))
            {
                return 1;
            }
            else
            {
                return GetFibonacciValueFromNumber(FibonacciNumber - 1) + GetFibonacciValueFromNumber(FibonacciNumber - 2);
            }

        }
        static int GetIntFromUser(string messageToUser)//Запрашивает и возвращает целое число >=1
        {
            Console.WriteLine(messageToUser);
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {

                return number;
            }
            else
            {
                return GetIntFromUser("Введите целое число, большее или равное единице:");
            }
        }

    }
}
