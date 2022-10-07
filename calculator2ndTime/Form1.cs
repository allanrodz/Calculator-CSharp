using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2ndTime
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);

            double answer = 0;

            if (rdoAdd.Checked)
            {
                answer = num1 + num2;
                lblDisplay.Text = answer.ToString();
            }
            else if (rdoDiv.Checked)
            {
                answer = num1 / num2;
                lblDisplay.Text = answer.ToString();
            }
            else if (rdoMinus.Checked)
            {
                answer = num1 - num2;
                lblDisplay.Text = answer.ToString();
            }
            else if (rdoMultip.Checked)
            {
                answer = num1 * num2;
                lblDisplay.Text = answer.ToString();

            }

        }
    }
}
