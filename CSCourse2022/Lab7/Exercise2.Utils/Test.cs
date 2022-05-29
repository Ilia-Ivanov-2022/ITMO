using System;


public class Test
{
    public static void Main()
    {
        Console.WriteLine("Enter any string to reverse: ");
        string anyString = Console.ReadLine();
        Utils.Utils.Reverse(ref anyString);

        Console.WriteLine(anyString);
    }
}
