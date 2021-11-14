using System;

namespace Project_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пустое поле
            int mapLength = 10;
            var map = new string[mapLength, mapLength];
            for (int i = 0; i < mapLength; i++)
            {
                for (int j = 0; j < mapLength; j++)
                {
                    map[i, j] = "O";
                }
            }
            //Корабли
            Random rnd = new Random();
            var k = 0;
            while (k < 30)
            {
                var x = rnd.Next(0, 9);
                var y = rnd.Next(0, 9);
                map[x, y] = "X";
                k++;
            }

            //Вывод поля
            for (int i = 0; i < mapLength; i++)
            {
                for (int j = 0; j < mapLength; j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
