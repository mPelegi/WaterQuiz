using System;
using System.IO;

namespace WaterQuiz.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            Console.WriteLine(projectDirectory);
            Console.ReadKey();
        }
    }
}
