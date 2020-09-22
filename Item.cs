using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Item
    {
        private int _damage;
        public Item(int damage)
        {
            _damage = damage;
        }
        public int GetDamage()
        {
            return _damage;
        }
    }
}
