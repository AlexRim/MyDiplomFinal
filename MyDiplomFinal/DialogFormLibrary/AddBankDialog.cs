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
    public partial class AddBankDialog : Form
    {
        public AddBankDialog()
        {
            InitializeComponent();
        }

        private void checkBox_EditBankInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_EditBankInfo.Checked == false)
            {
                this.textBox_PhonePhax.Enabled = true;
                this.textBox_BankCode.Enabled = true;
                this.textBox_BankName.Enabled = true;
                this.textBox_BankUNN.Enabled = true;
            }

           else
            {
                this.textBox_PhonePhax.Enabled = false;
                this.textBox_BankCode.Enabled = false;
                this.textBox_BankName.Enabled = false;
                this.textBox_BankUNN.Enabled = false;
            }
        }
    }
}
