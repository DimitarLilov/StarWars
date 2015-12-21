﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWars.GameObject;

namespace StarWars.Items.ArmorSet
{
    public class Chest: Armor
    {
        private const int ChestArmorRestore = 10;
        public Chest(Position position, char symbol) : base(position, symbol, ChestArmorRestore)
        {
        }
    }
}