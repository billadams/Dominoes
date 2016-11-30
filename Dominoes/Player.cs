using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concentration
{
    /*****************************************************************
    * Name: Bill Adams
    * Project: Program 2
    * Date: 11/17/2016
    * Description: Dominoes memory game.
    * **************************************************************/
    public class Player
    {
        public string PlayerName { get; set; }

        public int PlayerScore { get; set; }

        public Player() {}

        public Player(string playerName)
        {
            this.PlayerName = playerName;
            this.PlayerScore = 0;
        }

    }
}
