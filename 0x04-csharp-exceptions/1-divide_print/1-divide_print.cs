using System;

class Int
{
    public static void divide(int a, int b)
    {
        int c = 0;

        try
        {
            c = a / b;
        }
        catch (System.DivideByZeroException)
        {
            c = 0;
            Console.WriteLine("DivideByZeroException");
        }
        finally
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, c);
        }
    }
}