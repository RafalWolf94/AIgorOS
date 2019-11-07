namespace AIgorOS
{
    partial class GameChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameChoice));
            this.TicTacButt = new System.Windows.Forms.Button();
            this.ExitButt = new System.Windows.Forms.Button();
            this.RaceButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TicTacButt
            // 
            this.TicTacButt.BackColor = System.Drawing.Color.Transparent;
            this.TicTacButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TicTacButt.FlatAppearance.BorderSize = 0;
            this.TicTacButt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.TicTacButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TicTacButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TicTacButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TicTacButt.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TicTacButt.ForeColor = System.Drawing.Color.Maroon;
            this.TicTacButt.Location = new System.Drawing.Point(30, 202);
            this.TicTacButt.Margin = new System.Windows.Forms.Padding(5);
            this.TicTacButt.Name = "TicTacButt";
            this.TicTacButt.Size = new System.Drawing.Size(343, 50);
            this.TicTacButt.TabIndex = 0;
            this.TicTacButt.Text = "1. Tic-Tac-Toe";
            this.TicTacButt.UseMnemonic = false;
            this.TicTacButt.UseVisualStyleBackColor = false;
            this.TicTacButt.Click += new System.EventHandler(this.TicTacButt_Click);
            // 
            // ExitButt
            // 
            this.ExitButt.BackColor = System.Drawing.Color.Transparent;
            this.ExitButt.FlatAppearance.BorderSize = 0;
            this.ExitButt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ExitButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExitButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButt.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButt.ForeColor = System.Drawing.Color.Firebrick;
            this.ExitButt.Location = new System.Drawing.Point(128, 549);
            this.ExitButt.Name = "ExitButt";
            this.ExitButt.Size = new System.Drawing.Size(150, 50);
            this.ExitButt.TabIndex = 4;
            this.ExitButt.Text = "Menu";
            this.ExitButt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ExitButt.UseVisualStyleBackColor = true;
            this.ExitButt.Click += new System.EventHandler(this.ExitButt_Click);
            // 
            // RaceButt
            // 
            this.RaceButt.BackColor = System.Drawing.Color.Transparent;
            this.RaceButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RaceButt.FlatAppearance.BorderSize = 0;
            this.RaceButt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.RaceButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RaceButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RaceButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RaceButt.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RaceButt.ForeColor = System.Drawing.Color.Crimson;
            this.RaceButt.Location = new System.Drawing.Point(30, 260);
            this.RaceButt.Name = "RaceButt";
            this.RaceButt.Size = new System.Drawing.Size(343, 50);
            this.RaceButt.TabIndex = 5;
            this.RaceButt.Text = "2. Space Race";
            this.RaceButt.UseMnemonic = false;
            this.RaceButt.UseVisualStyleBackColor = false;
            this.RaceButt.Click += new System.EventHandler(this.RaceButt_Click);
            // 
            // GameChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AIgorOS.Properties.Resources.GamesMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 611);
            this.Controls.Add(this.RaceButt);
            this.Controls.Add(this.ExitButt);
            this.Controls.Add(this.TicTacButt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AigorOS Gry";
            this.Load += new System.EventHandler(this.GameChoice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TicTacButt;
        private System.Windows.Forms.Button ExitButt;
        private System.Windows.Forms.Button RaceButt;
    }
}