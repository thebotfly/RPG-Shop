
﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HelloWorld
{
    class Game
    {
        private bool _run = true;
        private bool incombat = false;
        Player player;
        Shop shop; 

        //Run the game
        public void Run()
        {
            
            Start();
            while (_run)
            {
                Update();
                if(incombat)
                Combat();
            }
            End();
        }

        //Performed once when the game begins
        public void Start()
        {
            player = new Player("Hero", 150);
            player.Gold = 50;
            Attack_Item botfly = new Attack_Item(20, 15, "botfly");
            Attack_Item thecactus = new Attack_Item(15, 10, "thecactus");
            Defense_Item crabshell = new Defense_Item(20, 20, "crabshell");
            Defense_Item electricpulse = new Defense_Item(25, 20, "electricpulse");
            Attack_Item bottle = new Attack_Item(35, 25, "bottle");
            shop = new Shop();

            shop.AddItem(botfly, 0);
            shop.AddItem(thecactus, 1);
            shop.AddItem(crabshell, 2);
            shop.AddItem(electricpulse, 3);
            shop.AddItem(bottle, 4);
        }

        //Repeated until the game ends
        public void Update()
        {
            Console.WriteLine("Would you like to look at your inventory or look at the shop or do you want to save or load or to start combat?");
            
            char choice = Console.ReadKey().KeyChar;
            Console.Clear();
            if (choice == '1')
            {
                player.PrintItem();
            }
            if (choice == '2')
            {
                shop.SellItem(player);
            }
            if (choice == '3')
            {
                Save(player.GetName());
            }
            if (choice == '4')
            {
                Load();
            }
            if (choice == '5')
            {
                incombat = true;
            }
            if (choice == 'g')
            {
                Console.WriteLine("Do you want to change the player's or the shop's inventory?");
                choice = Console.ReadKey().KeyChar;
                Console.Clear();
                if (choice == '1')
                {
                    player.SuperUser();
                }
                if (choice == '2')
                {
                    shop.SuperUser();
                }
            }

        }
        public void Combat()
        {
            Ballboy ballboy = new Ballboy(150, 30);
            while(ballboy.Gethealth()>0 && player.Gethealth() > 0)
            {
                ballboy.Printstat();
                player.PrintStat();
                Console.WriteLine(player.GetName() + " dealt " + player.Getdamage());
                Console.WriteLine("ballboy dealt " + ballboy.Getdamage());
                player.Takedamage(ballboy.Getdamage());
                ballboy.takedamage(player.Getdamage());
            }
            _run = false;
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
        public void Save(string _playerName)
        {
            StreamWriter writer = File.CreateText("playerinventory.txt");
            
            StreamWriter writer2 = File.CreateText("Shopinventory.txt");
           
            writer.WriteLine(player.GetName());
            writer.WriteLine(player.Gold);
            Item[] ShopInventory = shop.GetInventory();
            foreach(Item item in ShopInventory)
            {
                writer2.WriteLine(item.GetName());
                writer2.WriteLine(item.GetDamage());
                writer2.WriteLine(item.GetCost());
                if(item is Attack_Item)
                {
                    writer2.WriteLine("AttackItem");
                }
                if(item is Defense_Item)
                {
                    writer2.WriteLine("DefenseItem");
                }
            }
            writer.Close();
            writer2.Close();
        }
        public void Load()
        {
            if (File.Exists("playerinventory.txt"))
            {
                StreamReader reader = File.OpenText("playerinventory.txt");
                player.SetName(reader.ReadLine());
                player.Gold = Convert.ToInt32(reader.ReadLine());
                reader.Close();
            }
            if (File.Exists("Shopinventory.txt"))
            {
                StreamReader reader = File.OpenText("Shopinventory.txt");
               
                string temp;
                string itemName;
                int itemDamage;
                int itemCost;
                while (true)
                {
                    
                    temp = reader.ReadLine();
                    if(temp == " ")
                    {
                        reader.Close();

                        return;
                    }

                    itemName = reader.ReadLine();
                    Int32.TryParse(reader.ReadLine(), out itemDamage);
                    Int32.TryParse(reader .ReadLine(), out itemCost);
                    if (reader.ReadLine()== "AttackItem")
                    {
                        shop.AddItem(new Attack_Item(itemDamage, itemCost, itemName));
                    }
                    else
                    {
                        shop.AddItem(new Defense_Item(itemDamage, itemCost, itemName));
                    }
                }
            }
        }
    }
}

﻿




   
        
            
        
    


