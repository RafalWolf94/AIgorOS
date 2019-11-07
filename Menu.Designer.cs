namespace AIgorOS
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.CalcButt = new System.Windows.Forms.Button();
            this.NoteButt = new System.Windows.Forms.Button();
            this.GameButt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalcButt
            // 
            this.CalcButt.BackColor = System.Drawing.Color.Transparent;
            this.CalcButt.FlatAppearance.BorderSize = 0;
            this.CalcButt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.CalcButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CalcButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.CalcButt, "CalcButt");
            this.CalcButt.Name = "CalcButt";
            this.CalcButt.UseVisualStyleBackColor = false;
            this.CalcButt.Click += new System.EventHandler(this.CalcClick);
            this.CalcButt.MouseHover += new System.EventHandler(this.CalcHov);
            // 
            // NoteButt
            // 
            this.NoteButt.BackColor = System.Drawing.Color.Transparent;
            this.NoteButt.FlatAppearance.BorderSize = 0;
            this.NoteButt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.NoteButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NoteButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.NoteButt, "NoteButt");
            this.NoteButt.Name = "NoteButt";
            this.NoteButt.UseVisualStyleBackColor = false;
            this.NoteButt.Click += new System.EventHandler(this.NoteClick);
            this.NoteButt.MouseHover += new System.EventHandler(this.NoteHov);
            // 
            // GameButt
            // 
            this.GameButt.BackColor = System.Drawing.Color.Transparent;
            this.GameButt.FlatAppearance.BorderSize = 0;
            this.GameButt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.GameButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GameButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.GameButt, "GameButt");
            this.GameButt.Name = "GameButt";
            this.GameButt.UseVisualStyleBackColor = false;
            this.GameButt.Click += new System.EventHandler(this.GameClick);
            this.GameButt.MouseHover += new System.EventHandler(this.GameHov);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ExitButt);
            this.button1.MouseHover += new System.EventHandler(this.ExitHov);
            // 
            // Menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::AIgorOS.Properties.Resources.MenuItem;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GameButt);
            this.Controls.Add(this.NoteButt);
            this.Controls.Add(this.CalcButt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CalcButt;
        private System.Windows.Forms.Button NoteButt;
        private System.Windows.Forms.Button GameButt;
        private System.Windows.Forms.Button button1;
    }
}

