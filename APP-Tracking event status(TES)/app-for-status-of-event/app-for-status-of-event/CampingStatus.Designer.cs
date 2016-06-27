namespace app_for_status_of_event
{
    partial class CampingStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampingStatus));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonNrOfFreeSpots = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonNrOfPeopleAtCamping = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(175, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 199);
            this.listBox1.TabIndex = 0;
            // 
            // buttonNrOfFreeSpots
            // 
            this.buttonNrOfFreeSpots.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonNrOfFreeSpots.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNrOfFreeSpots.Location = new System.Drawing.Point(5, 12);
            this.buttonNrOfFreeSpots.Name = "buttonNrOfFreeSpots";
            this.buttonNrOfFreeSpots.Size = new System.Drawing.Size(164, 91);
            this.buttonNrOfFreeSpots.TabIndex = 1;
            this.buttonNrOfFreeSpots.Text = "Available spots";
            this.toolTip1.SetToolTip(this.buttonNrOfFreeSpots, "Display the count of available camping spots.");
            this.buttonNrOfFreeSpots.UseVisualStyleBackColor = false;
            this.buttonNrOfFreeSpots.Click += new System.EventHandler(this.buttonNrOfFreeSpots_Click);
            // 
            // buttonNrOfPeopleAtCamping
            // 
            this.buttonNrOfPeopleAtCamping.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonNrOfPeopleAtCamping.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNrOfPeopleAtCamping.Location = new System.Drawing.Point(5, 120);
            this.buttonNrOfPeopleAtCamping.Name = "buttonNrOfPeopleAtCamping";
            this.buttonNrOfPeopleAtCamping.Size = new System.Drawing.Size(164, 91);
            this.buttonNrOfPeopleAtCamping.TabIndex = 2;
            this.buttonNrOfPeopleAtCamping.Text = "People at camping";
            this.toolTip1.SetToolTip(this.buttonNrOfPeopleAtCamping, "Display the count of available camping spots.");
            this.buttonNrOfPeopleAtCamping.UseVisualStyleBackColor = false;
            this.buttonNrOfPeopleAtCamping.Click += new System.EventHandler(this.buttonNrOfPeopleAtCamping_Click);
            // 
            // CampingStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(392, 225);
            this.Controls.Add(this.buttonNrOfPeopleAtCamping);
            this.Controls.Add(this.buttonNrOfFreeSpots);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CampingStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camping Status";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonNrOfFreeSpots;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonNrOfPeopleAtCamping;
    }
}