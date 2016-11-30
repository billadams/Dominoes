namespace Concentration
{
    partial class frmConcentration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radThreePlayers = new System.Windows.Forms.RadioButton();
            this.radTwoPlayers = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayerThree = new System.Windows.Forms.Label();
            this.txtPlayerOne = new System.Windows.Forms.TextBox();
            this.txtPlayerTwo = new System.Windows.Forms.TextBox();
            this.txtPlayerThree = new System.Windows.Forms.TextBox();
            this.pnlGameBoard = new System.Windows.Forms.Panel();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPlayerOneScore = new System.Windows.Forms.Label();
            this.lblPlayerTwoScore = new System.Windows.Forms.Label();
            this.lblPlayerThreeScore = new System.Windows.Forms.Label();
            this.lblPlayerOneTotalScore = new System.Windows.Forms.Label();
            this.lblPlayerTwoTotalScore = new System.Windows.Forms.Label();
            this.lblPlayerThreeTotalScore = new System.Windows.Forms.Label();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.lblCurrentPlayerName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radThreePlayers);
            this.groupBox1.Controls.Add(this.radTwoPlayers);
            this.groupBox1.Location = new System.Drawing.Point(514, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number of Players";
            // 
            // radThreePlayers
            // 
            this.radThreePlayers.AutoSize = true;
            this.radThreePlayers.Location = new System.Drawing.Point(67, 58);
            this.radThreePlayers.Name = "radThreePlayers";
            this.radThreePlayers.Size = new System.Drawing.Size(53, 17);
            this.radThreePlayers.TabIndex = 1;
            this.radThreePlayers.Text = "Three";
            this.radThreePlayers.UseVisualStyleBackColor = true;
            // 
            // radTwoPlayers
            // 
            this.radTwoPlayers.AutoSize = true;
            this.radTwoPlayers.Checked = true;
            this.radTwoPlayers.Location = new System.Drawing.Point(67, 35);
            this.radTwoPlayers.Name = "radTwoPlayers";
            this.radTwoPlayers.Size = new System.Drawing.Size(46, 17);
            this.radTwoPlayers.TabIndex = 0;
            this.radTwoPlayers.TabStop = true;
            this.radTwoPlayers.Text = "Two";
            this.radTwoPlayers.UseVisualStyleBackColor = true;
            this.radTwoPlayers.CheckedChanged += new System.EventHandler(this.radTwoPlayers_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player 1 Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player 2 Name:";
            // 
            // lblPlayerThree
            // 
            this.lblPlayerThree.AutoSize = true;
            this.lblPlayerThree.Location = new System.Drawing.Point(511, 273);
            this.lblPlayerThree.Name = "lblPlayerThree";
            this.lblPlayerThree.Size = new System.Drawing.Size(79, 13);
            this.lblPlayerThree.TabIndex = 4;
            this.lblPlayerThree.Text = "Player 3 Name:";
            this.lblPlayerThree.Visible = false;
            // 
            // txtPlayerOne
            // 
            this.txtPlayerOne.Location = new System.Drawing.Point(596, 177);
            this.txtPlayerOne.Name = "txtPlayerOne";
            this.txtPlayerOne.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerOne.TabIndex = 5;
            this.txtPlayerOne.Text = "Player 1";
            // 
            // txtPlayerTwo
            // 
            this.txtPlayerTwo.Location = new System.Drawing.Point(596, 224);
            this.txtPlayerTwo.Name = "txtPlayerTwo";
            this.txtPlayerTwo.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerTwo.TabIndex = 6;
            this.txtPlayerTwo.Text = "Player 2";
            // 
            // txtPlayerThree
            // 
            this.txtPlayerThree.Location = new System.Drawing.Point(596, 270);
            this.txtPlayerThree.Name = "txtPlayerThree";
            this.txtPlayerThree.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerThree.TabIndex = 7;
            this.txtPlayerThree.Text = "Player 3";
            this.txtPlayerThree.Visible = false;
            // 
            // pnlGameBoard
            // 
            this.pnlGameBoard.Location = new System.Drawing.Point(12, 56);
            this.pnlGameBoard.Name = "pnlGameBoard";
            this.pnlGameBoard.Size = new System.Drawing.Size(428, 387);
            this.pnlGameBoard.TabIndex = 8;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNewGame.Location = new System.Drawing.Point(514, 345);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(169, 65);
            this.btnNewGame.TabIndex = 9;
            this.btnNewGame.Text = "&New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(514, 464);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(169, 32);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblPlayerOneScore
            // 
            this.lblPlayerOneScore.AutoSize = true;
            this.lblPlayerOneScore.Location = new System.Drawing.Point(12, 454);
            this.lblPlayerOneScore.Name = "lblPlayerOneScore";
            this.lblPlayerOneScore.Size = new System.Drawing.Size(90, 13);
            this.lblPlayerOneScore.TabIndex = 11;
            this.lblPlayerOneScore.Text = "Player One Score";
            this.lblPlayerOneScore.Visible = false;
            // 
            // lblPlayerTwoScore
            // 
            this.lblPlayerTwoScore.AutoSize = true;
            this.lblPlayerTwoScore.Location = new System.Drawing.Point(172, 454);
            this.lblPlayerTwoScore.Name = "lblPlayerTwoScore";
            this.lblPlayerTwoScore.Size = new System.Drawing.Size(91, 13);
            this.lblPlayerTwoScore.TabIndex = 12;
            this.lblPlayerTwoScore.Text = "Player Two Score";
            this.lblPlayerTwoScore.Visible = false;
            // 
            // lblPlayerThreeScore
            // 
            this.lblPlayerThreeScore.AutoSize = true;
            this.lblPlayerThreeScore.Location = new System.Drawing.Point(342, 454);
            this.lblPlayerThreeScore.Name = "lblPlayerThreeScore";
            this.lblPlayerThreeScore.Size = new System.Drawing.Size(98, 13);
            this.lblPlayerThreeScore.TabIndex = 13;
            this.lblPlayerThreeScore.Text = "Player Three Score";
            this.lblPlayerThreeScore.Visible = false;
            // 
            // lblPlayerOneTotalScore
            // 
            this.lblPlayerOneTotalScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerOneTotalScore.Location = new System.Drawing.Point(12, 475);
            this.lblPlayerOneTotalScore.Name = "lblPlayerOneTotalScore";
            this.lblPlayerOneTotalScore.Size = new System.Drawing.Size(90, 21);
            this.lblPlayerOneTotalScore.TabIndex = 14;
            this.lblPlayerOneTotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayerOneTotalScore.Visible = false;
            // 
            // lblPlayerTwoTotalScore
            // 
            this.lblPlayerTwoTotalScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerTwoTotalScore.Location = new System.Drawing.Point(175, 475);
            this.lblPlayerTwoTotalScore.Name = "lblPlayerTwoTotalScore";
            this.lblPlayerTwoTotalScore.Size = new System.Drawing.Size(90, 21);
            this.lblPlayerTwoTotalScore.TabIndex = 15;
            this.lblPlayerTwoTotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayerTwoTotalScore.Visible = false;
            // 
            // lblPlayerThreeTotalScore
            // 
            this.lblPlayerThreeTotalScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayerThreeTotalScore.Location = new System.Drawing.Point(345, 475);
            this.lblPlayerThreeTotalScore.Name = "lblPlayerThreeTotalScore";
            this.lblPlayerThreeTotalScore.Size = new System.Drawing.Size(90, 21);
            this.lblPlayerThreeTotalScore.TabIndex = 16;
            this.lblPlayerThreeTotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayerThreeTotalScore.Visible = false;
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(190, 9);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(73, 13);
            this.lblCurrentPlayer.TabIndex = 17;
            this.lblCurrentPlayer.Text = "Current Player";
            this.lblCurrentPlayer.Visible = false;
            // 
            // lblCurrentPlayerName
            // 
            this.lblCurrentPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentPlayerName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCurrentPlayerName.Location = new System.Drawing.Point(179, 27);
            this.lblCurrentPlayerName.Name = "lblCurrentPlayerName";
            this.lblCurrentPlayerName.Size = new System.Drawing.Size(90, 21);
            this.lblCurrentPlayerName.TabIndex = 18;
            this.lblCurrentPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCurrentPlayerName.Visible = false;
            // 
            // frmConcentration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 515);
            this.Controls.Add(this.lblCurrentPlayerName);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblPlayerThreeTotalScore);
            this.Controls.Add(this.lblPlayerTwoTotalScore);
            this.Controls.Add(this.lblPlayerTwoScore);
            this.Controls.Add(this.lblPlayerOneTotalScore);
            this.Controls.Add(this.lblPlayerThreeScore);
            this.Controls.Add(this.lblPlayerOneScore);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.pnlGameBoard);
            this.Controls.Add(this.txtPlayerThree);
            this.Controls.Add(this.txtPlayerTwo);
            this.Controls.Add(this.txtPlayerOne);
            this.Controls.Add(this.lblPlayerThree);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConcentration";
            this.Text = "Concentration Dominoes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radThreePlayers;
        private System.Windows.Forms.RadioButton radTwoPlayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayerThree;
        private System.Windows.Forms.TextBox txtPlayerOne;
        private System.Windows.Forms.TextBox txtPlayerTwo;
        private System.Windows.Forms.TextBox txtPlayerThree;
        private System.Windows.Forms.Panel pnlGameBoard;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblPlayerOneScore;
        private System.Windows.Forms.Label lblPlayerTwoScore;
        private System.Windows.Forms.Label lblPlayerThreeScore;
        private System.Windows.Forms.Label lblPlayerOneTotalScore;
        private System.Windows.Forms.Label lblPlayerTwoTotalScore;
        private System.Windows.Forms.Label lblPlayerThreeTotalScore;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.Label lblCurrentPlayerName;
    }
}

