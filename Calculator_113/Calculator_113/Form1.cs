using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_113
{
    public partial class Form1 : Form
    {
        bool operandPerformed = false;
        string operand = "";
        double result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumEvent(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || operandPerformed)
                txtResult.Clear();

            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
            operandPerformed = false;
        }

        private void OperandEvent(object sender, EventArgs e)
        {
            operandPerformed = true;
            Button btn = (Button)sender;
            string newOperand = btn.Text;

            lbResult.Text = lbResult.Text + " " + txtResult.Text + " " + newOperand;
            double Opr1 = Convert.ToDouble(result);
            double Opr2 = Convert.ToDouble(txtResult.Text);

            switch (operand)
            {
                case "+":
                    txtResult.Text =  Convert.ToString( Opr1 + Opr2 ); 
                    break;
                case "-": 
                    txtResult.Text = Convert.ToString( Opr1 - Opr2 ); 
                    break;
                case "*": 
                    txtResult.Text = Convert.ToString( Opr1 * Opr2 ); 
                    break;
                case "/": 
                    txtResult.Text = Convert.ToString( Opr1 / Opr2 ); 
                    break;
                default: break;
            }

            result = Convert.ToDouble(txtResult.Text);
            operand = newOperand;
        }

        private void bCe_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void bC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            lbResult.Text = "";
            result = 0;
            operand = "";
        }

        private void bEq_Click(object sender, EventArgs e)
        {
            lbResult.Text = "";
            operandPerformed = true;
            double Opr1 = Convert.ToDouble(result);
            double Opr2 = Convert.ToDouble(txtResult.Text);

            switch (operand)
            {
                case "+":
                    txtResult.Text = Convert.ToString(Opr1 + Opr2);
                    break;
                case "-":
                    txtResult.Text = Convert.ToString(Opr1 - Opr2);
                    break;
                case "*":
                    txtResult.Text = Convert.ToString(Opr1 * Opr2);
                    break;
                case "/":
                    txtResult.Text = Convert.ToString(Opr1 / Opr2);
                    break;
                default: break;
            }

            result = Convert.ToDouble(txtResult.Text);
            txtResult.Text = result.ToString();
            result = 0;
            operand = "";
        }

        private void bdot_Click(object sender, EventArgs e)
        {
            if (!operandPerformed && !txtResult.Text.Contains(","))
            {
                txtResult.Text += ".";
            }
            else if (operandPerformed)
            {
                txtResult.Text = "0";
            }

            if (!txtResult.Text.Contains("."))
            {
                txtResult.Text += ".";
            }

            operandPerformed = false;
        }
    }
}