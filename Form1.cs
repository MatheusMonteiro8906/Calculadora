using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if((results.Text == "0")||(operation_pressed))
              results.Clear();
            
            Button b = (Button)sender;
            results.Text = results.Text + b.Text;
        }

        private void CE_Click(object sender, EventArgs e)
        {
            results.Text = "0";
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(results.Text);
            bool operation_pressed = true;
        }

        private void Equal_Click(object sender, EventArgs e)
        {

        }

    }
}
