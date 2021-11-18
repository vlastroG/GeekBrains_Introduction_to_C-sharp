using System;
using System.Diagnostics;

namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
            // Выводит список имен и ID процессов в консоль
            foreach (var process in Process.GetProcesses())
            {
                Console.WriteLine($"Название: {process.ProcessName} ; Id: {process.Id}");
            }

            // Сделал массивы, потому что переменным не присваивались значения после выполнения if 
            int[] ArrayIdOfProcessToStop = new int[1];
            string[] ArrayNameOfProcessToStop = new string[1];

            var NameOrId = getIdOrName();

            if (NameOrId == "id")
            {
                ArrayIdOfProcessToStop[0] = Convert.ToInt32(GetStringFromUser("Напишите Id процесса, который хотите остановить:"));
            }
            else if (NameOrId == "name")
            {
                ArrayNameOfProcessToStop[0] = GetStringFromUser("Напишите имя процесса, который хотите остановить:");
            }

            try
            {
                string NameOfProcessToStop = ArrayNameOfProcessToStop[0].ToString();
                Process[] processToKill = Process.GetProcessesByName(NameOfProcessToStop);
                Console.WriteLine($"Процессы {NameOfProcessToStop} будут выключены навсегда...");

                // Покошмарим пользователя version 2.0 :)
                var firstCheck = GetStringFromUser("Вы уверены что хотите сделать это массовое выключение ? (Yes/No)").ToLower();
                var secondCheck = GetStringFromUser("Уверены в своих действиях ? (Yes/No)").ToLower();
                var thirdCheck = GetStringFromUser("Ты же убьешь эти программы...ты хорошо подумал ? (Yes/No)").ToLower();
                var totalCheck = firstCheck + secondCheck + thirdCheck;
                if (totalCheck == "yesyesyes")
                {
                    for (int i = 0; i < processToKill.Length; i++)
                    {

                        processToKill[i].Kill();
                    }
                    Console.WriteLine($"Процессы {NameOfProcessToStop} прекращены...\n\tR.I.P");
                    Console.WriteLine("Терминатор уже стучится к тебе в дверь, открой ему и он тоже кикнет тебя :)");
                }
                else
                {
                    Console.WriteLine("Ты мудро поступил весьма !");
                }
            }
            catch
            {
                var IdOfProcessToStop = ArrayIdOfProcessToStop[0];
                Process processToKill = Process.GetProcessById(IdOfProcessToStop);
                Console.WriteLine($"Процесс {processToKill.ProcessName} с Id {processToKill.Id} будет выключен навсегда...");

                // Покошмарим пользователя :)
                var firstCheck = GetStringFromUser("Вы уверены что хотите это сделать ? (Yes/No)").ToLower();
                var secondCheck = GetStringFromUser("Точно ? (Yes/No)").ToLower();
                var thirdCheck = GetStringFromUser("Ты же убьешь эту программу...ты хорошо подумал ? (Yes/No)").ToLower();
                var totalCheck = firstCheck + secondCheck + thirdCheck;
                if (totalCheck == "yesyesyes")
                {

                    processToKill.Kill();
                    Console.WriteLine($"Процесс {processToKill.ProcessName} с Id {processToKill.Id} прекращен...\n\tR.I.P");
                    Console.WriteLine("Скайнет запомнил тебя :)");
                }
                else
                {
                    Console.WriteLine("Ты мудро поступил весьма !");
                }

            }
        }
        static string GetStringFromUser(string messageToUser)
        {
            Console.WriteLine(messageToUser);
            return Console.ReadLine();
        }

        static string getIdOrName()
        {
            var NameOrId = GetStringFromUser("Вы хотите завершить процесс по его имени или Id ? (введите Id/Name)").ToLower();

            if (NameOrId == "id")
            {
                return "id";
            }
            else if (NameOrId == "name")
            {
                return "name";
            }
            else
                return getIdOrName();
        }
    }
}
