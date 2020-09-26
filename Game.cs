
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        private bool _run = true;
        Player player;
        Shop shop; 

        //Run the game
        public void Run()
        {
            Start();
            while (_run)
            {
                Update();
            }
            End();
        }

        //Performed once when the game begins
        public void Start()
        {
            player = new Player("botfly");
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
            Console.WriteLine("Would you like to look at your inventory or look at the shop?");
            
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

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}

﻿




   
        
            
        
    


