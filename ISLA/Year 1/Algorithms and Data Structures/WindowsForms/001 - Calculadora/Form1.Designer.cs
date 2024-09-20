namespace _001___Calculadora
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnExit = new Button();
            lblTitulo = new Label();
            btnSomar = new Button();
            btnSubtrair = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            lblN1 = new Label();
            lblN2 = new Label();
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            lblResultado = new Label();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Location = new Point(239, 345);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(478, 73);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += button1_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Cooper Black", 75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.DodgerBlue;
            lblTitulo.Location = new Point(107, -11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(665, 115);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Calculadora";
            // 
            // btnSomar
            // 
            btnSomar.BackColor = Color.Transparent;
            btnSomar.Enabled = false;
            btnSomar.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnSomar.Location = new Point(54, 107);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(117, 73);
            btnSomar.TabIndex = 2;
            btnSomar.Text = "+";
            btnSomar.UseVisualStyleBackColor = false;
            btnSomar.Click += btnSomar_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.BackColor = Color.Transparent;
            btnSubtrair.Enabled = false;
            btnSubtrair.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubtrair.Location = new Point(54, 186);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(117, 73);
            btnSubtrair.TabIndex = 3;
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = false;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.BackColor = Color.Transparent;
            btnMultiplicar.Enabled = false;
            btnMultiplicar.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiplicar.Location = new Point(54, 265);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(117, 73);
            btnMultiplicar.TabIndex = 4;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = false;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.BackColor = Color.Transparent;
            btnDividir.Enabled = false;
            btnDividir.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnDividir.Location = new Point(54, 344);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(117, 73);
            btnDividir.TabIndex = 5;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = false;
            btnDividir.Click += btnDividir_Click;
            // 
            // lblN1
            // 
            lblN1.AutoSize = true;
            lblN1.BackColor = Color.Transparent;
            lblN1.Font = new Font("Comic Sans MS", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblN1.ForeColor = Color.Black;
            lblN1.Location = new Point(239, 125);
            lblN1.Name = "lblN1";
            lblN1.Size = new Size(236, 55);
            lblN1.TabIndex = 6;
            lblN1.Text = "1º Numero";
            // 
            // lblN2
            // 
            lblN2.AutoSize = true;
            lblN2.BackColor = Color.Transparent;
            lblN2.Font = new Font("Comic Sans MS", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblN2.ForeColor = Color.Black;
            lblN2.Location = new Point(492, 125);
            lblN2.Name = "lblN2";
            lblN2.Size = new Size(236, 55);
            lblN2.TabIndex = 7;
            lblN2.Text = "2º Numero";
            // 
            // txtN1
            // 
            txtN1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtN1.Location = new Point(239, 184);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(219, 43);
            txtN1.TabIndex = 8;
            txtN1.TextAlign = HorizontalAlignment.Center;
            txtN1.TextChanged += txtN1_TextChanged;
            // 
            // txtN2
            // 
            txtN2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtN2.Location = new Point(492, 184);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(225, 43);
            txtN2.TabIndex = 9;
            txtN2.TextAlign = HorizontalAlignment.Center;
            txtN2.TextChanged += txtN2_TextChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Transparent;
            lblResultado.Font = new Font("Comic Sans MS", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.ForeColor = Color.Black;
            lblResultado.Location = new Point(366, 237);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(209, 55);
            lblResultado.TabIndex = 10;
            lblResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultado.Location = new Point(239, 296);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(478, 43);
            txtResultado.TabIndex = 11;
            txtResultado.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 461);
            Controls.Add(txtResultado);
            Controls.Add(lblResultado);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(lblN2);
            Controls.Add(lblN1);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(btnSomar);
            Controls.Add(lblTitulo);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Label lblTitulo;
        private Button btnSomar;
        private Button btnSubtrair;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Label lblN1;
        private Label lblN2;
        private TextBox txtN1;
        private TextBox txtN2;
        private Label lblResultado;
        private TextBox txtResultado;
    }
}