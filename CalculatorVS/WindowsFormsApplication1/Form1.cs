using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operationPrest = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operationPrest))
            {
                result.Clear();
            }
            operationPrest = false;
            Button button = (Button)sender;
            result.Text = result.Text + button.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_clicked(object sender, EventArgs e)
        {
            Button buttonOperation = (Button)sender;
            operation = buttonOperation.Text;
            value = Double.Parse(result.Text);
            operationPrest = true;
            equation.Text = value + " " + operation;
        }

        private void equals_button(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {

                case "+" :
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            operationPrest = false;
          

        }

        private void button15_Click(object sender, EventArgs e)
        {
            result.Text= "0";
            value = 0;
        }
    }
}
