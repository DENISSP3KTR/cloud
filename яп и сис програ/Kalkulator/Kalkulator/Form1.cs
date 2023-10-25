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
        bool isOperatorSelected = false;
        char operation;
        private void ButtonToMainTextBox(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (maintextbox.Text == "" || maintextbox.Text == num1.ToString())
            {
                maintextbox.Text = button.Text;
            }
            else if (maintextbox.Text.Length <= 16)
            {
                maintextbox.Text += button.Text;
            }
        }
        private void OperationSelectedAction(object sender, EventArgs e)
        {
            if (isOperatorSelected)
                EveryAction();
            Button button = (Button)sender;
            num1 = float.Parse(maintextbox.Text);
            operation = button.Text[0];
            ActionBuff.Text = maintextbox.Text + operation.ToString();
            isOperatorSelected = true;
            //maintextbox.Text = "";
        }
        private void EveryAction()
        {
            if (isOperatorSelected)
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
                    case '=':
                        maintextbox.Text = result.ToString();
                        break;
                }
                maintextbox.Text = result.ToString();
                isOperatorSelected = false;
            }
        }

        private void bAC_Click(object sender, EventArgs e)
        {
            result = 0;
            num1 = 0;
            num2 = 0;
            maintextbox.Clear();
            ActionBuff.Clear();
            isOperatorSelected = false;
        }
    }
}
