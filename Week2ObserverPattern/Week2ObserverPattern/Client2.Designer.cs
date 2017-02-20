namespace Week2ObserverPattern
{
    partial class Client2
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
            this.evenood = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAttach
            // 
            this.btAttach.Location = new System.Drawing.Point(77, 46);
            this.btAttach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAttach.Name = "btAttach";
            this.btAttach.Size = new System.Drawing.Size(112, 35);
            this.btAttach.TabIndex = 0;
            this.btAttach.Text = "Attach";
            this.btAttach.UseVisualStyleBackColor = true;
            this.btAttach.Click += new System.EventHandler(this.btAttach_Click);
            // 
            // btDeatach
            // 
            this.btDeatach.Location = new System.Drawing.Point(198, 46);
            this.btDeatach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDeatach.Name = "btDeatach";
            this.btDeatach.Size = new System.Drawing.Size(112, 35);
            this.btDeatach.TabIndex = 1;
            this.btDeatach.Text = "Deatach";
            this.btDeatach.UseVisualStyleBackColor = true;
            this.btDeatach.Click += new System.EventHandler(this.btDeatach_Click);
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.Location = new System.Drawing.Point(121, 103);
            this.lbValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(54, 20);
            this.lbValue.TabIndex = 2;
            this.lbValue.Text = "Value:";
            // 
            // tbCurrentValue
            // 
            this.tbCurrentValue.Enabled = false;
            this.tbCurrentValue.Location = new System.Drawing.Point(200, 100);
            this.tbCurrentValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCurrentValue.Name = "tbCurrentValue";
            this.tbCurrentValue.Size = new System.Drawing.Size(148, 26);
            this.tbCurrentValue.TabIndex = 3;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbStatus.Location = new System.Drawing.Point(247, 164);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(101, 20);
            this.lbStatus.TabIndex = 4;
            this.lbStatus.Text = "Not attached";
            // 
            // evenood
            // 
            this.evenood.AutoSize = true;
            this.evenood.Location = new System.Drawing.Point(104, 142);
            this.evenood.Name = "evenood";
            this.evenood.Size = new System.Drawing.Size(0, 20);
            this.evenood.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "This form will display whether the value is even or odd!:";
            // 
            // Client2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 217);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.evenood);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.tbCurrentValue);
            this.Controls.Add(this.lbValue);
            this.Controls.Add(this.btDeatach);
            this.Controls.Add(this.btAttach);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Client2";
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
        private System.Windows.Forms.Label evenood;
        private System.Windows.Forms.Label label1;
    }
}