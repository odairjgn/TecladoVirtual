namespace TecladoVirtual
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxWithVirtualKeyBoard1 = new TecladoVirtual.Controles.TextBoxWithVirtualKeyBoard();
            this.textBoxWithVirtualKeyBoard2 = new TecladoVirtual.Controles.TextBoxWithVirtualKeyBoard();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxWithVirtualKeyBoard1
            // 
            this.textBoxWithVirtualKeyBoard1.Location = new System.Drawing.Point(28, 30);
            this.textBoxWithVirtualKeyBoard1.Name = "textBoxWithVirtualKeyBoard1";
            this.textBoxWithVirtualKeyBoard1.Size = new System.Drawing.Size(194, 20);
            this.textBoxWithVirtualKeyBoard1.TabIndex = 0;
            this.textBoxWithVirtualKeyBoard1.Terminado += new System.EventHandler(this.textBoxWithVirtualKeyBoard1_Terminado);
            // 
            // textBoxWithVirtualKeyBoard2
            // 
            this.textBoxWithVirtualKeyBoard2.Location = new System.Drawing.Point(28, 72);
            this.textBoxWithVirtualKeyBoard2.Name = "textBoxWithVirtualKeyBoard2";
            this.textBoxWithVirtualKeyBoard2.Size = new System.Drawing.Size(194, 20);
            this.textBoxWithVirtualKeyBoard2.TabIndex = 1;
            this.textBoxWithVirtualKeyBoard2.Terminado += new System.EventHandler(this.textBoxWithVirtualKeyBoard2_Terminado);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 119);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWithVirtualKeyBoard2);
            this.Controls.Add(this.textBoxWithVirtualKeyBoard1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.TextBoxWithVirtualKeyBoard textBoxWithVirtualKeyBoard1;
        private Controles.TextBoxWithVirtualKeyBoard textBoxWithVirtualKeyBoard2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

