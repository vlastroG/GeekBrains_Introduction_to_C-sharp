using System;
using System.Globalization;

namespace Project_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string stringOfNumbersFromUser = GetStringFromUser("Введите последовательность чисел через пробел:\n *(в качетве разделителя дробных чисел можете использовать \'.\' или \',\')");
            string[] arrayOfStringNumbers = stringOfNumbersFromUser.Split(" ");
            double sum = 0;
            for (int i = 0; i < arrayOfStringNumbers.Length; i++)
            {
                double number;
                if (Double.TryParse(arrayOfStringNumbers[i], out number))
                {
                    sum += number;
                }
                else
                {
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                    //NumberFormatInfo nfi = new CultureInfo("en-US");
                    //nfi.NumberDecimalSeparator = ".";
                    Double.TryParse(arrayOfStringNumbers[i], out number);
                    sum += number;
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-RU");
                }
            }
            
            Console.WriteLine($"Сумма введенных чисел: {sum}");
            
        }
        static string GetStringFromUser(string messageToUser)//Запрашивает и возвращает строковое значение
        {
            Console.WriteLine(messageToUser);
            return Console.ReadLine();
        }
    }
}
