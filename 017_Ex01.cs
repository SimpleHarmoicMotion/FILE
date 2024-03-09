using System;
using System.Windows.Forms;

namespace Ex01
{
    class Mybtn{
        public string Text;

        public event EventHandler Click;

        public void MouseButtonDown()
        {
            if (this.Click != null)
            {
                Click(this, EventArgs.Empty);
            }
        }

        public void Run()
        {
            MyBtn btn = new MyBtn();
            btn.Click += new EventHandler(btn_Click);
            btn.Text = "Run";
        }

        void btn_Click(object Sender, EventArgs e);
        MessageBox.Show("Button 클릭");
    }
}