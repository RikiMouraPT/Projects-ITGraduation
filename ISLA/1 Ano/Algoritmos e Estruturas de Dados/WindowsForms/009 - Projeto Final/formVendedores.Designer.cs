namespace _009___Projeto_Final
{
    partial class formVendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVendedores));
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            btnVoltar = new Button();
            label1 = new Label();
            panel1 = new Panel();
            listVendedores = new ListView();
            Código = new ColumnHeader();
            Nome = new ColumnHeader();
            Comissão = new ColumnHeader();
            panel2 = new Panel();
            txtValor = new TextBox();
            btnCalcular = new Button();
            comboBox1 = new ComboBox();
            btnInserir = new Button();
            btnAlterar = new Button();
            btnEliminar = new Button();
            label2 = new Label();
            label3 = new Label();
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(48, 70, 116);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltar.ForeColor = SystemColors.ButtonHighlight;
            btnVoltar.Location = new Point(12, 638);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(125, 50);
            btnVoltar.TabIndex = 7;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
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
            panel1.TabIndex = 9;
            // 
            // listVendedores
            // 
            listVendedores.Columns.AddRange(new ColumnHeader[] { Código, Nome, Comissão });
            listVendedores.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            listVendedores.FullRowSelect = true;
            listVendedores.Location = new Point(151, 116);
            listVendedores.Name = "listVendedores";
            listVendedores.Size = new Size(682, 414);
            listVendedores.TabIndex = 10;
            listVendedores.UseCompatibleStateImageBehavior = false;
            listVendedores.View = View.Details;
            // 
            // Código
            // 
            Código.Text = "Código";
            Código.Width = 100;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 450;
            // 
            // Comissão
            // 
            Comissão.Text = "Comissão";
            Comissão.Width = 128;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(178, 203, 222);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(txtValor);
            panel2.Controls.Add(btnCalcular);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new Point(12, 582);
            panel2.Name = "panel2";
            panel2.Size = new Size(826, 50);
            panel2.TabIndex = 11;
            // 
            // txtValor
            // 
            txtValor.Enabled = false;
            txtValor.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor.Location = new Point(569, 5);
            txtValor.Name = "txtValor";
            txtValor.PlaceholderText = "Valor";
            txtValor.Size = new Size(250, 35);
            txtValor.TabIndex = 14;
            txtValor.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(48, 70, 116);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(259, 5);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(304, 36);
            btnCalcular.TabIndex = 13;
            btnCalcular.Text = "Calcular Comissão";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 5);
            comboBox1.MaxDropDownItems = 30;
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 36);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 12;
            comboBox1.Text = "Vendedor";
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.FromArgb(48, 70, 116);
            btnInserir.FlatAppearance.BorderSize = 0;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnInserir.ForeColor = Color.White;
            btnInserir.Location = new Point(3, 116);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(142, 75);
            btnInserir.TabIndex = 12;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.FromArgb(48, 70, 116);
            btnAlterar.FlatAppearance.BorderSize = 0;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlterar.ForeColor = Color.White;
            btnAlterar.Location = new Point(3, 197);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(142, 75);
            btnAlterar.TabIndex = 13;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(48, 70, 116);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(3, 278);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(142, 75);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(48, 70, 116);
            label2.Location = new Point(151, 56);
            label2.Name = "label2";
            label2.Size = new Size(304, 57);
            label2.TabIndex = 15;
            label2.Text = "Vendedores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(48, 70, 116);
            label3.Location = new Point(12, 534);
            label3.Name = "label3";
            label3.Size = new Size(340, 45);
            label3.TabIndex = 16;
            label3.Text = "Comissão Vendedor";
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.FromArgb(48, 70, 116);
            btnAtualizar.FlatAppearance.BorderSize = 0;
            btnAtualizar.FlatStyle = FlatStyle.Flat;
            btnAtualizar.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtualizar.ForeColor = Color.White;
            btnAtualizar.Location = new Point(683, 85);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(150, 25);
            btnAtualizar.TabIndex = 17;
            btnAtualizar.Text = "Atualizar Lista";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // formVendedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 211, 227);
            ClientSize = new Size(850, 700);
            ControlBox = false;
            Controls.Add(btnAtualizar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEliminar);
            Controls.Add(btnAlterar);
            Controls.Add(btnInserir);
            Controls.Add(panel2);
            Controls.Add(listVendedores);
            Controls.Add(btnVoltar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formVendedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formVendedores";
            Load += formVendedores_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private PictureBox pictureBox1;
        private Button btnVoltar;
        private Label label1;
        private Panel panel1;
        private ListView listVendedores;
        private Panel panel2;
        private ComboBox comboBox1;
        private TextBox txtValor;
        private Button btnCalcular;
        private Button btnInserir;
        private Button btnAlterar;
        private Button btnEliminar;
        private ColumnHeader Código;
        private ColumnHeader Nome;
        private ColumnHeader Comissão;
        private Label label2;
        private Label label3;
        private Button btnAtualizar;
    }
}