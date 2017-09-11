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
            GetPlayersName();
        }


        public override int GetPlayersChoice(List<string> allPlayerChoice)
        {

            return playersChoice;
        }

        public override string GetPlayersName()
        {
            Console.WriteLine("Player, What is your name?");
            string name = Console.ReadLine();
            return name;
        }
    }
}
