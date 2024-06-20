namespace _003___Autentificação
{
    partial class formAutenticacao
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAutenticacao));
            btnLogin = new Button();
            btnExit = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pwdHide = new PictureBox();
            pwdView = new PictureBox();
            btnRegistar = new Button();
            ((System.ComponentModel.ISupportInitialize)pwdHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pwdView).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Akroma", 26F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(645, 192);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(225, 149);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Akroma", 26F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(705, 381);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(165, 60);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Tahoma", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(240, 197);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Type your username";
            txtUsername.Size = new Size(399, 52);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Tahoma", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(240, 285);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Type your password";
            txtPassword.Size = new Size(399, 52);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Akroma", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 195);
            label1.Name = "label1";
            label1.Size = new Size(201, 59);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Akroma", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 283);
            label2.Name = "label2";
            label2.Size = new Size(213, 59);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Akroma", 64F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(109, 9);
            label3.Name = "label3";
            label3.Size = new Size(677, 141);
            label3.TabIndex = 6;
            label3.Text = "Autenticação";
            // 
            // pwdHide
            // 
            pwdHide.Cursor = Cursors.Hand;
            pwdHide.Image = (Image)resources.GetObject("pwdHide.Image");
            pwdHide.Location = new Point(240, 337);
            pwdHide.Margin = new Padding(3, 5, 3, 5);
            pwdHide.Name = "pwdHide";
            pwdHide.Size = new Size(50, 50);
            pwdHide.SizeMode = PictureBoxSizeMode.StretchImage;
            pwdHide.TabIndex = 14;
            pwdHide.TabStop = false;
            pwdHide.MouseDown += pwdHide_MouseDown;
            pwdHide.MouseUp += pwdHide_MouseUp;
            // 
            // pwdView
            // 
            pwdView.Image = (Image)resources.GetObject("pwdView.Image");
            pwdView.Location = new Point(240, 337);
            pwdView.Margin = new Padding(3, 4, 3, 4);
            pwdView.Name = "pwdView";
            pwdView.Size = new Size(50, 50);
            pwdView.SizeMode = PictureBoxSizeMode.StretchImage;
            pwdView.TabIndex = 15;
            pwdView.TabStop = false;
            // 
            // btnRegistar
            // 
            btnRegistar.Font = new Font("Akroma", 26F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistar.Location = new Point(348, 381);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(226, 60);
            btnRegistar.TabIndex = 16;
            btnRegistar.Text = "Registar";
            btnRegistar.UseVisualStyleBackColor = true;
            btnRegistar.Click += btnRegistar_Click_1;
            // 
            // formAutenticacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 453);
            Controls.Add(btnRegistar);
            Controls.Add(pwdHide);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(pwdView);
            Name = "formAutenticacao";
            Text = "Autenticação";
            ((System.ComponentModel.ISupportInitialize)pwdHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pwdView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnExit;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pwdHide;
        private PictureBox pwdView;
        private Button btnRegistar;
    }
}
