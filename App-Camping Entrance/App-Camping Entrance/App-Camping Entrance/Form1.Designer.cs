namespace App_Camping_Entrance
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHiredSpot = new System.Windows.Forms.TextBox();
            this.textBoxMainVisitorId = new System.Windows.Forms.TextBox();
            this.textBoxMainVisitorRFID = new System.Windows.Forms.TextBox();
            this.textBoxGuestRfid = new System.Windows.Forms.TextBox();
            this.textBoxGuestId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonVerifyMainVisitor = new System.Windows.Forms.Button();
            this.buttonVerifyGuest = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonEnterCS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the main visitor info:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hired spot ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Main Visitor ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Main visitor RFID:";
            // 
            // textBoxHiredSpot
            // 
            this.textBoxHiredSpot.Location = new System.Drawing.Point(96, 31);
            this.textBoxHiredSpot.Name = "textBoxHiredSpot";
            this.textBoxHiredSpot.Size = new System.Drawing.Size(100, 20);
            this.textBoxHiredSpot.TabIndex = 4;
            // 
            // textBoxMainVisitorId
            // 
            this.textBoxMainVisitorId.Location = new System.Drawing.Point(96, 53);
            this.textBoxMainVisitorId.Name = "textBoxMainVisitorId";
            this.textBoxMainVisitorId.Size = new System.Drawing.Size(100, 20);
            this.textBoxMainVisitorId.TabIndex = 5;
            // 
            // textBoxMainVisitorRFID
            // 
            this.textBoxMainVisitorRFID.Enabled = false;
            this.textBoxMainVisitorRFID.Location = new System.Drawing.Point(96, 76);
            this.textBoxMainVisitorRFID.Name = "textBoxMainVisitorRFID";
            this.textBoxMainVisitorRFID.Size = new System.Drawing.Size(100, 20);
            this.textBoxMainVisitorRFID.TabIndex = 6;
            // 
            // textBoxGuestRfid
            // 
            this.textBoxGuestRfid.Enabled = false;
            this.textBoxGuestRfid.Location = new System.Drawing.Point(96, 199);
            this.textBoxGuestRfid.Name = "textBoxGuestRfid";
            this.textBoxGuestRfid.Size = new System.Drawing.Size(100, 20);
            this.textBoxGuestRfid.TabIndex = 12;
            // 
            // textBoxGuestId
            // 
            this.textBoxGuestId.Enabled = false;
            this.textBoxGuestId.Location = new System.Drawing.Point(96, 176);
            this.textBoxGuestId.Name = "textBoxGuestId";
            this.textBoxGuestId.Size = new System.Drawing.Size(100, 20);
            this.textBoxGuestId.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Guest RFID:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(41, 183);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(52, 13);
            this.label.TabIndex = 8;
            this.label.Text = "Guest ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Enter guest info:";
            // 
            // buttonVerifyMainVisitor
            // 
            this.buttonVerifyMainVisitor.Location = new System.Drawing.Point(121, 102);
            this.buttonVerifyMainVisitor.Name = "buttonVerifyMainVisitor";
            this.buttonVerifyMainVisitor.Size = new System.Drawing.Size(75, 23);
            this.buttonVerifyMainVisitor.TabIndex = 14;
            this.buttonVerifyMainVisitor.Text = "Verify Main";
            this.buttonVerifyMainVisitor.UseVisualStyleBackColor = true;
            this.buttonVerifyMainVisitor.Click += new System.EventHandler(this.buttonVerifyMainVisitor_Click);
            // 
            // buttonVerifyGuest
            // 
            this.buttonVerifyGuest.Location = new System.Drawing.Point(121, 225);
            this.buttonVerifyGuest.Name = "buttonVerifyGuest";
            this.buttonVerifyGuest.Size = new System.Drawing.Size(75, 23);
            this.buttonVerifyGuest.TabIndex = 15;
            this.buttonVerifyGuest.Text = "Verify Guest";
            this.buttonVerifyGuest.UseVisualStyleBackColor = true;
            this.buttonVerifyGuest.Click += new System.EventHandler(this.buttonVerifyGuest_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(221, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 199);
            this.listBox1.TabIndex = 16;
            // 
            // buttonEnterCS
            // 
            this.buttonEnterCS.Location = new System.Drawing.Point(221, 225);
            this.buttonEnterCS.Name = "buttonEnterCS";
            this.buttonEnterCS.Size = new System.Drawing.Size(201, 23);
            this.buttonEnterCS.TabIndex = 17;
            this.buttonEnterCS.Text = "Enter Camping Spot";
            this.buttonEnterCS.UseVisualStyleBackColor = true;
            this.buttonEnterCS.Click += new System.EventHandler(this.buttonEnterCS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 320);
            this.Controls.Add(this.buttonEnterCS);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonVerifyGuest);
            this.Controls.Add(this.buttonVerifyMainVisitor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxGuestRfid);
            this.Controls.Add(this.textBoxGuestId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxMainVisitorRFID);
            this.Controls.Add(this.textBoxMainVisitorId);
            this.Controls.Add(this.textBoxHiredSpot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Welcome to the camping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxHiredSpot;
        private System.Windows.Forms.TextBox textBoxMainVisitorId;
        private System.Windows.Forms.TextBox textBoxMainVisitorRFID;
        private System.Windows.Forms.TextBox textBoxGuestRfid;
        private System.Windows.Forms.TextBox textBoxGuestId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonVerifyMainVisitor;
        private System.Windows.Forms.Button buttonVerifyGuest;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonEnterCS;
    }
}

