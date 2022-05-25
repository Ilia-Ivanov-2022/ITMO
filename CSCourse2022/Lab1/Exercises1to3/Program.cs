using System;


namespace ITMO.CSCourse2022.Lab1.Exercise1
{
    internal class Greeter
    {
        static void Main(string[] args)
        {
            string myName;

            Console.WriteLine("Please enter your name:");
            myName = Console.ReadLine();
            Console.WriteLine("Hello {0}", myName);
        }
    }
}
