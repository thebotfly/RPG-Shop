using System;
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
            Item botfly = new Item(20, 15, "botfly");
            shop = new Shop();

            shop.AddItem(botfly, 0);
            shop.AddItem(botfly, 1);
            shop.AddItem(botfly, 2);
            shop.AddItem(botfly, 3);
            shop.AddItem(botfly, 4);
        }

        //Repeated until the game ends
        public void Update()
        {
            shop.SellItem(player); 
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
