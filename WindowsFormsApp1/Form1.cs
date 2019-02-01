using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbAccept_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BtSubmit_Click(object sender, EventArgs e)
        {
            int num1, num2, num3; 

            num1 = int.Parse(tbAccept.Text);
            num2 = int.Parse(textBox1.Text);
            num3 = num1 + num2;

            
            MessageBox.Show($"The answer is {num3}");
        }

        private void lblNameprompt_Click(object sender, EventArgs e)
        {

        }
    }
}
