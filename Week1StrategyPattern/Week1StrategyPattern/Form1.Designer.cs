namespace Week1StrategyPattern
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
            this.trbViewprocess = new System.Windows.Forms.TrackBar();
            this.lbToBeProcessed = new System.Windows.Forms.ListBox();
            this.tbCurrentlyProcessed = new System.Windows.Forms.TextBox();
            this.btRun = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.rbFirstInFirstOut = new System.Windows.Forms.RadioButton();
            this.rbSeekTime = new System.Windows.Forms.RadioButton();
            this.rbScan = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbViewprocess)).BeginInit();
            this.SuspendLayout();
            // 
            // trbViewprocess
            // 
            this.trbViewprocess.LargeChange = 10;
            this.trbViewprocess.Location = new System.Drawing.Point(12, 24);
            this.trbViewprocess.Maximum = 100;
            this.trbViewprocess.Name = "trbViewprocess";
            this.trbViewprocess.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbViewprocess.Size = new System.Drawing.Size(45, 423);
            this.trbViewprocess.TabIndex = 0;
            this.trbViewprocess.Value = 50;
            this.trbViewprocess.Scroll += new System.EventHandler(this.trbViewprocess_Scroll);
            // 
            // lbToBeProcessed
            // 
            this.lbToBeProcessed.FormattingEnabled = true;
            this.lbToBeProcessed.Location = new System.Drawing.Point(97, 64);
            this.lbToBeProcessed.Name = "lbToBeProcessed";
            this.lbToBeProcessed.Size = new System.Drawing.Size(51, 264);
            this.lbToBeProcessed.TabIndex = 1;
            // 
            // tbCurrentlyProcessed
            // 
            this.tbCurrentlyProcessed.Location = new System.Drawing.Point(97, 38);
            this.tbCurrentlyProcessed.Name = "tbCurrentlyProcessed";
            this.tbCurrentlyProcessed.Size = new System.Drawing.Size(51, 20);
            this.tbCurrentlyProcessed.TabIndex = 2;
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(154, 154);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(75, 23);
            this.btRun.TabIndex = 3;
            this.btRun.Text = "Run";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(154, 183);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 4;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // rbFirstInFirstOut
            // 
            this.rbFirstInFirstOut.AutoSize = true;
            this.rbFirstInFirstOut.Location = new System.Drawing.Point(154, 61);
            this.rbFirstInFirstOut.Name = "rbFirstInFirstOut";
            this.rbFirstInFirstOut.Size = new System.Drawing.Size(92, 17);
            this.rbFirstInFirstOut.TabIndex = 5;
            this.rbFirstInFirstOut.TabStop = true;
            this.rbFirstInFirstOut.Text = "First in first out";
            this.rbFirstInFirstOut.UseVisualStyleBackColor = true;
            // 
            // rbSeekTime
            // 
            this.rbSeekTime.AutoSize = true;
            this.rbSeekTime.Location = new System.Drawing.Point(154, 85);
            this.rbSeekTime.Name = "rbSeekTime";
            this.rbSeekTime.Size = new System.Drawing.Size(118, 17);
            this.rbSeekTime.TabIndex = 6;
            this.rbSeekTime.TabStop = true;
            this.rbSeekTime.Text = "Shortest Seek Time";
            this.rbSeekTime.UseVisualStyleBackColor = true;
            // 
            // rbScan
            // 
            this.rbScan.AutoSize = true;
            this.rbScan.Location = new System.Drawing.Point(154, 109);
            this.rbScan.Name = "rbScan";
            this.rbScan.Size = new System.Drawing.Size(50, 17);
            this.rbScan.TabIndex = 7;
            this.rbScan.TabStop = true;
            this.rbScan.Text = "Scan";
            this.rbScan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbScan);
            this.Controls.Add(this.rbSeekTime);
            this.Controls.Add(this.rbFirstInFirstOut);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.tbCurrentlyProcessed);
            this.Controls.Add(this.lbToBeProcessed);
            this.Controls.Add(this.trbViewprocess);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trbViewprocess)).EndInit();
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
        private System.Windows.Forms.Label label1;
    }
}

