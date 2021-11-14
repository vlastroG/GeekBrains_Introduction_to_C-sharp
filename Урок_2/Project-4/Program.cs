using System;

namespace Project_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Чек оплаты счета в кафе. Гости заказали 4 позиции.
            
            //Первое блюдо
            Console.WriteLine("Введите название первого блюда:");
            string firstDishName = Console.ReadLine();
            Console.WriteLine("Введите стоимость первого блюда:");
            double firstDishValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество блюд №1");
            int firstDishCount = Convert.ToInt32(Console.ReadLine());

            //Второе блюдо
            Console.WriteLine("Введите название второго блюда:");
            string secondDishName = Console.ReadLine();
            Console.WriteLine("Введите стоимость второго блюда:");
            double secondDishValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество блюд №2");
            int secondDishCount = Convert.ToInt32(Console.ReadLine());

            //Третье блюдо
            Console.WriteLine("Введите название третьего блюда:");
            string thirdDishName = Console.ReadLine();
            Console.WriteLine("Введите стоимость третьего блюда:");
            double thirdDishValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество блюд №3");
            int thirdDishCount = Convert.ToInt32(Console.ReadLine());

            //Четвертое блюдо
            Console.WriteLine("Введите название четвертого блюда:");
            string fourthDishName = Console.ReadLine();
            Console.WriteLine("Введите стоимость четвертого блюда:");
            double fourthDishValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество блюд №4");
            int fourthDishCount = Convert.ToInt32(Console.ReadLine());

            //Сумма заказа
            double totalDishValue = Convert.ToDouble(firstDishValue*firstDishCount
                                                    +secondDishValue*secondDishCount
                                                    +thirdDishValue*thirdDishCount
                                                    +fourthDishValue*fourthDishCount);

            //Текущая дата
            object date = DateTime.Now;

            //Дальше идет рисование чека в консоль
            Console.WriteLine($"\tООО \'The best taste\'\n\tДОБРО ПОЖАЛОВАТЬ !\nОткрыт {date}\n_________________________");
            Console.WriteLine("Блюда\tКол-во\tСумма\n.........................");
            Console.WriteLine($"{firstDishName}\t{firstDishCount}*\t{firstDishValue}");
            Console.WriteLine($"{secondDishName}\t{secondDishCount}*\t{secondDishValue}");
            Console.WriteLine($"{thirdDishName }\t{thirdDishCount}*\t{thirdDishValue}");
            Console.WriteLine($"{fourthDishName}\t{fourthDishCount}*\t{fourthDishValue}");
            Console.WriteLine($"Итого к оплате:\t{totalDishValue}");
            Console.WriteLine("\nВознаграждение официанту\nприветствуется, но всегда\nостается на Ваше усмотрение.");
         
        }
    }
}
