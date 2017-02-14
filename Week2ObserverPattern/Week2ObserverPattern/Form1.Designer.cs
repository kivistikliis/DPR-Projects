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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_value = new System.Windows.Forms.TextBox();
            this.btn_decrease = new System.Windows.Forms.Button();
            this.tb_changevalue = new System.Windows.Forms.TextBox();
            this.btn_increase = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Material:";
            // 
            // tb_value
            // 
            this.tb_value.Enabled = false;
            this.tb_value.Location = new System.Drawing.Point(145, 22);
            this.tb_value.Name = "tb_value";
            this.tb_value.Size = new System.Drawing.Size(100, 26);
            this.tb_value.TabIndex = 1;
            // 
            // btn_decrease
            // 
            this.btn_decrease.Location = new System.Drawing.Point(26, 123);
            this.btn_decrease.Name = "btn_decrease";
            this.btn_decrease.Size = new System.Drawing.Size(113, 31);
            this.btn_decrease.TabIndex = 2;
            this.btn_decrease.Text = "Decrease";
            this.btn_decrease.UseVisualStyleBackColor = true;
            // 
            // tb_changevalue
            // 
            this.tb_changevalue.Location = new System.Drawing.Point(26, 91);
            this.tb_changevalue.Name = "tb_changevalue";
            this.tb_changevalue.Size = new System.Drawing.Size(245, 26);
            this.tb_changevalue.TabIndex = 3;
            // 
            // btn_increase
            // 
            this.btn_increase.Location = new System.Drawing.Point(163, 123);
            this.btn_increase.Name = "btn_increase";
            this.btn_increase.Size = new System.Drawing.Size(108, 31);
            this.btn_increase.TabIndex = 4;
            this.btn_increase.Text = "Increase";
            this.btn_increase.UseVisualStyleBackColor = true;
            this.btn_increase.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 265);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_increase);
            this.Controls.Add(this.tb_changevalue);
            this.Controls.Add(this.btn_decrease);
            this.Controls.Add(this.tb_value);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_value;
        private System.Windows.Forms.Button btn_decrease;
        private System.Windows.Forms.TextBox tb_changevalue;
        private System.Windows.Forms.Button btn_increase;
        private System.Windows.Forms.Label label2;
    }
}

