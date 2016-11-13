using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Stream Form - Part of the COMP1004 F2016 Movie Bonanza Assignment
 * Designed by Devon Cochrane (SN 200244662)
 * Rev 1.0
 * This form simply displays the final cost and movie selection
 */

namespace MovieBonanza_OnlineStream
{
    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            InitializeComponent();
            //No need to over complicate things, just update the labels here
            CreditChargeLabel.Text = "Your Credit card will be charged " + Program.cost.ToString("C2");
            MovieLabel.Text = Program.selection[0] + " will begin streaming shortly";
        }
        /// <summary>
        /// OkButton_Click event handler
        /// This will close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
