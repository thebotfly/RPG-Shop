using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Enemy
    {
        protected int _health;
        protected int _damage;
        public void takedamage(int damage)
        {
            _health -= damage;
        }
        public Enemy(int health, int damage)
        {
            _health = health;
            _damage = damage;
        }
    }
}
