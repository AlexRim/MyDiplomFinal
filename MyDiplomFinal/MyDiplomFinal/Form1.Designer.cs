namespace MyDiplomFinal
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выводToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчетСтоимостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проектДоговораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.протоколСоглToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.коммерческоеПредлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расценкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.материалыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.расчетыToolStripMenuItem,
            this.выводToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.клиентыToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.клиентыToolStripMenuItem.Text = "клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // расчетыToolStripMenuItem
            // 
            this.расчетыToolStripMenuItem.Enabled = false;
            this.расчетыToolStripMenuItem.Name = "расчетыToolStripMenuItem";
            this.расчетыToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.расчетыToolStripMenuItem.Text = "расчеты";
            this.расчетыToolStripMenuItem.Click += new System.EventHandler(this.расчетыToolStripMenuItem_Click);
            // 
            // выводToolStripMenuItem
            // 
            this.выводToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расчетСтоимостиToolStripMenuItem,
            this.проектДоговораToolStripMenuItem,
            this.протоколСоглToolStripMenuItem,
            this.коммерческоеПредлToolStripMenuItem});
            this.выводToolStripMenuItem.Enabled = false;
            this.выводToolStripMenuItem.Name = "выводToolStripMenuItem";
            this.выводToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.выводToolStripMenuItem.Text = "отчеты";
            this.выводToolStripMenuItem.Click += new System.EventHandler(this.выводToolStripMenuItem_Click);
            // 
            // расчетСтоимостиToolStripMenuItem
            // 
            this.расчетСтоимостиToolStripMenuItem.Name = "расчетСтоимостиToolStripMenuItem";
            this.расчетСтоимостиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.расчетСтоимостиToolStripMenuItem.Text = "расчет";
            this.расчетСтоимостиToolStripMenuItem.Click += new System.EventHandler(this.расчетСтоимостиToolStripMenuItem_Click);
            // 
            // проектДоговораToolStripMenuItem
            // 
            this.проектДоговораToolStripMenuItem.Name = "проектДоговораToolStripMenuItem";
            this.проектДоговораToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.проектДоговораToolStripMenuItem.Text = "договор";
            this.проектДоговораToolStripMenuItem.Click += new System.EventHandler(this.проектДоговораToolStripMenuItem_Click);
            // 
            // протоколСоглToolStripMenuItem
            // 
            this.протоколСоглToolStripMenuItem.Name = "протоколСоглToolStripMenuItem";
            this.протоколСоглToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.протоколСоглToolStripMenuItem.Text = "протокол";
            // 
            // коммерческоеПредлToolStripMenuItem
            // 
            this.коммерческоеПредлToolStripMenuItem.Name = "коммерческоеПредлToolStripMenuItem";
            this.коммерческоеПредлToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.коммерческоеПредлToolStripMenuItem.Text = "предложение";
            this.коммерческоеПредлToolStripMenuItem.Click += new System.EventHandler(this.коммерческоеПредлToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расценкиToolStripMenuItem,
            this.материалыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.справочникиToolStripMenuItem.Text = "справочники";
            // 
            // расценкиToolStripMenuItem
            // 
            this.расценкиToolStripMenuItem.Name = "расценкиToolStripMenuItem";
            this.расценкиToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.расценкиToolStripMenuItem.Text = "расценки";
            this.расценкиToolStripMenuItem.Click += new System.EventHandler(this.расценкиToolStripMenuItem_Click);
            // 
            // материалыToolStripMenuItem
            // 
            this.материалыToolStripMenuItem.Name = "материалыToolStripMenuItem";
            this.материалыToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.материалыToolStripMenuItem.Text = "материалы";
            this.материалыToolStripMenuItem.Click += new System.EventHandler(this.материалыToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.оПрограммеToolStripMenuItem.Text = "о программе";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(904, 461);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyBuildSolution";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выводToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расчетСтоимостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проектДоговораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem протоколСоглToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem коммерческоеПредлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расценкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem материалыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem расчетыToolStripMenuItem;
    }
}

