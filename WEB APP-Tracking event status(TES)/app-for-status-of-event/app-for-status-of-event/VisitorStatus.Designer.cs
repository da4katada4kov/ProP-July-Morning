namespace app_for_status_of_event
{
    partial class VisitorStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitorStatus));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visitorStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalMoneySpentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Tomato;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitorStatusToolStripMenuItem,
            this.visitorHistoryToolStripMenuItem,
            this.totalBalanceToolStripMenuItem,
            this.totalMoneySpentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(469, 27);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visitorStatusToolStripMenuItem
            // 
            this.visitorStatusToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.visitorStatusToolStripMenuItem.Name = "visitorStatusToolStripMenuItem";
            this.visitorStatusToolStripMenuItem.Size = new System.Drawing.Size(102, 23);
            this.visitorStatusToolStripMenuItem.Text = "Visitor Status";
            this.visitorStatusToolStripMenuItem.Click += new System.EventHandler(this.visitorStatusToolStripMenuItem_Click);
            // 
            // visitorHistoryToolStripMenuItem
            // 
            this.visitorHistoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.visitorHistoryToolStripMenuItem.Name = "visitorHistoryToolStripMenuItem";
            this.visitorHistoryToolStripMenuItem.Size = new System.Drawing.Size(108, 23);
            this.visitorHistoryToolStripMenuItem.Text = "Visitor History";
            this.visitorHistoryToolStripMenuItem.Click += new System.EventHandler(this.visitorHistoryToolStripMenuItem_Click);
            // 
            // totalBalanceToolStripMenuItem
            // 
            this.totalBalanceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.totalBalanceToolStripMenuItem.Name = "totalBalanceToolStripMenuItem";
            this.totalBalanceToolStripMenuItem.Size = new System.Drawing.Size(101, 23);
            this.totalBalanceToolStripMenuItem.Text = "Total Balance";
            this.totalBalanceToolStripMenuItem.Click += new System.EventHandler(this.totalBalanceToolStripMenuItem_Click);
            // 
            // totalMoneySpentToolStripMenuItem
            // 
            this.totalMoneySpentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.totalMoneySpentToolStripMenuItem.Name = "totalMoneySpentToolStripMenuItem";
            this.totalMoneySpentToolStripMenuItem.Size = new System.Drawing.Size(135, 23);
            this.totalMoneySpentToolStripMenuItem.Text = "Total money spent";
            this.totalMoneySpentToolStripMenuItem.Click += new System.EventHandler(this.totalMoneySpentToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 11;
            // 
            // VisitorStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(469, 282);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VisitorStatus";
            this.Text = "VisitorStatus";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visitorStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitorHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalMoneySpentToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}