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
    public partial class AddContractDialog : Form
    {
        public AddContractDialog()
        {
            InitializeComponent();
        }

        private void textBox_ContractPrice_Validating(object sender, CancelEventArgs e)
        {
            string str = textBox_ContractPrice.Text;
            double result;
            bool z = double.TryParse(str, out result);
            if (z == false || str.Length == 0 || result < 0)
            {
                e.Cancel = true;

            }
            else

                e.Cancel = false;
        }
    }
}
