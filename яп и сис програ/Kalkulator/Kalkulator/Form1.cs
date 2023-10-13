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
        //if ((maintextbox.Text.Length % 3 == 0) & (maintextbox.Text.Length != 0) & (maintextbox.Text.Length<16))
        //{
        //    maintextbox.Text += ',';
        //}
        float num1 = 0;
        float num2 = 0;
        float result = 0;
        bool isOperatorSelected = false;
        char operation;
        private void ButtonToMainTextBox(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (maintextbox.Text == "" || maintextbox.Text == result.ToString())
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
            maintextbox.Text = "";
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
                        result = num1 / num2;
                        break;
                    case '=':
                        maintextbox.Text = result.ToString();
                        break;
                }
                maintextbox.Text = result.ToString();
                isOperatorSelected = false;
            }
        }
    }
}
