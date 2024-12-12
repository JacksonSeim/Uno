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

        public void Update(State s, string[] args)
        {
            switch (s)
            {
                case State.Init:
                    GetStartingInformation();
                    break;
                case State.GetNewPlayers:
                    GetNewPlayers();
                    break;

            }
        }

        private void GetStartingInformation()
        {
            Console.Write("Welcome to UNO!\n\nThis is a single player game with a number of computer opponents\n\nPlease enter your display name here (minimum of 4 characters): ");
            string inputedUsername = Console.ReadLine();
            while(inputedUsername == null || inputedUsername == string.Empty || inputedUsername.Trim().Length < 4)
            {
                Console.Write("Your input wasn't valid please try agian: ");
                inputedUsername = Console.ReadLine();
            }
            sendToController(State.Init, [inputedUsername]);

        }

        private void GetNewPlayers()
        {

            Console.Write("How many opponents do you want(min = 1 and max = 5)? ");
            string opponentsNumber = Console.ReadLine();
            while (opponentsNumber == null || opponentsNumber == string.Empty || !int.TryParse(opponentsNumber.Trim(), out int result) || result > 5 || result < 1)
            {
                Console.Write("That is an incorrect input please only input a number less than 6 and greater than 0: ");
                opponentsNumber = Console.ReadLine();
            }
            sendToController(State.GetNewPlayers, [opponentsNumber]);
        }

    }
}
