using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fechayhora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxFecha.Text = DateTime.Now.Year.ToString();
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxFecha.Text = DateTime.Now.Day.ToString();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            textBoxFecha.Text = DateTime.Now.Month.ToString();
        }

        private void textBoxFecha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
