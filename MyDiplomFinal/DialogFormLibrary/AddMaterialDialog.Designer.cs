namespace DialogFormLibrary
{
    partial class AddMaterialDialog
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
            this.textBox_MaterialName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_MaterialAmmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_MaterialUnit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_MaterialUnitPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // textBox_MaterialName
            // 
            this.textBox_MaterialName.Location = new System.Drawing.Point(29, 29);
            this.textBox_MaterialName.Name = "textBox_MaterialName";
            this.textBox_MaterialName.Size = new System.Drawing.Size(161, 20);
            this.textBox_MaterialName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Объем";
            // 
            // textBox_MaterialAmmount
            // 
            this.textBox_MaterialAmmount.Location = new System.Drawing.Point(29, 68);
            this.textBox_MaterialAmmount.Name = "textBox_MaterialAmmount";
            this.textBox_MaterialAmmount.Size = new System.Drawing.Size(80, 20);
            this.textBox_MaterialAmmount.TabIndex = 3;
            this.textBox_MaterialAmmount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ед. изм.";
            // 
            // comboBox_MaterialUnit
            // 
            this.comboBox_MaterialUnit.FormattingEnabled = true;
            this.comboBox_MaterialUnit.Location = new System.Drawing.Point(134, 68);
            this.comboBox_MaterialUnit.Name = "comboBox_MaterialUnit";
            this.comboBox_MaterialUnit.Size = new System.Drawing.Size(56, 21);
            this.comboBox_MaterialUnit.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "цена за ед.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "руб.";
            // 
            // textBox_MaterialUnitPrice
            // 
            this.textBox_MaterialUnitPrice.Location = new System.Drawing.Point(29, 109);
            this.textBox_MaterialUnitPrice.Name = "textBox_MaterialUnitPrice";
            this.textBox_MaterialUnitPrice.Size = new System.Drawing.Size(80, 20);
            this.textBox_MaterialUnitPrice.TabIndex = 16;
            this.textBox_MaterialUnitPrice.Text = "0";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(29, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(115, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddMaterialDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 206);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_MaterialUnitPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_MaterialUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_MaterialAmmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_MaterialName);
            this.Controls.Add(this.label1);
            this.Name = "AddMaterialDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddMaterialDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_MaterialName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_MaterialAmmount;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBox_MaterialUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox_MaterialUnitPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}