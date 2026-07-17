using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonEngine.Characters
{
    public class character
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }
    }
}
