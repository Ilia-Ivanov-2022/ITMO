using System;

namespace ITMO.CSCourse2022.Lab1.Exercise4
{
    internal class DivideIt
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("For this exercise wee need two integers.\nPlease enter the first integer:");
                string temp = Console.ReadLine();
                int i = Int32.Parse(temp);

                Console.WriteLine("Please enter the second integer:");
                temp = Console.ReadLine();
                int j = Int32.Parse(temp);

                int k = i / j;

                Console.WriteLine("The result of division is {0}", k);
            }
            catch(Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e);
            }
        }      
    }
}
