namespace Week2ObserverPattern
{
    partial class Client1
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
            this.lbValue = new System.Windows.Forms.Label();
            this.btAttach = new System.Windows.Forms.Button();
            this.btDeatach = new System.Windows.Forms.Button();
            this.tbCurrentValue = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.Location = new System.Drawing.Point(16, 65);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(54, 20);
            this.lbValue.TabIndex = 0;
            this.lbValue.Text = "Value:";
            // 
            // btAttach
            // 
            this.btAttach.Location = new System.Drawing.Point(20, 20);
            this.btAttach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAttach.Name = "btAttach";
            this.btAttach.Size = new System.Drawing.Size(112, 35);
            this.btAttach.TabIndex = 1;
            this.btAttach.Text = "Attach";
            this.btAttach.UseVisualStyleBackColor = true;
            this.btAttach.Click += new System.EventHandler(this.btAttach_Click);
            // 
            // btDeatach
            // 
            this.btDeatach.Location = new System.Drawing.Point(142, 20);
            this.btDeatach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDeatach.Name = "btDeatach";
            this.btDeatach.Size = new System.Drawing.Size(112, 35);
            this.btDeatach.TabIndex = 2;
            this.btDeatach.Text = "Deatach";
            this.btDeatach.UseVisualStyleBackColor = true;
            this.btDeatach.Click += new System.EventHandler(this.btDeatach_Click);
            // 
            // tbCurrentValue
            // 
            this.tbCurrentValue.Enabled = false;
            this.tbCurrentValue.Location = new System.Drawing.Point(81, 66);
            this.tbCurrentValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCurrentValue.Name = "tbCurrentValue";
            this.tbCurrentValue.Size = new System.Drawing.Size(148, 26);
            this.tbCurrentValue.TabIndex = 3;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbStatus.Location = new System.Drawing.Point(21, 125);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(101, 20);
            this.lbStatus.TabIndex = 4;
            this.lbStatus.Text = "Not attached";
            // 
            // Client1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 217);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.tbCurrentValue);
            this.Controls.Add(this.btDeatach);
            this.Controls.Add(this.btAttach);
            this.Controls.Add(this.lbValue);
            this.Name = "Client1";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbValue;
        private System.Windows.Forms.Button btAttach;
        private System.Windows.Forms.Button btDeatach;
        private System.Windows.Forms.TextBox tbCurrentValue;
        private System.Windows.Forms.Label lbStatus;
    }
}