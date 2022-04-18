using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string bP = "";
        int bS = 0;
        foreach (KeyValuePair<string, int> player in myList)
        {
            if (player.Value > bS)
            {
                bP = player.Key;
                bS = player.Value;
            }
        }
        return bP;
    }
}