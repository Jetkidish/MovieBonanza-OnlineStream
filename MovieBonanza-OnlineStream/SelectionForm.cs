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
 * Selection Form - Part of the COMP1004 F2016 Movie Bonanza Assignment
 * Designed by Devon Cochrane (SN 200244662)
 * Rev 1.0
 * This form displays the movie selection, takes user input, and saves info for later
 */

namespace MovieBonanza_OnlineStream
{
    public partial class SelectionForm : Form
    {
        private string _selectedMovie;
        public SelectionForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// CurrentMoviesListBox_SelectedIndexChanged Event Handler
        /// This will update all information in the window based on the user selection. This includes the movie title, category, cost, and image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentMoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {   
            //This converts the selected item to a string, and displays it in the title text box
            TitleTextBox.Text = (string)CurrentMoviesListBox.SelectedItem;
            //If any movie is selected, the next button is enabled
            NextButton.Enabled = true;
            //The following if statements set the images for the movies. No images were provided, so ones based on each movies category were created
            if (this._selectedMovie == "The Green Hornet" || this._selectedMovie == "Death Race 2" || this._selectedMovie == "The Mechanic" || this._selectedMovie == "Sanctum" || this._selectedMovie == "The Other Woman" || this._selectedMovie == "The Eagle")
            {
                CategoryTextBox.Text = "Action";
                CostTextBox.Text = "$2.99";
                SelectionPictureBox.Image = MovieBonanza_OnlineStream .Properties.Resources.action;
                SelectionPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (this._selectedMovie == "Season of the Witch" || this._selectedMovie == "I am Number Four")
            {
                CategoryTextBox.Text = "Sci-Fi";
                CostTextBox.Text = "$2.99";
                SelectionPictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.scifi;
                SelectionPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (this._selectedMovie == "The Dilemma" || this._selectedMovie == "No Strings Attached" || this._selectedMovie == "Cedar Rapids" || this._selectedMovie == "Just Go With It")
            {
                CategoryTextBox.Text = "Comedy";
                CostTextBox.Text = "$1.99";
                SelectionPictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.comedy;
                SelectionPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (this._selectedMovie == "Company Men" || this._selectedMovie == "The Way Back" || this._selectedMovie == "Waiting for Forever")
            {
                CategoryTextBox.Text = "Drama";
                CostTextBox.Text = "$1.99";
                SelectionPictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.drama;
                SelectionPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (this._selectedMovie == "The Rite")
            {
                CategoryTextBox.Text = "Horror";
                CostTextBox.Text = "$2.99";
                SelectionPictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.horror;
                SelectionPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (this._selectedMovie == "The Roommate")
            {
                CategoryTextBox.Text = "Thriller";
                CostTextBox.Text = "$1.99";
                SelectionPictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.thriller;
                SelectionPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (this._selectedMovie == "Gnomeo and Juliet")
            {
                CategoryTextBox.Text = "Family";
                CostTextBox.Text = "$0.99";
                SelectionPictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.family;
                SelectionPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else {
                CategoryTextBox.Text = "New Release";
                CostTextBox.Text = "$4.99";
                SelectionPictureBox.Image = MovieBonanza_OnlineStream.Properties.Resources.newrelease;
                SelectionPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        /// <summary>
        /// NextButton_Click event handler
        /// This will store the movie title, category, and cost into a global array. It will also hide the current window, and show the next one, as well as set the "previous form" to this window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.selection[0] = TitleTextBox.Text;
            Program.selection[1] = CategoryTextBox.Text;
            Program.selection[2] = CostTextBox.Text;
            OrderForm orderForm = new MovieBonanza_OnlineStream.OrderForm();
            orderForm.previousForm = this;
            orderForm.Show();
            this.Hide();
        }
    }
}
