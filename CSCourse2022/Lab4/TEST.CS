namespace Utils
{
    using System;

    /// <summary>
    ///   This is the test harness
    /// </summary>

    public class Test
    {
        public static void Main()
        {
            Console.WriteLine("Exercise No. 1. Greater number.\n");

            int x, y;
            Console.Write("Please enter first number: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Please enter second number: ");
            y = int.Parse(Console.ReadLine());

            // Check which value is greater
            int greater;
            greater = Utils.Gtreater(x, y);
            Console.WriteLine("The greater value is {0}", greater);

            // Swap two value
            Console.WriteLine("\nExercise No. 2. Swap.\n");

            Console.WriteLine("Before Swap x = {0}, wy = {1}", x, y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("After Swap x = {0}, wy = {1}", x, y);


            // Factorial
            Console.WriteLine("\nExercise No.3. Factorial.\n");

            bool ok;
            int factorial;
            Console.Write("Please enter a number for factorial calculation: ");
            int num = int.Parse(Console.ReadLine());

            ok = Utils.Factorial(num, out factorial);

            if (ok)
            {
                Console.WriteLine("Factorial of {0} is {1}", num, factorial);
            }
            else
            {
                Console.WriteLine("Cannot process this factorial.");
            }
        }
    }
}
