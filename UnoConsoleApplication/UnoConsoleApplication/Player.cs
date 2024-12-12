using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoConsoleApplication
{
    public class Player
    {
        public string Username;
        public List<Card> Hand;

        public Player(string u)
        {
            Username = u;
            Hand = new List<Card>();
        }
    }
}
