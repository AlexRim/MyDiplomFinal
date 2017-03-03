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
            this.dataGridView_AdWork = new System.Windows.Forms.DataGridView();
            this.button_AddWork = new System.Windows.Forms.Button();
            this.button_DeleteWork = new System.Windows.Forms.Button();
            this.button_ChangeWork = new System.Windows.Forms.Button();
            this.dataGridView_ShowMaterials = new System.Windows.Forms.DataGridView();
            this.button_AddMaterial = new System.Windows.Forms.Button();
            this.button_DeleteMaterial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_Contr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AdWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ShowMaterials)).BeginInit();
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
            this.listBox1_TypesOfWork.SelectedIndexChanged += new System.EventHandler(this.listBox1_TypesOfWork_SelectedIndexChanged);
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
            // dataGridView_AdWork
            // 
            this.dataGridView_AdWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AdWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AdWork.Location = new System.Drawing.Point(264, 70);
            this.dataGridView_AdWork.MultiSelect = false;
            this.dataGridView_AdWork.Name = "dataGridView_AdWork";
            this.dataGridView_AdWork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_AdWork.Size = new System.Drawing.Size(591, 160);
            this.dataGridView_AdWork.TabIndex = 5;
            // 
            // button_AddWork
            // 
            this.button_AddWork.Location = new System.Drawing.Point(862, 70);
            this.button_AddWork.Name = "button_AddWork";
            this.button_AddWork.Size = new System.Drawing.Size(75, 23);
            this.button_AddWork.TabIndex = 6;
            this.button_AddWork.Text = "Добавить работу";
            this.button_AddWork.UseVisualStyleBackColor = true;
            this.button_AddWork.Click += new System.EventHandler(this.button_AddWork_Click);
            // 
            // button_DeleteWork
            // 
            this.button_DeleteWork.Location = new System.Drawing.Point(862, 100);
            this.button_DeleteWork.Name = "button_DeleteWork";
            this.button_DeleteWork.Size = new System.Drawing.Size(75, 23);
            this.button_DeleteWork.TabIndex = 7;
            this.button_DeleteWork.Text = "Удалить работу";
            this.button_DeleteWork.UseVisualStyleBackColor = true;
            this.button_DeleteWork.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_ChangeWork
            // 
            this.button_ChangeWork.Location = new System.Drawing.Point(862, 130);
            this.button_ChangeWork.Name = "button_ChangeWork";
            this.button_ChangeWork.Size = new System.Drawing.Size(75, 23);
            this.button_ChangeWork.TabIndex = 8;
            this.button_ChangeWork.Text = "Редакт.";
            this.button_ChangeWork.UseVisualStyleBackColor = true;
            this.button_ChangeWork.Click += new System.EventHandler(this.button_ChangeWork_Click);
            // 
            // dataGridView_ShowMaterials
            // 
            this.dataGridView_ShowMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ShowMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ShowMaterials.Location = new System.Drawing.Point(264, 254);
            this.dataGridView_ShowMaterials.MultiSelect = false;
            this.dataGridView_ShowMaterials.Name = "dataGridView_ShowMaterials";
            this.dataGridView_ShowMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ShowMaterials.Size = new System.Drawing.Size(591, 160);
            this.dataGridView_ShowMaterials.TabIndex = 9;
            // 
            // button_AddMaterial
            // 
            this.button_AddMaterial.Location = new System.Drawing.Point(861, 254);
            this.button_AddMaterial.Name = "button_AddMaterial";
            this.button_AddMaterial.Size = new System.Drawing.Size(75, 23);
            this.button_AddMaterial.TabIndex = 10;
            this.button_AddMaterial.Text = "Добавить";
            this.button_AddMaterial.UseVisualStyleBackColor = true;
            this.button_AddMaterial.Click += new System.EventHandler(this.button_AddMaterial_Click);
            // 
            // button_DeleteMaterial
            // 
            this.button_DeleteMaterial.Location = new System.Drawing.Point(862, 284);
            this.button_DeleteMaterial.Name = "button_DeleteMaterial";
            this.button_DeleteMaterial.Size = new System.Drawing.Size(75, 23);
            this.button_DeleteMaterial.TabIndex = 11;
            this.button_DeleteMaterial.Text = "Удалить";
            this.button_DeleteMaterial.UseVisualStyleBackColor = true;
            this.button_DeleteMaterial.Click += new System.EventHandler(this.button_DeleteMaterial_Click);
            // 
            // MyFormUserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.button_DeleteMaterial);
            this.Controls.Add(this.button_AddMaterial);
            this.Controls.Add(this.dataGridView_ShowMaterials);
            this.Controls.Add(this.button_ChangeWork);
            this.Controls.Add(this.button_DeleteWork);
            this.Controls.Add(this.button_AddWork);
            this.Controls.Add(this.dataGridView_AdWork);
            this.Controls.Add(this.button_ChangeTypeOfWork);
            this.Controls.Add(this.button_DeleteWorkType);
            this.Controls.Add(this.button_AddTypeWork);
            this.Controls.Add(this.listBox1_TypesOfWork);
            this.Controls.Add(this.dataGridView2_Contr);
            this.Name = "MyFormUserControl2";
            this.Size = new System.Drawing.Size(1000, 675);
            this.Load += new System.EventHandler(this.MyFormUserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_Contr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AdWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ShowMaterials)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView2_Contr;
        public System.Windows.Forms.ListBox listBox1_TypesOfWork;
        private System.Windows.Forms.Button button_AddTypeWork;
        private System.Windows.Forms.Button button_DeleteWorkType;
        private System.Windows.Forms.Button button_ChangeTypeOfWork;
        public System.Windows.Forms.DataGridView dataGridView_AdWork;
        private System.Windows.Forms.Button button_AddWork;
        private System.Windows.Forms.Button button_DeleteWork;
        private System.Windows.Forms.Button button_ChangeWork;
        public System.Windows.Forms.DataGridView dataGridView_ShowMaterials;
        private System.Windows.Forms.Button button_AddMaterial;
        private System.Windows.Forms.Button button_DeleteMaterial;
    }
}
