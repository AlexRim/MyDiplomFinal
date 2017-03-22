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
            this.button_ChangeMat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_FindTypeOfWork = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.dataGridView2_Contr.Location = new System.Drawing.Point(221, 3);
            this.dataGridView2_Contr.MultiSelect = false;
            this.dataGridView2_Contr.Name = "dataGridView2_Contr";
            this.dataGridView2_Contr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2_Contr.Size = new System.Drawing.Size(591, 41);
            this.dataGridView2_Contr.TabIndex = 0;
            // 
            // listBox1_TypesOfWork
            // 
            this.listBox1_TypesOfWork.FormattingEnabled = true;
            this.listBox1_TypesOfWork.Location = new System.Drawing.Point(25, 70);
            this.listBox1_TypesOfWork.Name = "listBox1_TypesOfWork";
            this.listBox1_TypesOfWork.Size = new System.Drawing.Size(161, 264);
            this.listBox1_TypesOfWork.TabIndex = 1;
            this.listBox1_TypesOfWork.SelectedIndexChanged += new System.EventHandler(this.listBox1_TypesOfWork_SelectedIndexChanged);
            // 
            // button_AddTypeWork
            // 
            this.button_AddTypeWork.Location = new System.Drawing.Point(25, 340);
            this.button_AddTypeWork.Name = "button_AddTypeWork";
            this.button_AddTypeWork.Size = new System.Drawing.Size(76, 23);
            this.button_AddTypeWork.TabIndex = 2;
            this.button_AddTypeWork.Text = "Добавить ПТМ";
            this.button_AddTypeWork.UseVisualStyleBackColor = true;
            this.button_AddTypeWork.Click += new System.EventHandler(this.button_AddTypeWork_Click);
            // 
            // button_DeleteWorkType
            // 
            this.button_DeleteWorkType.Location = new System.Drawing.Point(110, 340);
            this.button_DeleteWorkType.Name = "button_DeleteWorkType";
            this.button_DeleteWorkType.Size = new System.Drawing.Size(75, 23);
            this.button_DeleteWorkType.TabIndex = 3;
            this.button_DeleteWorkType.Text = "Удалить тип работ";
            this.button_DeleteWorkType.UseVisualStyleBackColor = true;
            this.button_DeleteWorkType.Click += new System.EventHandler(this.button_DeleteWorkType_Click);
            // 
            // button_ChangeTypeOfWork
            // 
            this.button_ChangeTypeOfWork.Location = new System.Drawing.Point(28, 369);
            this.button_ChangeTypeOfWork.Name = "button_ChangeTypeOfWork";
            this.button_ChangeTypeOfWork.Size = new System.Drawing.Size(73, 23);
            this.button_ChangeTypeOfWork.TabIndex = 4;
            this.button_ChangeTypeOfWork.Text = "Редакт.  ";
            this.button_ChangeTypeOfWork.UseVisualStyleBackColor = true;
            this.button_ChangeTypeOfWork.Click += new System.EventHandler(this.button_ChangeTypeOfWork_Click);
            // 
            // dataGridView_AdWork
            // 
            this.dataGridView_AdWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_AdWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AdWork.Location = new System.Drawing.Point(221, 70);
            this.dataGridView_AdWork.MultiSelect = false;
            this.dataGridView_AdWork.Name = "dataGridView_AdWork";
            this.dataGridView_AdWork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_AdWork.Size = new System.Drawing.Size(591, 160);
            this.dataGridView_AdWork.TabIndex = 5;
            this.dataGridView_AdWork.SelectionChanged += new System.EventHandler(this.dataGridView_AdWork_SelectionChanged);
            // 
            // button_AddWork
            // 
            this.button_AddWork.Location = new System.Drawing.Point(818, 70);
            this.button_AddWork.Name = "button_AddWork";
            this.button_AddWork.Size = new System.Drawing.Size(75, 23);
            this.button_AddWork.TabIndex = 6;
            this.button_AddWork.Text = "Добавить работу";
            this.button_AddWork.UseVisualStyleBackColor = true;
            this.button_AddWork.Click += new System.EventHandler(this.button_AddWork_Click);
            // 
            // button_DeleteWork
            // 
            this.button_DeleteWork.Location = new System.Drawing.Point(818, 99);
            this.button_DeleteWork.Name = "button_DeleteWork";
            this.button_DeleteWork.Size = new System.Drawing.Size(75, 23);
            this.button_DeleteWork.TabIndex = 7;
            this.button_DeleteWork.Text = "Удалить работу";
            this.button_DeleteWork.UseVisualStyleBackColor = true;
            this.button_DeleteWork.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_ChangeWork
            // 
            this.button_ChangeWork.Location = new System.Drawing.Point(819, 128);
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
            this.dataGridView_ShowMaterials.Location = new System.Drawing.Point(221, 258);
            this.dataGridView_ShowMaterials.MultiSelect = false;
            this.dataGridView_ShowMaterials.Name = "dataGridView_ShowMaterials";
            this.dataGridView_ShowMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_ShowMaterials.Size = new System.Drawing.Size(591, 160);
            this.dataGridView_ShowMaterials.TabIndex = 9;
            this.dataGridView_ShowMaterials.SelectionChanged += new System.EventHandler(this.dataGridView_ShowMaterials_SelectionChanged);
            // 
            // button_AddMaterial
            // 
            this.button_AddMaterial.Location = new System.Drawing.Point(818, 258);
            this.button_AddMaterial.Name = "button_AddMaterial";
            this.button_AddMaterial.Size = new System.Drawing.Size(75, 23);
            this.button_AddMaterial.TabIndex = 10;
            this.button_AddMaterial.Text = "Добавить";
            this.button_AddMaterial.UseVisualStyleBackColor = true;
            this.button_AddMaterial.Click += new System.EventHandler(this.button_AddMaterial_Click);
            // 
            // button_DeleteMaterial
            // 
            this.button_DeleteMaterial.Location = new System.Drawing.Point(819, 288);
            this.button_DeleteMaterial.Name = "button_DeleteMaterial";
            this.button_DeleteMaterial.Size = new System.Drawing.Size(75, 23);
            this.button_DeleteMaterial.TabIndex = 11;
            this.button_DeleteMaterial.Text = "Удалить";
            this.button_DeleteMaterial.UseVisualStyleBackColor = true;
            this.button_DeleteMaterial.Click += new System.EventHandler(this.button_DeleteMaterial_Click);
            // 
            // button_ChangeMat
            // 
            this.button_ChangeMat.Location = new System.Drawing.Point(818, 317);
            this.button_ChangeMat.Name = "button_ChangeMat";
            this.button_ChangeMat.Size = new System.Drawing.Size(75, 23);
            this.button_ChangeMat.TabIndex = 12;
            this.button_ChangeMat.Text = "Редакт.";
            this.button_ChangeMat.UseVisualStyleBackColor = true;
            this.button_ChangeMat.Click += new System.EventHandler(this.button_ChangeMat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ПТМ:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_FindTypeOfWork
            // 
            this.button_FindTypeOfWork.Location = new System.Drawing.Point(110, 369);
            this.button_FindTypeOfWork.Name = "button_FindTypeOfWork";
            this.button_FindTypeOfWork.Size = new System.Drawing.Size(75, 23);
            this.button_FindTypeOfWork.TabIndex = 14;
            this.button_FindTypeOfWork.Text = "Найти ";
            this.button_FindTypeOfWork.UseVisualStyleBackColor = true;
            this.button_FindTypeOfWork.Click += new System.EventHandler(this.button_FindTypeOfWork_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Текущий договор:";
            // 
            // MyFormUserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_FindTypeOfWork);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ChangeMat);
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
            this.Size = new System.Drawing.Size(920, 470);
            this.Load += new System.EventHandler(this.MyFormUserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_Contr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AdWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ShowMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button button_ChangeMat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_FindTypeOfWork;
        private System.Windows.Forms.Label label2;
    }
}
