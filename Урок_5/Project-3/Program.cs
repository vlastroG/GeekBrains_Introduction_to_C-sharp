using System;
using System.Collections.Generic;
using System.IO;

namespace Project_3
{

    public class Program
    {
        static void Main(string[] args)
        {
            var fileName = "binarySave.bin";
            var countOfByteNumbers = Convert.ToInt32(GetStringFromUser("Напишите количество целых чисел (0...250), которые хотите ввести:"));
            List<byte> listOfByteNumbers = new List<byte>();
            for (int i = 0; i < countOfByteNumbers; i++)
            {
                listOfByteNumbers.Add(Convert.ToByte(GetStringFromUser($"Введите {i + 1} число:")));
            }
            File.WriteAllBytes(fileName, listOfByteNumbers.ToArray());

            //byte[] fromFile = File.ReadAllBytes(fileName);
            //for (int i = 0; i < fromFile.Length; i++)
            //{
            //    Console.WriteLine(fromFile[i]);
            //}

        }
        static string GetStringFromUser(string messageToUser)//Запрашивает и возвращает строковое значение
        {
            Console.WriteLine(messageToUser);
            return Console.ReadLine();
        }
    }


}
