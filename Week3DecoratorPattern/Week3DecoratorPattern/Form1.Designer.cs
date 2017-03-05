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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(66, 63);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Select drink";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 16;
            this.lbInfo.Location = new System.Drawing.Point(332, 63);
            this.lbInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(300, 356);
            this.lbInfo.TabIndex = 1;
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(65, 195);
            this.btSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(161, 28);
            this.btSubmit.TabIndex = 4;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // cbCaramel
            // 
            this.cbCaramel.AutoSize = true;
            this.cbCaramel.Location = new System.Drawing.Point(66, 98);
            this.cbCaramel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCaramel.Name = "cbCaramel";
            this.cbCaramel.Size = new System.Drawing.Size(82, 21);
            this.cbCaramel.TabIndex = 5;
            this.cbCaramel.Text = "Caramel";
            this.cbCaramel.UseVisualStyleBackColor = true;
            this.cbCaramel.CheckedChanged += new System.EventHandler(this.cbCaramel_CheckedChanged);
            // 
            // cbMilk
            // 
            this.cbMilk.AutoSize = true;
            this.cbMilk.Location = new System.Drawing.Point(66, 127);
            this.cbMilk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMilk.Name = "cbMilk";
            this.cbMilk.Size = new System.Drawing.Size(54, 21);
            this.cbMilk.TabIndex = 6;
            this.cbMilk.Text = "Milk";
            this.cbMilk.UseVisualStyleBackColor = true;
            this.cbMilk.CheckedChanged += new System.EventHandler(this.cbMilk_CheckedChanged);
            // 
            // cbSoy
            // 
            this.cbSoy.AutoSize = true;
            this.cbSoy.Location = new System.Drawing.Point(66, 157);
            this.cbSoy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSoy.Name = "cbSoy";
            this.cbSoy.Size = new System.Drawing.Size(54, 21);
            this.cbSoy.TabIndex = 7;
            this.cbSoy.Text = "Soy";
            this.cbSoy.UseVisualStyleBackColor = true;
            this.cbSoy.CheckedChanged += new System.EventHandler(this.cbSoy_CheckedChanged);
            // 
            // lbPrice
            // 
            this.lbPrice.FormattingEnabled = true;
            this.lbPrice.ItemHeight = 16;
            this.lbPrice.Location = new System.Drawing.Point(640, 63);
            this.lbPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(108, 356);
            this.lbPrice.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Order information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Final price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.cbSoy);
            this.Controls.Add(this.cbMilk);
            this.Controls.Add(this.cbCaramel);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}

