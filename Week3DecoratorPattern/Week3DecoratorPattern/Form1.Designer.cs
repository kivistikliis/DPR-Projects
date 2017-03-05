namespace Week3DecoratorPattern
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.cbCaramel = new System.Windows.Forms.CheckBox();
            this.cbMilk = new System.Windows.Forms.CheckBox();
            this.cbSoy = new System.Windows.Forms.CheckBox();
            this.lbPrice = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.Location = new System.Drawing.Point(248, 23);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(226, 290);
            this.lbInfo.TabIndex = 1;
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(25, 171);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(121, 23);
            this.btSubmit.TabIndex = 4;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // cbCaramel
            // 
            this.cbCaramel.AutoSize = true;
            this.cbCaramel.Location = new System.Drawing.Point(25, 51);
            this.cbCaramel.Name = "cbCaramel";
            this.cbCaramel.Size = new System.Drawing.Size(64, 17);
            this.cbCaramel.TabIndex = 5;
            this.cbCaramel.Text = "Caramel";
            this.cbCaramel.UseVisualStyleBackColor = true;
            this.cbCaramel.CheckedChanged += new System.EventHandler(this.cbCaramel_CheckedChanged);
            // 
            // cbMilk
            // 
            this.cbMilk.AutoSize = true;
            this.cbMilk.Location = new System.Drawing.Point(25, 75);
            this.cbMilk.Name = "cbMilk";
            this.cbMilk.Size = new System.Drawing.Size(45, 17);
            this.cbMilk.TabIndex = 6;
            this.cbMilk.Text = "Milk";
            this.cbMilk.UseVisualStyleBackColor = true;
            this.cbMilk.CheckedChanged += new System.EventHandler(this.cbMilk_CheckedChanged);
            // 
            // cbSoy
            // 
            this.cbSoy.AutoSize = true;
            this.cbSoy.Location = new System.Drawing.Point(25, 99);
            this.cbSoy.Name = "cbSoy";
            this.cbSoy.Size = new System.Drawing.Size(44, 17);
            this.cbSoy.TabIndex = 7;
            this.cbSoy.Text = "Soy";
            this.cbSoy.UseVisualStyleBackColor = true;
            this.cbSoy.CheckedChanged += new System.EventHandler(this.cbSoy_CheckedChanged);
            // 
            // lbPrice
            // 
            this.lbPrice.FormattingEnabled = true;
            this.lbPrice.Location = new System.Drawing.Point(480, 23);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(64, 290);
            this.lbPrice.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 324);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.cbSoy);
            this.Controls.Add(this.cbMilk);
            this.Controls.Add(this.cbCaramel);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.CheckBox cbCaramel;
        private System.Windows.Forms.CheckBox cbMilk;
        private System.Windows.Forms.CheckBox cbSoy;
        private System.Windows.Forms.ListBox lbPrice;

    }
}

