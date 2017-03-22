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
    public partial class AddMaterialDialog : Form
    {
        public AddMaterialDialog()
        {
            InitializeComponent();
        }

        private void textBox_MaterialAmmount_Validating(object sender, CancelEventArgs e)
        {
            string str = textBox_MaterialAmmount.Text;
            double result;
            bool z = double.TryParse(str, out result);
            if (z == false || str.Length == 0 || result <= 0)
            {
                e.Cancel = true;

            }
            else

                e.Cancel = false;
        }

        private void textBox_MaterialUnitPrice_Validating(object sender, CancelEventArgs e)
        {
            string str = textBox_MaterialUnitPrice.Text;
            double result;
            bool z = double.TryParse(str, out result);
            if (z == false || str.Length == 0 || result <= 0)
            {
                e.Cancel = true;

            }
            else

                e.Cancel = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данный функционал в разработке!");
        }
    }
}
