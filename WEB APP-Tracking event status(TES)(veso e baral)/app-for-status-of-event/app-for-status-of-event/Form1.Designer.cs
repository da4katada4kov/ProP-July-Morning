namespace app_for_status_of_event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonStatusVisitor = new System.Windows.Forms.Button();
            this.buttonStatusEvent = new System.Windows.Forms.Button();
            this.buttonStatusCamping = new System.Windows.Forms.Button();
            this.buttonStatusShop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStatusVisitor
            // 
            this.buttonStatusVisitor.BackColor = System.Drawing.Color.Tomato;
            this.buttonStatusVisitor.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatusVisitor.Location = new System.Drawing.Point(12, 12);
            this.buttonStatusVisitor.Name = "buttonStatusVisitor";
            this.buttonStatusVisitor.Size = new System.Drawing.Size(164, 112);
            this.buttonStatusVisitor.TabIndex = 0;
            this.buttonStatusVisitor.Text = "Visitor";
            this.buttonStatusVisitor.UseVisualStyleBackColor = false;
            this.buttonStatusVisitor.Click += new System.EventHandler(this.buttonStatusVisitor_Click);
            // 
            // buttonStatusEvent
            // 
            this.buttonStatusEvent.BackColor = System.Drawing.Color.Gold;
            this.buttonStatusEvent.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatusEvent.Location = new System.Drawing.Point(182, 130);
            this.buttonStatusEvent.Name = "buttonStatusEvent";
            this.buttonStatusEvent.Size = new System.Drawing.Size(163, 102);
            this.buttonStatusEvent.TabIndex = 1;
            this.buttonStatusEvent.Text = "Event";
            this.buttonStatusEvent.UseVisualStyleBackColor = false;
            this.buttonStatusEvent.Click += new System.EventHandler(this.buttonStatusEvent_Click);
            // 
            // buttonStatusCamping
            // 
            this.buttonStatusCamping.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonStatusCamping.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatusCamping.Location = new System.Drawing.Point(182, 12);
            this.buttonStatusCamping.Name = "buttonStatusCamping";
            this.buttonStatusCamping.Size = new System.Drawing.Size(163, 112);
            this.buttonStatusCamping.TabIndex = 2;
            this.buttonStatusCamping.Text = "Camping";
            this.buttonStatusCamping.UseVisualStyleBackColor = false;
            this.buttonStatusCamping.Click += new System.EventHandler(this.buttonStatusCamping_Click);
            // 
            // buttonStatusShop
            // 
            this.buttonStatusShop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonStatusShop.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatusShop.Location = new System.Drawing.Point(12, 130);
            this.buttonStatusShop.Name = "buttonStatusShop";
            this.buttonStatusShop.Size = new System.Drawing.Size(164, 102);
            this.buttonStatusShop.TabIndex = 3;
            this.buttonStatusShop.Text = "Shop";
            this.buttonStatusShop.UseVisualStyleBackColor = false;
            this.buttonStatusShop.Click += new System.EventHandler(this.buttonStatusShop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(358, 244);
            this.Controls.Add(this.buttonStatusShop);
            this.Controls.Add(this.buttonStatusCamping);
            this.Controls.Add(this.buttonStatusEvent);
            this.Controls.Add(this.buttonStatusVisitor);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Status";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStatusVisitor;
        private System.Windows.Forms.Button buttonStatusEvent;
        private System.Windows.Forms.Button buttonStatusCamping;
        private System.Windows.Forms.Button buttonStatusShop;
    }
}

