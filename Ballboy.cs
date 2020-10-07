using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Ballboy:Enemy
    {
        public Ballboy(int health, int damage):base(health, damage)
        {

        }
        public void Printstat()
        {
            Console.WriteLine("Ballboy");
            Console.WriteLine(_health);
            Console.WriteLine(_damage);
        }
        public int Gethealth()
        {
            return _health;
        }
        public int Getdamage()
        {
            return _damage;
        }
    }
}
