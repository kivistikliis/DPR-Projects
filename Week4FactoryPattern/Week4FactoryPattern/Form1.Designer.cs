namespace Week4FactoryPattern
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
            this.btCreateMinionGame = new System.Windows.Forms.Button();
            this.lb_events = new System.Windows.Forms.ListBox();
            this.btCreateSmurfGame = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btSing = new System.Windows.Forms.Button();
            this.btDance = new System.Windows.Forms.Button();
            this.lb_figures = new System.Windows.Forms.ListBox();
            this.btCreateMinion = new System.Windows.Forms.Button();
            this.btCreateSmurf = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btMinHouse = new System.Windows.Forms.Button();
            this.btSmurfHouse = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO MINION LAND!";
            // 
            // btCreateMinionGame
            // 
            this.btCreateMinionGame.BackColor = System.Drawing.Color.Gold;
            this.btCreateMinionGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btCreateMinionGame.Location = new System.Drawing.Point(144, 61);
            this.btCreateMinionGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCreateMinionGame.Name = "btCreateMinionGame";
            this.btCreateMinionGame.Size = new System.Drawing.Size(142, 42);
            this.btCreateMinionGame.TabIndex = 1;
            this.btCreateMinionGame.Text = "Create Minion Game";
            this.btCreateMinionGame.UseVisualStyleBackColor = false;
            this.btCreateMinionGame.Click += new System.EventHandler(this.btCreateMinionGame_Click);
            // 
            // lb_events
            // 
            this.lb_events.FormattingEnabled = true;
            this.lb_events.ItemHeight = 16;
            this.lb_events.Location = new System.Drawing.Point(24, 471);
            this.lb_events.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_events.Name = "lb_events";
            this.lb_events.ScrollAlwaysVisible = true;
            this.lb_events.Size = new System.Drawing.Size(582, 164);
            this.lb_events.TabIndex = 2;
            // 
            // btCreateSmurfGame
            // 
            this.btCreateSmurfGame.BackColor = System.Drawing.Color.DodgerBlue;
            this.btCreateSmurfGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btCreateSmurfGame.Location = new System.Drawing.Point(292, 61);
            this.btCreateSmurfGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCreateSmurfGame.Name = "btCreateSmurfGame";
            this.btCreateSmurfGame.Size = new System.Drawing.Size(129, 42);
            this.btCreateSmurfGame.TabIndex = 3;
            this.btCreateSmurfGame.Text = "Create Smurf Game";
            this.btCreateSmurfGame.UseVisualStyleBackColor = false;
            this.btCreateSmurfGame.Click += new System.EventHandler(this.btCreateSmurfGame_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(24, 157);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(180, 22);
            this.tbName.TabIndex = 4;
            this.tbName.Text = "Type name for your figure";
            // 
            // btSing
            // 
            this.btSing.Location = new System.Drawing.Point(506, 157);
            this.btSing.Name = "btSing";
            this.btSing.Size = new System.Drawing.Size(95, 34);
            this.btSing.TabIndex = 5;
            this.btSing.Text = "Sing";
            this.btSing.UseVisualStyleBackColor = true;
            this.btSing.Click += new System.EventHandler(this.btSing_Click);
            // 
            // btDance
            // 
            this.btDance.Location = new System.Drawing.Point(506, 197);
            this.btDance.Name = "btDance";
            this.btDance.Size = new System.Drawing.Size(95, 35);
            this.btDance.TabIndex = 6;
            this.btDance.Text = "Dance";
            this.btDance.UseVisualStyleBackColor = true;
            this.btDance.Click += new System.EventHandler(this.btDance_Click);
            // 
            // lb_figures
            // 
            this.lb_figures.FormattingEnabled = true;
            this.lb_figures.ItemHeight = 16;
            this.lb_figures.Location = new System.Drawing.Point(366, 157);
            this.lb_figures.Name = "lb_figures";
            this.lb_figures.Size = new System.Drawing.Size(134, 164);
            this.lb_figures.TabIndex = 7;
            // 
            // btCreateMinion
            // 
            this.btCreateMinion.Location = new System.Drawing.Point(24, 184);
            this.btCreateMinion.Name = "btCreateMinion";
            this.btCreateMinion.Size = new System.Drawing.Size(135, 40);
            this.btCreateMinion.TabIndex = 8;
            this.btCreateMinion.Text = "Create Minion";
            this.btCreateMinion.UseVisualStyleBackColor = true;
            this.btCreateMinion.Click += new System.EventHandler(this.btCreateMinion_Click);
            // 
            // btCreateSmurf
            // 
            this.btCreateSmurf.Location = new System.Drawing.Point(24, 230);
            this.btCreateSmurf.Name = "btCreateSmurf";
            this.btCreateSmurf.Size = new System.Drawing.Size(135, 39);
            this.btCreateSmurf.TabIndex = 9;
            this.btCreateSmurf.Text = "Create Smurf";
            this.btCreateSmurf.UseVisualStyleBackColor = true;
            this.btCreateSmurf.Click += new System.EventHandler(this.btCreateSmurf_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 206);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btSmurfHouse);
            this.panel2.Controls.Add(this.btMinHouse);
            this.panel2.Location = new System.Drawing.Point(24, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 80);
            this.panel2.TabIndex = 11;
            // 
            // btMinHouse
            // 
            this.btMinHouse.Location = new System.Drawing.Point(57, 4);
            this.btMinHouse.Name = "btMinHouse";
            this.btMinHouse.Size = new System.Drawing.Size(180, 73);
            this.btMinHouse.TabIndex = 0;
            this.btMinHouse.Text = "Repair and measure minion house";
            this.btMinHouse.UseVisualStyleBackColor = true;
            this.btMinHouse.Click += new System.EventHandler(this.btMinHouse_Click);
            // 
            // btSmurfHouse
            // 
            this.btSmurfHouse.Location = new System.Drawing.Point(268, 3);
            this.btSmurfHouse.Name = "btSmurfHouse";
            this.btSmurfHouse.Size = new System.Drawing.Size(180, 73);
            this.btSmurfHouse.TabIndex = 1;
            this.btSmurfHouse.Text = "Repair and measure smurf house";
            this.btSmurfHouse.UseVisualStyleBackColor = true;
            this.btSmurfHouse.Click += new System.EventHandler(this.btSmurfHouse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(693, 659);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btCreateSmurf);
            this.Controls.Add(this.btCreateMinion);
            this.Controls.Add(this.lb_figures);
            this.Controls.Add(this.btDance);
            this.Controls.Add(this.btSing);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btCreateSmurfGame);
            this.Controls.Add(this.lb_events);
            this.Controls.Add(this.btCreateMinionGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCreateMinionGame;
        private System.Windows.Forms.ListBox lb_events;
        private System.Windows.Forms.Button btCreateSmurfGame;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btSing;
        private System.Windows.Forms.Button btDance;
        private System.Windows.Forms.ListBox lb_figures;
        private System.Windows.Forms.Button btCreateMinion;
        private System.Windows.Forms.Button btCreateSmurf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btSmurfHouse;
        private System.Windows.Forms.Button btMinHouse;
    }
}

