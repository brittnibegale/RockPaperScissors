using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Human: Player
    {
        string userInput;
        public Human()
        {
           this.name =  SetPlayersName();
        }


        public override int GetPlayersChoice()
        {
            Console.WriteLine(name + " , What is your your move? Please choose one number. ");
            allPlayersChoices.ForEach(Console.WriteLine);
            userInput = Console.ReadLine();
            while (!int.TryParse(userInput, out playersChoice) || playersChoice < 0 || playersChoice > 5)
            {
                Console.WriteLine("Invaild input. Please, enter a number 1 - 5 ");
                allPlayersChoices.ForEach(Console.WriteLine);
                userInput = Console.ReadLine();
            }

            return playersChoice;
        }

        public override string SetPlayersName()
        {
            Console.WriteLine("Player, What is your name?");
            string name = Console.ReadLine();
            return name;
        }

      
    }
}
