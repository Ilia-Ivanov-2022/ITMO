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
            int x, y;
            Console.Write("Please enter first integer: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Please enter second integer: ");
            y = int.Parse(Console.ReadLine());

            int greater;

            greater = Utils.Gtreater(x, y);

            Console.WriteLine("The greater value is {0}", greater);
        }
    }
}
