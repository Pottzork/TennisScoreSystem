using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTennisScoreSystem
{
    public partial class Form1 : Form
    {

        int leftPlayerPoints = 0;
        int rightPlayerPoints = 0;
        int currentRound = 1;
        bool gameOver = false;
        Players players = new Players();


        public Form1()
        {
            InitializeComponent();
            BackgroundImageLayout = ImageLayout.Stretch;
            PlayerLeftServe.Visible = true;
            PlayerRightServe.Visible = false;
            
        }
        

        private void PlayerLeftServe_Click(object sender, EventArgs e)
        {
            CheckGameScore();
            UpdateGameInterface();
            if (gameOver == true)
            {
                PlayerLeftServe.Visible = false;
                PlayerRightServe.Visible = false;
            }
            else
            {
                PlayerLeftServe.Visible = false;
                PlayerRightServe.Visible = true;
                currentRound++;
            }


        }

        private void PlayerRightServe_Click(object sender, EventArgs e)
        {
            CheckGameScore();
            UpdateGameInterface();
            if (gameOver == true)
            {
                PlayerLeftServe.Visible = false;
                PlayerRightServe.Visible = false;
            }
            else
            {
                PlayerLeftServe.Visible = true;
                PlayerRightServe.Visible = false;
                currentRound++;
            }
        }

        public string GetPointWinnerPlayerName()
        {
            //Sets the player names
            
            players.PlayerOne = "Nadal";
            players.PlayerTwo = "Federer";
            
            var playerList = new List<string> { players.PlayerOne, players.PlayerTwo };

            Random random = new Random();
            int index = random.Next(playerList.Count);

            return playerList[index].ToString();
        }

        public void GivePoints()
        {
            if (WinnerLabel.Text == "Federer")
            {
                rightPlayerPoints++;
            }
            else if (WinnerLabel.Text == "Nadal")
            {
                leftPlayerPoints++;
            }
        }

        private void CheckGameScore()
        {

            if (gameOver == true)
            {
                PlayerLeftServe.Visible = false;
                PlayerRightServe.Visible = false;
            }
            else
            {
                if (rightPlayerPoints >= 10 && rightPlayerPoints > leftPlayerPoints + 1)
                {
                    gameOver = true;
                    WinnerStaticLabel.Text = $"THE GAME WAS WON BY: {players.PlayerTwo}";
                    WinnerLabel.Text = "";
                    
                }
                else if (leftPlayerPoints >= 10 && leftPlayerPoints > rightPlayerPoints + 1)
                {
                    gameOver = true;
                    WinnerStaticLabel.Text = $"THE GAME WAS WON BY: {players.PlayerOne}";
                    WinnerLabel.Text = "";
                    
                }
            }
        
        }

        private void UpdateGameInterface()
        {
            WinnerLabel.Text = GetPointWinnerPlayerName();
            GivePoints();
            PointsLeftLabel.Text = $"Points: {leftPlayerPoints.ToString()}";
            PointsRightLabel.Text = $"Points: {rightPlayerPoints.ToString()}";
            
        }

        private void RulesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"The rules are simple:
                1. First player to reach 10 points wins.
                2. Players take turns to serve
                3. If both players are at equal 10 points or above, 
                then you need an 2 points leverage to win.
                (For example if the the result is 11-10, 
                the left player needs only 1 point more to win. 
                If instead the right player
                makes it 11-11 then either player needs 13 to win. 
                Provided that the other player doesn't score");
            
            
        }
    }
}
