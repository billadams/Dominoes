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
    class Domino
    {
        private string[] mAllDominoes = { "0-0", "1-0", "2-0", "3-0", "4-0", "5-0", "6-0",
                                          "1-1", "2-1", "3-1", "4-1", "5-1", "6-1",
                                          "2-2", "3-2", "4-2", "5-2", "6-2",
                                          "3-3", "4-3", "5-3", "6-3",
                                          "4-4", "5-4", "6-4",
                                          "5-5", "6-5",
                                          "6-6" };

        private string mTopNumber;
        private string mBottomNumber;
        private int mTotal;

        public Domino()
        {
            ShuffleDominoes();
        }

        public string[] AllDominoes
        {
            get { return mAllDominoes; }
        }

        public string TopNumber
        {
            get { return mTopNumber; }
            set { mTopNumber = value; }
        }

        public string BottomNumber
        {
            get { return mBottomNumber; }
            set { mBottomNumber = value; }
        }

        public int Total
        {
            get
            {
                int topTotal = Convert.ToInt32(TopNumber);
                int bottomTotal = Convert.ToInt32(BottomNumber);
                this.mTotal = topTotal + bottomTotal;

                return mTotal;
            }
        }

        public string[] ShuffleDominoes()
        {
            Random rnd = new Random();
            double[] order = new double[28];

            string[] allDominoes = this.AllDominoes;

            for (int i = 0; i < order.Length; i++)
                order[i] = rnd.NextDouble();

            Array.Sort(order, allDominoes);

            return allDominoes;
        }


    }
}
