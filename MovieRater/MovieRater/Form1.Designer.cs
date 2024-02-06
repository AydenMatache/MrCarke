namespace MovieRater
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.creatorLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.creatorTextBox = new System.Windows.Forms.TextBox();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            this.revenueLabel = new System.Windows.Forms.Label();
            this.characterLabel = new System.Windows.Forms.Label();
            this.revenueTextBox = new System.Windows.Forms.TextBox();
            this.characterTextBox = new System.Windows.Forms.TextBox();
            this.picturePathLabel = new System.Windows.Forms.Label();
            this.picturePathTextBox = new System.Windows.Forms.TextBox();
            this.loadPictureButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();

            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 39);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(35, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title:";
            // 
            // creatorLabel
            // 
            this.creatorLabel.AutoSize = true;
            this.creatorLabel.Location = new System.Drawing.Point(12, 65);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(47, 13);
            this.creatorLabel.TabIndex = 2;
            this.creatorLabel.Text = "Creator:";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(12, 91);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(41, 13);
            this.ratingLabel.TabIndex = 3;
            this.ratingLabel.Text = "Rating:";
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePictureBox.Location = new System.Drawing.Point(272, 39);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(248, 170);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 4;
            this.imagePictureBox.TabStop = false;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(77, 36);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(189, 20);
            this.titleTextBox.TabIndex = 5;
            // 
            // creatorTextBox
            // 
            this.creatorTextBox.Location = new System.Drawing.Point(77, 62);
            this.creatorTextBox.Name = "creatorTextBox";
            this.creatorTextBox.Size = new System.Drawing.Size(189, 20);
            this.creatorTextBox.TabIndex = 6;
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ratingComboBox.FormattingEnabled = true;
            this.ratingComboBox.Items.AddRange(new object[] {
            "Poor",
            "Average",
            "Good",
            "Excellent"});
            this.ratingComboBox.Location = new System.Drawing.Point(77, 88);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(121, 21);
            this.ratingComboBox.TabIndex = 7;
            // 
            // revenueLabel
            // 
            this.revenueLabel.AutoSize = true;
            this.revenueLabel.Location = new System.Drawing.Point(12, 119);
            this.revenueLabel.Name = "revenueLabel";
            this.revenueLabel.Size = new System.Drawing.Size(52, 13);
            this.revenueLabel.TabIndex = 8;
            this.revenueLabel.Text = "Revenue:";
            // 
            // characterLabel
            // 
            this.characterLabel.AutoSize = true;
            this.characterLabel.Location = new System.Drawing.Point(12, 145);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(57, 13);
            this.characterLabel.TabIndex = 9;
            this.characterLabel.Text = "Character:";
            // 
            // revenueTextBox
            // 
            this.revenueTextBox.Location = new System.Drawing.Point(77, 116);
            this.revenueTextBox.Name = "revenueTextBox";
            this.revenueTextBox.Size = new System.Drawing.Size(100, 20);
            this.revenueTextBox.TabIndex = 10;
            // 
            // characterTextBox
            // 
            this.characterTextBox.Location = new System.Drawing.Point(77, 142);
            this.characterTextBox.Name = "characterTextBox";
            this.characterTextBox.Size = new System.Drawing.Size(189, 20);
            this.characterTextBox.TabIndex = 11;
            // 
            // picturePathLabel
            // 
            this.picturePathLabel.AutoSize = true;
            this.picturePathLabel.Location = new System.Drawing.Point(12, 171);
            this.picturePathLabel.Name = "picturePathLabel";
            this.picturePathLabel.Size = new System.Drawing.Size(68, 13);
            this.picturePathLabel.TabIndex = 12;
            this.picturePathLabel.Text = "Picture Path:";
            // 
            // picturePathTextBox
            // 
            this.picturePathTextBox.Location = new System.Drawing.Point(12, 187);
            this.picturePathTextBox.Name = "picturePathTextBox";
            this.picturePathTextBox.Size = new System.Drawing.Size(179, 20);
            this.picturePathTextBox.TabIndex = 13;
            // 
            // loadPictureButton
            // 
            this.loadPictureButton.Location = new System.Drawing.Point(197, 185);
            this.loadPictureButton.Name = "loadPictureButton";
            this.loadPictureButton.Size = new System.Drawing.Size(75, 23);
            this.loadPictureButton.TabIndex = 14;
            this.loadPictureButton.Text = "Load";
            this.loadPictureButton.UseVisualStyleBackColor = true;
            //this.loadPictureButton.Click += new System.EventHandler(this.loadPictureButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(15, 213);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // MainForm
            // 


        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label creatorLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox creatorTextBox;
        private System.Windows.Forms.ComboBox ratingComboBox;
        private System.Windows.Forms.Label revenueLabel;
        private System.Windows.Forms.Label characterLabel;
        private System.Windows.Forms.TextBox revenueTextBox;
        private System.Windows.Forms.TextBox characterTextBox;
        private System.Windows.Forms.Label picturePathLabel;
        private System.Windows.Forms.TextBox picturePathTextBox;
        private System.Windows.Forms.Button loadPictureButton;
        private System.Windows.Forms.Button saveButton;
    }
}


