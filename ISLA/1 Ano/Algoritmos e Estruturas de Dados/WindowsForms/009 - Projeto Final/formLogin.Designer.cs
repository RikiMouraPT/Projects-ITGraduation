namespace _009___Projeto_Final
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            panel1 = new Panel();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            panel2 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnCriarConta = new Button();
            btnLogin = new Button();
            panelPassword = new Panel();
            pwdHide = new PictureBox();
            pwdView = new PictureBox();
            txtPassword = new TextBox();
            pictureBox3 = new PictureBox();
            panelUsername = new Panel();
            txtUsername = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pwdHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pwdView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 70, 116);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 700);
            panel1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(2, 332);
            label5.Name = "label5";
            label5.Size = new Size(339, 48);
            label5.TabIndex = 8;
            label5.Text = "Gestão de Vendas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(140, 674);
            label3.Name = "label3";
            label3.Size = new Size(200, 20);
            label3.TabIndex = 7;
            label3.Text = "Ricardo Moura e Vitor Rocha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(275, 656);
            label2.Name = "label2";
            label2.Size = new Size(65, 18);
            label2.TabIndex = 6;
            label2.Text = "Feito Por";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(66, 284);
            label4.Name = "label4";
            label4.Size = new Size(213, 48);
            label4.TabIndex = 5;
            label4.Text = "Bem-Vindo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(94, 80);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 225, 232);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(48, 70, 116);
            btnExit.Location = new Point(804, 0);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(46, 53);
            btnExit.TabIndex = 4;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(198, 211, 227);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnCriarConta);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(panelPassword);
            panel2.Controls.Add(panelUsername);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnExit);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 700);
            panel2.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(48, 70, 116);
            label8.Location = new Point(722, 102);
            label8.Name = "label8";
            label8.Size = new Size(106, 24);
            label8.TabIndex = 12;
            label8.Text = "2023/2024";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(48, 70, 116);
            label7.Location = new Point(371, 66);
            label7.Name = "label7";
            label7.Size = new Size(457, 36);
            label7.TabIndex = 11;
            label7.Text = "Algoritmos e Estruturas de Dados";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(48, 70, 116);
            label6.Location = new Point(472, 18);
            label6.Name = "label6";
            label6.Size = new Size(240, 48);
            label6.TabIndex = 10;
            label6.Text = "Projeto Final";
            // 
            // btnCriarConta
            // 
            btnCriarConta.BackColor = Color.FromArgb(198, 211, 227);
            btnCriarConta.Cursor = Cursors.Hand;
            btnCriarConta.FlatAppearance.BorderSize = 0;
            btnCriarConta.FlatStyle = FlatStyle.Flat;
            btnCriarConta.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCriarConta.ForeColor = Color.FromArgb(48, 70, 116);
            btnCriarConta.Location = new Point(644, 417);
            btnCriarConta.Name = "btnCriarConta";
            btnCriarConta.Size = new Size(150, 50);
            btnCriarConta.TabIndex = 9;
            btnCriarConta.Text = "Criar Conta";
            btnCriarConta.UseVisualStyleBackColor = false;
            btnCriarConta.Click += btnCriarConta_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(48, 70, 116);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(431, 417);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 50);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panelPassword
            // 
            panelPassword.BackColor = Color.White;
            panelPassword.Controls.Add(pwdHide);
            panelPassword.Controls.Add(pwdView);
            panelPassword.Controls.Add(txtPassword);
            panelPassword.Controls.Add(pictureBox3);
            panelPassword.Location = new Point(350, 341);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(500, 50);
            panelPassword.TabIndex = 7;
            // 
            // pwdHide
            // 
            pwdHide.Cursor = Cursors.Hand;
            pwdHide.Image = (Image)resources.GetObject("pwdHide.Image");
            pwdHide.Location = new Point(450, 0);
            pwdHide.Margin = new Padding(3, 4, 3, 4);
            pwdHide.Name = "pwdHide";
            pwdHide.Size = new Size(50, 50);
            pwdHide.SizeMode = PictureBoxSizeMode.StretchImage;
            pwdHide.TabIndex = 13;
            pwdHide.TabStop = false;
            pwdHide.MouseDown += pwdHide_MouseDown;
            pwdHide.MouseUp += pwdHide_MouseUp;
            // 
            // pwdView
            // 
            pwdView.Image = (Image)resources.GetObject("pwdView.Image");
            pwdView.Location = new Point(450, 0);
            pwdView.Margin = new Padding(3, 4, 3, 4);
            pwdView.Name = "pwdView";
            pwdView.Size = new Size(50, 50);
            pwdView.SizeMode = PictureBoxSizeMode.StretchImage;
            pwdView.TabIndex = 12;
            pwdView.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.FromArgb(48, 70, 116);
            txtPassword.Location = new Point(56, 14);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(388, 25);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // panelUsername
            // 
            panelUsername.BackColor = Color.White;
            panelUsername.Controls.Add(txtUsername);
            panelUsername.Controls.Add(pictureBox2);
            panelUsername.Location = new Point(350, 257);
            panelUsername.Name = "panelUsername";
            panelUsername.Size = new Size(500, 50);
            panelUsername.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.FromArgb(48, 70, 116);
            txtUsername.Location = new Point(56, 13);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(388, 25);
            txtUsername.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(48, 70, 116);
            label1.Location = new Point(350, 191);
            label1.Name = "label1";
            label1.Size = new Size(115, 48);
            label1.TabIndex = 5;
            label1.Text = "Login";
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(178, 203, 222);
            ClientSize = new Size(850, 700);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pwdHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pwdView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelUsername.ResumeLayout(false);
            panelUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnExit;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private Panel panel2;
        private Panel panelUsername;
        private Label label1;
        private Panel panelPassword;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private PictureBox pwdHide;
        private PictureBox pwdView;
        private Button btnLogin;
        private Button btnCriarConta;
        private Label label7;
        private Label label6;
        private Label label8;
    }
}
