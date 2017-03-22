namespace DialogFormLibrary
{
    partial class ClientDialog
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
            this.textBox1_ClientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_ClientAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ClientUNN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ClientPassport = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ClintPhone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название/ФИО";
            // 
            // textBox1_ClientName
            // 
            this.textBox1_ClientName.Location = new System.Drawing.Point(30, 59);
            this.textBox1_ClientName.Name = "textBox1_ClientName";
            this.textBox1_ClientName.Size = new System.Drawing.Size(188, 20);
            this.textBox1_ClientName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адрес";
            // 
            // textBox1_ClientAdress
            // 
            this.textBox1_ClientAdress.Location = new System.Drawing.Point(30, 98);
            this.textBox1_ClientAdress.Name = "textBox1_ClientAdress";
            this.textBox1_ClientAdress.Size = new System.Drawing.Size(188, 20);
            this.textBox1_ClientAdress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "УНН";
            // 
            // textBox_ClientUNN
            // 
            this.textBox_ClientUNN.Location = new System.Drawing.Point(30, 137);
            this.textBox_ClientUNN.MaxLength = 9;
            this.textBox_ClientUNN.Name = "textBox_ClientUNN";
            this.textBox_ClientUNN.Size = new System.Drawing.Size(188, 20);
            this.textBox_ClientUNN.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Пасспорт";
            // 
            // textBox_ClientPassport
            // 
            this.textBox_ClientPassport.Location = new System.Drawing.Point(30, 176);
            this.textBox_ClientPassport.MaxLength = 9;
            this.textBox_ClientPassport.Name = "textBox_ClientPassport";
            this.textBox_ClientPassport.Size = new System.Drawing.Size(188, 20);
            this.textBox_ClientPassport.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Тел_Факс";
            // 
            // textBox_ClintPhone
            // 
            this.textBox_ClintPhone.Location = new System.Drawing.Point(30, 215);
            this.textBox_ClintPhone.Name = "textBox_ClintPhone";
            this.textBox_ClintPhone.Size = new System.Drawing.Size(188, 20);
            this.textBox_ClintPhone.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(30, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(143, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(30, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Юр. лицо";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(140, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.Text = "Физ. лицо";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // ClientDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 300);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_ClintPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_ClientPassport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ClientUNN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1_ClientAdress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1_ClientName);
            this.Controls.Add(this.label1);
            this.Name = "ClientDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClientDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1_ClientName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox1_ClientAdress;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox_ClientUNN;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_ClientPassport;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox_ClintPhone;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.RadioButton radioButton2;
    }
}