using System;

///<summary>Class that represents an object</summary>
class Obj
{
    /// <summary>Checks if an obj is an instance of array</summary>
    public static bool IsInstanceOfArray(object obj)
    {

        if (obj is Array || obj.GetType() == typeof(Array))
            return (true);

        else
            return (false);
    }
}