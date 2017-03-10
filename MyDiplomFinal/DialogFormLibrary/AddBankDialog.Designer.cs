namespace DialogFormLibrary
{
    partial class AddBankDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_BankName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.textBox_BankCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox_EditBankInfo = new System.Windows.Forms.CheckBox();
            this.textBox_BankUNN = new System.Windows.Forms.TextBox();
            this.textBox_PhonePhax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование  банка";
            // 
            // textBox_BankName
            // 
            this.textBox_BankName.Location = new System.Drawing.Point(27, 29);
            this.textBox_BankName.Name = "textBox_BankName";
            this.textBox_BankName.Size = new System.Drawing.Size(330, 20);
            this.textBox_BankName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "УНН Банка";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(24, 91);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(60, 13);
            this.lab.TabIndex = 4;
            this.lab.Text = "Код Банка";
            // 
            // textBox_BankCode
            // 
            this.textBox_BankCode.Location = new System.Drawing.Point(27, 107);
            this.textBox_BankCode.MaxLength = 9;
            this.textBox_BankCode.Name = "textBox_BankCode";
            this.textBox_BankCode.Size = new System.Drawing.Size(330, 20);
            this.textBox_BankCode.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Расчетный счет";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(92, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(234, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox_EditBankInfo
            // 
            this.checkBox_EditBankInfo.AutoSize = true;
            this.checkBox_EditBankInfo.Location = new System.Drawing.Point(27, 187);
            this.checkBox_EditBankInfo.Name = "checkBox_EditBankInfo";
            this.checkBox_EditBankInfo.Size = new System.Drawing.Size(103, 17);
            this.checkBox_EditBankInfo.TabIndex = 10;
            this.checkBox_EditBankInfo.Text = "Редактировать";
            this.checkBox_EditBankInfo.UseVisualStyleBackColor = true;
            this.checkBox_EditBankInfo.CheckedChanged += new System.EventHandler(this.checkBox_EditBankInfo_CheckedChanged);
            // 
            // textBox_BankUNN
            // 
            this.textBox_BankUNN.Location = new System.Drawing.Point(27, 68);
            this.textBox_BankUNN.MaxLength = 9;
            this.textBox_BankUNN.Name = "textBox_BankUNN";
            this.textBox_BankUNN.Size = new System.Drawing.Size(330, 20);
            this.textBox_BankUNN.TabIndex = 3;
            // 
            // textBox_PhonePhax
            // 
            this.textBox_PhonePhax.Location = new System.Drawing.Point(27, 146);
            this.textBox_PhonePhax.MaxLength = 13;
            this.textBox_PhonePhax.Name = "textBox_PhonePhax";
            this.textBox_PhonePhax.Size = new System.Drawing.Size(330, 20);
            this.textBox_PhonePhax.TabIndex = 12;
            // 
            // AddBankDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 256);
            this.Controls.Add(this.textBox_PhonePhax);
            this.Controls.Add(this.checkBox_EditBankInfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_BankCode);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.textBox_BankUNN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_BankName);
            this.Controls.Add(this.label1);
            this.Name = "AddBankDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddBankDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_BankName;
        private System.Windows.Forms.Label lab;
        public System.Windows.Forms.TextBox textBox_BankCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.CheckBox checkBox_EditBankInfo;
        public System.Windows.Forms.TextBox textBox_BankUNN;
        public System.Windows.Forms.TextBox textBox_PhonePhax;
    }
}