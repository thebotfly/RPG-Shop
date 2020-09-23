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
            player = new Player("Hero");
            player.Gold = 50;
            Item botfly = new Item(20, 15, "botfly");
            Item thecactus = new Item(15, 5, "thecactus");
            Item impostor = new Item(30, 10, "impostor");
            Item redbutton = new Item(5, 1, "redbutton");
            Item bottle = new Item(35, 25, "bottle");
            shop = new Shop();

            shop.AddItem(botfly, 0);
            shop.AddItem(thecactus, 1);
            shop.AddItem(impostor, 2);
            shop.AddItem(redbutton, 3);
            shop.AddItem(bottle, 4);
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
