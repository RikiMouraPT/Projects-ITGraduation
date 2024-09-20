namespace _009___Projeto_Final
{
    partial class formCriarConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCriarConta));
            panel1 = new Panel();
            btnSair = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panelUsername = new Panel();
            txtUsername = new TextBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panelPassword = new Panel();
            pwdHide = new PictureBox();
            pwdView = new PictureBox();
            txtPassword = new TextBox();
            pictureBox3 = new PictureBox();
            btnCriarConta = new Button();
            btnCancelar = new Button();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pwdHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pwdView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 70, 116);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 11;
            // 
            // btnSair
            // 
            btnSair.Cursor = Cursors.Hand;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 225, 232);
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(751, 0);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(49, 50);
            btnSair.TabIndex = 9;
            btnSair.Text = "X";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 34);
            label1.TabIndex = 8;
            label1.Text = "Criar Conta";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(48, 70, 116);
            label3.Location = new Point(49, 178);
            label3.Name = "label3";
            label3.Size = new Size(132, 34);
            label3.TabIndex = 13;
            label3.Text = "Password";
            // 
            // panelUsername
            // 
            panelUsername.BackColor = Color.White;
            panelUsername.Controls.Add(txtUsername);
            panelUsername.Controls.Add(pictureBox2);
            panelUsername.Location = new Point(49, 112);
            panelUsername.Name = "panelUsername";
            panelUsername.Size = new Size(500, 50);
            panelUsername.TabIndex = 14;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(48, 70, 116);
            label2.Location = new Point(49, 71);
            label2.Name = "label2";
            label2.Size = new Size(141, 34);
            label2.TabIndex = 12;
            label2.Text = "Username";
            // 
            // panelPassword
            // 
            panelPassword.BackColor = Color.White;
            panelPassword.Controls.Add(pwdHide);
            panelPassword.Controls.Add(pwdView);
            panelPassword.Controls.Add(txtPassword);
            panelPassword.Controls.Add(pictureBox3);
            panelPassword.Location = new Point(49, 219);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(500, 50);
            panelPassword.TabIndex = 15;
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
            // btnCriarConta
            // 
            btnCriarConta.BackColor = Color.FromArgb(48, 70, 116);
            btnCriarConta.Cursor = Cursors.Hand;
            btnCriarConta.FlatAppearance.BorderSize = 0;
            btnCriarConta.FlatStyle = FlatStyle.Flat;
            btnCriarConta.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCriarConta.ForeColor = Color.White;
            btnCriarConta.Location = new Point(258, 388);
            btnCriarConta.Name = "btnCriarConta";
            btnCriarConta.Size = new Size(150, 50);
            btnCriarConta.TabIndex = 16;
            btnCriarConta.Text = "Criar Conta";
            btnCriarConta.UseVisualStyleBackColor = false;
            btnCriarConta.Click += btnCriarConta_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(48, 70, 116);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(638, 388);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 50);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.CheckAlign = ContentAlignment.MiddleRight;
            checkBox1.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.FromArgb(48, 70, 116);
            checkBox1.Location = new Point(49, 275);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(208, 38);
            checkBox1.TabIndex = 18;
            checkBox1.Text = "Administrador";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // formCriarConta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 225, 232);
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnCriarConta);
            Controls.Add(panelPassword);
            Controls.Add(panelUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(48, 70, 116);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formCriarConta";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formCriarConta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelUsername.ResumeLayout(false);
            panelUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pwdHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pwdView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnSair;
        private Label label3;
        private Panel panelUsername;
        private TextBox txtUsername;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panelPassword;
        private PictureBox pwdHide;
        private PictureBox pwdView;
        private TextBox txtPassword;
        private PictureBox pictureBox3;
        private Button btnCriarConta;
        private Button btnCancelar;
        private CheckBox checkBox1;
    }
}