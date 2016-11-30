using System;
using System.Collections;
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
    public class PlayerList<Player> : IEnumerable<Player>
    {
        private List<Player> players;

        public PlayerList()
        {
            players = new List<Player>();
        }

        public int Count
        {
            get
            {
                return players.Count;
            }
        }

        public Player this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                else if (i >= players.Count)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }

                return players[i];
            }
            set
            {
                players[i] = value;
            }
        }

        public void Add(Player player)
        {
            players.Add(player);
        }

        public IEnumerator<Player> GetEnumerator()
        {
            foreach (Player item in players)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
