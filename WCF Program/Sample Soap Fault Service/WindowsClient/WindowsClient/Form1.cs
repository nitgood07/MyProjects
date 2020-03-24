using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace WindowsClient
{
    public partial class Form1 : Form
    {
        string Operation = "";
        CalculatorService.CalculatorServiceClient client = null;
        public Form1()
        {
            InitializeComponent();
            client = new CalculatorService.CalculatorServiceClient();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            Operation = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + 1.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + 2.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + 3.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + 4.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + 5.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + 6.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + 7.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + 8.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + 9.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if(txtInput.Text != "" && Operation == "")
            { 
                txtInput.Text = txtInput.Text + "/";
                Operation = "Divide";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "" && Operation == "")
            {
                txtInput.Text = txtInput.Text + "X";
                Operation = "Multiply";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "" && Operation == "")
            {
                txtInput.Text = txtInput.Text + "-";
                Operation = "Minus";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "" && Operation == "")
            {
                txtInput.Text = txtInput.Text + "+";
                Operation = "Plus";
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                switch (Operation)
                {
                        case "Divide":
                            string[] values1 = txtInput.Text.Split('/');
                            txtInput.Text = "";
                            txtInput.Text = client.Divide(Convert.ToInt32(values1[0]), Convert.ToInt32(values1[1])).ToString();
                            break;
                        case "Multiply":
                            string[] values2 = txtInput.Text.Split('X');
                            txtInput.Text = "";
                            txtInput.Text = client.Multiply(Convert.ToInt32(values2[0]), Convert.ToInt32(values2[1])).ToString();
                            break;
                        case "Minus":
                            string[] values3 = txtInput.Text.Split('-');
                            txtInput.Text = "";
                            txtInput.Text = client.Multiply(Convert.ToInt32(values3[0]), Convert.ToInt32(values3[1])).ToString();
                            break;
                        case "Plus":
                            string[] values4 = txtInput.Text.Split('+');
                            txtInput.Text = "";
                            txtInput.Text = client.Multiply(Convert.ToInt32(values4[0]), Convert.ToInt32(values4[1])).ToString();
                            break;
                        default:
                            txtInput.Text = "Pleaes add correct values";
                            break;
                }
            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.Message);
                Operation = "";
                //reestablish new instance of proxy class
               // client = new CalculatorService.CalculatorServiceClient("NetTcpBinding_ICalculatorService");
               //We are throwing a fault exception from service itself to handle it. that way it will not break channel and we do not need this code.

            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text + 0.ToString();
        }
    }
}
