using System;
using System.Diagnostics;
using System.Text;

namespace Project_before_changes
{
    class Program
    {
        static void Main(string[] args)
        {
            var googleSearch = "https://www.google.com/search?q=";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(googleSearch);
            var userSearchInput = GetStringFromUser("Что вы хотите найти в Google?").Replace(' ', '+');
            stringBuilder.Append(userSearchInput);


            Random rnd = new Random();

            var numberOfPage = rnd.Next(0, 3);

            string defaultPage = "";

            switch (numberOfPage)
            {
                case 0:
                    defaultPage = "https://www.ptc.com/en/blogs/cad/beginner-guide-generative-design";
                    break;
                case 1:
                    defaultPage = "https://primer.dynamobim.org/en/";
                    break;
                case 2:
                    defaultPage = "https://thebuildingcoder.typepad.com/";
                    break;

            }

             Process.Start("chrome.exe", stringBuilder.ToString()); //--> Эта строчка должна запускаться после изменения
           // Process.Start("chrome.exe", defaultPage); // --> Эта строчка должна быть удалена после изменения
            // Сборку сделал через msbuild, предварительно написав код в Visual Studio и сохранив его через Ctrl+S
        }
        static string GetStringFromUser(string messageToUser)
        {
            Console.WriteLine(messageToUser);
            return Console.ReadLine();
        }
    }
}
