
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Item
    {
        protected int _damage;
        protected int _cost;
        protected string _name;

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
        public void SetDamage(int damage)
        {
            _damage = damage;
        }
        public int GetCost()
        {
            return _cost;
        }
        public void SetCost(int cost)
        {
            _cost = cost;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }
    }
    
}

