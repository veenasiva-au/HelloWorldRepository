using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Welcome to Hello World Project!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Show(Form2.ActiveForm);
            if(Form1.ActiveForm.Visible)
                Form1.ActiveForm.Hide();
        }
    }
}
