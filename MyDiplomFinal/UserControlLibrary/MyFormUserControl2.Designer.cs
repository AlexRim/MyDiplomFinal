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
            // MyFormUserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.dataGridView2_Contr);
            this.Name = "MyFormUserControl2";
            this.Size = new System.Drawing.Size(1000, 675);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_Contr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView2_Contr;
    }
}
