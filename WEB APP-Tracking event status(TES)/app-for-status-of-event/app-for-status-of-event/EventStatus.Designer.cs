namespace app_for_status_of_event
{
    partial class EventStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventStatus));
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPplAtEvent = new System.Windows.Forms.Button();
            this.buttonPplLeft = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "How many people will visit the event?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPplAtEvent
            // 
            this.buttonPplAtEvent.Location = new System.Drawing.Point(25, 90);
            this.buttonPplAtEvent.Name = "buttonPplAtEvent";
            this.buttonPplAtEvent.Size = new System.Drawing.Size(124, 53);
            this.buttonPplAtEvent.TabIndex = 1;
            this.buttonPplAtEvent.Text = "How many people are at the event?";
            this.buttonPplAtEvent.UseVisualStyleBackColor = true;
            this.buttonPplAtEvent.Click += new System.EventHandler(this.buttonPplAtEvent_Click);
            // 
            // buttonPplLeft
            // 
            this.buttonPplLeft.Location = new System.Drawing.Point(25, 149);
            this.buttonPplLeft.Name = "buttonPplLeft";
            this.buttonPplLeft.Size = new System.Drawing.Size(124, 53);
            this.buttonPplLeft.TabIndex = 2;
            this.buttonPplLeft.Text = "How many people left the event?";
            this.buttonPplLeft.UseVisualStyleBackColor = true;
            this.buttonPplLeft.Click += new System.EventHandler(this.buttonPplLeft_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(177, 33);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(222, 173);
            this.listBox1.TabIndex = 8;
            // 
            // EventStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 242);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonPplLeft);
            this.Controls.Add(this.buttonPplAtEvent);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EventStatus";
            this.Text = "EventStatus";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonPplAtEvent;
        private System.Windows.Forms.Button buttonPplLeft;
        private System.Windows.Forms.ListBox listBox1;
    }
}