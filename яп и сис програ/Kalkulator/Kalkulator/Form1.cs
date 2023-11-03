using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num1;
        float num2;
        float result;
        bool isInput = true;
        char operation;
        string oper;
        private void ButtonToMainTextBox(object sender, EventArgs e)
        {
            if (isInput)
            {
                maintextbox.Text = "";
                isInput = false;
            }
            Button button = (Button)sender;
            maintextbox.Text += button.Text;
        }
        private void OperationSelectedAction(object sender, EventArgs e)
        {
            num1 = float.Parse(maintextbox.Text);
            result = num1;
            if (!isInput)
            {
                EveryAction();
                isInput = true;
            }
            Button button = (Button)sender;
            operation = button.Text[0];
            ActionBuff.Text = maintextbox.Text + operation.ToString();
        }
        private void EveryAction()
        {
            num2 = float.Parse(maintextbox.Text);
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case 'x':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        maintextbox.Text = "Ошибка";
                        return;
                    }
                    break;
            }
            maintextbox.Text = result.ToString();
        }

        private void bAC_Click(object sender, EventArgs e)
        {
            result = 0;
            num1 = 0;
            num2 = 0;
            maintextbox.Clear();
            ActionBuff.Clear();
            isInput = true;
        }

        private void bequals_Click(object sender, EventArgs e)
        {
            EveryAction();
            isInput = true;
            ActionBuff.Clear();
        }
        public static long Fact(long n)
        {
            if (n == 0)
                return 1;
            else
                return n * Fact(n - 1);
        }

        private void factorialBtn_Click(object sender, EventArgs e)
        {
            if (!isInput)
            {
                maintextbox.Text = Fact(long.Parse(maintextbox.Text)).ToString();
            }
        }
        private void OtherAction(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            oper = button.Text;
            if (!isInput)
            {
                num1 = float.Parse(maintextbox.Text);
                switch (oper)
                {
                    case "sin":
                        maintextbox.Text = Math.Sin(num1).ToString();
                        break;
                    case "cos":
                        maintextbox.Text = Math.Cos(num1).ToString();
                        break;
                    case "tan":
                        maintextbox.Text = Math.Tan(num1).ToString();
                        break;
                    case "e":
                        maintextbox.Text = Math.E.ToString();
                        break;
                    case "exp(x)":
                        maintextbox.Text = Math.Exp(num1).ToString();
                        break;
                    case "log":
                        maintextbox.Text = Math.Log10(num1).ToString();
                        break;
                    case "ln":
                        maintextbox.Text = Math.Log(num1).ToString();
                        break;
                    case "√x":
                        maintextbox.Text = Math.Sqrt(num1).ToString();
                        break;
                    case "x²":
                        maintextbox.Text = Math.Pow(num1, 2).ToString();
                        break;
                }
            }
        }
    }
}
