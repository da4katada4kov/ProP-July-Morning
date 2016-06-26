namespace App_Camping_Entrance
{
    partial class Welcome
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
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.Location = new System.Drawing.Point(115, 109);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckIn.TabIndex = 0;
            this.buttonCheckIn.Text = "Check In";
            this.buttonCheckIn.UseVisualStyleBackColor = true;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheckOut.Location = new System.Drawing.Point(306, 109);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckOut.TabIndex = 1;
            this.buttonCheckOut.Text = "Check Out";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 243);
            this.Controls.Add(this.buttonCheckOut);
            this.Controls.Add(this.buttonCheckIn);
            this.Name = "Welcome";
            this.Text = "Welcome to the camping";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.Button buttonCheckOut;
    }
}