﻿
namespace _8.gyakorlat
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
            this.components = new System.ComponentModel.Container();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBall = new System.Windows.Forms.Button();
            this.buttonCar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BoxColorButton = new System.Windows.Forms.Button();
            this.RibbenColorButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.RibbenColorButton);
            this.mainPanel.Controls.Add(this.BoxColorButton);
            this.mainPanel.Controls.Add(this.button2);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.buttonBall);
            this.mainPanel.Controls.Add(this.buttonCar);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(766, 434);
            this.mainPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(407, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coming next:";
            // 
            // buttonBall
            // 
            this.buttonBall.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBall.Location = new System.Drawing.Point(313, 118);
            this.buttonBall.Name = "buttonBall";
            this.buttonBall.Size = new System.Drawing.Size(75, 23);
            this.buttonBall.TabIndex = 1;
            this.buttonBall.Text = "BALL";
            this.buttonBall.UseVisualStyleBackColor = false;
            this.buttonBall.Click += new System.EventHandler(this.buttonBall_Click);
            // 
            // buttonCar
            // 
            this.buttonCar.Location = new System.Drawing.Point(208, 118);
            this.buttonCar.Name = "buttonCar";
            this.buttonCar.Size = new System.Drawing.Size(75, 23);
            this.buttonCar.TabIndex = 0;
            this.buttonCar.Text = "CAR";
            this.buttonCar.UseVisualStyleBackColor = true;
            this.buttonCar.Click += new System.EventHandler(this.buttonCar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "PRESENT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BoxColorButton
            // 
            this.BoxColorButton.BackColor = System.Drawing.Color.Red;
            this.BoxColorButton.Location = new System.Drawing.Point(327, 174);
            this.BoxColorButton.Name = "BoxColorButton";
            this.BoxColorButton.Size = new System.Drawing.Size(75, 23);
            this.BoxColorButton.TabIndex = 5;
            this.BoxColorButton.Text = "button3";
            this.BoxColorButton.UseVisualStyleBackColor = false;
            this.BoxColorButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // RibbenColorButton
            // 
            this.RibbenColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.RibbenColorButton.Location = new System.Drawing.Point(419, 174);
            this.RibbenColorButton.Name = "RibbenColorButton";
            this.RibbenColorButton.Size = new System.Drawing.Size(75, 23);
            this.RibbenColorButton.TabIndex = 6;
            this.RibbenColorButton.Text = "button4";
            this.RibbenColorButton.UseVisualStyleBackColor = false;
            this.RibbenColorButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBall;
        private System.Windows.Forms.Button buttonCar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RibbenColorButton;
        private System.Windows.Forms.Button BoxColorButton;
        private System.Windows.Forms.Button button2;
    }
}

