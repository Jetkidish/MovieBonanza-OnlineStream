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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            this.OrderForm_Load();
        }
        private void OrderForm_Load()
        {
            TitleTextBox.Text = Program.selection[0];
            CategoryTextBox.Text = Program.selection[1];
            CostTextBox.Text = Program.selection[2];
            
        }
        private void OptionalDVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void streamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
