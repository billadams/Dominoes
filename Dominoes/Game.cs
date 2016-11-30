using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Concentration
{
    /*****************************************************************
    * Name: Bill Adams
    * Project: Program 2
    * Date: 11/17/2016
    * Description: Dominoes memory game.
    * **************************************************************/
    class Game
    {
        //private List<Player> players;
        private PlayerList<Player> players = new PlayerList<Player>();
        private Panel gameBoard;
        private Domino domino;

        // Player objects.
        private int totalPlayers;
        private Player currentPlayer;
        private string playerName;
        private int playerIndex;

        // Keeps track of dominoes flipped and their values.
        // Also stores them temporarily.
        private int numFlippedDominoes;
        private int flippedDominoValues;
        private Button[] clickedButtons = new Button[2];
        private int gameCounter = 0;

        // Initialize the array to hold the domino buttons.
        private Button[,] dominoButtons = new Button[4, 7];

        public delegate void PlayerChange(string playerName);
        public event PlayerChange Changed;

        public delegate void PlayerScored(int playerIndex);
        public event PlayerScored OnPlayerScored;
        

        public Game()
        {

        }

        public Game(Panel gameBoard, PlayerList<Player> players)
        {
            this.gameBoard = gameBoard;
            this.numFlippedDominoes = 0;
            this.flippedDominoValues = 0;
            this.playerIndex = 0;
            this.Players = players;
            this.totalPlayers = players.Count - 1;
            this.currentPlayer = players[0];
            this.playerName = currentPlayer.PlayerName;
        }

        public PlayerList<Player> Players
        {
            get
            {
                return players;
            }
            set
            {
                players = value;
            }
        }

        public int TotalPlayers
        {
            get
            {
                return totalPlayers;
            }
            set
            {
                this.totalPlayers = players.Count;
            }
        }

        public void BuildBoard()
        {
            domino = new Domino();
            domino.ShuffleDominoes();

            int startTop = 3;
            int startLeft = 3;
            int counter = 0; // Index pointer for going through all dominoes.

            for (int row = 0; row <= dominoButtons.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= dominoButtons.GetUpperBound(1); col++)
                {
                    // Go through all 28 dominoes and get its value
                    // from each domino object.
                    string[] columns = domino.AllDominoes[counter].Split('-');
                    domino.TopNumber = columns[0];
                    domino.BottomNumber = columns[1];
                    string separator = "--------------";

                    string textValue = domino.TopNumber + "\n\n" +
                                        separator + "\n\n" +
                                        domino.BottomNumber;
                    int dominoTotal = domino.Total;

                    dominoButtons[row, col] = new Button();
                    dominoButtons[row, col].Location = new Point(startLeft + (col * 60), startTop + (row * 94));
                    dominoButtons[row, col].Width = 60;
                    dominoButtons[row, col].Height = 94;
                    dominoButtons[row, col].BackColor = Color.Black;
                    dominoButtons[row, col].Text = textValue;
                    dominoButtons[row, col].Tag = dominoTotal;
                    dominoButtons[row, col].Click += FlipDomino_Click;
                    gameBoard.Controls.Add(dominoButtons[row, col]);

                    counter++;
                }
            }
        }

        private void FlipDomino_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButtons[0] == null)
            {
                clickedButtons[0] = clickedButton;
            }
            else
            {
                clickedButtons[1] = clickedButton;
            }

            clickedButton.ForeColor = Color.White;

            flippedDominoValues += Convert.ToInt32(clickedButton.Tag);
            numFlippedDominoes++;

            if (numFlippedDominoes == 2 && flippedDominoValues != 12)
            {
                // Store the clicked buttons in an array so we can flip them back over.
                MessageBox.Show("No match, try again!");
                clickedButtons[0].ForeColor = Color.Black;
                clickedButtons[1].ForeColor = Color.Black;

                clickedButtons[0] = null;
                clickedButtons[1] = null;

                if (playerIndex < totalPlayers)
                {
                    playerIndex++;
                }
                else
                {
                    playerIndex = 0;
                }

                currentPlayer = (players[playerIndex]);
                playerName = currentPlayer.PlayerName;
                Changed(playerName);

                numFlippedDominoes = 0;
                flippedDominoValues = 0;
            }

            if (numFlippedDominoes == 2 && flippedDominoValues == 12)
            {
                MessageBox.Show(playerName + " found a match!");

                clickedButtons[0].Visible = false;
                clickedButtons[1].Visible = false;
                clickedButtons[0] = null;
                clickedButtons[1] = null;

                currentPlayer.PlayerScore += flippedDominoValues;

                OnPlayerScored(playerIndex);

                if (playerIndex < totalPlayers)
                {
                    playerIndex++;
                }
                else
                {
                    playerIndex = 0;
                }

                currentPlayer = (players[playerIndex]);
                playerName = currentPlayer.PlayerName;
                Changed(playerName);

                numFlippedDominoes = 0;
                flippedDominoValues = 0;

                gameCounter++;

                if (gameCounter == 14)
                {
                    MessageBox.Show("Game Over! Reset to start a new game.");
                }
            }
        }

        public void ResetGame()
        {
            gameBoard.Controls.Clear();
        }
    }
}
