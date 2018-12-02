using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._11Karkulyator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string operation = "";
        //ilk daxil edilen deyer bura yuklenir hansisa emeliyyat buttonu kliklendikde.
        double firstValue = 0;
        bool check = false;
        private void btn_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || check==true) 
                txtResult.Clear();
            check = false;
            Button ClickedNumberBtn = (Button)sender;
            if (ClickedNumberBtn.Text == "Pi")
                txtResult.Text += 3.14;  
            else    
            txtResult.Text += ClickedNumberBtn.Text;
        }

        private void btnOperationClicked(object sender, EventArgs e)
        {
            Button btnOperationClicked = (Button)sender;
            operation += btnOperationClicked.Text;
            firstValue += double.Parse(txtResult.Text);
            //gonderilen emeliyyat faktorialdisa o zaman ! isaresi qaysun:
            if (operation != "n!")
                label1.Text = txtResult.Text + "  " + operation;
            else
                label1.Text = txtResult.Text + "!";
            check = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "/":
                    txtResult.Text = (firstValue / double.Parse(txtResult.Text)).ToString();
                    break;
                case "x":
                    txtResult.Text = (firstValue * double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (firstValue - double.Parse(txtResult.Text)).ToString();
                    break;
                case "+":
                    txtResult.Text = (firstValue + double.Parse(txtResult.Text)).ToString();
                    break;
                case "x2":
                    txtResult.Text = Math.Pow(double.Parse(txtResult.Text), 2).ToString();
                    break;
                case "Log10":
                    txtResult.Text = Math.Log10(double.Parse(txtResult.Text)).ToString();
                    break;
                case "Log":
                    txtResult.Text = Math.Log(double.Parse(txtResult.Text)).ToString();
                    break;
                case "1/x2":
                    txtResult.Text = (1 / (Math.Pow(double.Parse(txtResult.Text), 2))).ToString();
                    break;
                case "n!":
                    int step = 1;
                    double result = 1;
                    while (step <= double.Parse(txtResult.Text))
                    {
                        result *= step;
                        step++;
                    }
                    txtResult.Text = result.ToString();
                    break;
                default:
                    break;
            }
            operation = "";
            firstValue = 0;
            label1.Text = "";       
        }
        //CE ve C buttonlarinin islemesi ucun:
        void ClearMethod()
        {
            txtResult.Text = "0";
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            ClearMethod();
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            ClearMethod();
        }
        //Backspace buttonunun islemesi ucun:
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
