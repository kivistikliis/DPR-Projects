namespace Week2ObserverPattern
{
    partial class Form3
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
            this.btAttach = new System.Windows.Forms.Button();
            this.btDeatach = new System.Windows.Forms.Button();
            this.lbValue = new System.Windows.Forms.Label();
            this.tbCurrentValue = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAttach
            // 
            this.btAttach.Location = new System.Drawing.Point(13, 12);
            this.btAttach.Name = "btAttach";
            this.btAttach.Size = new System.Drawing.Size(75, 23);
            this.btAttach.TabIndex = 0;
            this.btAttach.Text = "Attach";
            this.btAttach.UseVisualStyleBackColor = true;
            this.btAttach.Click += new System.EventHandler(this.btAttach_Click);
            // 
            // btDeatach
            // 
            this.btDeatach.Location = new System.Drawing.Point(94, 12);
            this.btDeatach.Name = "btDeatach";
            this.btDeatach.Size = new System.Drawing.Size(75, 23);
            this.btDeatach.TabIndex = 1;
            this.btDeatach.Text = "Deatach";
            this.btDeatach.UseVisualStyleBackColor = true;
            this.btDeatach.Click += new System.EventHandler(this.btDeatach_Click);
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.Location = new System.Drawing.Point(12, 47);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(37, 13);
            this.lbValue.TabIndex = 2;
            this.lbValue.Text = "Value:";
            // 
            // tbCurrentValue
            // 
            this.tbCurrentValue.Enabled = false;
            this.tbCurrentValue.Location = new System.Drawing.Point(56, 47);
            this.tbCurrentValue.Name = "tbCurrentValue";
            this.tbCurrentValue.Size = new System.Drawing.Size(100, 20);
            this.tbCurrentValue.TabIndex = 3;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbStatus.Location = new System.Drawing.Point(13, 85);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(50, 13);
            this.lbStatus.TabIndex = 4;
            this.lbStatus.Text = "Attached";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 134);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.tbCurrentValue);
            this.Controls.Add(this.lbValue);
            this.Controls.Add(this.btDeatach);
            this.Controls.Add(this.btAttach);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAttach;
        private System.Windows.Forms.Button btDeatach;
        private System.Windows.Forms.Label lbValue;
        private System.Windows.Forms.TextBox tbCurrentValue;
        private System.Windows.Forms.Label lbStatus;
    }
}