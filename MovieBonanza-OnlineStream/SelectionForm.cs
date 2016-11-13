using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieBonanza_OnlineStream
{
    public partial class SelectionForm : Form
    {
        private string _selectedMovie;
        public SelectionForm()
        {
            InitializeComponent();
        }

        private void CurrentMoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {   
            TitleTextBox.Text = (string)CurrentMoviesListBox.SelectedItem;
            this._selectedMovie = TitleTextBox.Text;
            NextButton.Enabled = true;
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

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.selection[0] = TitleTextBox.Text;
            Program.selection[1] = CategoryTextBox.Text;
            Program.selection[2] = CostTextBox.Text;
            Program.selection[3] = SelectionPictureBox.Image.ToString();
            OrderForm orderForm = new MovieBonanza_OnlineStream.OrderForm();
            orderForm.Show();
            this.Hide();
        }
    }
}
