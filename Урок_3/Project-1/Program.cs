using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива:");
            var arraySize = Convert.ToInt32(Console.ReadLine());

            var array = new int[arraySize, arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    Console.WriteLine($"Введите элемент {i+1} строки {j+1} столбца:");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    if (i == j)
                    {

                        Console.Write(array[i,j]);
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
