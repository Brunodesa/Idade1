using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        diamesano dia = new diamesano();


        private void Button1_Click_1(object sender, EventArgs e)
        {
            dia.recebe = textBox1.Text;
            label2.Text = dia.envia;
        }
    }
}
