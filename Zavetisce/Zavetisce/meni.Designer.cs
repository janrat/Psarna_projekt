namespace Zavetisce
{
    partial class meni
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
            this.vnospsa_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uporabnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamenjajGesloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.odjaviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.st_psov_progBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.vnospasme_btn = new System.Windows.Forms.Button();
            this.procenti_label = new System.Windows.Forms.Label();
            this.nakuppsa_btn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vnospsa_btn
            // 
            this.vnospsa_btn.Location = new System.Drawing.Point(16, 38);
            this.vnospsa_btn.Name = "vnospsa_btn";
            this.vnospsa_btn.Size = new System.Drawing.Size(356, 80);
            this.vnospsa_btn.TabIndex = 0;
            this.vnospsa_btn.Text = "Vnos psa";
            this.vnospsa_btn.UseVisualStyleBackColor = true;
            this.vnospsa_btn.Click += new System.EventHandler(this.vnospsa_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uporabnikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uporabnikToolStripMenuItem
            // 
            this.uporabnikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamenjajGesloToolStripMenuItem,
            this.toolStripSeparator1,
            this.odjaviToolStripMenuItem});
            this.uporabnikToolStripMenuItem.Name = "uporabnikToolStripMenuItem";
            this.uporabnikToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.uporabnikToolStripMenuItem.Text = "Uporabnik";
            // 
            // zamenjajGesloToolStripMenuItem
            // 
            this.zamenjajGesloToolStripMenuItem.Name = "zamenjajGesloToolStripMenuItem";
            this.zamenjajGesloToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.zamenjajGesloToolStripMenuItem.Text = "Zamenjaj geslo";
            this.zamenjajGesloToolStripMenuItem.Click += new System.EventHandler(this.zamenjajGesloToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // odjaviToolStripMenuItem
            // 
            this.odjaviToolStripMenuItem.Name = "odjaviToolStripMenuItem";
            this.odjaviToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.odjaviToolStripMenuItem.Text = "Odjavi";
            this.odjaviToolStripMenuItem.Click += new System.EventHandler(this.odjaviToolStripMenuItem_Click);
            // 
            // st_psov_progBar
            // 
            this.st_psov_progBar.Location = new System.Drawing.Point(12, 326);
            this.st_psov_progBar.Name = "st_psov_progBar";
            this.st_psov_progBar.Size = new System.Drawing.Size(360, 23);
            this.st_psov_progBar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zapolnjenost:";
            // 
            // vnospasme_btn
            // 
            this.vnospasme_btn.Location = new System.Drawing.Point(16, 124);
            this.vnospasme_btn.Name = "vnospasme_btn";
            this.vnospasme_btn.Size = new System.Drawing.Size(356, 80);
            this.vnospasme_btn.TabIndex = 4;
            this.vnospasme_btn.Text = "Vnos pasme";
            this.vnospasme_btn.UseVisualStyleBackColor = true;
            this.vnospasme_btn.Click += new System.EventHandler(this.vnospasme_btn_Click);
            // 
            // procenti_label
            // 
            this.procenti_label.AutoSize = true;
            this.procenti_label.Location = new System.Drawing.Point(90, 307);
            this.procenti_label.Name = "procenti_label";
            this.procenti_label.Size = new System.Drawing.Size(37, 13);
            this.procenti_label.TabIndex = 5;
            this.procenti_label.Text = "stevilo";
            // 
            // nakuppsa_btn
            // 
            this.nakuppsa_btn.Location = new System.Drawing.Point(16, 210);
            this.nakuppsa_btn.Name = "nakuppsa_btn";
            this.nakuppsa_btn.Size = new System.Drawing.Size(356, 80);
            this.nakuppsa_btn.TabIndex = 6;
            this.nakuppsa_btn.Text = "Nakup psa";
            this.nakuppsa_btn.UseVisualStyleBackColor = true;
            this.nakuppsa_btn.Click += new System.EventHandler(this.nakuppsa_btn_Click);
            // 
            // meni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.nakuppsa_btn);
            this.Controls.Add(this.procenti_label);
            this.Controls.Add(this.vnospasme_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.st_psov_progBar);
            this.Controls.Add(this.vnospsa_btn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "meni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meni";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.meni_FormClosed);
            this.Load += new System.EventHandler(this.meni_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vnospsa_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uporabnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamenjajGesloToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ProgressBar st_psov_progBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vnospasme_btn;
        private System.Windows.Forms.Label procenti_label;
        private System.Windows.Forms.Button nakuppsa_btn;
    }
}