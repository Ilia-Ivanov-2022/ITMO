using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreTestNo_13_IliaIvanov_124_16
{ // Algorithm # 13 - Searching by halving in sorted array
    internal class Program
    {
        // The code for algorithm #13:
        static bool searchValue(int[] array, int keyValue)
        {
            int firstValue = array[0];
            int lastValue = array[array.Length - 1];

            while (firstValue <= lastValue)
            {
                if ((firstValue + lastValue) / 2 == keyValue)
                {
                    return true;
                }
                else if (keyValue < (firstValue + lastValue) / 2)
                {
                    lastValue = (firstValue + lastValue) / 2 - 1;
                }
                else
                {
                    firstValue = (firstValue + lastValue) / 2 + 1;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            int[] arraySorted = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            
            Console.WriteLine("Enter required value between " + arraySorted[0] + " and " + arraySorted[arraySorted.Length - 1]);
            int requiredValue = Convert.ToInt32(Console.ReadLine());

            bool result = searchValue(arraySorted, requiredValue);

            Console.WriteLine(result);
        }
    }
}
