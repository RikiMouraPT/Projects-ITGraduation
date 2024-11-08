namespace Project
{
    partial class FormFornecedor
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
            this.listFornecedoresButton = new System.Windows.Forms.Button();
            this.fornecedoresListBox = new System.Windows.Forms.ListBox();
            this.codigoFornecedorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeFornecedorTextBox = new System.Windows.Forms.TextBox();
            this.obterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listFornecedoresButton
            // 
            this.listFornecedoresButton.Location = new System.Drawing.Point(9, 10);
            this.listFornecedoresButton.Margin = new System.Windows.Forms.Padding(2);
            this.listFornecedoresButton.Name = "listFornecedoresButton";
            this.listFornecedoresButton.Size = new System.Drawing.Size(149, 33);
            this.listFornecedoresButton.TabIndex = 0;
            this.listFornecedoresButton.Text = "Lista de Fornecedores *";
            this.listFornecedoresButton.UseVisualStyleBackColor = true;
            this.listFornecedoresButton.Click += new System.EventHandler(this.listFornecedoresButton_Click);
            // 
            // fornecedoresListBox
            // 
            this.fornecedoresListBox.FormattingEnabled = true;
            this.fornecedoresListBox.Location = new System.Drawing.Point(9, 53);
            this.fornecedoresListBox.Margin = new System.Windows.Forms.Padding(2);
            this.fornecedoresListBox.Name = "fornecedoresListBox";
            this.fornecedoresListBox.Size = new System.Drawing.Size(149, 186);
            this.fornecedoresListBox.TabIndex = 1;
            // 
            // codigoFornecedorTextBox
            // 
            this.codigoFornecedorTextBox.Location = new System.Drawing.Point(243, 48);
            this.codigoFornecedorTextBox.Name = "codigoFornecedorTextBox";
            this.codigoFornecedorTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoFornecedorTextBox.TabIndex = 2;
            this.codigoFornecedorTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.codigoFornecedorTextBox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome: *";
            // 
            // nomeFornecedorTextBox
            // 
            this.nomeFornecedorTextBox.Location = new System.Drawing.Point(243, 97);
            this.nomeFornecedorTextBox.Name = "nomeFornecedorTextBox";
            this.nomeFornecedorTextBox.Size = new System.Drawing.Size(181, 20);
            this.nomeFornecedorTextBox.TabIndex = 5;
            // 
            // obterButton
            // 
            this.obterButton.Location = new System.Drawing.Point(349, 48);
            this.obterButton.Name = "obterButton";
            this.obterButton.Size = new System.Drawing.Size(75, 23);
            this.obterButton.TabIndex = 6;
            this.obterButton.Text = "...";
            this.obterButton.UseVisualStyleBackColor = true;
            // 
            // FormFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.obterButton);
            this.Controls.Add(this.nomeFornecedorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codigoFornecedorTextBox);
            this.Controls.Add(this.fornecedoresListBox);
            this.Controls.Add(this.listFornecedoresButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFornecedor";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listFornecedoresButton;
        private System.Windows.Forms.ListBox fornecedoresListBox;
        private System.Windows.Forms.TextBox codigoFornecedorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeFornecedorTextBox;
        private System.Windows.Forms.Button obterButton;
    }
}

