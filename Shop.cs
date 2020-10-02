
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Shop
    {
        private Item[] _inventory = new Item[5];
        //public Shop(Item[] inventory)
        //{
        //    _inventory = inventory;
        //}
        public void SellItem(Player player)
        {
            PrintItem();
            Console.WriteLine("What would you like to buy");
            char choice = Console.ReadKey().KeyChar;
            switch (choice)
            {
                case '1':
                    
                    if (CheckCost(_inventory[0].GetCost(), player.Gold))
                    {
                        player.Gold -= _inventory[0].GetCost();
                        int index = GetSlot();
                       
                        player.AddItem(_inventory[0], index);
                    }
                    break;
                case '2':

                    if (CheckCost(_inventory[1].GetCost(), player.Gold))
                    {
                        player.Gold -= _inventory[1].GetCost();
                        int index = GetSlot();

                        player.AddItem(_inventory[1], index);

                    }
                    break;
                case '3':

                    if (CheckCost(_inventory[2].GetCost(), player.Gold))
                    {
                        player.Gold -= _inventory[2].GetCost();
                        int index = GetSlot();

                        player.AddItem(_inventory[2], index);
                    }
                    break;
                case '4':

                    if (CheckCost(_inventory[3].GetCost(), player.Gold))
                    {
                        player.Gold -= _inventory[3].GetCost();
                        int index = GetSlot();

                        player.AddItem(_inventory[3], index);
                    }
                    break;
                case '5':

                    if (CheckCost(_inventory[4].GetCost(), player.Gold))
                    {
                        player.Gold -= _inventory[4].GetCost();
                        int index = GetSlot();

                        player.AddItem(_inventory[4], index);
                    }
                    break;
            }
        }
        private void PrintItem()
        {
            int inter = 1;

            foreach(Item item in _inventory)
            {
                Console.WriteLine(inter +"."+item.GetName());
                Console.WriteLine(item.GetCost());
                Console.WriteLine(item.GetDamage());
                inter++;
            }
            Console.ReadKey();
        }
        public void AddItem(Item item, int index)
        {
            _inventory[index] = item;
        }
        private bool CheckCost(int cost, int playerGold)
        {
            Console.WriteLine(cost <= playerGold);
            return cost <= playerGold;
        }
        private int GetSlot()
        {
            Console.WriteLine("What slot do you want to put the item in?");
            char index = Console.ReadKey().KeyChar;
            switch (index)
            {
                case '1':
                    {
                        return 0;
                        break;
                    }
                case '2':
                    {
                        return 1;
                        break;
                    }
                case '3':
                    {
                        return 2;
                        break;
                    }
                case '4':
                    {
                        return 3;
                        break;
                    }
                case '5':
                    {
                        return 4;
                        break;
                    }
            }
            return 0;
        }
        public void SuperUser()
        {
            Console.WriteLine("Do you want to name the item");
            string name = Console.ReadLine();
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
            if (choice == '1')
            {
                AddItem(new Attack_Item(tempDamage, tempCost, name), tempIndex);
            }
            if (choice == '2')
            {
                AddItem(new Defense_Item(tempDamage, tempCost, name), tempIndex);
            }
        }
        public Item[] GetInventory()
        {
            return _inventory;
        }
        public void AddItem(Item item)
        {
            int inter = 0;
            foreach(Item items in _inventory)
            {
                if(items == null)
                {
                    AddItem(item, inter);
                    return;
                }
                inter++;
            }
        }
    }
}


