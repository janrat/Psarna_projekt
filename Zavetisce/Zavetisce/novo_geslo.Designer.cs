namespace Zavetisce
{
    partial class novo_geslo
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
            this.label2 = new System.Windows.Forms.Label();
            this.stgeslo_tb = new System.Windows.Forms.TextBox();
            this.nvgeslo_tb = new System.Windows.Forms.TextBox();
            this.zamenjaj_btn = new System.Windows.Forms.Button();
            this.preklici_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staro geslo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Novo geslo:";
            // 
            // stgeslo_tb
            // 
            this.stgeslo_tb.Location = new System.Drawing.Point(82, 10);
            this.stgeslo_tb.Name = "stgeslo_tb";
            this.stgeslo_tb.PasswordChar = '•';
            this.stgeslo_tb.Size = new System.Drawing.Size(143, 20);
            this.stgeslo_tb.TabIndex = 2;
            // 
            // nvgeslo_tb
            // 
            this.nvgeslo_tb.Location = new System.Drawing.Point(82, 53);
            this.nvgeslo_tb.Name = "nvgeslo_tb";
            this.nvgeslo_tb.PasswordChar = '•';
            this.nvgeslo_tb.Size = new System.Drawing.Size(143, 20);
            this.nvgeslo_tb.TabIndex = 3;
            // 
            // zamenjaj_btn
            // 
            this.zamenjaj_btn.Location = new System.Drawing.Point(82, 96);
            this.zamenjaj_btn.Name = "zamenjaj_btn";
            this.zamenjaj_btn.Size = new System.Drawing.Size(75, 23);
            this.zamenjaj_btn.TabIndex = 4;
            this.zamenjaj_btn.Text = "Zamenjaj";
            this.zamenjaj_btn.UseVisualStyleBackColor = true;
            this.zamenjaj_btn.Click += new System.EventHandler(this.zamenjaj_btn_Click);
            // 
            // preklici_btn
            // 
            this.preklici_btn.Location = new System.Drawing.Point(297, 96);
            this.preklici_btn.Name = "preklici_btn";
            this.preklici_btn.Size = new System.Drawing.Size(75, 23);
            this.preklici_btn.TabIndex = 5;
            this.preklici_btn.Text = "Prekliči";
            this.preklici_btn.UseVisualStyleBackColor = true;
            this.preklici_btn.Click += new System.EventHandler(this.preklici_btn_Click);
            // 
            // novo_geslo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 131);
            this.Controls.Add(this.preklici_btn);
            this.Controls.Add(this.zamenjaj_btn);
            this.Controls.Add(this.nvgeslo_tb);
            this.Controls.Add(this.stgeslo_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "novo_geslo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo geslo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stgeslo_tb;
        private System.Windows.Forms.TextBox nvgeslo_tb;
        private System.Windows.Forms.Button zamenjaj_btn;
        private System.Windows.Forms.Button preklici_btn;
    }
}