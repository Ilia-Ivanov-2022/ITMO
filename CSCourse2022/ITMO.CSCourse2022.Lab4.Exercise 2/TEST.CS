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
            int x;
            int y;
            int greater;

            Console.Write("Enter integers x: ");
            x = Int32.Parse(Console.ReadLine());

            Console.Write("Enter integers y: ");
            y = Int32.Parse(Console.ReadLine());

            // greater = Utils.Greater(x, y);
            // Console.WriteLine("The greater value is {0}", greater);

            Console.WriteLine("Before the swap x = {0}, y = {1}", x, y);

            Utils.Swap(ref x, ref y);

            Console.WriteLine("After the swap x = {0}, y = {1}", x, y);
        }
    }
}
