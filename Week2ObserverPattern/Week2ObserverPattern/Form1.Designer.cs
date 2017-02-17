namespace Week2ObserverPattern
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
            this.btChangeValue = new System.Windows.Forms.Button();
            this.lbValue = new System.Windows.Forms.Label();
            this.numChangeValue = new System.Windows.Forms.NumericUpDown();
            this.tbCurrentValue = new System.Windows.Forms.TextBox();
            this.lbAttached = new System.Windows.Forms.Label();
            this.lbNrOfObservers = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numChangeValue)).BeginInit();
            this.SuspendLayout();
            // 
            // btChangeValue
            // 
            this.btChangeValue.Location = new System.Drawing.Point(141, 21);
            this.btChangeValue.Name = "btChangeValue";
            this.btChangeValue.Size = new System.Drawing.Size(130, 23);
            this.btChangeValue.TabIndex = 7;
            this.btChangeValue.Text = "Change value";
            this.btChangeValue.UseVisualStyleBackColor = true;
            this.btChangeValue.Click += new System.EventHandler(this.btChangeValue_Click);
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.Location = new System.Drawing.Point(17, 60);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(73, 13);
            this.lbValue.TabIndex = 8;
            this.lbValue.Text = "Current value:";
            // 
            // numChangeValue
            // 
            this.numChangeValue.Location = new System.Drawing.Point(20, 21);
            this.numChangeValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numChangeValue.Name = "numChangeValue";
            this.numChangeValue.Size = new System.Drawing.Size(115, 20);
            this.numChangeValue.TabIndex = 9;
            // 
            // tbCurrentValue
            // 
            this.tbCurrentValue.Enabled = false;
            this.tbCurrentValue.Location = new System.Drawing.Point(97, 60);
            this.tbCurrentValue.Name = "tbCurrentValue";
            this.tbCurrentValue.Size = new System.Drawing.Size(100, 20);
            this.tbCurrentValue.TabIndex = 10;
            // 
            // lbAttached
            // 
            this.lbAttached.AutoSize = true;
            this.lbAttached.Location = new System.Drawing.Point(20, 106);
            this.lbAttached.Name = "lbAttached";
            this.lbAttached.Size = new System.Drawing.Size(127, 13);
            this.lbAttached.TabIndex = 11;
            this.lbAttached.Text = "Nr of attached observers:";
            // 
            // lbNrOfObservers
            // 
            this.lbNrOfObservers.AutoSize = true;
            this.lbNrOfObservers.Location = new System.Drawing.Point(154, 106);
            this.lbNrOfObservers.Name = "lbNrOfObservers";
            this.lbNrOfObservers.Size = new System.Drawing.Size(13, 13);
            this.lbNrOfObservers.TabIndex = 12;
            this.lbNrOfObservers.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 203);
            this.Controls.Add(this.lbNrOfObservers);
            this.Controls.Add(this.lbAttached);
            this.Controls.Add(this.tbCurrentValue);
            this.Controls.Add(this.numChangeValue);
            this.Controls.Add(this.lbValue);
            this.Controls.Add(this.btChangeValue);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numChangeValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btChangeValue;
        private System.Windows.Forms.Label lbValue;
        private System.Windows.Forms.NumericUpDown numChangeValue;
        private System.Windows.Forms.TextBox tbCurrentValue;
        private System.Windows.Forms.Label lbAttached;
        private System.Windows.Forms.Label lbNrOfObservers;
        private System.Windows.Forms.Timer timer1;

    }
}

