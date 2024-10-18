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
            this.SuspendLayout();
            // 
            // listFornecedoresButton
            // 
            this.listFornecedoresButton.Location = new System.Drawing.Point(12, 12);
            this.listFornecedoresButton.Name = "listFornecedoresButton";
            this.listFornecedoresButton.Size = new System.Drawing.Size(182, 41);
            this.listFornecedoresButton.TabIndex = 0;
            this.listFornecedoresButton.Text = "Lista de Fornecedores *";
            this.listFornecedoresButton.UseVisualStyleBackColor = true;
            this.listFornecedoresButton.Click += new System.EventHandler(this.listFornecedoresButton_Click);
            // 
            // fornecedoresListBox
            // 
            this.fornecedoresListBox.FormattingEnabled = true;
            this.fornecedoresListBox.ItemHeight = 16;
            this.fornecedoresListBox.Location = new System.Drawing.Point(12, 59);
            this.fornecedoresListBox.Name = "fornecedoresListBox";
            this.fornecedoresListBox.Size = new System.Drawing.Size(776, 292);
            this.fornecedoresListBox.TabIndex = 1;
            // 
            // FormFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fornecedoresListBox);
            this.Controls.Add(this.listFornecedoresButton);
            this.Name = "FormFornecedor";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listFornecedoresButton;
        private System.Windows.Forms.ListBox fornecedoresListBox;
    }
}

