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
 * Splash Form - Part of the COMP1004 F2016 Movie Bonanza Assignment
 * Designed by Devon Cochrane (SN 200244662)
 * Rev 1.0
 * This form simply displays the splash image
 */

namespace MovieBonanza_OnlineStream
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// SplashFormTimer_Tick Event Handler
        /// This displays the splash form for 3 seconds, then moves on to the selection name form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            //this is so that the timer only goes once, otherwise it will open a billion generate name forms
            SplashFormTimer.Enabled = false;
            //this is where the generate name form opens
            SelectionForm startform = new SelectionForm();
            startform.Show();
            //this hides the splash screen
            this.Hide();
        }
    }
}
