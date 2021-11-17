using System;
using System.IO;

namespace Project_4
{
    class Program
    {
        static void Main(string[] args)
        {

            var DirectoryName = @GetStringFromUser("Введите путь каталога, из которого хотите извлечь дерево каталогов и файлов:");
            var FileNameToWriteCatalogTree = GetStringFromUser("Введите название файла, в который хотите сохранить дерево каталогов:");

            Console.WriteLine("Directory exist:" + Directory.Exists(DirectoryName));

            string[] entries = Directory.GetFileSystemEntries(DirectoryName, "*", SearchOption.AllDirectories);

            File.WriteAllLines(FileNameToWriteCatalogTree, entries);

        }
        static string GetStringFromUser(string messageToUser)//Запрашивает и возвращает строковое значение
        {
            Console.WriteLine(messageToUser);
            return Console.ReadLine();
        }
    }
}
