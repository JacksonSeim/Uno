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
        private Player _userPlayer;

        public ConsoleController()
        {
            _deck = GetNewShuffledDeck();
        }

        public void Start()
        {
            GetStartingInformation();
            GetAmountOfPlayers();
        }

        public void SetUpViewDelegates(UpdateForm stv)
        {
            sendToView = stv;
        }

        public void NewFormInput(State s, string[] args)
        {
            switch (s)
            {
                case State.Init:
                    if (args != null && args.Length > 0)
                    {
                        _userPlayer = new HumanPlayer(args[0]);//args in form ["username"]
                    }
                    else
                    {
                        throw new ArgumentNullException("args was null in ConsoleController.NewFormInput > case State.Init");
                    }
                    break;
                case State.GetNewPlayers:
                    if (args != null && args.Length > 0)
                    {
                        if (int.TryParse(args[0], out int numberOfComputerPlayers))//args in form ["number of computer players(int as string)"]
                        {
                            _players = new Player[(numberOfComputerPlayers + 1)];
                        }
                        else
                        {
                            throw new ArgumentException("args[0] the number of computer players could not be parsed in ConsoleController.NewFormInput > case State.GetNewPlayers");
                        }
                    }
                    else
                    {
                        throw new ArgumentNullException("args was null in ConsoleController.NewFormInput > case State.GetNewPlayers");
                    }
                    break;
            }
        }

        public void GetAmountOfPlayers()
        {
            sendToView(State.GetNewPlayers, null);
        }

        public void GetStartingInformation()
        {
            sendToView(State.Init, null);
        }

        public Deck GetNewShuffledDeck()
        {
            return null;//to be changed
        }
    }
}
