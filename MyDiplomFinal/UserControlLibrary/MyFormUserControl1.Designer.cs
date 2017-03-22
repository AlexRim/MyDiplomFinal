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
            this.button_ChangeContract = new System.Windows.Forms.Button();
            this.button_RemoveContrct = new System.Windows.Forms.Button();
            this.button_FindClient = new System.Windows.Forms.Button();
            this.button_FindContract = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Contract)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1_Client
            // 
            this.dataGridView1_Client.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Client.Location = new System.Drawing.Point(78, 35);
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
            this.button1_AddClient.Location = new System.Drawing.Point(782, 35);
            this.button1_AddClient.Name = "button1_AddClient";
            this.button1_AddClient.Size = new System.Drawing.Size(75, 23);
            this.button1_AddClient.TabIndex = 1;
            this.button1_AddClient.Text = "Добавить клиента";
            this.button1_AddClient.UseVisualStyleBackColor = true;
            this.button1_AddClient.Click += new System.EventHandler(this.button1_AddClient_Click);
            // 
            // button1_DeleClient
            // 
            this.button1_DeleClient.Location = new System.Drawing.Point(782, 64);
            this.button1_DeleClient.Name = "button1_DeleClient";
            this.button1_DeleClient.Size = new System.Drawing.Size(75, 23);
            this.button1_DeleClient.TabIndex = 2;
            this.button1_DeleClient.Text = "Удалить клиента";
            this.button1_DeleClient.UseVisualStyleBackColor = true;
            this.button1_DeleClient.Click += new System.EventHandler(this.button1_DeleClient_Click);
            // 
            // button1_ChangeClient
            // 
            this.button1_ChangeClient.Location = new System.Drawing.Point(781, 93);
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
            this.dataGridView_Contract.Location = new System.Drawing.Point(78, 236);
            this.dataGridView_Contract.Name = "dataGridView_Contract";
            this.dataGridView_Contract.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Contract.Size = new System.Drawing.Size(697, 150);
            this.dataGridView_Contract.TabIndex = 4;
            // 
            // button_AddContractToClient
            // 
            this.button_AddContractToClient.Location = new System.Drawing.Point(782, 236);
            this.button_AddContractToClient.Name = "button_AddContractToClient";
            this.button_AddContractToClient.Size = new System.Drawing.Size(75, 23);
            this.button_AddContractToClient.TabIndex = 5;
            this.button_AddContractToClient.Text = "Добавить договор";
            this.button_AddContractToClient.UseVisualStyleBackColor = true;
            this.button_AddContractToClient.Click += new System.EventHandler(this.button_AddContractToClient_Click);
            // 
            // button_ChangeContract
            // 
            this.button_ChangeContract.Location = new System.Drawing.Point(781, 265);
            this.button_ChangeContract.Name = "button_ChangeContract";
            this.button_ChangeContract.Size = new System.Drawing.Size(75, 23);
            this.button_ChangeContract.TabIndex = 6;
            this.button_ChangeContract.Text = "Редакт. договор";
            this.button_ChangeContract.UseVisualStyleBackColor = true;
            this.button_ChangeContract.Click += new System.EventHandler(this.button_ChangeContract_Click);
            // 
            // button_RemoveContrct
            // 
            this.button_RemoveContrct.Location = new System.Drawing.Point(782, 294);
            this.button_RemoveContrct.Name = "button_RemoveContrct";
            this.button_RemoveContrct.Size = new System.Drawing.Size(75, 23);
            this.button_RemoveContrct.TabIndex = 7;
            this.button_RemoveContrct.Text = "Удалить Договор";
            this.button_RemoveContrct.UseVisualStyleBackColor = true;
            this.button_RemoveContrct.Click += new System.EventHandler(this.button_RemoveContrct_Click);
            // 
            // button_FindClient
            // 
            this.button_FindClient.Location = new System.Drawing.Point(782, 122);
            this.button_FindClient.Name = "button_FindClient";
            this.button_FindClient.Size = new System.Drawing.Size(75, 23);
            this.button_FindClient.TabIndex = 8;
            this.button_FindClient.Text = "Найти клиента";
            this.button_FindClient.UseVisualStyleBackColor = true;
            // 
            // button_FindContract
            // 
            this.button_FindContract.Location = new System.Drawing.Point(782, 323);
            this.button_FindContract.Name = "button_FindContract";
            this.button_FindContract.Size = new System.Drawing.Size(75, 23);
            this.button_FindContract.TabIndex = 9;
            this.button_FindContract.Text = "Найти клиента";
            this.button_FindContract.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(782, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Банк";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Клиенты:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Договора:";
            // 
            // MyFormUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_FindContract);
            this.Controls.Add(this.button_FindClient);
            this.Controls.Add(this.button_RemoveContrct);
            this.Controls.Add(this.button_ChangeContract);
            this.Controls.Add(this.button_AddContractToClient);
            this.Controls.Add(this.dataGridView_Contract);
            this.Controls.Add(this.button1_ChangeClient);
            this.Controls.Add(this.button1_DeleClient);
            this.Controls.Add(this.button1_AddClient);
            this.Controls.Add(this.dataGridView1_Client);
            this.Name = "MyFormUserControl1";
            this.Size = new System.Drawing.Size(920, 470);
            this.Load += new System.EventHandler(this.MyFormUserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Contract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1_Client;
        public System.Windows.Forms.Button button1_AddClient;
        public System.Windows.Forms.Button button1_DeleClient;
        public System.Windows.Forms.Button button1_ChangeClient;
        public System.Windows.Forms.DataGridView dataGridView_Contract;
        public System.Windows.Forms.Button button_AddContractToClient;
        public System.Windows.Forms.Button button_ChangeContract;
        private System.Windows.Forms.Button button_RemoveContrct;
        private System.Windows.Forms.Button button_FindClient;
        private System.Windows.Forms.Button button_FindContract;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
