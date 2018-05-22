namespace AvoiderGame
{
    partial class GameForm
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
			this.Score = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.ScoreTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.HPTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Ranking_List = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// Score
			// 
			this.Score.Enabled = true;
			this.Score.Interval = 30;
			this.Score.Tick += new System.EventHandler(this.Score_Tick_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(1069, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Score";
			// 
			// ScoreTextBox
			// 
			this.ScoreTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.ScoreTextBox.Location = new System.Drawing.Point(1072, 25);
			this.ScoreTextBox.Name = "ScoreTextBox";
			this.ScoreTextBox.ReadOnly = true;
			this.ScoreTextBox.Size = new System.Drawing.Size(100, 20);
			this.ScoreTextBox.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(1069, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(22, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "HP";
			// 
			// HPTextBox
			// 
			this.HPTextBox.Location = new System.Drawing.Point(1072, 64);
			this.HPTextBox.Name = "HPTextBox";
			this.HPTextBox.ReadOnly = true;
			this.HPTextBox.Size = new System.Drawing.Size(100, 20);
			this.HPTextBox.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Ranking";
			// 
			// Ranking_List
			// 
			this.Ranking_List.FormattingEnabled = true;
			this.Ranking_List.Location = new System.Drawing.Point(15, 25);
			this.Ranking_List.Name = "Ranking_List";
			this.Ranking_List.Size = new System.Drawing.Size(330, 719);
			this.Ranking_List.TabIndex = 5;
			// 
			// GameForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1184, 761);
			this.Controls.Add(this.Ranking_List);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.HPTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ScoreTextBox);
			this.MaximumSize = new System.Drawing.Size(1200, 800);
			this.MinimumSize = new System.Drawing.Size(1200, 800);
			this.Name = "GameForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GameForm";
			this.Load += new System.EventHandler(this.GameForm_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ScoreTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HPTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Ranking_List;
    }
}