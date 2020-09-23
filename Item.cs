
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Item
    {
        private int _damage;
        private int _cost;
        private string _name;

        public Item(int damage, int cost, string name)
        {
            _damage = damage;
            _cost = cost;
            _name = name;
        }
        public int GetDamage()
        {
            return _damage;
        }
        public int GetCost()
        {
            return _cost;
        }
        public string GetName()
        {
            return _name;
        }
    }
    
}

