using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class GamePlay
    {
        string playChoice;
        Player player1;
        Player player2;

        public void PlayGame()
        {
            GivePlayersRules();
            string numberOfPlayers =FindHowManyPlayers();
            GetHumanOrComp (numberOfPlayers); 
        }

        public void GivePlayersRules()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock! It's simailar to Rock, Paper, Scissors; but with a twist. Here are the rules: Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock, Spock smashes Scissors, Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock");
            Console.ReadLine();
        }

        public string FindHowManyPlayers()
        {
            Console.WriteLine("Would you like to play the 1 player version or the 2 player version? Please input 1 or 2");
            string numberOfPlayers = Console.ReadLine();
            return numberOfPlayers; 

        }
        public void GetHumanOrComp(string numberOfPlayers)
        {
            if (numberOfPlayers == "1")
            {
                player1 = new Human();
                player2 = new Computer();
            }
        }

       
    }
}
