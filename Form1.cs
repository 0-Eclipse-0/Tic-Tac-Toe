using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {

        bool turn = true; //true = X turn; false = Y turn;
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Matthew Hambrecht. This game is a simple tic tac toe that you and a friend/loved one/family member can play and hopefully enjoy!", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWinner();
        }


        private void checkForWinner()
        {
            bool winner = false;

            //horizontal winners
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                winner = true;
            //vertical winners
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                winner = true;
            //diagonal winners
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                winner = true;
            
            if (winner)
            {
                disableButtons();
                String winnerusr = "";
                if (turn)
                    winnerusr = "O";
                else
                    winnerusr = "X";

                MessageBox.Show(winnerusr + " won the round!", "Winner");
            }//end if
            else
            {
                if (turn_count == 9)
                    MessageBox.Show("It's a draw :-(", "Draw");
            }
        }

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            } 
            catch { }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void developerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Matthew. Matthew is a 12 year old programmer that loves making things simpler for people!");
        }

        private void gameInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Built using MS Visual Studio 2015. Designed using windows forms. Coded in C# (See Sharp)");
        }

        private void buildInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Built 11/26/2015 (Thanksgiving) at 3:46");
        }

        private void otherGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Download Bouncy Block and Ball Fall for even more fun!");
        }

        private void testersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void creatorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void programmerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matthew is the Lead and only programmer of this game.");
        }

        private void testersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tested by - Zach, Matthew, Kevin, Jack, Jake, Edris, Parker, Layla, Kayla, Maria and Bella");
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.0");
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            } 
            catch { }
        }
    }
}