/*Programmer: Matthew Moore
 * Description: Rock Paper Scissors
 * Date: 9-25-18
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public static class Globals
        {
            public static int loses = 0;
            public static int ties = 0;
            public static int wins = 0;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Random random1 = new Random();

            Image[] rps = {Image.FromFile("rock.jpg"), Image.FromFile("scissors.jpg"), Image.FromFile("paper.jpg")};
            
            DisplayRoll(random1, rps, pic1, pic2, txtWins, txtLosses, txtTies, txtDisplay);
            
        }

        public static void DisplayRoll(Random random1, Image[] rps, PictureBox pic1, PictureBox pic2, TextBox txtWins, TextBox txtLoses, TextBox txtTies, TextBox txtDisplay)
        {
            int randomNum1 = random1.Next(1, 4);
            int randomNum2 = random1.Next(1, 4);

            if (randomNum1 == 1)
            {
                pic1.ImageLocation = "rock.jpg";
                pic1.SizeMode = PictureBoxSizeMode.StretchImage;

                if (randomNum2 == 1)
                {
                    pic2.ImageLocation = "rock.jpg";
                    pic2.SizeMode = PictureBoxSizeMode.StretchImage;

                    Globals.ties += 1;

                    txtTies.Text = "You have tied " + Globals.ties + " times.";
                    txtDisplay.Text = "Rock ties Rock";
                }
                else if (randomNum2 == 2)
                {
                    pic2.ImageLocation = "scissors.jpg";
                    pic2.SizeMode = PictureBoxSizeMode.StretchImage;

                    Globals.wins += 1;

                    txtWins.Text = "You have won " + Globals.wins + " times.";
                    txtDisplay.Text = "Rock beats Scissors";
                }
                else
                {
                    pic2.ImageLocation = "paper.jpg";
                    pic2.SizeMode = PictureBoxSizeMode.StretchImage;

                    Globals.loses += 1;

                    txtLoses.Text = "You have lost " + Globals.loses + " times.";
                    txtDisplay.Text = "Paper beats Rock";
                }
            }

            else if (randomNum1 == 2)
            {
                pic1.ImageLocation = "scissors.jpg";
                pic1.SizeMode = PictureBoxSizeMode.StretchImage;

                if (randomNum2 == 1)
                {
                    pic2.ImageLocation = "rock.jpg";
                    pic2.SizeMode = PictureBoxSizeMode.StretchImage;

                    Globals.loses += 1;

                    txtLoses.Text = "You have lost " + Globals.loses + " times.";
                    txtDisplay.Text = "Rock beats Scissors";
                }
                else if (randomNum2 == 2)
                {
                    pic2.ImageLocation = "scissors.jpg";
                    pic2.SizeMode = PictureBoxSizeMode.StretchImage;

                    Globals.ties += 1;

                    txtTies.Text = "You have tied " + Globals.ties + " times.";
                    txtDisplay.Text = "Scissors ties Scissors";
                }
                else
                {
                    pic2.ImageLocation = "paper.jpg";
                    pic2.SizeMode = PictureBoxSizeMode.StretchImage;

                    Globals.wins += 1;

                    txtWins.Text = "You have won " + Globals.wins + " times.";
                    txtDisplay.Text = "Scissors beats Paper";
                }   
            }
            else
            {
                pic1.ImageLocation = "paper.jpg";
                pic1.SizeMode = PictureBoxSizeMode.StretchImage;

                if (randomNum2 == 1)
                {
                    pic2.ImageLocation = "rock.jpg";
                    pic2.SizeMode = PictureBoxSizeMode.StretchImage;

                    Globals.wins += 1;

                    txtWins.Text = "You have won " + Globals.wins + " times.";
                    txtDisplay.Text = "Paper beats Rock";
                }
                else if (randomNum2 == 2)
                {
                    pic2.ImageLocation = "scissors.jpg";
                    pic2.SizeMode = PictureBoxSizeMode.StretchImage;

                    Globals.loses += 1;

                    txtLoses.Text = "You have lost " + Globals.loses + " times.";
                    txtDisplay.Text = "Scissors beats Paper";
                }
                else
                {
                    pic2.ImageLocation = "paper.jpg";
                    pic2.SizeMode = PictureBoxSizeMode.StretchImage;

                    Globals.ties += 1;

                    txtTies.Text = "You have tied " + Globals.ties + " times.";
                    txtDisplay.Text = "Paper ties Paper";
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Gets the image location and then sets the size of the image to stetch into the container's width and height
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            pic1.ImageLocation = "negatory.jpg";
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2.ImageLocation = "negatory.jpg";
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
