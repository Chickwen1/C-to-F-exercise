using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_to_F_convert
{
    public partial class Form1 : Form
    {
        double celsiusInput, farenheitInput, celsius, farenheit;

        public Form1()
        {
            InitializeComponent();
        }

        public double FtoC()
        {
            farenheitInput = double.Parse(txtFarenheitInput.Text);
            celsius = (farenheitInput - 32) / 1.8;
            return celsius;
        }

        public double CtoF()
        {
            celsiusInput = double.Parse(txtCelsiusInput.Text);
            farenheit = celsiusInput * 1.8 + 32;
            return farenheit;
        }

        private void btnCtF_Click(object sender, EventArgs e)
        {
            CtoF();
            txtFarenheitOutput.Text = farenheit.ToString();
        }

        private void btnFtC_Click(object sender, EventArgs e)
        {
            FtoC();
            txtCelsiusOutput.Text = celsius.ToString();
        }
    }
}
