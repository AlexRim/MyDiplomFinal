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
        public Form1()
        {
            InitializeComponent();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControl1 = new MyFormUserControl1();
            this.Controls.Add(userControl1);
            userControl1.Top = 25;
            userControl1.Left = 0;
        }
    }
}
