using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string bP = "None";

        foreach (KeyValuePair<string, int> item in myList.OrderBy(key => key.Value))
        {
            bP = item.Key;
        }
        return(bP);
    }
}