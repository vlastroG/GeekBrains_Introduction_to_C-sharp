using System;

namespace Project_3
{
    enum seasons
    {
        Winter,
        Spring,
        Summer,
        Autumn
    }
    class Program
    {
        static void Main(string[] args)
        {
            var monthNumber = checkMonthNumber(Convert.ToInt32(GetStringFromUser("Введите порядковый номер месяца:")));
            Console.WriteLine(getStringFromSeason(getSeasonFromMonthNumber(monthNumber)));
        }

        static string GetStringFromUser(string messageToUser)//Запрашивает и возвращает строковое значение
        {
            Console.WriteLine(messageToUser);
            return Console.ReadLine();
        }

        static int checkMonthNumber(int monthNumber)//Проверяет номер месяца и возвращает верный
        {
            if ((monthNumber > 0) && (monthNumber < 13))
            {
                return monthNumber;
            }
            else
            {
                monthNumber = Convert.ToInt32(GetStringFromUser("Ошибка: введите число от 1 до 12:"));
                return checkMonthNumber(monthNumber);
            }
        }

        static seasons getSeasonFromMonthNumber(int monthNumber)//Возвращает season по номеру месяца
        {
            
            switch (monthNumber)
            {
                case 3:
                case 4:
                case 5:
                    return seasons.Spring;

                case 6:
                case 7:
                case 8:
                    return seasons.Summer;

                case 9:
                case 10:
                case 11:
                    return seasons.Autumn;

                default:
                    return seasons.Winter;
            }
        }

        static string getStringFromSeason(seasons season)//Возвращает строку из season
        {
            switch (season)
            {
                case seasons.Winter:
                    return "Вы ввели номер зимнего месяца.";
                case seasons.Spring:
                    return "Вы ввели номер весеннего месяца.";
                case seasons.Summer:
                    return "Вы ввели номер летнего месяца.";
                default:
                    return "Вы ввели номер осеннего месяца.";
            }
        }
    }
}
