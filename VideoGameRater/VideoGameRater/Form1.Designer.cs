namespace VideoGameRater
{
    partial class Form1
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
            this.titleTbox = new System.Windows.Forms.TextBox();
            this.creatorTbox = new System.Windows.Forms.TextBox();
            this.revenueTbox = new System.Windows.Forms.TextBox();
            this.characterActorTbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleTbox
            // 
            this.titleTbox.Location = new System.Drawing.Point(172, 72);
            this.titleTbox.Name = "titleTbox";
            this.titleTbox.Size = new System.Drawing.Size(99, 22);
            this.titleTbox.TabIndex = 0;
            // 
            // creatorTbox
            // 
            this.creatorTbox.Location = new System.Drawing.Point(172, 100);
            this.creatorTbox.Name = "creatorTbox";
            this.creatorTbox.Size = new System.Drawing.Size(99, 22);
            this.creatorTbox.TabIndex = 1;
            // 
            // revenueTbox
            // 
            this.revenueTbox.Location = new System.Drawing.Point(172, 128);
            this.revenueTbox.Name = "revenueTbox";
            this.revenueTbox.Size = new System.Drawing.Size(99, 22);
            this.revenueTbox.TabIndex = 2;
            // 
            // characterActorTbox
            // 
            this.characterActorTbox.Location = new System.Drawing.Point(172, 156);
            this.characterActorTbox.Name = "characterActorTbox";
            this.characterActorTbox.Size = new System.Drawing.Size(99, 22);
            this.characterActorTbox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(606, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 95);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.FormattingEnabled = true;
            this.ratingComboBox.Location = new System.Drawing.Point(172, 184);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(121, 24);
            this.ratingComboBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ratingComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.characterActorTbox);
            this.Controls.Add(this.revenueTbox);
            this.Controls.Add(this.creatorTbox);
            this.Controls.Add(this.titleTbox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTbox;
        private System.Windows.Forms.TextBox creatorTbox;
        private System.Windows.Forms.TextBox revenueTbox;
        private System.Windows.Forms.TextBox characterActorTbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ratingComboBox;
    }
}

