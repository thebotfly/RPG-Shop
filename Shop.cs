using System;
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
                        player.AddItem(_inventory[0], 0);
                    }
                    break;
                case '2':

                    if (CheckCost(_inventory[1].GetCost(), player.Gold))
                    {
                        player.Gold -= _inventory[1].GetCost();
                        player.AddItem(_inventory[1], 0);
                    }
                    break;
                case '3':

                    if (CheckCost(_inventory[2].GetCost(), player.Gold))
                    {
                        player.Gold -= _inventory[2].GetCost();
                        player.AddItem(_inventory[2], 0);
                    }
                    break;
                case '4':

                    if (CheckCost(_inventory[3].GetCost(), player.Gold))
                    {
                        player.Gold -= _inventory[3].GetCost();
                        player.AddItem(_inventory[3], 0);
                    }
                    break;
                case '5':

                    if (CheckCost(_inventory[4].GetCost(), player.Gold))
                    {
                        player.Gold -= _inventory[4].GetCost();
                        player.AddItem(_inventory[4], 0);
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
    }
}
