namespace UserControlLibrary
{
    partial class MyFormUserControl1
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
            this.dataGridView1_Client = new System.Windows.Forms.DataGridView();
            this.button1_AddClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Client)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1_Client
            // 
            this.dataGridView1_Client.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Client.Location = new System.Drawing.Point(39, 44);
            this.dataGridView1_Client.Name = "dataGridView1_Client";
            this.dataGridView1_Client.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_Client.Size = new System.Drawing.Size(697, 150);
            this.dataGridView1_Client.TabIndex = 0;
            // 
            // button1_AddClient
            // 
            this.button1_AddClient.Location = new System.Drawing.Point(742, 44);
            this.button1_AddClient.Name = "button1_AddClient";
            this.button1_AddClient.Size = new System.Drawing.Size(75, 23);
            this.button1_AddClient.TabIndex = 1;
            this.button1_AddClient.Text = "Добавить клиента";
            this.button1_AddClient.UseVisualStyleBackColor = true;
            this.button1_AddClient.Click += new System.EventHandler(this.button1_AddClient_Click);
            // 
            // MyFormUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.button1_AddClient);
            this.Controls.Add(this.dataGridView1_Client);
            this.Name = "MyFormUserControl1";
            this.Size = new System.Drawing.Size(1000, 675);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Client)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1_Client;
        public System.Windows.Forms.Button button1_AddClient;
    }
}
