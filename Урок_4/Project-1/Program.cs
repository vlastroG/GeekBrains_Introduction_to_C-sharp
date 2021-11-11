using System;

namespace Project_1
{
    
    class Program
    {
        static void Main(string[] args) //Выводит ФИО заданного количества пользователей
        {
            var arraySize = Convert.ToInt32(GetStringFromUser("Введите количество пользователей:"));

            var arrayOfUsers = new string[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                string firstName = GetStringFromUser($"Пользователь {i + 1}, введите Ваше имя:");
                string lastName = GetStringFromUser($"Пользователь {i + 1}, введите Вашу фамилию:");
                string patronymic = GetStringFromUser($"Пользователь {i + 1}, введите Ваше отчетво:");
                arrayOfUsers[i] = GetFullName(firstName, lastName, patronymic);
            }
            printStringArray(arrayOfUsers);

        }
        static string GetFullName(string firstName, string lastName, string patronymic)//Возвращает ФИО из полученных имени, фамилии и отчества
        {

            return $"{lastName} {firstName} {patronymic}";
        }
        static string GetStringFromUser(string messageToUser)//Запрашивает и возвращает строковое значение
        {
            Console.WriteLine(messageToUser);
            return Console.ReadLine();
        }
        static void printStringArray(string[] array)//Выводит в консоль построчно элементы строкового одномерного массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

    }
}
