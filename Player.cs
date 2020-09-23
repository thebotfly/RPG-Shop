using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player
    {
       public int Gold { set; get; }
        private string _playerName;
        Item[] _inventory= new Item[5];
        public Player(string playerName)
        {
            _playerName = playerName;
        }
        public void AddItem(Item item, int index)
        {
            _inventory[index] = item;
        }
    }
}
