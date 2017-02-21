using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControlLibrary;


namespace MyDiplomFinal
{
    public partial class Form1 : Form
    {
        public MyFormUserControl1 userControl1;
        public MyFormUserControl2 userControl2;


            // method removes current userControl    
        public void ChangeUserControl(MyFormUserControl1 userControl1, MyFormUserControl2 userControl2)
        {
            if (userControl1 != null)
            {
                Controls.Remove(userControl1);
                userControl1.Dispose();
            }
            if (userControl2 != null)
            {
                Controls.Remove(userControl2);
                userControl2.Dispose();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeUserControl(userControl1, userControl2);
            userControl1 = new MyFormUserControl1();
            this.Controls.Add(userControl1);
            userControl1.Top = 25;
            userControl1.Left = 0;
        }

        private void расчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeUserControl(userControl1, userControl2);
            userControl2 = new MyFormUserControl2();
            this.Controls.Add(userControl2);
            userControl1.Top = 25;
            userControl1.Left = 0;
        }
    }
}
