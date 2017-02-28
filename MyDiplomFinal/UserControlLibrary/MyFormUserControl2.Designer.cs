namespace UserControlLibrary
{
    partial class MyFormUserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView2_Contr = new System.Windows.Forms.DataGridView();
            this.listBox1_TypesOfWork = new System.Windows.Forms.ListBox();
            this.button_AddTypeWork = new System.Windows.Forms.Button();
            this.button_DeleteWorkType = new System.Windows.Forms.Button();
            this.button_ChangeTypeOfWork = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_Contr)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2_Contr
            // 
            this.dataGridView2_Contr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2_Contr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2_Contr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_Contr.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2_Contr.MultiSelect = false;
            this.dataGridView2_Contr.Name = "dataGridView2_Contr";
            this.dataGridView2_Contr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2_Contr.Size = new System.Drawing.Size(598, 41);
            this.dataGridView2_Contr.TabIndex = 0;
            // 
            // listBox1_TypesOfWork
            // 
            this.listBox1_TypesOfWork.FormattingEnabled = true;
            this.listBox1_TypesOfWork.Location = new System.Drawing.Point(3, 70);
            this.listBox1_TypesOfWork.Name = "listBox1_TypesOfWork";
            this.listBox1_TypesOfWork.Size = new System.Drawing.Size(161, 160);
            this.listBox1_TypesOfWork.TabIndex = 1;
            // 
            // button_AddTypeWork
            // 
            this.button_AddTypeWork.Location = new System.Drawing.Point(170, 70);
            this.button_AddTypeWork.Name = "button_AddTypeWork";
            this.button_AddTypeWork.Size = new System.Drawing.Size(75, 23);
            this.button_AddTypeWork.TabIndex = 2;
            this.button_AddTypeWork.Text = "Добавить ПТМ";
            this.button_AddTypeWork.UseVisualStyleBackColor = true;
            this.button_AddTypeWork.Click += new System.EventHandler(this.button_AddTypeWork_Click);
            // 
            // button_DeleteWorkType
            // 
            this.button_DeleteWorkType.Location = new System.Drawing.Point(171, 100);
            this.button_DeleteWorkType.Name = "button_DeleteWorkType";
            this.button_DeleteWorkType.Size = new System.Drawing.Size(75, 23);
            this.button_DeleteWorkType.TabIndex = 3;
            this.button_DeleteWorkType.Text = "Удалить тип работ";
            this.button_DeleteWorkType.UseVisualStyleBackColor = true;
            this.button_DeleteWorkType.Click += new System.EventHandler(this.button_DeleteWorkType_Click);
            // 
            // button_ChangeTypeOfWork
            // 
            this.button_ChangeTypeOfWork.Location = new System.Drawing.Point(171, 130);
            this.button_ChangeTypeOfWork.Name = "button_ChangeTypeOfWork";
            this.button_ChangeTypeOfWork.Size = new System.Drawing.Size(75, 23);
            this.button_ChangeTypeOfWork.TabIndex = 4;
            this.button_ChangeTypeOfWork.Text = "Редакт.  ";
            this.button_ChangeTypeOfWork.UseVisualStyleBackColor = true;
            this.button_ChangeTypeOfWork.Click += new System.EventHandler(this.button_ChangeTypeOfWork_Click);
            // 
            // MyFormUserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.button_ChangeTypeOfWork);
            this.Controls.Add(this.button_DeleteWorkType);
            this.Controls.Add(this.button_AddTypeWork);
            this.Controls.Add(this.listBox1_TypesOfWork);
            this.Controls.Add(this.dataGridView2_Contr);
            this.Name = "MyFormUserControl2";
            this.Size = new System.Drawing.Size(1000, 675);
            this.Load += new System.EventHandler(this.MyFormUserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_Contr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView2_Contr;
        public System.Windows.Forms.ListBox listBox1_TypesOfWork;
        private System.Windows.Forms.Button button_AddTypeWork;
        private System.Windows.Forms.Button button_DeleteWorkType;
        private System.Windows.Forms.Button button_ChangeTypeOfWork;
    }
}
