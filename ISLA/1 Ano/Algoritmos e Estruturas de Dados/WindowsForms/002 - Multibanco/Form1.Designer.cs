namespace _002___Multibanco
{
    partial class FormMultibanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMultibanco));
            lbTitulo = new Label();
            txtSaldo = new TextBox();
            label1 = new Label();
            btnLevantar = new Button();
            btnDepositar = new Button();
            txtValor = new TextBox();
            label2 = new Label();
            lstMovimentos = new ListView();
            label3 = new Label();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.BackColor = Color.Transparent;
            lbTitulo.Font = new Font("Akroma", 102F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitulo.Location = new Point(327, -23);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(918, 224);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Multibanco";
            // 
            // txtSaldo
            // 
            txtSaldo.Enabled = false;
            txtSaldo.Font = new Font("Akroma", 22F, FontStyle.Regular, GraphicsUnit.Point);
            txtSaldo.Location = new Point(997, 275);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(211, 56);
            txtSaldo.TabIndex = 1;
            txtSaldo.TextAlign = HorizontalAlignment.Right;
            txtSaldo.TextChanged += txtSaldo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Akroma", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(989, 227);
            label1.Name = "label1";
            label1.Size = new Size(132, 59);
            label1.TabIndex = 2;
            label1.Text = "Saldo";
            // 
            // btnLevantar
            // 
            btnLevantar.Enabled = false;
            btnLevantar.Font = new Font("Akroma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLevantar.Location = new Point(204, 442);
            btnLevantar.Name = "btnLevantar";
            btnLevantar.Size = new Size(119, 46);
            btnLevantar.TabIndex = 3;
            btnLevantar.Text = "Levantar";
            btnLevantar.UseVisualStyleBackColor = true;
            btnLevantar.Click += btnLevantar_Click;
            // 
            // btnDepositar
            // 
            btnDepositar.Enabled = false;
            btnDepositar.Font = new Font("Akroma", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnDepositar.Location = new Point(195, 529);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(119, 46);
            btnDepositar.TabIndex = 4;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Akroma", 22F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor.Location = new Point(333, 488);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(150, 56);
            txtValor.TabIndex = 5;
            txtValor.TextAlign = HorizontalAlignment.Right;
            txtValor.TextChanged += txtValor_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Akroma", 26F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(340, 436);
            label2.Name = "label2";
            label2.Size = new Size(133, 59);
            label2.TabIndex = 6;
            label2.Text = "Valor";
            // 
            // lstMovimentos
            // 
            lstMovimentos.Activation = ItemActivation.OneClick;
            lstMovimentos.Cursor = Cursors.Hand;
            lstMovimentos.HoverSelection = true;
            lstMovimentos.Location = new Point(489, 347);
            lstMovimentos.Name = "lstMovimentos";
            lstMovimentos.Size = new Size(719, 269);
            lstMovimentos.TabIndex = 7;
            lstMovimentos.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Akroma", 34F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(479, 284);
            label3.Name = "label3";
            label3.Size = new Size(321, 76);
            label3.TabIndex = 8;
            label3.Text = "Movimentos";
            // 
            // btnSair
            // 
            btnSair.BackColor = SystemColors.ControlLight;
            btnSair.Font = new Font("Akroma", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.Location = new Point(1223, 580);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(117, 44);
            btnSair.TabIndex = 9;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // FormMultibanco
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnSair);
            Controls.Add(lstMovimentos);
            Controls.Add(label3);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(btnDepositar);
            Controls.Add(btnLevantar);
            Controls.Add(txtSaldo);
            Controls.Add(label1);
            Controls.Add(lbTitulo);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1028);
            Name = "FormMultibanco";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Multibanco";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private TextBox txtSaldo;
        private Label label1;
        private Button btnLevantar;
        private Button btnDepositar;
        private TextBox txtValor;
        private Label label2;
        private ListView lstMovimentos;
        private Label label3;
        private Button btnSair;
    }
}
