using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiOP_06_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Dorucak_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextBox();
        }

        private void Rucak_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextBox();
        }

        private void Vecera_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextBox();
        }

        private void Sakrij_narudzbu_CheckedChanged(object sender, EventArgs e)
        {
            HideTextBox();
        }

        void UpdateTextBox()
        {
            TextBox.Text = "Odabrali ste: ";
            var words = new List<string>();

            words.Add("Odabrali ste:");

            if (Dorucak.Checked)
                words.Add("Dorucak");

            if (Rucak.Checked)
                words.Add("Rucak");

            if (Vecera.Checked)
                words.Add("Vecera");

            TextBox.Text = string.Join(Environment.NewLine, words);
        }

        void HideTextBox()
        {
            if (Sakrij_narudzbu.Checked)
                TextBox.Visible = false;
            else
                TextBox.Visible = true;
        }
    }
}
