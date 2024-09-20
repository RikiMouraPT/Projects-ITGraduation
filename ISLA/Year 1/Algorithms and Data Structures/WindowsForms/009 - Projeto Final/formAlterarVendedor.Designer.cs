namespace _009___Projeto_Final
{
    partial class formAlterarVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAlterarVendedor));
            panel1 = new Panel();
            label1 = new Label();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            btnCancelar = new Button();
            btnAlterar = new Button();
            panelPassword = new Panel();
            txtComissao = new TextBox();
            pictureBox3 = new PictureBox();
            panelUsername = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panelUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 70, 116);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 9);
            label1.Name = "label1";
            label1.Size = new Size(224, 34);
            label1.TabIndex = 8;
            label1.Text = "Alterar Vendedor";
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 225, 232);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(750, -1);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 5;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
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
            // comboBox1
            // 
            comboBox1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(56, 9);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(388, 32);
            comboBox1.TabIndex = 12;
            comboBox1.Text = "Vendedor";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(48, 70, 116);
            label2.Location = new Point(49, 81);
            label2.Name = "label2";
            label2.Size = new Size(133, 34);
            label2.TabIndex = 20;
            label2.Text = "Vendedor";
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
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(48, 70, 116);
            btnAlterar.Cursor = Cursors.Hand;
            btnAlterar.FlatAppearance.BorderSize = 0;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlterar.ForeColor = Color.White;
            btnAlterar.Location = new Point(258, 388);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(150, 50);
            btnAlterar.TabIndex = 26;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // panelPassword
            // 
            panelPassword.BackColor = Color.White;
            panelPassword.Controls.Add(txtComissao);
            panelPassword.Controls.Add(pictureBox3);
            panelPassword.Location = new Point(49, 227);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(500, 50);
            panelPassword.TabIndex = 30;
            // 
            // txtComissao
            // 
            txtComissao.BorderStyle = BorderStyle.None;
            txtComissao.Enabled = false;
            txtComissao.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtComissao.ForeColor = Color.FromArgb(48, 70, 116);
            txtComissao.Location = new Point(56, 14);
            txtComissao.Name = "txtComissao";
            txtComissao.PlaceholderText = "Comissão | 0-99%";
            txtComissao.Size = new Size(388, 25);
            txtComissao.TabIndex = 11;
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
            panelUsername.Controls.Add(pictureBox2);
            panelUsername.Controls.Add(comboBox1);
            panelUsername.Location = new Point(49, 118);
            panelUsername.Name = "panelUsername";
            panelUsername.Size = new Size(500, 50);
            panelUsername.TabIndex = 29;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(48, 70, 116);
            label3.Location = new Point(49, 189);
            label3.Name = "label3";
            label3.Size = new Size(133, 34);
            label3.TabIndex = 28;
            label3.Text = "Comissão";
            // 
            // formAlterarVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(216, 225, 232);
            ClientSize = new Size(800, 450);
            Controls.Add(panelPassword);
            Controls.Add(panelUsername);
            Controls.Add(label3);
            Controls.Add(btnAlterar);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formAlterarVendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formAlterarVendedor";
            Load += formAlterarVendedor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panelUsername.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnExit;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label2;
        private Button btnCancelar;
        private Button btnAlterar;
        private Panel panelPassword;
        private TextBox txtComissao;
        private PictureBox pictureBox3;
        private Panel panelUsername;
        private PictureBox pictureBox2;
        private Label label3;
    }
}