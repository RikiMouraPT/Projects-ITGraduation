namespace _009___Projeto_Final
{
    partial class formMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMenu));
            btnFormVendedores = new Button();
            btnFormProdutos = new Button();
            btnFormVendas = new Button();
            btnFormAnalises = new Button();
            panel1 = new Panel();
            label1 = new Label();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnLogOut = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnFormVendedores
            // 
            btnFormVendedores.BackColor = Color.FromArgb(48, 70, 116);
            btnFormVendedores.FlatAppearance.BorderSize = 0;
            btnFormVendedores.FlatStyle = FlatStyle.Flat;
            btnFormVendedores.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnFormVendedores.ForeColor = Color.White;
            btnFormVendedores.Location = new Point(160, 168);
            btnFormVendedores.Name = "btnFormVendedores";
            btnFormVendedores.Size = new Size(200, 200);
            btnFormVendedores.TabIndex = 0;
            btnFormVendedores.Text = "Vendedores";
            btnFormVendedores.UseVisualStyleBackColor = false;
            btnFormVendedores.Click += btnFormVendedores_Click;
            // 
            // btnFormProdutos
            // 
            btnFormProdutos.BackColor = Color.FromArgb(48, 70, 116);
            btnFormProdutos.Enabled = false;
            btnFormProdutos.FlatAppearance.BorderSize = 0;
            btnFormProdutos.FlatStyle = FlatStyle.Flat;
            btnFormProdutos.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnFormProdutos.ForeColor = Color.White;
            btnFormProdutos.Location = new Point(160, 411);
            btnFormProdutos.Name = "btnFormProdutos";
            btnFormProdutos.Size = new Size(200, 200);
            btnFormProdutos.TabIndex = 1;
            btnFormProdutos.Text = "Produtos";
            btnFormProdutos.UseVisualStyleBackColor = false;
            btnFormProdutos.Click += btnFormProdutos_Click;
            // 
            // btnFormVendas
            // 
            btnFormVendas.BackColor = Color.FromArgb(48, 70, 116);
            btnFormVendas.Enabled = false;
            btnFormVendas.FlatAppearance.BorderSize = 0;
            btnFormVendas.FlatStyle = FlatStyle.Flat;
            btnFormVendas.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnFormVendas.ForeColor = Color.White;
            btnFormVendas.Location = new Point(515, 168);
            btnFormVendas.Name = "btnFormVendas";
            btnFormVendas.Size = new Size(200, 200);
            btnFormVendas.TabIndex = 2;
            btnFormVendas.Text = "Vendas";
            btnFormVendas.UseVisualStyleBackColor = false;
            btnFormVendas.Click += btnFormVendas_Click;
            // 
            // btnFormAnalises
            // 
            btnFormAnalises.BackColor = Color.FromArgb(48, 70, 116);
            btnFormAnalises.FlatAppearance.BorderSize = 0;
            btnFormAnalises.FlatStyle = FlatStyle.Flat;
            btnFormAnalises.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnFormAnalises.ForeColor = Color.White;
            btnFormAnalises.Location = new Point(515, 411);
            btnFormAnalises.Name = "btnFormAnalises";
            btnFormAnalises.Size = new Size(200, 200);
            btnFormAnalises.TabIndex = 3;
            btnFormAnalises.Text = "Analises";
            btnFormAnalises.UseVisualStyleBackColor = false;
            btnFormAnalises.Click += btnFormAnalises_Click;
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
            panel1.Size = new Size(850, 50);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 9);
            label1.Name = "label1";
            label1.Size = new Size(240, 34);
            label1.TabIndex = 8;
            label1.Text = "Gestão de Vendas";
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 225, 232);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(801, 0);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(49, 50);
            btnExit.TabIndex = 5;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(48, 70, 116);
            label2.Location = new Point(0, 53);
            label2.Name = "label2";
            label2.Size = new Size(196, 72);
            label2.TabIndex = 11;
            label2.Text = "Menu";
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(48, 70, 116);
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(670, 638);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(180, 62);
            btnLogOut.TabIndex = 12;
            btnLogOut.Text = "LogOut";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // formMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 211, 227);
            ClientSize = new Size(850, 700);
            Controls.Add(btnLogOut);
            Controls.Add(btnFormAnalises);
            Controls.Add(btnFormProdutos);
            Controls.Add(label2);
            Controls.Add(btnFormVendas);
            Controls.Add(panel1);
            Controls.Add(btnFormVendedores);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formMenu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFormVendedores;
        private Button btnFormProdutos;
        private Button btnFormVendas;
        private Button btnFormAnalises;
        private Panel panel1;
        private Label label1;
        private Button btnExit;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnLogOut;
    }
}