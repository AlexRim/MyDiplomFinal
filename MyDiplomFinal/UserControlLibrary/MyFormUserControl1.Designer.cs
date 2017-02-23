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
            this.button1_DeleClient = new System.Windows.Forms.Button();
            this.button1_ChangeClient = new System.Windows.Forms.Button();
            this.dataGridView_Contract = new System.Windows.Forms.DataGridView();
            this.button_AddContractToClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Contract)).BeginInit();
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
            this.dataGridView1_Client.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dataGridView1_Client_CellStateChanged);
            this.dataGridView1_Client.SelectionChanged += new System.EventHandler(this.dataGridView1_Client_SelectionChanged);
            this.dataGridView1_Client.Click += new System.EventHandler(this.dataGridView1_Client_Click);
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
            // button1_DeleClient
            // 
            this.button1_DeleClient.Location = new System.Drawing.Point(742, 73);
            this.button1_DeleClient.Name = "button1_DeleClient";
            this.button1_DeleClient.Size = new System.Drawing.Size(75, 23);
            this.button1_DeleClient.TabIndex = 2;
            this.button1_DeleClient.Text = "Удалить клиента";
            this.button1_DeleClient.UseVisualStyleBackColor = true;
            this.button1_DeleClient.Click += new System.EventHandler(this.button1_DeleClient_Click);
            // 
            // button1_ChangeClient
            // 
            this.button1_ChangeClient.Location = new System.Drawing.Point(742, 102);
            this.button1_ChangeClient.Name = "button1_ChangeClient";
            this.button1_ChangeClient.Size = new System.Drawing.Size(75, 23);
            this.button1_ChangeClient.TabIndex = 3;
            this.button1_ChangeClient.Text = "Редакт. клиента";
            this.button1_ChangeClient.UseVisualStyleBackColor = true;
            this.button1_ChangeClient.Click += new System.EventHandler(this.button1_ChangeClient_Click);
            // 
            // dataGridView_Contract
            // 
            this.dataGridView_Contract.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Contract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Contract.Location = new System.Drawing.Point(39, 216);
            this.dataGridView_Contract.Name = "dataGridView_Contract";
            this.dataGridView_Contract.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Contract.Size = new System.Drawing.Size(697, 150);
            this.dataGridView_Contract.TabIndex = 4;
            // 
            // button_AddContractToClient
            // 
            this.button_AddContractToClient.Location = new System.Drawing.Point(743, 132);
            this.button_AddContractToClient.Name = "button_AddContractToClient";
            this.button_AddContractToClient.Size = new System.Drawing.Size(75, 23);
            this.button_AddContractToClient.TabIndex = 5;
            this.button_AddContractToClient.Text = "Новый договор";
            this.button_AddContractToClient.UseVisualStyleBackColor = true;
            this.button_AddContractToClient.Click += new System.EventHandler(this.button_AddContractToClient_Click);
            // 
            // MyFormUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.button_AddContractToClient);
            this.Controls.Add(this.dataGridView_Contract);
            this.Controls.Add(this.button1_ChangeClient);
            this.Controls.Add(this.button1_DeleClient);
            this.Controls.Add(this.button1_AddClient);
            this.Controls.Add(this.dataGridView1_Client);
            this.Name = "MyFormUserControl1";
            this.Size = new System.Drawing.Size(1000, 675);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Contract)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1_Client;
        public System.Windows.Forms.Button button1_AddClient;
        public System.Windows.Forms.Button button1_DeleClient;
        public System.Windows.Forms.Button button1_ChangeClient;
        public System.Windows.Forms.DataGridView dataGridView_Contract;
        public System.Windows.Forms.Button button_AddContractToClient;
    }
}
