using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Computer : Player
    {
        
        public Computer()
        {
            this.name = SetPlayersName();
        }

        public override int GetPlayersChoice()
        {
            Random choice = new Random();
            playersChoice = choice.Next(1, 6);
            return playersChoice;
        }

        public override string SetPlayersName()
        {
            string name = "Computer";
            return name;
        }

    }
}
