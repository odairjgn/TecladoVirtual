using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecladoVirtual.Controles
{
    public class TextBoxWithVirtualKeyBoard : TextBox
    {
        private Keyboard _teclado;
        private DropDownProvider _ddp;

        public event EventHandler Terminado;

        public TextBoxWithVirtualKeyBoard()
        {
            _teclado = new Keyboard();
            _teclado.KeyPress += _teclado_KeyPress;
            _teclado.Ok += _teclado_Ok;

            _ddp = new DropDownProvider(_teclado, this);
        }

        private void _teclado_Ok(object sender, EventArgs e)
        {
            _ddp.FecharDropDown();
            OnTerminado();
        }

        private void _teclado_KeyPress(char key)
        {
            Text += key;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            e.Handled = true;
            base.OnKeyPress(e);
        }

       protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            _ddp.ClickDropDown();
        }

        protected virtual void OnTerminado()
        {
            Terminado?.Invoke(this, EventArgs.Empty);
        }
    }
}
