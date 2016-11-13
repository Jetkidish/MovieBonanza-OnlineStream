namespace MovieBonanza_OnlineStream
{
    partial class StreamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ThanksLabel = new System.Windows.Forms.Label();
            this.CreditChargeLabel = new System.Windows.Forms.Label();
            this.MovieLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ThanksLabel
            // 
            this.ThanksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThanksLabel.Location = new System.Drawing.Point(12, 9);
            this.ThanksLabel.Name = "ThanksLabel";
            this.ThanksLabel.Size = new System.Drawing.Size(429, 49);
            this.ThanksLabel.TabIndex = 0;
            this.ThanksLabel.Text = "Thanks for choosing Movie Bonanza!";
            this.ThanksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreditChargeLabel
            // 
            this.CreditChargeLabel.Location = new System.Drawing.Point(12, 58);
            this.CreditChargeLabel.Name = "CreditChargeLabel";
            this.CreditChargeLabel.Size = new System.Drawing.Size(429, 27);
            this.CreditChargeLabel.TabIndex = 1;
            this.CreditChargeLabel.Text = "Your Credit Card will be charged [x]";
            this.CreditChargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MovieLabel
            // 
            this.MovieLabel.Location = new System.Drawing.Point(15, 89);
            this.MovieLabel.Name = "MovieLabel";
            this.MovieLabel.Size = new System.Drawing.Size(426, 23);
            this.MovieLabel.TabIndex = 2;
            this.MovieLabel.Text = "[movie] will begin streaming shortly";
            this.MovieLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(189, 115);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 148);
            this.ControlBox = false;
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.MovieLabel);
            this.Controls.Add(this.CreditChargeLabel);
            this.Controls.Add(this.ThanksLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StreamForm";
            this.ShowIcon = false;
            this.Text = "Your Movie is about to start!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ThanksLabel;
        private System.Windows.Forms.Label CreditChargeLabel;
        private System.Windows.Forms.Label MovieLabel;
        private System.Windows.Forms.Button OkButton;
    }
}