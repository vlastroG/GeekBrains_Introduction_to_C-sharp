using System;
using System.IO;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "startup.txt";
            var time = DateTime.Now.ToString();
            File.AppendAllLines(fileName, new[] { $"Программа была запущена {time}. Такие дела." });
            Console.WriteLine("Содержимое файла \"startup.txt\":");
            for (int i = 0; i < File.ReadAllLines(fileName).Length; i++)
            {
                Console.WriteLine(File.ReadAllLines(fileName)[i]); 
            }
        }
    }
}
