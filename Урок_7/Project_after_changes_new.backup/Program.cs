// Decompiled with JetBrains decompiler
// Type: Project_before_changes.Program
// Assembly: Project_before_changes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4B6E2558-9A23-48DB-B4D7-8D2FCBED5249
// Assembly location: C:\Users\Public\Geekbrains\Введение_в_C#\Lesson_7\Урок_7\Project_before_changes\bin\Debug\net5.0\Project_before_changes.dll

using System;
using System.Diagnostics;
using System.Text;

namespace Project_before_changes
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      string str1 = "https://www.google.com/search?q=";
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(str1);
      string str2 = Program.GetStringFromUser("Что вы хотите найти в Google?").Replace(' ', '+');
      stringBuilder.Append(str2);
      int num = new Random().Next(0, 3);
      string str3 = "";
      switch (num)
      {
        case 0:
          str3 = "https://www.ptc.com/en/blogs/cad/beginner-guide-generative-design";
          break;
        case 1:
          str3 = "https://primer.dynamobim.org/en/";
          break;
        case 2:
          str3 = "https://thebuildingcoder.typepad.com/";
          break;
      }
            Process process = new Process()
      {
        StartInfo = {
          FileName = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe",
          Arguments = str3
        }
      }.Start();
    }

    private static string GetStringFromUser(string messageToUser)
    {
      Console.WriteLine(messageToUser);
      return Console.ReadLine();
    }
  }
}
