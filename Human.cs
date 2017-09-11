using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Human: Player
    {
        public Human()
        {
           this.name =  SetPlayersName();
        }


        public override int GetPlayersChoice()
        {
            Console.WriteLine(name + " , What is your your move? Please choose one number. ");
            allPlayersChoices.ForEach(Console.WriteLine);
            while (!int.TryParse(Console.ReadLine(), out playersChoice))
                Console.WriteLine("Please, enter a number 1 - 5 " + allPlayersChoices);
            
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
