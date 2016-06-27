﻿namespace Cashapp
{
    partial class Rent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rent));
            this.orderlist = new System.Windows.Forms.ListBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalcMinus = new System.Windows.Forms.Button();
            this.btnCalcPlus = new System.Windows.Forms.Button();
            this.btnCamera = new System.Windows.Forms.Button();
            this.btnGoPro = new System.Windows.Forms.Button();
            this.btnLaptop = new System.Windows.Forms.Button();
            this.btnTablet = new System.Windows.Forms.Button();
            this.btnSpeaker = new System.Windows.Forms.Button();
            this.btnHoverBoard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCharger = new System.Windows.Forms.Button();
            this.btnPhoneCharger = new System.Windows.Forms.Button();
            this.btnUSB = new System.Windows.Forms.Button();
            this.toolTipCamera = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipGoPro = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCharger = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipHoverBoard = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLaptop = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLaptopCharger = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipTablet = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSpeakers = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipUSB = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // orderlist
            // 
            this.orderlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderlist.FormattingEnabled = true;
            this.orderlist.ItemHeight = 20;
            this.orderlist.Location = new System.Drawing.Point(630, 26);
            this.orderlist.Name = "orderlist";
            this.orderlist.Size = new System.Drawing.Size(312, 324);
            this.orderlist.TabIndex = 0;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(630, 412);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(312, 61);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(756, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(845, 361);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 39);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "0 €";
            // 
            // btnCalcMinus
            // 
            this.btnCalcMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalcMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcMinus.Location = new System.Drawing.Point(630, 356);
            this.btnCalcMinus.Name = "btnCalcMinus";
            this.btnCalcMinus.Size = new System.Drawing.Size(50, 50);
            this.btnCalcMinus.TabIndex = 28;
            this.btnCalcMinus.Text = "-";
            this.btnCalcMinus.UseVisualStyleBackColor = false;
            this.btnCalcMinus.Click += new System.EventHandler(this.btnCalcMinus_Click);
            // 
            // btnCalcPlus
            // 
            this.btnCalcPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCalcPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcPlus.Location = new System.Drawing.Point(693, 356);
            this.btnCalcPlus.Name = "btnCalcPlus";
            this.btnCalcPlus.Size = new System.Drawing.Size(50, 50);
            this.btnCalcPlus.TabIndex = 30;
            this.btnCalcPlus.Text = "+";
            this.btnCalcPlus.UseVisualStyleBackColor = false;
            this.btnCalcPlus.Click += new System.EventHandler(this.btnCalcPlus_Click);
            // 
            // btnCamera
            // 
            this.btnCamera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCamera.BackgroundImage")));
            this.btnCamera.Location = new System.Drawing.Point(12, 12);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(200, 150);
            this.btnCamera.TabIndex = 4;
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.btnCola_Click);
            // 
            // btnGoPro
            // 
            this.btnGoPro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGoPro.BackgroundImage")));
            this.btnGoPro.Location = new System.Drawing.Point(218, 12);
            this.btnGoPro.Name = "btnGoPro";
            this.btnGoPro.Size = new System.Drawing.Size(200, 150);
            this.btnGoPro.TabIndex = 5;
            this.btnGoPro.UseVisualStyleBackColor = true;
            this.btnGoPro.Click += new System.EventHandler(this.btnFanta_Click);
            // 
            // btnLaptop
            // 
            this.btnLaptop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLaptop.BackgroundImage")));
            this.btnLaptop.Location = new System.Drawing.Point(218, 168);
            this.btnLaptop.Name = "btnLaptop";
            this.btnLaptop.Size = new System.Drawing.Size(200, 150);
            this.btnLaptop.TabIndex = 6;
            this.btnLaptop.UseVisualStyleBackColor = true;
            this.btnLaptop.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTablet
            // 
            this.btnTablet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTablet.BackgroundImage")));
            this.btnTablet.Location = new System.Drawing.Point(12, 324);
            this.btnTablet.Name = "btnTablet";
            this.btnTablet.Size = new System.Drawing.Size(200, 150);
            this.btnTablet.TabIndex = 7;
            this.btnTablet.UseVisualStyleBackColor = true;
            this.btnTablet.Click += new System.EventHandler(this.btnSchweppes_Click);
            // 
            // btnSpeaker
            // 
            this.btnSpeaker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpeaker.BackgroundImage")));
            this.btnSpeaker.Location = new System.Drawing.Point(218, 324);
            this.btnSpeaker.Name = "btnSpeaker";
            this.btnSpeaker.Size = new System.Drawing.Size(200, 150);
            this.btnSpeaker.TabIndex = 8;
            this.btnSpeaker.UseVisualStyleBackColor = true;
            this.btnSpeaker.Click += new System.EventHandler(this.btnRedBull_Click);
            // 
            // btnHoverBoard
            // 
            this.btnHoverBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHoverBoard.BackgroundImage")));
            this.btnHoverBoard.Location = new System.Drawing.Point(12, 168);
            this.btnHoverBoard.Name = "btnHoverBoard";
            this.btnHoverBoard.Size = new System.Drawing.Size(200, 150);
            this.btnHoverBoard.TabIndex = 9;
            this.btnHoverBoard.UseVisualStyleBackColor = true;
            this.btnHoverBoard.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(627, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "*Select product from list";
            // 
            // btnCharger
            // 
            this.btnCharger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCharger.BackgroundImage")));
            this.btnCharger.Location = new System.Drawing.Point(424, 168);
            this.btnCharger.Name = "btnCharger";
            this.btnCharger.Size = new System.Drawing.Size(200, 150);
            this.btnCharger.TabIndex = 39;
            this.btnCharger.UseVisualStyleBackColor = true;
            this.btnCharger.Click += new System.EventHandler(this.btnCharger_Click);
            // 
            // btnPhoneCharger
            // 
            this.btnPhoneCharger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPhoneCharger.BackgroundImage")));
            this.btnPhoneCharger.Location = new System.Drawing.Point(424, 12);
            this.btnPhoneCharger.Name = "btnPhoneCharger";
            this.btnPhoneCharger.Size = new System.Drawing.Size(200, 150);
            this.btnPhoneCharger.TabIndex = 40;
            this.btnPhoneCharger.UseVisualStyleBackColor = true;
            this.btnPhoneCharger.Click += new System.EventHandler(this.btnPhoneCharger_Click);
            // 
            // btnUSB
            // 
            this.btnUSB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUSB.BackgroundImage")));
            this.btnUSB.Location = new System.Drawing.Point(424, 324);
            this.btnUSB.Name = "btnUSB";
            this.btnUSB.Size = new System.Drawing.Size(200, 150);
            this.btnUSB.TabIndex = 41;
            this.btnUSB.UseVisualStyleBackColor = true;
            this.btnUSB.Click += new System.EventHandler(this.btnUSB_Click);
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(951, 485);
            this.Controls.Add(this.btnUSB);
            this.Controls.Add(this.btnPhoneCharger);
            this.Controls.Add(this.btnCharger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcPlus);
            this.Controls.Add(this.btnCalcMinus);
            this.Controls.Add(this.btnHoverBoard);
            this.Controls.Add(this.btnSpeaker);
            this.Controls.Add(this.btnTablet);
            this.Controls.Add(this.btnLaptop);
            this.Controls.Add(this.btnGoPro);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.orderlist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rent Equipment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox orderlist;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalcMinus;
        private System.Windows.Forms.Button btnCalcPlus;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.Button btnGoPro;
        private System.Windows.Forms.Button btnLaptop;
        private System.Windows.Forms.Button btnTablet;
        private System.Windows.Forms.Button btnSpeaker;
        private System.Windows.Forms.Button btnHoverBoard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCharger;
        private System.Windows.Forms.Button btnPhoneCharger;
        private System.Windows.Forms.Button btnUSB;
        private System.Windows.Forms.ToolTip toolTipCamera;
        private System.Windows.Forms.ToolTip toolTipGoPro;
        private System.Windows.Forms.ToolTip toolTipCharger;
        private System.Windows.Forms.ToolTip toolTipHoverBoard;
        private System.Windows.Forms.ToolTip toolTipLaptop;
        private System.Windows.Forms.ToolTip toolTipLaptopCharger;
        private System.Windows.Forms.ToolTip toolTipTablet;
        private System.Windows.Forms.ToolTip toolTipSpeakers;
        private System.Windows.Forms.ToolTip toolTipUSB;
    }
}

