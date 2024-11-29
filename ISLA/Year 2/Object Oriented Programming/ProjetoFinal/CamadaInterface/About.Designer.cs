namespace CamadaInterface
{
    partial class About
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.subTitleLabel = new System.Windows.Forms.Label();
            this.changeFontComboBox = new System.Windows.Forms.ComboBox();
            this.changeFontLabel = new System.Windows.Forms.Label();
            this.changeTextColorComboBox = new System.Windows.Forms.ComboBox();
            this.changeTextColorLabel = new System.Windows.Forms.Label();
            this.changeBackgroundColorComboBox = new System.Windows.Forms.ComboBox();
            this.changeBackgroundColorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(415, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Programação Orientada a Objetos *";
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Location = new System.Drawing.Point(526, 428);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(262, 13);
            this.copyrightLabel.TabIndex = 1;
            this.copyrightLabel.Text = "Copyright © 2024 Ricardo Moura, All rights reserved. *";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 106);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(65, 20);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name: *";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(12, 138);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(79, 20);
            this.numberLabel.TabIndex = 5;
            this.numberLabel.Text = "Number: *";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(83, 103);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(159, 26);
            this.nameTextBox.TabIndex = 6;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTextBox.Location = new System.Drawing.Point(83, 135);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(159, 26);
            this.numberTextBox.TabIndex = 7;
            // 
            // subTitleLabel
            // 
            this.subTitleLabel.AutoSize = true;
            this.subTitleLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.subTitleLabel.Location = new System.Drawing.Point(12, 48);
            this.subTitleLabel.Name = "subTitleLabel";
            this.subTitleLabel.Size = new System.Drawing.Size(155, 26);
            this.subTitleLabel.TabIndex = 8;
            this.subTitleLabel.Text = "Projeto Final *";
            // 
            // changeFontComboBox
            // 
            this.changeFontComboBox.FormattingEnabled = true;
            this.changeFontComboBox.Location = new System.Drawing.Point(12, 417);
            this.changeFontComboBox.Name = "changeFontComboBox";
            this.changeFontComboBox.Size = new System.Drawing.Size(155, 21);
            this.changeFontComboBox.TabIndex = 9;
            this.changeFontComboBox.SelectedIndexChanged += new System.EventHandler(this.fontComboBox_SelectedIndexChanged);
            // 
            // changeFontLabel
            // 
            this.changeFontLabel.AutoSize = true;
            this.changeFontLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeFontLabel.Location = new System.Drawing.Point(8, 394);
            this.changeFontLabel.Name = "changeFontLabel";
            this.changeFontLabel.Size = new System.Drawing.Size(116, 20);
            this.changeFontLabel.TabIndex = 10;
            this.changeFontLabel.Text = "Change Font: *";
            // 
            // changeTextColorComboBox
            // 
            this.changeTextColorComboBox.FormattingEnabled = true;
            this.changeTextColorComboBox.Location = new System.Drawing.Point(173, 417);
            this.changeTextColorComboBox.Name = "changeTextColorComboBox";
            this.changeTextColorComboBox.Size = new System.Drawing.Size(150, 21);
            this.changeTextColorComboBox.TabIndex = 11;
            this.changeTextColorComboBox.SelectedIndexChanged += new System.EventHandler(this.changeTextColorComboBox_SelectedIndexChanged);
            // 
            // changeTextColorLabel
            // 
            this.changeTextColorLabel.AutoSize = true;
            this.changeTextColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeTextColorLabel.Location = new System.Drawing.Point(169, 394);
            this.changeTextColorLabel.Name = "changeTextColorLabel";
            this.changeTextColorLabel.Size = new System.Drawing.Size(154, 20);
            this.changeTextColorLabel.TabIndex = 12;
            this.changeTextColorLabel.Text = "Change Text Color: *";
            // 
            // changeBackgroundColorComboBox
            // 
            this.changeBackgroundColorComboBox.FormattingEnabled = true;
            this.changeBackgroundColorComboBox.Location = new System.Drawing.Point(329, 417);
            this.changeBackgroundColorComboBox.Name = "changeBackgroundColorComboBox";
            this.changeBackgroundColorComboBox.Size = new System.Drawing.Size(184, 21);
            this.changeBackgroundColorComboBox.TabIndex = 13;
            this.changeBackgroundColorComboBox.SelectedIndexChanged += new System.EventHandler(this.changeBackgroundColorComboBox_SelectedIndexChanged);
            // 
            // changeBackgroundColorLabel
            // 
            this.changeBackgroundColorLabel.AutoSize = true;
            this.changeBackgroundColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBackgroundColorLabel.Location = new System.Drawing.Point(325, 394);
            this.changeBackgroundColorLabel.Name = "changeBackgroundColorLabel";
            this.changeBackgroundColorLabel.Size = new System.Drawing.Size(210, 20);
            this.changeBackgroundColorLabel.TabIndex = 14;
            this.changeBackgroundColorLabel.Text = "Change Background Color: *";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeBackgroundColorLabel);
            this.Controls.Add(this.changeBackgroundColorComboBox);
            this.Controls.Add(this.changeTextColorLabel);
            this.Controls.Add(this.changeTextColorComboBox);
            this.Controls.Add(this.changeFontLabel);
            this.Controls.Add(this.changeFontComboBox);
            this.Controls.Add(this.subTitleLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "About";
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label subTitleLabel;
        private System.Windows.Forms.ComboBox changeFontComboBox;
        private System.Windows.Forms.Label changeFontLabel;
        private System.Windows.Forms.ComboBox changeTextColorComboBox;
        private System.Windows.Forms.Label changeTextColorLabel;
        private System.Windows.Forms.ComboBox changeBackgroundColorComboBox;
        private System.Windows.Forms.Label changeBackgroundColorLabel;
    }
}