using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoConsoleApplication
{
    public class Card
    {
        public Color _color;
        public bool inDeck;

        public Card(Color c, bool indeck)
        {
            _color = c;
            inDeck = indeck;
        }
    }
}
