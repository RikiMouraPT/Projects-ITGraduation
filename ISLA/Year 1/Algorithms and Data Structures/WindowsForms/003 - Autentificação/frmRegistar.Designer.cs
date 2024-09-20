namespace _003___Autentificação
{
    partial class frmRegistar
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
            btnSair = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtRetypePassword = new TextBox();
            btnRegistar = new Button();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.Location = new Point(626, 360);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(162, 78);
            btnSair.TabIndex = 0;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(87, 185);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(300, 34);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(87, 279);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(300, 34);
            txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(266, 9);
            label1.Name = "label1";
            label1.Size = new Size(307, 106);
            label1.TabIndex = 3;
            label1.Text = "Registo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(87, 154);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(87, 248);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(419, 248);
            label4.Name = "label4";
            label4.Size = new Size(158, 28);
            label4.TabIndex = 7;
            label4.Text = "Retype Password";
            // 
            // txtRetypePassword
            // 
            txtRetypePassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRetypePassword.Location = new Point(419, 279);
            txtRetypePassword.Name = "txtRetypePassword";
            txtRetypePassword.PlaceholderText = "Retype Password";
            txtRetypePassword.Size = new Size(300, 34);
            txtRetypePassword.TabIndex = 6;
            // 
            // btnRegistar
            // 
            btnRegistar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistar.Location = new Point(324, 360);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(162, 78);
            btnRegistar.TabIndex = 8;
            btnRegistar.Text = "Registar";
            btnRegistar.UseVisualStyleBackColor = true;
            btnRegistar.Click += btnRegistar_Click;
            // 
            // frmRegistar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistar);
            Controls.Add(label4);
            Controls.Add(txtRetypePassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnSair);
            Name = "frmRegistar";
            Text = "Registar Novas Credencias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSair;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtRetypePassword;
        private Button btnRegistar;
    }
}