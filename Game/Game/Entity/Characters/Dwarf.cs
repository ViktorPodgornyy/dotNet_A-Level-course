﻿using Game.InterfaceAndAbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entity.Characters
{
    internal class Troll : Character
    {
        public IWeapon weapon;

        public string Name;
        public int Health;
        public int AttackAmount;

        public Troll(IWeapon weapon, string name, int health, int attack) : base(name, health, attack, weapon)
        {
            Name = name;
            Health = health;
            AttackAmount = attack;
            this.weapon = weapon;

        }

        public override void Fight(Character enemy)
        {
            Console.WriteLine($"{this.Name} attack {enemy.Name}");
        }
    }
}
