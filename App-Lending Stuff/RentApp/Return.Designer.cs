namespace Cashapp
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
            this.buttonIdentifyVisitor = new System.Windows.Forms.Button();
            this.toolTipselectone = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipGetList = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonReturnAll
            // 
            this.buttonReturnAll.BackColor = System.Drawing.Color.Gold;
            this.buttonReturnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnAll.Location = new System.Drawing.Point(12, 12);
            this.buttonReturnAll.Name = "buttonReturnAll";
            this.buttonReturnAll.Size = new System.Drawing.Size(162, 81);
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
            this.listBox1.Location = new System.Drawing.Point(180, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(322, 264);
            this.listBox1.TabIndex = 1;
            // 
            // buttonReturnOne
            // 
            this.buttonReturnOne.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonReturnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnOne.Location = new System.Drawing.Point(12, 99);
            this.buttonReturnOne.Name = "buttonReturnOne";
            this.buttonReturnOne.Size = new System.Drawing.Size(162, 87);
            this.buttonReturnOne.TabIndex = 2;
            this.buttonReturnOne.Text = "Return Selected";
            this.buttonReturnOne.UseVisualStyleBackColor = false;
            this.buttonReturnOne.Click += new System.EventHandler(this.buttonReturnOne_Click);
            // 
            // buttonIdentifyVisitor
            // 
            this.buttonIdentifyVisitor.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonIdentifyVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIdentifyVisitor.Location = new System.Drawing.Point(12, 192);
            this.buttonIdentifyVisitor.Name = "buttonIdentifyVisitor";
            this.buttonIdentifyVisitor.Size = new System.Drawing.Size(162, 82);
            this.buttonIdentifyVisitor.TabIndex = 3;
            this.buttonIdentifyVisitor.Text = "Get rented equipment";
            this.buttonIdentifyVisitor.UseVisualStyleBackColor = false;
            this.buttonIdentifyVisitor.Click += new System.EventHandler(this.buttonIdentifyVisitor_Click);
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(514, 284);
            this.Controls.Add(this.buttonIdentifyVisitor);
            this.Controls.Add(this.buttonReturnOne);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonReturnAll);
            this.Name = "Return";
            this.Text = "Return Equipment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Return_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReturnAll;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonReturnOne;
        private System.Windows.Forms.Button buttonIdentifyVisitor;
        private System.Windows.Forms.ToolTip toolTipselectone;
        private System.Windows.Forms.ToolTip toolTipGetList;
    }
}