using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robertJanjaninDorucak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChkSakrij_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkSakrij.Checked) {
                if (chkDorucak.Checked)
                {
                    txtPrikaz.AppendText("Odabrali ste dorucak");

                }
                if (chkRucak.Checked)
                {
                    txtPrikaz.AppendText("\r\nOdabrali ste rucak");
                }
                if (chkVecera.Checked)
                {
                    txtPrikaz.AppendText("\r\nOdabrali ste veceru");
                }

            }
            else
            {
                txtPrikaz.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnPosalji_Click(object sender, EventArgs e)
        {
            if (chkSakrij.Checked)
            { }
            else
            {

                txtPrikaz.Clear();
                if (chkDorucak.Checked)
                {
                    txtPrikaz.AppendText("Odabrali ste dorucak");

                }
                if (chkRucak.Checked)
                {
                    txtPrikaz.AppendText("\r\nOdabrali ste rucak");
                }
                if (chkVecera.Checked)
                {
                    txtPrikaz.AppendText("\r\nOdabrali ste veceru");
                }
            }
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
