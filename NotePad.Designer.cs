namespace AIgorOS
{
    partial class NotePad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotePad));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szyfrujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odszyfrujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WriteBox = new System.Windows.Forms.RichTextBox();
            this.ReturnButt = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.Highlight;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save,
            this.czcionkiToolStripMenuItem,
            this.szyfrujToolStripMenuItem,
            this.odszyfrujToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.Save.Size = new System.Drawing.Size(52, 20);
            this.Save.Text = "Zapisz";
            this.Save.Click += new System.EventHandler(this.SaveClick);
            // 
            // czcionkiToolStripMenuItem
            // 
            this.czcionkiToolStripMenuItem.Name = "czcionkiToolStripMenuItem";
            this.czcionkiToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.czcionkiToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.czcionkiToolStripMenuItem.Text = "Czcionki";
            this.czcionkiToolStripMenuItem.Click += new System.EventHandler(this.FontClick);
            // 
            // szyfrujToolStripMenuItem
            // 
            this.szyfrujToolStripMenuItem.Name = "szyfrujToolStripMenuItem";
            this.szyfrujToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.szyfrujToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.szyfrujToolStripMenuItem.Text = "Szyfruj";
            this.szyfrujToolStripMenuItem.Click += new System.EventHandler(this.CodeClick);
            // 
            // odszyfrujToolStripMenuItem
            // 
            this.odszyfrujToolStripMenuItem.Name = "odszyfrujToolStripMenuItem";
            this.odszyfrujToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.odszyfrujToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.odszyfrujToolStripMenuItem.Text = "Odszyfruj";
            this.odszyfrujToolStripMenuItem.Click += new System.EventHandler(this.DeCodeClick);
            // 
            // WriteBox
            // 
            this.WriteBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WriteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WriteBox.Location = new System.Drawing.Point(0, 24);
            this.WriteBox.Name = "WriteBox";
            this.WriteBox.Size = new System.Drawing.Size(800, 426);
            this.WriteBox.TabIndex = 1;
            this.WriteBox.Text = "";
            this.WriteBox.TextChanged += new System.EventHandler(this.WriteBox_TextChanged);
            // 
            // ReturnButt
            // 
            this.ReturnButt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ReturnButt.FlatAppearance.BorderSize = 0;
            this.ReturnButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ReturnButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ReturnButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReturnButt.Location = new System.Drawing.Point(243, 1);
            this.ReturnButt.Name = "ReturnButt";
            this.ReturnButt.Size = new System.Drawing.Size(54, 23);
            this.ReturnButt.TabIndex = 4;
            this.ReturnButt.Text = "Menu";
            this.ReturnButt.UseVisualStyleBackColor = false;
            this.ReturnButt.Click += new System.EventHandler(this.ReturnClick);
            // 
            // NotePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnButt);
            this.Controls.Add(this.WriteBox);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "NotePad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotePad";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem czcionkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szyfrujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odszyfrujToolStripMenuItem;
        private System.Windows.Forms.RichTextBox WriteBox;
        private System.Windows.Forms.Button ReturnButt;
    }
}