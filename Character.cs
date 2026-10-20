using System;

namespace GameInheritanceDemo
{
    public class Character
    {
        public string id = string.Empty;
        public string name = string.Empty;
        public int basePower = 0;
        public string address = string.Empty;

        
        public Character()
        {
            Console.WriteLine("----> Konstruktor default Character <----");
        }

        
        public Character(string id, string name, int basePower, string address)
        {
            Console.WriteLine("----> Konstruktor berparameter Character <----");
            this.id = id;
            this.name = name;
            this.basePower = basePower;
            this.address = address;
        }

        
        public int GetBasePower()
        {
            return basePower;
        }

        
        public void DisplayBaseData()
        {
            Console.WriteLine("ID             = " + id);
            Console.WriteLine("NAME           = " + name);
            Console.WriteLine("BASE POWER     = " + basePower);
            Console.WriteLine("ADDRESS        = " + address);
        }
    }
}

