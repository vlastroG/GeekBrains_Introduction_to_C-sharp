using System;
using System.Collections.Generic;
using System.IO;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "AllYouNeedIsLove.txt";
            var CountOfLines = Convert.ToInt32(GetStringFromUser("Напишите количество строчек, который Вы хотите сохранить в файл:"));
            List<string> ListOfTextLines = new List<string>();
            for (int i = 0; i < CountOfLines; i++)
            {
                ListOfTextLines.Add(GetStringFromUser($"Напишите {i + 1} строчку текста:"));
            }

            File.WriteAllLines(fileName, ListOfTextLines.ToArray());
        }
        static string GetStringFromUser(string messageToUser)//Запрашивает и возвращает строковое значение
        {
            Console.WriteLine(messageToUser);
            return Console.ReadLine();
        }

    }
}
