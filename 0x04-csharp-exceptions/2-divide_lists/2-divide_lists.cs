using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> pp = new List<int>();

        for (int i = 0; i < listLength; i++)
        {
            try
            {
                pp.Add(list1[i] / list2[i]);
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                pp.Add(0);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
        return pp;
    }
}
     