/*Programmer: Matthew Moore
   Description: Flyer Sports Club
   Date: 12-1-18
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

namespace FlyerSportsClub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Set all checkboxes back to not checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearSelectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkEarmuffs.Checked = false;
            checkGoggles.Checked = false;
            checkBindings.Checked = false;
            checkBoots.Checked = false;
            checkSkis.Checked = false;
            checkPoles.Checked = false;
            checkGloves.Checked = false;
        }

        /// <summary>
        /// Determine if checkbox is checked, and if true append it to a string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displaySelectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string textView = "Items Needed\n-----------\n";

            textView += checkEarmuffs.Checked ? "Earmuffs\n" : "";
            textView += checkGoggles.Checked ? "Goggles\n" : "";
            textView += checkBindings.Checked ? "Ski Bindings\n" : "";
            textView += checkBoots.Checked ? "Ski Boots\n" : "";
            textView += checkSkis.Checked ? "Skis\n" : "";
            textView += checkPoles.Checked ? "Ski Poles\n" : "";
            textView += checkGloves.Checked ? "Snow Gloves\n" : "";

            MessageBox.Show(textView);
        }
    }
}
