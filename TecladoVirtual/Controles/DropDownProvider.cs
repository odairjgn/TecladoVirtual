using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TecladoVirtual.Controles
{
    [ToolboxBitmap(typeof(ComboBox))]
    public class DropDownProvider : Component
    {
        private DropDownControl _dropDownControl;
        private int _cronometro;

        public event EventHandler DropDownOpen;
        public event EventHandler DropDownClose;

        private Control _containerControl;
        public Control ContainerControl
        {
            get { return _containerControl; }
            set
            {
                _containerControl = value;
                _dropDownControl.InitializeDropDown(_containerControl);
            }
        }

        private Control _anchorControl;

        public Control AnchorControl
        {
            get { return _anchorControl; }
            set
            {
                _anchorControl = value;
                _dropDownControl.Parent = _anchorControl;
            }
        }
        

        public DropDownProvider(Control containerControl, Control anchorControl)
        {
            _dropDownControl = new DropDownControl() { Visible = false };
            AnchorControl = anchorControl;
            ContainerControl = containerControl;
            _cronometro = 0;
        }

        public DropDownProvider()
        {
            _dropDownControl = new DropDownControl() { Visible = false };
            //_dropDownControl.Parent = ancora;
            //_dropDownControl.InitializeDropDown(container);
            _cronometro = 0;
        }



        public bool ClickDropDown()
        {
            if (_dropDownControl.DropState == DropDownControl.eDropState.Closing ||
                _dropDownControl.DropState == DropDownControl.eDropState.Dropping)
                return false;

            if (_dropDownControl.DropState == DropDownControl.eDropState.Closed)
            {
                _dropDownControl.OpenDropDown();
                OnDropDownOpen();
                return true;
            }

            if (_dropDownControl.DropState == DropDownControl.eDropState.Dropped)
            {
                _dropDownControl.CloseDropDown();
                OnDropDownClose();
                return true;
            }

            return true;
        }

        public void FecharDropDown()
        {
            if (_dropDownControl.DropState == DropDownControl.eDropState.Closing ||
               _dropDownControl.DropState == DropDownControl.eDropState.Dropping)
                return;

            _dropDownControl.CloseDropDown();
            OnDropDownClose();
        }

        public void AbrirDropDown()
        {
            if (_dropDownControl.DropState == DropDownControl.eDropState.Closing ||
               _dropDownControl.DropState == DropDownControl.eDropState.Dropping)
                return;

            _dropDownControl.OpenDropDown();
            OnDropDownOpen();

        }

        protected virtual void OnDropDownOpen()
        {
            DropDownOpen?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnDropDownClose()
        {
            DropDownClose?.Invoke(this, EventArgs.Empty);
        }
    }
}
