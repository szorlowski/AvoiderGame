namespace AvoiderGame
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartGameButton = new System.Windows.Forms.Button();
            this.CreatePlayerButton = new System.Windows.Forms.Button();
            this.AllPlayersList = new System.Windows.Forms.ListBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeletePlayerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartGameButton
            // 
            this.StartGameButton.BackColor = System.Drawing.Color.Green;
            this.StartGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGameButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StartGameButton.Location = new System.Drawing.Point(369, 490);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(90, 33);
            this.StartGameButton.TabIndex = 1;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = false;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // CreatePlayerButton
            // 
            this.CreatePlayerButton.BackColor = System.Drawing.Color.Red;
            this.CreatePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePlayerButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CreatePlayerButton.Location = new System.Drawing.Point(476, 490);
            this.CreatePlayerButton.Name = "CreatePlayerButton";
            this.CreatePlayerButton.Size = new System.Drawing.Size(90, 33);
            this.CreatePlayerButton.TabIndex = 2;
            this.CreatePlayerButton.Text = "Create Player";
            this.CreatePlayerButton.UseVisualStyleBackColor = false;
            this.CreatePlayerButton.Click += new System.EventHandler(this.CreatePlayerButton_Click);
            // 
            // AllPlayersList
            // 
            this.AllPlayersList.FormattingEnabled = true;
            this.AllPlayersList.Location = new System.Drawing.Point(369, 168);
            this.AllPlayersList.Name = "AllPlayersList";
            this.AllPlayersList.Size = new System.Drawing.Size(303, 303);
            this.AllPlayersList.TabIndex = 3;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Blue;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateButton.Location = new System.Drawing.Point(582, 490);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(90, 33);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Refresh";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click_1);
            // 
            // DeletePlayerButton
            // 
            this.DeletePlayerButton.BackColor = System.Drawing.Color.Black;
            this.DeletePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePlayerButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeletePlayerButton.Location = new System.Drawing.Point(476, 538);
            this.DeletePlayerButton.Name = "DeletePlayerButton";
            this.DeletePlayerButton.Size = new System.Drawing.Size(90, 33);
            this.DeletePlayerButton.TabIndex = 5;
            this.DeletePlayerButton.Text = "Delete Player";
            this.DeletePlayerButton.UseVisualStyleBackColor = false;
            this.DeletePlayerButton.Click += new System.EventHandler(this.DeletePlayerButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.DeletePlayerButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AllPlayersList);
            this.Controls.Add(this.CreatePlayerButton);
            this.Controls.Add(this.StartGameButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AvoiderGame";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Button CreatePlayerButton;
        private System.Windows.Forms.ListBox AllPlayersList;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeletePlayerButton;
    }
}

