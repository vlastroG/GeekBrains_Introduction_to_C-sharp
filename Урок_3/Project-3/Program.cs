using System;

namespace Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите что-нибудь интересное о своей жизни:)");
            string phrase = Console.ReadLine();
            for (int i = (phrase.Length - 1); i > -1; i--)
            {
                Console.Write(phrase[i]);
            }
            Console.WriteLine();
        }
    }
}
