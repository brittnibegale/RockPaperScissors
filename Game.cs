using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Game
    {
        Player player1;
        Player player2;

        public void PlayGame()
        {
            GivePlayersRules();
            string numberOfPlayers = FindHowManyPlayers();
            GetHumanOrComp (numberOfPlayers);
            ComparePlayersChoice();
            CheckForWinner();
        }

        public void GivePlayersRules()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock! It's simailar to Rock, Paper, Scissors; but with a twist. Here are the rules: \n Scissors cuts Paper \n Paper covers Rock \n Rock crushes Lizard \n Lizard poisons Spock \n Spock smashes Scissors \n Scissors decapitates Lizard \n Lizard eats Paper \n Paper disproves Spock \n Spock vaporizes Rock \n Let's find out who the winner of best 2 out of 3 games will be! \n Hit ENTER to continue.");
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
                player1.GetPlayersChoice();
                player2.GetPlayersChoice();
            }
            else if (numberOfPlayers == "2")
            {
                player1 = new Human();
                player2 = new Human();
                player1.GetPlayersChoice();
                player2.GetPlayersChoice();

            }
            else
            {
                Console.WriteLine("Sorry, we did not recognize the number of players playing. Let's try going back to entering how many people are playing. Please, hit the ENTER key.");
                FindHowManyPlayers();
            }
        }
            
            public void ComparePlayersChoice()
        {
            if (player1.playersChoice == player2.playersChoice)
            {
                player1.winCount += 0; 
            }
            else if (player1.playersChoice == 5 && (player2.playersChoice == 2 || player2.playersChoice == 3))
            {
                player1.winCount += 1;
            }
            else if (player1.playersChoice == 4 && (player2.playersChoice == 1 || player2.playersChoice == 5))
            {
                player1.winCount += 1;
            }
            else if (player1.playersChoice == 3 && (player2.playersChoice == 1 || player2.playersChoice == 4))
            {
                player1.winCount += 1;
            }
            else if (player1.playersChoice == 2 && (player2.playersChoice == 3 || player2.playersChoice == 4))
            {
                player1.winCount += 1;
            }
            else if (player1.playersChoice == 1 && (player2.playersChoice == 2 || player2.playersChoice == 5))
            {
                player1.winCount += 1;
            }
            else
            {
                player2.winCount += 1;
            }
        
        }

        public void CheckForWinner()
        {
            if(player1.winCount == 2)
            {
                Console.WriteLine(player1.name + " wins! Would you like to play again? yes or no");
                string yesOrNo = Console.ReadLine().ToLower();
                PlayAgain(yesOrNo);


            }
            else if (player2.winCount == 2)
            {
                Console.WriteLine(player2.name + " wins! Would you like to play again? yes or no");
                string yesOrNo = Console.ReadLine().ToLower();
                PlayAgain(yesOrNo);
            }
            else
            {
                Console.WriteLine("The current score is: " + player1.name + " has won: " + player1.winCount + " game(s) and " + player2.name + " has won: " + player2.winCount + " game(s). Hit ENTER to play the next game.");
                Console.ReadLine();
                PlayNextGame();
            }
        }

        public void PlayNextGame()
        {
            player1.GetPlayersChoice();
            player2.GetPlayersChoice();
            ComparePlayersChoice();
            CheckForWinner();
        }

        public void PlayAgain(string yesOrNo)
        {
            while (yesOrNo != "yes" || yesOrNo != "no")
                Console.WriteLine("Invalid answer. Would you like to play again? yes or no");

            if (yesOrNo == "yes")
            {
                PlayGame();
            }
            else
            {
                Console.WriteLine("I hope you enjoied playing this game!");
            }
        }

       
    }
}
