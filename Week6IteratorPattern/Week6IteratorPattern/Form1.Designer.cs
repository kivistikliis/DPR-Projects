namespace Week6IteratorPattern
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
            this.lb_title = new System.Windows.Forms.Label();
            this.btn_createEI4S1 = new System.Windows.Forms.Button();
            this.btn_createEI4S2 = new System.Windows.Forms.Button();
            this.lb_students = new System.Windows.Forms.ListBox();
            this.btn_displayEI4S1 = new System.Windows.Forms.Button();
            this.btn_displayEI4S2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(156, 18);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(133, 25);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "ICT School";
            // 
            // btn_createEI4S1
            // 
            this.btn_createEI4S1.Location = new System.Drawing.Point(35, 61);
            this.btn_createEI4S1.Name = "btn_createEI4S1";
            this.btn_createEI4S1.Size = new System.Drawing.Size(144, 41);
            this.btn_createEI4S1.TabIndex = 1;
            this.btn_createEI4S1.Text = "Create EI4S1";
            this.btn_createEI4S1.UseVisualStyleBackColor = true;
            this.btn_createEI4S1.Click += new System.EventHandler(this.btn_createEI4S1_Click);
            // 
            // btn_createEI4S2
            // 
            this.btn_createEI4S2.Location = new System.Drawing.Point(267, 61);
            this.btn_createEI4S2.Name = "btn_createEI4S2";
            this.btn_createEI4S2.Size = new System.Drawing.Size(144, 41);
            this.btn_createEI4S2.TabIndex = 2;
            this.btn_createEI4S2.Text = "Create EI4S2";
            this.btn_createEI4S2.UseVisualStyleBackColor = true;
            this.btn_createEI4S2.Click += new System.EventHandler(this.btn_createEI4S2_Click);
            // 
            // lb_students
            // 
            this.lb_students.FormattingEnabled = true;
            this.lb_students.ItemHeight = 20;
            this.lb_students.Location = new System.Drawing.Point(35, 177);
            this.lb_students.Name = "lb_students";
            this.lb_students.Size = new System.Drawing.Size(376, 244);
            this.lb_students.TabIndex = 3;
            // 
            // btn_displayEI4S1
            // 
            this.btn_displayEI4S1.Enabled = false;
            this.btn_displayEI4S1.Location = new System.Drawing.Point(35, 119);
            this.btn_displayEI4S1.Name = "btn_displayEI4S1";
            this.btn_displayEI4S1.Size = new System.Drawing.Size(144, 41);
            this.btn_displayEI4S1.TabIndex = 4;
            this.btn_displayEI4S1.Text = "Display EI4S1";
            this.btn_displayEI4S1.UseVisualStyleBackColor = true;
            this.btn_displayEI4S1.Click += new System.EventHandler(this.btn_displayEI4S1_Click);
            // 
            // btn_displayEI4S2
            // 
            this.btn_displayEI4S2.Enabled = false;
            this.btn_displayEI4S2.Location = new System.Drawing.Point(267, 119);
            this.btn_displayEI4S2.Name = "btn_displayEI4S2";
            this.btn_displayEI4S2.Size = new System.Drawing.Size(144, 41);
            this.btn_displayEI4S2.TabIndex = 5;
            this.btn_displayEI4S2.Text = "Display EI4S2";
            this.btn_displayEI4S2.UseVisualStyleBackColor = true;
            this.btn_displayEI4S2.Click += new System.EventHandler(this.btn_displayEI4S2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 453);
            this.Controls.Add(this.btn_displayEI4S2);
            this.Controls.Add(this.btn_displayEI4S1);
            this.Controls.Add(this.lb_students);
            this.Controls.Add(this.btn_createEI4S2);
            this.Controls.Add(this.btn_createEI4S1);
            this.Controls.Add(this.lb_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Button btn_createEI4S1;
        private System.Windows.Forms.Button btn_createEI4S2;
        private System.Windows.Forms.ListBox lb_students;
        private System.Windows.Forms.Button btn_displayEI4S1;
        private System.Windows.Forms.Button btn_displayEI4S2;
    }
}

