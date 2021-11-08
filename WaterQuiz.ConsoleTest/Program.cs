using System;
using System.IO;
using WaterQuiz.Utils;

namespace WaterQuiz.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCaminhoDatabase();

            Console.ReadKey();
        }

        static void GetCaminhoDatabase()
        {
            string dbPath = new DatabaseUtil().GetDatabasePath();
            Console.WriteLine(dbPath);
        }
    }
}
