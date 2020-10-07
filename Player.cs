
﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        private int _health;
        
        public int Gold { set; get; }
        private string _playerName;
        Item[] _inventory = new Item[5];
        public Player()
        {
            _playerName = "Hero";
            _health = 150;
            _inventory[0] = new Attack_Item(20, 10, "sword");
            
        }
        public Player(string playerName, int health)
        {
            _playerName = playerName;
            _health = health;
            _inventory[0] = new Attack_Item(20, 10, "sword");
        }
        public void AddItem(Item item, int index)
        {
            _inventory[index] = item;
        }
        public void PrintItem()
        {
            int inter = 1;

            foreach (Item item in _inventory)
            {
                if (item == null)
                {
                    Console.WriteLine(inter + ".no item");
                    Console.WriteLine(".no cost");
                    Console.WriteLine(".no damage");
                    inter++;
                    continue;
                }
                Console.WriteLine(inter + "." + item.GetName());
                Console.WriteLine(item.GetCost());
                Console.WriteLine(item.GetDamage());
                inter++;
            }
            Console.ReadKey();
        }
        public void SuperUser()
        {
            Console.WriteLine("Do you want to name the item");
           string name= Console.ReadLine();
            Console.WriteLine("What do you want to set the damage to?");
            string damage = Console.ReadLine();
            Console.WriteLine("What would you like the cost to");
            string cost = Console.ReadLine();
            Console.WriteLine("What slot do you want to put it in?");
            string index = Console.ReadLine();
            Int32.TryParse(damage, out int tempDamage);
            Int32.TryParse(cost, out int tempCost);
            Int32.TryParse(index, out int tempIndex);
            Console.WriteLine("Do you want the item to be a Attack or Defense Item?");
            char choice = Console.ReadKey().KeyChar;
            if(choice == '1')
            {
                AddItem(new Attack_Item(tempDamage, tempCost, name), tempIndex);
            }
            if(choice == '2')
            {
                AddItem(new Defense_Item(tempDamage, tempCost, name), tempIndex);
            }
        }
        public string GetName()
        {
            return _playerName;
        }
        public void  SetName(string Name)
        {
            _playerName = Name;
        }
        public int Gethealth()
        {
            return _health;
        }
        public void PrintStat()
        {
            Console.WriteLine(_playerName);
            Console.WriteLine(_inventory[0].GetDamage());
            Console.WriteLine(_health);


        }
        public void Takedamage(int damage)
        {
            _health -= damage;
        }
        public int Getdamage()
        {
            return _inventory[0].GetDamage();
        }
    }
}

