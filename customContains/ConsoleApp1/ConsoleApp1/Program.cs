using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Bu bir custom contains methodudur";

            bool name1 = name.customContains("bu bir custom");
            Console.WriteLine(name1);
        }
    }
}
