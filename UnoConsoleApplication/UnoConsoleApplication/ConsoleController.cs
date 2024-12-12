using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnoConsoleApplication
{
    public class ConsoleController
    {
        UpdateForm sendToView;
        public Player[] _players;
        public Deck _deck;

        public ConsoleController()
        {
            _players = GetAmountOfPlayers();
            _deck = GetNewShuffledDeck();
        }

        public void SetUpViewDelegates(UpdateForm stv)
        {
            sendToView = stv;
        }

        public void NewFormInput()
        {

        }

        public Player[] GetAmountOfPlayers()
        {

        }

        public Deck GetNewShuffledDeck()
        {

        }
    }
}
