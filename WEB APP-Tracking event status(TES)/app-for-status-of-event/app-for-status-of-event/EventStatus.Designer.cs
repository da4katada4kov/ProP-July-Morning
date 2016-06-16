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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventStatus));
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPplAtEvent = new System.Windows.Forms.Button();
            this.buttonPplLeft = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "Total visitors";
            this.toolTip1.SetToolTip(this.button1, "Display total count of visitors that have registered to the event.");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPplAtEvent
            // 
            this.buttonPplAtEvent.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonPplAtEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPplAtEvent.Location = new System.Drawing.Point(9, 88);
            this.buttonPplAtEvent.Name = "buttonPplAtEvent";
            this.buttonPplAtEvent.Size = new System.Drawing.Size(138, 77);
            this.buttonPplAtEvent.TabIndex = 1;
            this.buttonPplAtEvent.Text = "Present visitors";
            this.toolTip1.SetToolTip(this.buttonPplAtEvent, "Display the count of visitors currently at the event.");
            this.buttonPplAtEvent.UseVisualStyleBackColor = false;
            this.buttonPplAtEvent.Click += new System.EventHandler(this.buttonPplAtEvent_Click);
            // 
            // buttonPplLeft
            // 
            this.buttonPplLeft.BackColor = System.Drawing.Color.Tomato;
            this.buttonPplLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPplLeft.Location = new System.Drawing.Point(9, 171);
            this.buttonPplLeft.Name = "buttonPplLeft";
            this.buttonPplLeft.Size = new System.Drawing.Size(138, 77);
            this.buttonPplLeft.TabIndex = 2;
            this.buttonPplLeft.Text = "Visitors left";
            this.toolTip1.SetToolTip(this.buttonPplLeft, "Display the count of visitors that have left the event.");
            this.buttonPplLeft.UseVisualStyleBackColor = false;
            this.buttonPplLeft.Click += new System.EventHandler(this.buttonPplLeft_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(153, 8);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(222, 238);
            this.listBox1.TabIndex = 8;
            // 
            // EventStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(385, 253);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonPplLeft);
            this.Controls.Add(this.buttonPplAtEvent);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.ToolTip toolTip1;
    }
}