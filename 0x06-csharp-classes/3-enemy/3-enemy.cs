using System;

namespace Enemies
{
    ///<summary>public class Zombie.</summary>
    public class Zombie
    {
        ///<summary> Public Field.</summary>
        public int health;
        ///<summary> Public Constructor.</summary>
        public Zombie()
        {
            health = 0;
        }
        ///<summary> Public Constructor.</summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
         }
         ///<summary> Public Method GetHealth().</summary>
         public int GetHealth()
         {
            return health;
         }
    }
}