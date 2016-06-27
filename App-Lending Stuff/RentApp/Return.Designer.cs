﻿namespace Cashapp
{
    partial class Return
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return));
            this.buttonReturnAll = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonReturnOne = new System.Windows.Forms.Button();
            this.toolTipselectone = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipGetList = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonReturnAll
            // 
            this.buttonReturnAll.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonReturnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnAll.Location = new System.Drawing.Point(11, 12);
            this.buttonReturnAll.Name = "buttonReturnAll";
            this.buttonReturnAll.Size = new System.Drawing.Size(149, 102);
            this.buttonReturnAll.TabIndex = 0;
            this.buttonReturnAll.Text = "Return All";
            this.buttonReturnAll.UseVisualStyleBackColor = false;
            this.buttonReturnAll.Click += new System.EventHandler(this.buttonReturnAll_Click);
            // 
            // toolTip2
            // 
            this.toolTip2.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip2_Popup);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(166, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 225);
            this.listBox1.TabIndex = 1;
            // 
            // buttonReturnOne
            // 
            this.buttonReturnOne.BackColor = System.Drawing.Color.Gold;
            this.buttonReturnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnOne.Location = new System.Drawing.Point(11, 135);
            this.buttonReturnOne.Name = "buttonReturnOne";
            this.buttonReturnOne.Size = new System.Drawing.Size(149, 102);
            this.buttonReturnOne.TabIndex = 2;
            this.buttonReturnOne.Text = "Return Selected";
            this.buttonReturnOne.UseVisualStyleBackColor = false;
            this.buttonReturnOne.Click += new System.EventHandler(this.buttonReturnOne_Click);
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(437, 258);
            this.Controls.Add(this.buttonReturnOne);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonReturnAll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Equipment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Return_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReturnAll;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonReturnOne;
        private System.Windows.Forms.ToolTip toolTipselectone;
        private System.Windows.Forms.ToolTip toolTipGetList;
    }
}