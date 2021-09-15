namespace Cross_zero
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelDrawnGame = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.labelScoreUser2 = new System.Windows.Forms.Label();
            this.labelScoreUser1 = new System.Windows.Forms.Label();
            this.labelUser2 = new System.Windows.Forms.Label();
            this.labelUser1 = new System.Windows.Forms.Label();
            this.labelStatistics = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelDrawnGame);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.nudSize);
            this.splitContainer1.Panel2.Controls.Add(this.labelScoreUser2);
            this.splitContainer1.Panel2.Controls.Add(this.labelScoreUser1);
            this.splitContainer1.Panel2.Controls.Add(this.labelUser2);
            this.splitContainer1.Panel2.Controls.Add(this.labelUser1);
            this.splitContainer1.Panel2.Controls.Add(this.labelStatistics);
            this.splitContainer1.Panel2.Controls.Add(this.buttonStart);
            this.splitContainer1.Size = new System.Drawing.Size(809, 556);
            this.splitContainer1.SplitterDistance = 656;
            this.splitContainer1.TabIndex = 1;
            // 
            // labelDrawnGame
            // 
            this.labelDrawnGame.BackColor = System.Drawing.Color.Transparent;
            this.labelDrawnGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDrawnGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDrawnGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDrawnGame.Font = new System.Drawing.Font("ROG Fonts", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrawnGame.Location = new System.Drawing.Point(0, 0);
            this.labelDrawnGame.Name = "labelDrawnGame";
            this.labelDrawnGame.Size = new System.Drawing.Size(656, 556);
            this.labelDrawnGame.TabIndex = 1;
            this.labelDrawnGame.Text = "DRAWN GAME";
            this.labelDrawnGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDrawnGame.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(656, 556);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // nudSize
            // 
            this.nudSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSize.Font = new System.Drawing.Font("ROG Fonts", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSize.Location = new System.Drawing.Point(10, 127);
            this.nudSize.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(120, 28);
            this.nudSize.TabIndex = 6;
            this.nudSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelScoreUser2
            // 
            this.labelScoreUser2.AutoSize = true;
            this.labelScoreUser2.Font = new System.Drawing.Font("ROG Fonts", 10F);
            this.labelScoreUser2.Location = new System.Drawing.Point(6, 382);
            this.labelScoreUser2.Name = "labelScoreUser2";
            this.labelScoreUser2.Size = new System.Drawing.Size(24, 20);
            this.labelScoreUser2.TabIndex = 5;
            this.labelScoreUser2.Text = "0";
            // 
            // labelScoreUser1
            // 
            this.labelScoreUser1.AutoSize = true;
            this.labelScoreUser1.Font = new System.Drawing.Font("ROG Fonts", 10F);
            this.labelScoreUser1.Location = new System.Drawing.Point(12, 308);
            this.labelScoreUser1.Name = "labelScoreUser1";
            this.labelScoreUser1.Size = new System.Drawing.Size(24, 20);
            this.labelScoreUser1.TabIndex = 4;
            this.labelScoreUser1.Text = "0";
            // 
            // labelUser2
            // 
            this.labelUser2.AutoSize = true;
            this.labelUser2.Font = new System.Drawing.Font("ROG Fonts", 10F);
            this.labelUser2.Location = new System.Drawing.Point(12, 345);
            this.labelUser2.Name = "labelUser2";
            this.labelUser2.Size = new System.Drawing.Size(82, 20);
            this.labelUser2.TabIndex = 3;
            this.labelUser2.Text = "User2";
            // 
            // labelUser1
            // 
            this.labelUser1.AutoSize = true;
            this.labelUser1.Font = new System.Drawing.Font("ROG Fonts", 10F);
            this.labelUser1.Location = new System.Drawing.Point(12, 267);
            this.labelUser1.Name = "labelUser1";
            this.labelUser1.Size = new System.Drawing.Size(76, 20);
            this.labelUser1.TabIndex = 2;
            this.labelUser1.Text = "User1";
            // 
            // labelStatistics
            // 
            this.labelStatistics.AutoSize = true;
            this.labelStatistics.Font = new System.Drawing.Font("ROG Fonts", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatistics.Location = new System.Drawing.Point(6, 217);
            this.labelStatistics.Name = "labelStatistics";
            this.labelStatistics.Size = new System.Drawing.Size(140, 20);
            this.labelStatistics.TabIndex = 1;
            this.labelStatistics.Text = "Statistics";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonStart.Font = new System.Drawing.Font("ROG Fonts", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(2, 61);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(144, 38);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 556);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelScoreUser2;
        private System.Windows.Forms.Label labelScoreUser1;
        private System.Windows.Forms.Label labelUser2;
        private System.Windows.Forms.Label labelUser1;
        private System.Windows.Forms.Label labelStatistics;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Label labelDrawnGame;
        private System.Windows.Forms.Timer timer1;
    }
}

