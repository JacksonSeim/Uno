using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoConsoleApplication
{
    public class ConsoleView
    {
        FormInput sendToController;
        private Player[] _players;
        private Deck _deck;

        public ConsoleView(FormInput stc, Player[] p, Deck d)
        {
            sendToController = stc;
            _players = p;
            _deck = d;
        }

        public void Update()
        {

        }

    }
}
