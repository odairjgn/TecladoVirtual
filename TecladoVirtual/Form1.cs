using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecladoVirtual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxWithVirtualKeyBoard1_Terminado(object sender, EventArgs e)
        {
            label1.Text = textBoxWithVirtualKeyBoard1.Text;
        }

        private void textBoxWithVirtualKeyBoard2_Terminado(object sender, EventArgs e)
        {
            label2.Text = textBoxWithVirtualKeyBoard2.Text;
        }
    }
}
