namespace DialogFormLibrary
{
    partial class AddContractDialog
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
            this.textBox_ContractNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ContractObject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ContractDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ContractPrice = new System.Windows.Forms.TextBox();
            this.radioButton_Status1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Status2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Status3 = new System.Windows.Forms.RadioButton();
            this.radioButton_Status4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_ContractNumber
            // 
            this.textBox_ContractNumber.Location = new System.Drawing.Point(26, 33);
            this.textBox_ContractNumber.Name = "textBox_ContractNumber";
            this.textBox_ContractNumber.Size = new System.Drawing.Size(200, 20);
            this.textBox_ContractNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер договора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Предмет договора";
            // 
            // textBox_ContractObject
            // 
            this.textBox_ContractObject.Location = new System.Drawing.Point(26, 72);
            this.textBox_ContractObject.Name = "textBox_ContractObject";
            this.textBox_ContractObject.Size = new System.Drawing.Size(200, 20);
            this.textBox_ContractObject.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата договора";
            // 
            // textBox_ContractDate
            // 
            this.textBox_ContractDate.Location = new System.Drawing.Point(26, 111);
            this.textBox_ContractDate.Name = "textBox_ContractDate";
            this.textBox_ContractDate.Size = new System.Drawing.Size(200, 20);
            this.textBox_ContractDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена договора";
            // 
            // textBox_ContractPrice
            // 
            this.textBox_ContractPrice.Location = new System.Drawing.Point(26, 150);
            this.textBox_ContractPrice.Name = "textBox_ContractPrice";
            this.textBox_ContractPrice.Size = new System.Drawing.Size(200, 20);
            this.textBox_ContractPrice.TabIndex = 7;
            this.textBox_ContractPrice.Text = "0";
            // 
            // radioButton_Status1
            // 
            this.radioButton_Status1.AutoSize = true;
            this.radioButton_Status1.Location = new System.Drawing.Point(26, 188);
            this.radioButton_Status1.Name = "radioButton_Status1";
            this.radioButton_Status1.Size = new System.Drawing.Size(91, 17);
            this.radioButton_Status1.TabIndex = 8;
            this.radioButton_Status1.TabStop = true;
            this.radioButton_Status1.Text = "заключается";
            this.radioButton_Status1.UseVisualStyleBackColor = true;
            // 
            // radioButton_Status2
            // 
            this.radioButton_Status2.AutoSize = true;
            this.radioButton_Status2.Location = new System.Drawing.Point(135, 188);
            this.radioButton_Status2.Name = "radioButton_Status2";
            this.radioButton_Status2.Size = new System.Drawing.Size(90, 17);
            this.radioButton_Status2.TabIndex = 9;
            this.radioButton_Status2.TabStop = true;
            this.radioButton_Status2.Text = "исполняется";
            this.radioButton_Status2.UseVisualStyleBackColor = true;
            // 
            // radioButton_Status3
            // 
            this.radioButton_Status3.AutoSize = true;
            this.radioButton_Status3.Location = new System.Drawing.Point(26, 211);
            this.radioButton_Status3.Name = "radioButton_Status3";
            this.radioButton_Status3.Size = new System.Drawing.Size(73, 17);
            this.radioButton_Status3.TabIndex = 10;
            this.radioButton_Status3.TabStop = true;
            this.radioButton_Status3.Text = "исполнен";
            this.radioButton_Status3.UseVisualStyleBackColor = true;
            // 
            // radioButton_Status4
            // 
            this.radioButton_Status4.AutoSize = true;
            this.radioButton_Status4.Location = new System.Drawing.Point(135, 211);
            this.radioButton_Status4.Name = "radioButton_Status4";
            this.radioButton_Status4.Size = new System.Drawing.Size(81, 17);
            this.radioButton_Status4.TabIndex = 11;
            this.radioButton_Status4.TabStop = true;
            this.radioButton_Status4.Text = "расторгнут";
            this.radioButton_Status4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(26, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(150, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddContractDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 304);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton_Status4);
            this.Controls.Add(this.radioButton_Status3);
            this.Controls.Add(this.radioButton_Status2);
            this.Controls.Add(this.radioButton_Status1);
            this.Controls.Add(this.textBox_ContractPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ContractDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_ContractObject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ContractNumber);
            this.Name = "AddContractDialog";
            this.Text = "AddContractDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_ContractNumber;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_ContractObject;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox_ContractDate;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_ContractPrice;
        public System.Windows.Forms.RadioButton radioButton_Status1;
        public System.Windows.Forms.RadioButton radioButton_Status2;
        public System.Windows.Forms.RadioButton radioButton_Status3;
        public System.Windows.Forms.RadioButton radioButton_Status4;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
    }
}