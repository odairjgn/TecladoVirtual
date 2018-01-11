using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecladoVirtual.Controles
{
    public delegate void KeyPressEvent(char key);

    public partial class Keyboard : UserControl
    {
        public event KeyPressEvent KeyPress;
        public event EventHandler Ok;

        public Keyboard()
        {
            InitializeComponent();
        }

        protected virtual void OnKeyPress(char key)
        {
            KeyPress?.Invoke(key);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var botao = sender as Button;
            OnKeyPress(botao.Text[0]);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OnKeyPress('\b');
        }

        protected virtual void OnOk()
        {
            Ok?.Invoke(this, EventArgs.Empty);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OnOk();
        }
    }
}
