using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Player
    {
        public string name;
        public int playersChoice;
        public List<string> allPlayersChoices = new List<string>();
        public int winCount;

        public Player()
        {
            AddAllChoicesToList();
        }
        public void AddAllChoicesToList()
        {
            allPlayersChoices.Add("1. Paper");
            allPlayersChoices.Add("2.Rock");
            allPlayersChoices.Add("3.Scissors");
            allPlayersChoices.Add("4.Lizard");
            allPlayersChoices.Add("5.Spock");

        }
        public virtual int GetPlayersChoice()
        {
            int playersChoice = 1993;
            return playersChoice;
        }

        public virtual string SetPlayersName()
        {
            string name = "Name";
            return name;
        }

    }
    
}
