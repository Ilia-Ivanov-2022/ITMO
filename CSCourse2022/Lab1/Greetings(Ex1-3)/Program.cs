using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2022.Greetings
{
    internal class Greeter
    {
        static void Main(string[] args)
        {
            string myName;

            Console.WriteLine("What is your name please?");
            myName = Console.ReadLine();
            Console.WriteLine("Hello {0}", myName);
        }
    }
}
