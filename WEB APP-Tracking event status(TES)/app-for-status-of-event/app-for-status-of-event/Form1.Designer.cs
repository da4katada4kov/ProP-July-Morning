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
            this.buttonStatusVisitor.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatusVisitor.Location = new System.Drawing.Point(26, 32);
            this.buttonStatusVisitor.Name = "buttonStatusVisitor";
            this.buttonStatusVisitor.Size = new System.Drawing.Size(150, 74);
            this.buttonStatusVisitor.TabIndex = 0;
            this.buttonStatusVisitor.Text = "Visitor";
            this.buttonStatusVisitor.UseVisualStyleBackColor = true;
            this.buttonStatusVisitor.Click += new System.EventHandler(this.buttonStatusVisitor_Click);
            // 
            // buttonStatusEvent
            // 
            this.buttonStatusEvent.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatusEvent.Location = new System.Drawing.Point(194, 130);
            this.buttonStatusEvent.Name = "buttonStatusEvent";
            this.buttonStatusEvent.Size = new System.Drawing.Size(150, 74);
            this.buttonStatusEvent.TabIndex = 1;
            this.buttonStatusEvent.Text = "Event";
            this.buttonStatusEvent.UseVisualStyleBackColor = true;
            this.buttonStatusEvent.Click += new System.EventHandler(this.buttonStatusEvent_Click);
            // 
            // buttonStatusCamping
            // 
            this.buttonStatusCamping.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatusCamping.Location = new System.Drawing.Point(194, 32);
            this.buttonStatusCamping.Name = "buttonStatusCamping";
            this.buttonStatusCamping.Size = new System.Drawing.Size(150, 74);
            this.buttonStatusCamping.TabIndex = 2;
            this.buttonStatusCamping.Text = "Camping";
            this.buttonStatusCamping.UseVisualStyleBackColor = true;
            this.buttonStatusCamping.Click += new System.EventHandler(this.buttonStatusCamping_Click);
            // 
            // buttonStatusShop
            // 
            this.buttonStatusShop.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatusShop.Location = new System.Drawing.Point(26, 130);
            this.buttonStatusShop.Name = "buttonStatusShop";
            this.buttonStatusShop.Size = new System.Drawing.Size(150, 74);
            this.buttonStatusShop.TabIndex = 3;
            this.buttonStatusShop.Text = "Shop";
            this.buttonStatusShop.UseVisualStyleBackColor = true;
            this.buttonStatusShop.Click += new System.EventHandler(this.buttonStatusShop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 231);
            this.Controls.Add(this.buttonStatusShop);
            this.Controls.Add(this.buttonStatusCamping);
            this.Controls.Add(this.buttonStatusEvent);
            this.Controls.Add(this.buttonStatusVisitor);
            this.ForeColor = System.Drawing.Color.Black;
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

