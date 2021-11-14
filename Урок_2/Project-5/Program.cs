using System;

namespace Project_5
{
    class Program
    {
        enum MonthsInYear
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            Jule,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            //months from project-2
            Console.WriteLine("Напишите порядковый номер текущего месяца:");
            byte monthNumber = Convert.ToByte(Console.ReadLine());
            string monthName = "";
            switch (monthNumber)
            {
                case 1:
                    monthName = Convert.ToString(MonthsInYear.January);
                    break;
                case 2:
                    monthName = Convert.ToString(MonthsInYear.February);
                    break;
                case 3:
                    monthName = Convert.ToString(MonthsInYear.March);
                    break;
                case 4:
                    monthName = Convert.ToString(MonthsInYear.April);
                    break;
                case 5:
                    monthName = Convert.ToString(MonthsInYear.May);
                    break;
                case 6:
                    monthName = Convert.ToString(MonthsInYear.June);
                    break;
                case 7:
                    monthName = Convert.ToString(MonthsInYear.Jule);
                    break;
                case 8:
                    monthName = Convert.ToString(MonthsInYear.August);
                    break;
                case 9:
                    monthName = Convert.ToString(MonthsInYear.September);
                    break;
                case 10:
                    monthName = Convert.ToString(MonthsInYear.October);
                    break;
                case 11:
                    monthName = Convert.ToString(MonthsInYear.November);
                    break;
                case 12:
                    monthName = Convert.ToString(MonthsInYear.December);
                    break;
                default:
                    Console.WriteLine("Некорректный ввод. Нужно ввести целое число от 1 до 12.");
                    break;
            }
            

            //temperature from project-1
            Console.WriteLine("Напишите минимальную температуру за сутки:");
            int minTemp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напишите максимальную температуру за сутки:");
            int maxTemp = Convert.ToInt32(Console.ReadLine());
            double middTemp = Convert.ToDouble(minTemp + maxTemp) / 2;
            
            //Вывод
            Console.WriteLine($"The current month is {monthName}.");
            Console.WriteLine($"Среднесуточная температура: {middTemp}.");
            if ((middTemp>0) && ((monthNumber == 12)  || (monthNumber == 1) || (monthNumber == 2)))
            {
                Console.WriteLine("Дождливая зима.");
            }
        }
    }
}
