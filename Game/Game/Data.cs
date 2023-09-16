﻿using Game.InterfaceAndAbstractClass;
using Game.Entity.Weapons;
using Game.Entity.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Data
    {
        public static List<IWeapon> weapons = new List<IWeapon>
        {
            new Axe(),
            new Bow(),
            new Knife(),
            new Sword(),
        };
        
        public List<Character> characters = new List<Character> 
        {
            new Dwarf(weapons[0], "Dwarf", 100, 40),
            new Orc(weapons[2], "Orc", 50, 20),
            new Wizzard(weapons[3], "Wizzard", 30, 10),
        };
    }
}
