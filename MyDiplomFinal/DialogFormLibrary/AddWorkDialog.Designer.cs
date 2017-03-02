namespace DialogFormLibrary
{
    partial class AddWorkDialog
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
            this.textBox1_WorkName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_WorkAmmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_WorkUnitPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox_WorkUnit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // textBox1_WorkName
            // 
            this.textBox1_WorkName.Location = new System.Drawing.Point(30, 39);
            this.textBox1_WorkName.Name = "textBox1_WorkName";
            this.textBox1_WorkName.Size = new System.Drawing.Size(161, 20);
            this.textBox1_WorkName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "объем";
            // 
            // textBox_WorkAmmount
            // 
            this.textBox_WorkAmmount.Location = new System.Drawing.Point(30, 78);
            this.textBox_WorkAmmount.Name = "textBox_WorkAmmount";
            this.textBox_WorkAmmount.Size = new System.Drawing.Size(89, 20);
            this.textBox_WorkAmmount.TabIndex = 3;
            this.textBox_WorkAmmount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ед. изм";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "цена за ед.";
            // 
            // textBox_WorkUnitPrice
            // 
            this.textBox_WorkUnitPrice.Location = new System.Drawing.Point(30, 117);
            this.textBox_WorkUnitPrice.Name = "textBox_WorkUnitPrice";
            this.textBox_WorkUnitPrice.Size = new System.Drawing.Size(61, 20);
            this.textBox_WorkUnitPrice.TabIndex = 7;
            this.textBox_WorkUnitPrice.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "руб.";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(30, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(116, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Отмена";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox_WorkUnit
            // 
            this.comboBox_WorkUnit.FormattingEnabled = true;
            this.comboBox_WorkUnit.Location = new System.Drawing.Point(135, 77);
            this.comboBox_WorkUnit.Name = "comboBox_WorkUnit";
            this.comboBox_WorkUnit.Size = new System.Drawing.Size(56, 21);
            this.comboBox_WorkUnit.TabIndex = 12;
            // 
            // AddWorkDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 217);
            this.Controls.Add(this.comboBox_WorkUnit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_WorkUnitPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_WorkAmmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1_WorkName);
            this.Controls.Add(this.label1);
            this.Name = "AddWorkDialog";
            this.Text = "AddWorkDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1_WorkName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_WorkAmmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_WorkUnitPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.ComboBox comboBox_WorkUnit;
    }
}