
using System;

class MatrixMultiply
{
    static void Input(int[,] dst)
    {
        for(int r = 0; r < dst.GetLength(0); r++)
        {
            for(int c = 0; c < dst.GetLength(1); c++)
            {
                Console.WriteLine("Enter values for [{0}, {1}]", r, c);
                string s = Console.ReadLine();
                dst[r, c] = int.Parse(s);
            }
        }
    }
    static int[,] Multiply(int[,] a, int[,] b)
    {
        int[,] result = new int[2, 2];
        for (int r = 0; r < a.GetLength(0); r++)
        {
            for (int c = 0; c < a.GetLength(1); c++)
            {
                result[r, c] = a[r, 0] * b[0, c] + a[r, 1] * b[1, c];
            }
        }

        return result;
    }
    static void Output(int[,] myResult)
    {
        for (int r = 0; r < myResult.GetLength(0); r++)
        {
            for (int c = 0; c < myResult.GetLength(1); c++)
            {
                Console.Write("{0}", myResult[r, c]);
            }
            Console.WriteLine();
        }
    }

    
    static void Main()
    {
        int[,] a = new int[2, 2];

        int[,] b = new int[2,2];
        
        Input(a);
        Input(b);

        int[,] result = Multiply(a, b);

        Output(result);
    }
}
    
