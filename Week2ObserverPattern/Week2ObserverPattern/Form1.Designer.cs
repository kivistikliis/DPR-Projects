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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numChangeValue)).BeginInit();
            this.SuspendLayout();
            // 
            // btChangeValue
            // 
            this.btChangeValue.Location = new System.Drawing.Point(212, 32);
            this.btChangeValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btChangeValue.Name = "btChangeValue";
            this.btChangeValue.Size = new System.Drawing.Size(195, 35);
            this.btChangeValue.TabIndex = 7;
            this.btChangeValue.Text = "Change value";
            this.btChangeValue.UseVisualStyleBackColor = true;
            this.btChangeValue.Click += new System.EventHandler(this.btChangeValue_Click);
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.Location = new System.Drawing.Point(26, 92);
            this.lbValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(107, 20);
            this.lbValue.TabIndex = 8;
            this.lbValue.Text = "Current value:";
            // 
            // numChangeValue
            // 
            this.numChangeValue.Location = new System.Drawing.Point(30, 32);
            this.numChangeValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numChangeValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numChangeValue.Name = "numChangeValue";
            this.numChangeValue.Size = new System.Drawing.Size(172, 26);
            this.numChangeValue.TabIndex = 9;
            // 
            // tbCurrentValue
            // 
            this.tbCurrentValue.Enabled = false;
            this.tbCurrentValue.Location = new System.Drawing.Point(146, 92);
            this.tbCurrentValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCurrentValue.Name = "tbCurrentValue";
            this.tbCurrentValue.Size = new System.Drawing.Size(148, 26);
            this.tbCurrentValue.TabIndex = 10;
            // 
            // lbAttached
            // 
            this.lbAttached.AutoSize = true;
            this.lbAttached.Location = new System.Drawing.Point(30, 163);
            this.lbAttached.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAttached.Name = "lbAttached";
            this.lbAttached.Size = new System.Drawing.Size(187, 20);
            this.lbAttached.TabIndex = 11;
            this.lbAttached.Text = "Nr of attached observers:";
            // 
            // lbNrOfObservers
            // 
            this.lbNrOfObservers.AutoSize = true;
            this.lbNrOfObservers.Location = new System.Drawing.Point(231, 163);
            this.lbNrOfObservers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNrOfObservers.Name = "lbNrOfObservers";
            this.lbNrOfObservers.Size = new System.Drawing.Size(18, 20);
            this.lbNrOfObservers.TabIndex = 12;
            this.lbNrOfObservers.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 206);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Create client1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 206);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "Create client2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 312);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbNrOfObservers);
            this.Controls.Add(this.lbAttached);
            this.Controls.Add(this.tbCurrentValue);
            this.Controls.Add(this.numChangeValue);
            this.Controls.Add(this.lbValue);
            this.Controls.Add(this.btChangeValue);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}

