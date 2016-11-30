using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concentration
{
    /*****************************************************************
    * Name: Bill Adams
    * Project: Program 2
    * Date: 11/17/2016
    * Description: Dominoes memory game.
    * **************************************************************/
    public partial class frmConcentration : Form
    {
        public frmConcentration()
        {
            InitializeComponent();
        }

        private PlayerList<Player> players;
        Game game = null;

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            players = new PlayerList<Player>();
            // Set up the players and their intial scores.
            // Validation isn't an issue here, it's their game.
            Player p1 = new Player(txtPlayerOne.Text);
            Player p2 = new Player(txtPlayerTwo.Text);
            players.Add(p1);
            players.Add(p2);

            lblPlayerOneScore.Visible = true;
            lblPlayerOneTotalScore.Visible = true;
            lblPlayerOneScore.Text = p1.PlayerName + "'s score";
            lblPlayerOneTotalScore.Text = Convert.ToString(p1.PlayerScore);

            lblPlayerTwoScore.Visible = true;
            lblPlayerTwoTotalScore.Visible = true;
            lblPlayerTwoScore.Text = p2.PlayerName + "'s score";
            lblPlayerTwoTotalScore.Text = Convert.ToString(p2.PlayerScore);

            if (radThreePlayers.Checked)
            {
                Player p3 = new Player(txtPlayerThree.Text);
                players.Add(p3);

                lblPlayerThreeScore.Visible = true;
                lblPlayerThreeTotalScore.Visible = true;
                lblPlayerThreeScore.Text = p3.PlayerName + "'s score";
                lblPlayerThreeTotalScore.Text = Convert.ToString(p3.PlayerScore);
            }

            lblCurrentPlayer.Visible = true;
            lblCurrentPlayerName.Visible = true;
            lblCurrentPlayerName.Text = Convert.ToString(p1.PlayerName);

            game = new Game(pnlGameBoard, players);
            game.BuildBoard();

            btnReset.Enabled = true;
            btnNewGame.Enabled = false;
            radTwoPlayers.Enabled = false;
            radThreePlayers.Enabled = false;
            txtPlayerOne.Enabled = false;
            txtPlayerTwo.Enabled = false;
            txtPlayerThree.Enabled = false;

            game.Changed += new Game.PlayerChange(HandleChange);
            game.OnPlayerScored += new Game.PlayerScored(HandleUpdate);
        }

        private void radTwoPlayers_CheckedChanged(object sender, EventArgs e)
        {
            if (radTwoPlayers.Checked)
            {
                lblPlayerThree.Visible = false;
                txtPlayerThree.Visible = false;
            }
            else
            {
                lblPlayerThree.Visible = true;
                txtPlayerThree.Visible = true;
            }
        }

        private void HandleChange(string playerName)
        {
            lblCurrentPlayerName.Text = playerName;
        }

        private void HandleUpdate(int playerIndex)
        {
            if (playerIndex == 0)
            {
                lblPlayerOneTotalScore.Text = Convert.ToString(players[playerIndex].PlayerScore);
            }
            else if (playerIndex == 1)
            {
                lblPlayerTwoTotalScore.Text = Convert.ToString(players[playerIndex].PlayerScore);
            }
            else if (playerIndex == 2)
            {
                lblPlayerThreeTotalScore.Text = Convert.ToString(players[playerIndex].PlayerScore);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset the form controls and clear the game board.
            txtPlayerOne.Text = "Player 1";
            txtPlayerTwo.Text = "Player 2";
            txtPlayerThree.Text = "Player 3";
            radTwoPlayers.Checked = true;

            lblCurrentPlayer.Visible = false;
            lblCurrentPlayerName.Visible = false;
            lblPlayerOneScore.Visible = false;
            lblPlayerOneTotalScore.Visible = false;
            lblPlayerTwoScore.Visible = false;
            lblPlayerTwoTotalScore.Visible = false;
            lblPlayerThreeScore.Visible = false;
            lblPlayerThreeTotalScore.Visible = false;
            radTwoPlayers.Enabled = true;
            radThreePlayers.Enabled = true;
            txtPlayerOne.Enabled = true;
            txtPlayerTwo.Enabled = true;
            txtPlayerThree.Enabled = true;

            btnNewGame.Enabled = true;
            btnReset.Enabled = false;

            game.Changed -= new Game.PlayerChange(HandleChange);
            game.OnPlayerScored -= new Game.PlayerScored(HandleUpdate);

            game.ResetGame();
            game = null;
        }
    }
}
