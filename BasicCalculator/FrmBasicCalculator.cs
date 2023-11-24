using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;


namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {

                float num1 = float.Parse(txtNum1.Text.ToString());
                float num2 = float.Parse(txtNum2.Text.ToString());

                float answer;

                if (cmbOperator.Text == "+")
                {

                    answer = BasicComputation.Addition(num1, num2);

                    lblTotal.Text = answer.ToString();

                }
                if (cmbOperator.Text == "-")
                {

                    answer = BasicComputation.Subtraction(num1, num2);

                    lblTotal.Text = answer.ToString();

                }
                if (cmbOperator.Text == "*")
                {

                    answer = BasicComputation.Multiplication(num1, num2);

                    lblTotal.Text = answer.ToString();

                }
                if (cmbOperator.Text == "/")
                {

                    answer = BasicComputation.Division(num1, num2);

                    lblTotal.Text = answer.ToString();

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";

            lblTotal.Text = "0000";
            cmbOperator.Text = "";
        }
    }
}
