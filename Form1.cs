using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Net;


namespace RussianRoulette
{
    public partial class Form1 : Form
    {
        Roulette roulette = new Roulette();


        public Form1()
        {
            InitializeComponent();
            // display ducks left
            lblAway.Text = "Dodges Left: " + roulette.FireAway.ToString();
            // plays background music
            SoundPlayer player = new SoundPlayer(Resource1._442997__suburbanwizard__8bit_sample);
            player.PlayLooping();

        }


        //Spin random number
        private void BtnSpin_Click(object sender, EventArgs e)
        {
            roulette.counter = roulette.RND();


        }


        // fire away counts down from 2 to 0 
        private void BtnAway_Click(object sender, EventArgs e)
        {
            FireAway();
        }

        private void FireAway()
        {
            roulette.isFireAway = true;
            roulette.FireAway--;
            lblAway.Text = "Dodges Left: " + roulette.FireAway.ToString();

            // tells user no dodges left
            if (roulette.FireAway <= 0)
            {
                lblAway.Text = "No dodges left.";
            }

            // tells user theyre dodging
            if (roulette.counter > 0 && roulette.isFireAway == true)
            {
                lblDodge.Text = "You are dodging.";
            }
        }


        // counts down from RND to 0
        private void BtnFire_Click(object sender, EventArgs e)
        {
            roulette.counter--;




            // tells user theyre not dodging
            if (roulette.counter > 0 && roulette.isFireAway == false)
            {
                lblDodge.Text = "You are not dodging.";
            }


            //win conditions
            WinConditions(roulette.counter, roulette.isFireAway);


            roulette.isFireAway = false;
            lblDodge.Text = "You are not dodging.";

        }

        public void WinConditions(int counter, bool isFireAway)
        {
            //Win condition
            if (counter == 0 && isFireAway == true)
            {
                MessageBox.Show("You Win, Congratulations!");
                roulette.winCounter++;
                roulette.gpCounter++;
                lblGP.Text = "Games Played: " + roulette.gpCounter.ToString();

                lblWin.Text = "Wins: " + roulette.winCounter.ToString();
            }
            //lose condition
            if (counter > 1 && roulette.FireAway == 0)
            {
                MessageBox.Show("You Lose, Try Again!");
                roulette.loseCounter++;
                lblLoses.Text = "Loses: " + roulette.loseCounter.ToString();
                roulette.gpCounter++;
                lblGP.Text = "Games Played: " + roulette.gpCounter.ToString();

            }
            //lose condition
            if (counter == 0 && isFireAway == false)
            {
                MessageBox.Show("You Lose, Try Again!");
                roulette.loseCounter++;
                lblLoses.Text = "Loses: " + roulette.loseCounter.ToString();
                roulette.gpCounter++;
                lblGP.Text = "Games Played: " + roulette.gpCounter.ToString();


            }


        }



        // load, resets form
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            roulette.FireAway = 2;
            lblAway.Text = "Dodges Left: " + roulette.FireAway.ToString();
            roulette.isFireAway = false;
            lblDodge.Text = "You are not dodging.";

        }



        private void BtnPlay_Click(object sender, EventArgs e)
        {
            // code for button click on windows form 1
            // code for button click on windows form 1
            //close the window
            this.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //COde for when form 1 is loaded
            // put form1 on top of all other windows
            this.TopMost = true;
        }



    }
}



