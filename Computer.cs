using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Computer : Player
    {
        int randomChoice;
        public Computer()
        {
            GetPlayersName();
        }

        public override int GetPlayersChoice(List<string> allPlayerChoice)
        {

            return randomChoice;
        }

        public override string GetPlayersName()
        {
            string name = "Computer";
            return name;
        }

    }
}
