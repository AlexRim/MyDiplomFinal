using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogFormLibrary
{
    public partial class AddWorkDialog : Form
    {
        public AddWorkDialog()
        {
            InitializeComponent();
        }

        private void textBox_WorkAmmount_Validating(object sender, CancelEventArgs e)
        {
            string str = textBox_WorkAmmount.Text;
            double result;
            bool z = double.TryParse(str, out result);
            if (z == false || str.Length == 0 || result <= 0)
            {
                e.Cancel = true;

            }
            else

                e.Cancel = false;
        }

        private void textBox_WorkUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_WorkUnitPrice_Validating(object sender, CancelEventArgs e)
        {
            string str =textBox_WorkUnitPrice.Text;
            double result;
            bool z = double.TryParse(str, out result);
            if (z == false || str.Length == 0 || result <= 0)
            {
                e.Cancel = true;

            }
            else

                e.Cancel = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данный функционал в разработке!");
        }
    }
}
