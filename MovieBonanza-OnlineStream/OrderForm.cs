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
 * Order Form - Part of the COMP1004 F2016 Movie Bonanza Assignment
 * Designed by Devon Cochrane (SN 200244662)
 * Rev 1.0
 * This form displays the cost breakdown and allows the user to add an optional DVD is desired.
 */

namespace MovieBonanza_OnlineStream
{
    public partial class OrderForm : Form
    {
        public SelectionForm previousForm;
        public OrderForm()
        {
            InitializeComponent();
            //This calls the order form load method, which populates all textboxes with appropriate info
            this.OrderForm_Load();
        }
        /// <summary>
        /// OrderForm_Load event handler
        /// This will fill the textboxes with appropriate information, as well as calls the caluclate total method, and the picture box method
        /// </summary>
        private void OrderForm_Load()
        {
            TitleTextBox.Text = Program.selection[0];
            CategoryTextBox.Text = Program.selection[1];
            CostTextBox.Text = Program.selection[2];
            CalculateTotal();
            PictureBox();           
        }
        /// <summary>
        /// OptionalDVDCheckBox_CheckedChanged Event Handler
        /// This will check if the optional dvd checkboc has been checked or unchecked, and will hide/show the dvd chage form, as well as call the calculate total method
        /// to update the grand total
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OptionalDVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
            if (OptionalDVDCheckBox.Checked)
            {
                DVDChargeTextBox.Text = "$10.00";
                DVDChargeLabel.Show();
                DVDChargeTextBox.Show();
            }
            else
            {
                DVDChargeLabel.Hide();
                DVDChargeTextBox.Hide();
            }
        }
        /// <summary>
        /// cancelToolStripMenuItem_Click
        /// This will close the program, it shares an event with the cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// printToolStripMenuItem_Click event handler
        /// This will show a print preview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
        }
        /// <summary>
        /// streamToolStripMenuItem_Click event handler
        /// This will hide the current window, and show the next. It shares an event handler with the stream button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void streamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamForm streamForm = new MovieBonanza_OnlineStream.StreamForm();
            streamForm.Show();
            this.Hide();
        }
        /// <summary>
        /// aboutToolStripMenuItem_Click event handler
        /// This will show the about information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }
        /// <summary>
        /// backToolStripMenuItem_Click
        /// This will switch windows back to the selection window, it shares its event handler with the back button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }
        /// <summary>
        /// CalculateTotal method
        /// This will calculate the total
        /// </summary>
        private void CalculateTotal()
        {
            double _Cost;
            double _SubTotal;
            double _SalesTax;
            double _GrandTotal;
            //const double because the price of the dvd does not change
            const double _DVD = 10;
            //parses the cost string 
            _Cost = double.Parse(CostTextBox.Text, System.Globalization.NumberStyles.Currency);
            //if statements check whether or not to add money.
            if (OptionalDVDCheckBox.Checked)
            {
                _SubTotal = _Cost + _DVD;
            }
            //this is necessary to ensure if the box was previous checked, and has been since unchecked, the cost will update accordingly
            else if (!OptionalDVDCheckBox.Checked)
            {
                _SubTotal = _Cost;
            }
            else
            {
                _SubTotal = _Cost;
            }
            //math operations
            _SalesTax = _SubTotal * 0.13;
            _GrandTotal = _SubTotal + _SalesTax;
            //convert doubles to strings and populate textboxes
            SubTotalTextBox.Text = _SubTotal.ToString("C2");
            SalesTaxTextBox.Text = _SalesTax.ToString("C2");
            GrandTotalTextBox.Text = _GrandTotal.ToString("C2");
            //store grand total in global variable
            Program.cost = _GrandTotal;

        }
        //this will decide what image to display. I tried to find a better method, but could not come up with anything
        private void PictureBox()
        {
            if (CategoryTextBox.Text == "Action")
            {
                MoviePictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.action;
            }
            else if (CategoryTextBox.Text == "Sci-Fi")
            {
                MoviePictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.scifi;
            }
            else if (CategoryTextBox.Text == "Comedy")
            {
                MoviePictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.comedy;
            }
            else if (CategoryTextBox.Text == "Drama")
            {
                MoviePictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.drama;
            }
            else if (CategoryTextBox.Text == "Horror")
            {
                MoviePictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.horror;
            }
            else if (CategoryTextBox.Text == "Thriller")
            {
                MoviePictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.thriller;
            }
            else if (CategoryTextBox.Text == "Family")
            {
                MoviePictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.family;
            }
            else
            {
                MoviePictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.newrelease;
            }
            //ensures image is appropriate size
            MoviePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}
