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

        private void BtnCompute_Click(object sender, EventArgs e)
        {
            if(CmbOperations.SelectedIndex == -1)
            {
                MessageBox.Show("Please select operation", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TextNum1.Text.Length > 0 && float.TryParse(TextNum1.Text, out float num1) &&
                TextNum2.Text.Length > 0 && float.TryParse(TextNum2.Text, out float num2)) {

                if (CmbOperations.SelectedItem.ToString().Equals("+"))
                {
                    float answer = BasicComputation.Addition(num1, num2);

                    LabelTotal.Text = answer.ToString();
                }

                if (CmbOperations.SelectedItem.ToString().Equals("-"))
                {
                    float answer = BasicComputation.Subtraction(num1, num2);

                    LabelTotal.Text = answer.ToString();
                }

                if (CmbOperations.SelectedItem.ToString().Equals("*"))
                {
                    float answer = BasicComputation.Multiplication(num1, num2);

                    LabelTotal.Text = answer.ToString();
                }

                if (CmbOperations.SelectedItem.ToString().Equals("/"))
                {
                    float answer = BasicComputation.Division(num1, num2);

                    LabelTotal.Text = answer.ToString();
                }
            } else
            {
                MessageBox.Show("Put numbers in the 2 textbox", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
