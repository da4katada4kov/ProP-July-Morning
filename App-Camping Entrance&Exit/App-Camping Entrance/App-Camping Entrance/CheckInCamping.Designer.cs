namespace App_Camping_Entrance
{
    partial class CheckInCamping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInCamping));
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckIn.Location = new System.Drawing.Point(12, 12);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(161, 89);
            this.buttonCheckIn.TabIndex = 0;
            this.buttonCheckIn.Text = "Check In";
            this.buttonCheckIn.UseVisualStyleBackColor = false;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(179, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.ReadOnly = true;
            this.listBox1.Size = new System.Drawing.Size(193, 236);
            this.listBox1.TabIndex = 1;
            this.listBox1.Text = "";
            // 
            // CheckInCamping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 260);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonCheckIn);
            this.Name = "CheckInCamping";
            this.Text = "Check In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckInCamping_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.RichTextBox listBox1;
    }
}