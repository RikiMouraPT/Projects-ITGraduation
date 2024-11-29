using CamadaInterface.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaInterface
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        #region Methods
        /// <summary>
        /// Inicializa os RESOURCES no formulário
        /// </summary>
        private void InitializeResources()
        {
            titleLabel.Text = Properties.Resources.ABOUT_LABEL_TITLE;
            subTitleLabel.Text = Properties.Resources.ABOUT_LABEL_SUBTITLE;

            nameLabel.Text = Properties.Resources.ABOUT_LABEL_NAME;
            nameTextBox.Text = Properties.Resources.ABOUT_TEXTBOX_NAME;

            numberLabel.Text = Properties.Resources.ABOUT_LABEL_NUMBER;
            numberTextBox.Text = Properties.Resources.ABOUT_TEXTBOX_NUMBER;

            changeFontLabel.Text = Properties.Resources.ABOUT_LABEL_FONT;
            changeTextColorLabel.Text = Properties.Resources.ABOUT_LABEL_TEXTCOLOR;
            changeBackgroundColorLabel.Text = Properties.Resources.ABOUT_LABEL_BACKGROUNDCOLOR;

            copyrightLabel.Text = Properties.Resources.ABOUT_LABEL_COPYRIGHT;
        }

        /// <summary>
        /// Inicializa o ComboBox de Fontes, sendo Aria o padrão
        /// </summary>
        private void InitializeFontComboBox()
        {
            changeFontComboBox.Items.Clear();
            changeFontComboBox.Text = "Arial";

            changeFontComboBox.Items.Add("Arial");
            changeFontComboBox.Items.Add("Times New Roman");
            changeFontComboBox.Items.Add("Comic Sans MS");
            changeFontComboBox.Items.Add("Impact");
            changeFontComboBox.Items.Add("Consolas");
        }

        /// <summary>
        /// Inicializa o ComboBox de Cores, sendo Black o padrão
        /// </summary>
        private void InitializeTextColorComboBox()
        {
            changeTextColorComboBox.Items.Clear();
            changeTextColorComboBox.Text = "Black";

            changeTextColorComboBox.Items.Add("Black");
            changeTextColorComboBox.Items.Add("Red");
            changeTextColorComboBox.Items.Add("Blue");
        }

        /// <summary>
        /// Inicializa o ComboBox de Cores de Fundo, sendo Default o padrão
        /// </summary>
        private void InitilizeBackgroundColorComboBox()
        {
            changeBackgroundColorComboBox.Items.Clear();
            changeBackgroundColorComboBox.Text = "Default";

            changeBackgroundColorComboBox.Items.Add("Default");
            changeBackgroundColorComboBox.Items.Add("Black");
            changeBackgroundColorComboBox.Items.Add("Purple");
        }

        /// <summary>
        /// Aplica a fonte selecionada no ComboBox
        /// </summary>
        /// <param name="font">Nome da fonte a ser aplicada</param>
        private void LoadCustomFont(string font)
        {
            Font bodyFont = new Font(font, 12, FontStyle.Regular);

            titleLabel.Font = new Font(font, bodyFont.Size + 6, FontStyle.Bold);
            subTitleLabel.Font = new Font(font, bodyFont.Size + 2, FontStyle.Bold);

            nameLabel.Font = bodyFont;
            nameTextBox.Font = bodyFont;

            numberLabel.Font = bodyFont;
            numberTextBox.Font = bodyFont;

            changeFontLabel.Font = bodyFont;
            changeFontComboBox.Font = bodyFont;

            changeTextColorLabel.Font = bodyFont;
            changeTextColorComboBox.Font = bodyFont;

            changeBackgroundColorLabel.Font = bodyFont;
            changeBackgroundColorComboBox.Font = bodyFont;
        }

        /// <summary>
        /// Aplica a cor selecionada no ComboBox
        /// </summary>
        /// <param name="color">Nome da cor a ser aplicada</param>
        private void LoadCustomTextColor(string color)
        {
            Color selectedColor = Color.FromName(color);

            titleLabel.ForeColor = selectedColor;
            subTitleLabel.ForeColor = selectedColor;
            nameLabel.ForeColor = selectedColor;
            nameTextBox.ForeColor = selectedColor;
            numberLabel.ForeColor = selectedColor;
            numberTextBox.ForeColor = selectedColor;
            changeFontLabel.ForeColor = selectedColor;
            changeFontComboBox.ForeColor = selectedColor;
            changeTextColorLabel.ForeColor = selectedColor;
            changeTextColorComboBox.ForeColor = selectedColor;
            changeBackgroundColorLabel.ForeColor = selectedColor;
            changeBackgroundColorComboBox.ForeColor = selectedColor;
            copyrightLabel.ForeColor = selectedColor;
        }

        /// <summary>
        /// Aplica a cor de fundo selecionada no ComboBox
        /// </summary>
        /// <param name="text">Nome da cor de fundo a ser aplicada</param>
        private void LoadCustomBackgroundColor(string text)
        {
            switch (text)
            {
                case "Default":
                    this.BackColor = SystemColors.Control;
                    break;
                case "Black":
                    this.BackColor = Color.Black;
                    break;
                case "Purple":
                    this.BackColor = Color.Purple;
                    break;
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// Evento de load do formulario, inicializa os recursos e os ComboBox
        /// </summary>
        private void About_Load(object sender, EventArgs e)
        {
            InitializeResources();
            InitializeFontComboBox();
            InitializeTextColorComboBox();
            InitilizeBackgroundColorComboBox();
        }

        /// <summary>
        /// Evento ativa quando o ComboBox de Fontes é alterado, alterando a fonte do texto do formulário
        /// </summary>
        private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCustomFont(changeFontComboBox.Text);
        }

        /// <summary>
        /// Evento ativa quando o ComboBox de Cores é alterado, alterando a cor do texto do formulário
        /// </summary>
        private void changeTextColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCustomTextColor(changeTextColorComboBox.Text);
        }

        /// <summary>
        /// Evento ativa quando o ComboBox de Cores de Fundo é alterado, alterando a cor de fundo do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeBackgroundColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCustomBackgroundColor(changeBackgroundColorComboBox.Text);
        }
        #endregion
    }
}
