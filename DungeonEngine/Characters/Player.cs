using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonEngine.Characters
{
    public class Player : Character
    {
        public int Gold { get; set; }
        public int Experience { get; set; }


        public Player(string name)
        {
            Name = name;
            Level = 1;
            Health = 100;
            MaxHealth = 100;
            AttackPower = 10;
            Defense = 6;
            Gold = 0;
            Experience = 0;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Player name is {Name}, your level is {Level}, Health : {Health}, you Have {Gold} Gold");
        }
    }
    
}
