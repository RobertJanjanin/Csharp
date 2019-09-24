using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int broj = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            broj--;
            txtPrikaz.Text = broj.ToString();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            broj++;
            txtPrikaz.Text = broj.ToString();
        }

        private void TxtPrikaz_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
