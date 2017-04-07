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
            this.lb_events = new System.Windows.Forms.ListBox();
            this.btStartGame = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btSing = new System.Windows.Forms.Button();
            this.btDance = new System.Windows.Forms.Button();
            this.lb_figures = new System.Windows.Forms.ListBox();
            this.btCreateFigure = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCreateHouse = new System.Windows.Forms.Button();
            this.btMeasureHouse = new System.Windows.Forms.Button();
            this.btRepairHouse = new System.Windows.Forms.Button();
            this.lb_houses = new System.Windows.Forms.ListBox();
            this.rbSmurfGame = new System.Windows.Forms.RadioButton();
            this.rbMinionGame = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME!";
            // 
            // lb_events
            // 
            this.lb_events.FormattingEnabled = true;
            this.lb_events.ItemHeight = 16;
            this.lb_events.Location = new System.Drawing.Point(24, 513);
            this.lb_events.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_events.Name = "lb_events";
            this.lb_events.ScrollAlwaysVisible = true;
            this.lb_events.Size = new System.Drawing.Size(838, 228);
            this.lb_events.TabIndex = 2;
            // 
            // btStartGame
            // 
            this.btStartGame.BackColor = System.Drawing.Color.DodgerBlue;
            this.btStartGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btStartGame.Location = new System.Drawing.Point(250, 61);
            this.btStartGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btStartGame.Name = "btStartGame";
            this.btStartGame.Size = new System.Drawing.Size(309, 42);
            this.btStartGame.TabIndex = 3;
            this.btStartGame.Text = "Start game";
            this.btStartGame.UseVisualStyleBackColor = false;
            this.btStartGame.Click += new System.EventHandler(this.btStartGame_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(25, 85);
            this.tbName.Margin = new System.Windows.Forms.Padding(0);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(123, 22);
            this.tbName.TabIndex = 4;
            this.tbName.Text = "name";
            // 
            // btSing
            // 
            this.btSing.Location = new System.Drawing.Point(393, 280);
            this.btSing.Name = "btSing";
            this.btSing.Size = new System.Drawing.Size(95, 34);
            this.btSing.TabIndex = 5;
            this.btSing.Text = "Sing";
            this.btSing.UseVisualStyleBackColor = true;
            this.btSing.Click += new System.EventHandler(this.btSing_Click);
            // 
            // btDance
            // 
            this.btDance.Location = new System.Drawing.Point(393, 320);
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
            this.lb_figures.Location = new System.Drawing.Point(333, 30);
            this.lb_figures.Name = "lb_figures";
            this.lb_figures.Size = new System.Drawing.Size(214, 244);
            this.lb_figures.TabIndex = 7;
            // 
            // btCreateFigure
            // 
            this.btCreateFigure.Location = new System.Drawing.Point(25, 107);
            this.btCreateFigure.Margin = new System.Windows.Forms.Padding(0);
            this.btCreateFigure.Name = "btCreateFigure";
            this.btCreateFigure.Size = new System.Drawing.Size(123, 40);
            this.btCreateFigure.TabIndex = 8;
            this.btCreateFigure.Text = "Create Figure";
            this.btCreateFigure.UseVisualStyleBackColor = true;
            this.btCreateFigure.Click += new System.EventHandler(this.btCreateFigure_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_figures);
            this.panel1.Controls.Add(this.btCreateHouse);
            this.panel1.Controls.Add(this.btMeasureHouse);
            this.panel1.Controls.Add(this.btRepairHouse);
            this.panel1.Controls.Add(this.lb_houses);
            this.panel1.Controls.Add(this.rbSmurfGame);
            this.panel1.Controls.Add(this.rbMinionGame);
            this.panel1.Controls.Add(this.btDance);
            this.panel1.Controls.Add(this.btCreateFigure);
            this.panel1.Controls.Add(this.btSing);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Location = new System.Drawing.Point(12, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 366);
            this.panel1.TabIndex = 10;
            // 
            // btCreateHouse
            // 
            this.btCreateHouse.Location = new System.Drawing.Point(27, 187);
            this.btCreateHouse.Name = "btCreateHouse";
            this.btCreateHouse.Size = new System.Drawing.Size(121, 40);
            this.btCreateHouse.TabIndex = 13;
            this.btCreateHouse.Text = "Create house";
            this.btCreateHouse.UseVisualStyleBackColor = true;
            this.btCreateHouse.Click += new System.EventHandler(this.btCreateHouse_Click);
            // 
            // btMeasureHouse
            // 
            this.btMeasureHouse.Location = new System.Drawing.Point(625, 320);
            this.btMeasureHouse.Name = "btMeasureHouse";
            this.btMeasureHouse.Size = new System.Drawing.Size(120, 35);
            this.btMeasureHouse.TabIndex = 12;
            this.btMeasureHouse.Text = "Measure House";
            this.btMeasureHouse.UseVisualStyleBackColor = true;
            this.btMeasureHouse.Click += new System.EventHandler(this.btMeasureHouse_Click);
            // 
            // btRepairHouse
            // 
            this.btRepairHouse.Location = new System.Drawing.Point(625, 280);
            this.btRepairHouse.Name = "btRepairHouse";
            this.btRepairHouse.Size = new System.Drawing.Size(120, 34);
            this.btRepairHouse.TabIndex = 0;
            this.btRepairHouse.Text = "Repair  house";
            this.btRepairHouse.UseVisualStyleBackColor = true;
            this.btRepairHouse.Click += new System.EventHandler(this.btRepairHouse_Click);
            // 
            // lb_houses
            // 
            this.lb_houses.FormattingEnabled = true;
            this.lb_houses.ItemHeight = 16;
            this.lb_houses.Location = new System.Drawing.Point(582, 30);
            this.lb_houses.Name = "lb_houses";
            this.lb_houses.Size = new System.Drawing.Size(224, 244);
            this.lb_houses.TabIndex = 11;
            // 
            // rbSmurfGame
            // 
            this.rbSmurfGame.AutoSize = true;
            this.rbSmurfGame.Location = new System.Drawing.Point(168, 15);
            this.rbSmurfGame.Name = "rbSmurfGame";
            this.rbSmurfGame.Size = new System.Drawing.Size(108, 21);
            this.rbSmurfGame.TabIndex = 10;
            this.rbSmurfGame.TabStop = true;
            this.rbSmurfGame.Text = "Smurf Game";
            this.rbSmurfGame.UseVisualStyleBackColor = true;
            this.rbSmurfGame.CheckedChanged += new System.EventHandler(this.rbSmurfGame_CheckedChanged);
            // 
            // rbMinionGame
            // 
            this.rbMinionGame.AutoSize = true;
            this.rbMinionGame.Location = new System.Drawing.Point(25, 15);
            this.rbMinionGame.Name = "rbMinionGame";
            this.rbMinionGame.Size = new System.Drawing.Size(112, 21);
            this.rbMinionGame.TabIndex = 9;
            this.rbMinionGame.TabStop = true;
            this.rbMinionGame.Text = "Minion Game";
            this.rbMinionGame.UseVisualStyleBackColor = true;
            this.rbMinionGame.CheckedChanged += new System.EventHandler(this.rbMinionGame_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 752);
            this.Controls.Add(this.btStartGame);
            this.Controls.Add(this.lb_events);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_events;
        private System.Windows.Forms.Button btStartGame;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btSing;
        private System.Windows.Forms.Button btDance;
        private System.Windows.Forms.ListBox lb_figures;
        private System.Windows.Forms.Button btCreateFigure;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btRepairHouse;
        private System.Windows.Forms.RadioButton rbSmurfGame;
        private System.Windows.Forms.RadioButton rbMinionGame;
        private System.Windows.Forms.ListBox lb_houses;
        private System.Windows.Forms.Button btMeasureHouse;
        private System.Windows.Forms.Button btCreateHouse;
    }
}

