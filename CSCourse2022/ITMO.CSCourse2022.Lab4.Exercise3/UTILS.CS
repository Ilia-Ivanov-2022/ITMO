namespace Utils
{
    using System;

    public class Utils
    {
        public static int Greater(int a, int b)
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

        public static void Swap(ref int a, ref int b)
        {
            int temp = a; a = b; b = temp;
        }

        // Calculate result and return factorial as an out parameter
        public static bool Factorial(int n, out int answer)
        {
            int k;  // Loop counter
            int f = 1;  // Working value
            bool ok = true; //True if ok, otherwisse false

            // ckeck input value
            if(n < 0) ok = false;

            // Calculate the factorial value as the
            // product of all of the numbers from 2 to n
            try
            {
                checked
                {
                    for (k = 2; k <= n; k++)
                    {
                        f *= k;
                    }
                }
                
            }
            catch(Exception)
            {
                // If something goes wrong in the calculation,
                // catch it here. All exceptions
                // are handled the same way: set the result
                // to zero and return false.

                f = 0;
                ok = false;
            }
            // Assign result value
            answer = f;

            //Return to caller
            return ok;
        }
    }
}
