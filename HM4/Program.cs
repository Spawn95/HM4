using System;
using System.Globalization;
using System.IO;

namespace Task1
{
    class Program
    {
        public static DateTime DateTime { get;}

        static void Main(string[] args)
        {
            Console.WriteLine("Запишите текст в файл ");
            string text = Console.ReadLine();
            File.WriteAllText("startup.txt", text + "  ");           
           
            File.AppendAllText(@"startup.txt", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss") + "\n");

        }
    }
}