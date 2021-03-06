﻿namespace Week1StrategyPattern
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
            this.trbViewprocess = new System.Windows.Forms.TrackBar();
            this.lbToBeProcessed = new System.Windows.Forms.ListBox();
            this.tbCurrentlyProcessed = new System.Windows.Forms.TextBox();
            this.btRun = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.rbFirstInFirstOut = new System.Windows.Forms.RadioButton();
            this.rbSeekTime = new System.Windows.Forms.RadioButton();
            this.rbScan = new System.Windows.Forms.RadioButton();
            this.trackbartimer = new System.Windows.Forms.Timer(this.components);
            this.rbCScan = new System.Windows.Forms.RadioButton();
            this.rbCLook = new System.Windows.Forms.RadioButton();
            this.numTimer = new System.Windows.Forms.NumericUpDown();
            this.lbSetTimer = new System.Windows.Forms.Label();
            this.btSetTimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbViewprocess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // trbViewprocess
            // 
            this.trbViewprocess.LargeChange = 10;
            this.trbViewprocess.Location = new System.Drawing.Point(18, 37);
            this.trbViewprocess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trbViewprocess.Maximum = 100;
            this.trbViewprocess.Minimum = -1;
            this.trbViewprocess.Name = "trbViewprocess";
            this.trbViewprocess.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbViewprocess.Size = new System.Drawing.Size(69, 651);
            this.trbViewprocess.TabIndex = 0;
            // 
            // lbToBeProcessed
            // 
            this.lbToBeProcessed.FormattingEnabled = true;
            this.lbToBeProcessed.ItemHeight = 20;
            this.lbToBeProcessed.Location = new System.Drawing.Point(146, 98);
            this.lbToBeProcessed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbToBeProcessed.Name = "lbToBeProcessed";
            this.lbToBeProcessed.Size = new System.Drawing.Size(74, 564);
            this.lbToBeProcessed.TabIndex = 1;
            // 
            // tbCurrentlyProcessed
            // 
            this.tbCurrentlyProcessed.Location = new System.Drawing.Point(146, 58);
            this.tbCurrentlyProcessed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCurrentlyProcessed.Name = "tbCurrentlyProcessed";
            this.tbCurrentlyProcessed.Size = new System.Drawing.Size(74, 26);
            this.tbCurrentlyProcessed.TabIndex = 2;
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(231, 283);
            this.btRun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(112, 35);
            this.btRun.TabIndex = 3;
            this.btRun.Text = "Run";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(231, 328);
            this.btStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(112, 35);
            this.btStop.TabIndex = 4;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // rbFirstInFirstOut
            // 
            this.rbFirstInFirstOut.AutoSize = true;
            this.rbFirstInFirstOut.Location = new System.Drawing.Point(231, 94);
            this.rbFirstInFirstOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbFirstInFirstOut.Name = "rbFirstInFirstOut";
            this.rbFirstInFirstOut.Size = new System.Drawing.Size(138, 24);
            this.rbFirstInFirstOut.TabIndex = 5;
            this.rbFirstInFirstOut.TabStop = true;
            this.rbFirstInFirstOut.Text = "First in first out";
            this.rbFirstInFirstOut.UseVisualStyleBackColor = true;
            this.rbFirstInFirstOut.CheckedChanged += new System.EventHandler(this.rbFirstInFirstOut_CheckedChanged);
            // 
            // rbSeekTime
            // 
            this.rbSeekTime.AutoSize = true;
            this.rbSeekTime.Location = new System.Drawing.Point(231, 131);
            this.rbSeekTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbSeekTime.Name = "rbSeekTime";
            this.rbSeekTime.Size = new System.Drawing.Size(174, 24);
            this.rbSeekTime.TabIndex = 6;
            this.rbSeekTime.TabStop = true;
            this.rbSeekTime.Text = "Shortest Seek Time";
            this.rbSeekTime.UseVisualStyleBackColor = true;
            this.rbSeekTime.CheckedChanged += new System.EventHandler(this.rbSeekTime_CheckedChanged);
            // 
            // rbScan
            // 
            this.rbScan.AutoSize = true;
            this.rbScan.Location = new System.Drawing.Point(231, 168);
            this.rbScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbScan.Name = "rbScan";
            this.rbScan.Size = new System.Drawing.Size(71, 24);
            this.rbScan.TabIndex = 7;
            this.rbScan.TabStop = true;
            this.rbScan.Text = "Scan";
            this.rbScan.UseVisualStyleBackColor = true;
            this.rbScan.CheckedChanged += new System.EventHandler(this.rbScan_CheckedChanged);
            // 
            // trackbartimer
            // 
            this.trackbartimer.Interval = 20;
            this.trackbartimer.Tick += new System.EventHandler(this.trackbartimer_Tick);
            // 
            // rbCScan
            // 
            this.rbCScan.AutoSize = true;
            this.rbCScan.Location = new System.Drawing.Point(232, 202);
            this.rbCScan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbCScan.Name = "rbCScan";
            this.rbCScan.Size = new System.Drawing.Size(87, 24);
            this.rbCScan.TabIndex = 8;
            this.rbCScan.TabStop = true;
            this.rbCScan.Text = "C-Scan";
            this.rbCScan.UseVisualStyleBackColor = true;
            this.rbCScan.CheckedChanged += new System.EventHandler(this.rbCScan_CheckedChanged);
            // 
            // rbCLook
            // 
            this.rbCLook.AutoSize = true;
            this.rbCLook.Location = new System.Drawing.Point(231, 238);
            this.rbCLook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbCLook.Name = "rbCLook";
            this.rbCLook.Size = new System.Drawing.Size(85, 24);
            this.rbCLook.TabIndex = 9;
            this.rbCLook.TabStop = true;
            this.rbCLook.Text = "C-Look";
            this.rbCLook.UseVisualStyleBackColor = true;
            this.rbCLook.CheckedChanged += new System.EventHandler(this.rbCLook_CheckedChanged);
            // 
            // numTimer
            // 
            this.numTimer.Location = new System.Drawing.Point(232, 465);
            this.numTimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numTimer.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTimer.Name = "numTimer";
            this.numTimer.Size = new System.Drawing.Size(111, 26);
            this.numTimer.TabIndex = 10;
            this.numTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbSetTimer
            // 
            this.lbSetTimer.AutoSize = true;
            this.lbSetTimer.Location = new System.Drawing.Point(231, 435);
            this.lbSetTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSetTimer.Name = "lbSetTimer";
            this.lbSetTimer.Size = new System.Drawing.Size(163, 20);
            this.lbSetTimer.TabIndex = 11;
            this.lbSetTimer.Text = "Timer tick: (max 2000)";
            // 
            // btSetTimer
            // 
            this.btSetTimer.Location = new System.Drawing.Point(231, 506);
            this.btSetTimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSetTimer.Name = "btSetTimer";
            this.btSetTimer.Size = new System.Drawing.Size(112, 35);
            this.btSetTimer.TabIndex = 12;
            this.btSetTimer.Text = "Set Timer";
            this.btSetTimer.UseVisualStyleBackColor = true;
            this.btSetTimer.Click += new System.EventHandler(this.btSetTimer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 706);
            this.Controls.Add(this.btSetTimer);
            this.Controls.Add(this.lbSetTimer);
            this.Controls.Add(this.numTimer);
            this.Controls.Add(this.rbCLook);
            this.Controls.Add(this.rbCScan);
            this.Controls.Add(this.rbScan);
            this.Controls.Add(this.rbSeekTime);
            this.Controls.Add(this.rbFirstInFirstOut);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.tbCurrentlyProcessed);
            this.Controls.Add(this.lbToBeProcessed);
            this.Controls.Add(this.trbViewprocess);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trbViewprocess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trbViewprocess;
        private System.Windows.Forms.ListBox lbToBeProcessed;
        private System.Windows.Forms.TextBox tbCurrentlyProcessed;
        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.RadioButton rbFirstInFirstOut;
        private System.Windows.Forms.RadioButton rbSeekTime;
        private System.Windows.Forms.RadioButton rbScan;
        private System.Windows.Forms.Timer trackbartimer;
        private System.Windows.Forms.RadioButton rbCScan;
        private System.Windows.Forms.RadioButton rbCLook;
        private System.Windows.Forms.NumericUpDown numTimer;
        private System.Windows.Forms.Label lbSetTimer;
        private System.Windows.Forms.Button btSetTimer;
    }
}

