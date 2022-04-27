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
        ///<summary> Private Field String name.</summary>
        private string name = "(No name)";
        ///<summary> Public Rroperty whith methods (get) and (set). </summary>
        public string Name
        {
            get {return name;}
            set {name = value;}
        }
        ///<summary> Public Method GetHealth().</summary>
        public int GetHealth()
        {
            return health;
        }
    }
}