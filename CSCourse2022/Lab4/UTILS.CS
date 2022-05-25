namespace Utils
{
    using System;

    public class Utils
    {   // Check which value is greater
        public static int Gtreater(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        //Swap two values
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Factorial
        public static bool Factorial(int n, out int answer)
        {
            int counter; // Loop counter
            int factorial = 1;  // Working value
            bool ok = true;

            // Let's check the input value
            if (n < 0)
            {
                ok = false;
            }

            try
            {
                checked
                {
                    for (counter = 2; counter <= n; counter++)
                    {
                        factorial *= counter;
                    }
                }
            }
            catch(Exception)
            {
                factorial = 0;
                ok = false;
            }
            answer = factorial;
            return ok;
            }
    }
    
    

}
