using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pyConversordeunidades
{
    public partial class frmConversorunidades : Form
    {
        public frmConversorunidades()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
            
        {
            double valor = double.Parse(txtValor.Text);
            lblResultado.Text = "";
            lblResultado.Text = (cmbDesde.Text == "Metros") ? (valor * 100).ToString() + " cm" : (valor / 100).ToString() + " mts";
        }
    }
}
