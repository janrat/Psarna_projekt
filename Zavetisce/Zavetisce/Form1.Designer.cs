namespace Zavetisce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.uporabnisko_tb = new System.Windows.Forms.TextBox();
            this.geslo_tb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prijava_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uporabnisko_tb
            // 
            this.uporabnisko_tb.Location = new System.Drawing.Point(90, 235);
            this.uporabnisko_tb.Name = "uporabnisko_tb";
            this.uporabnisko_tb.Size = new System.Drawing.Size(200, 20);
            this.uporabnisko_tb.TabIndex = 4;
            this.uporabnisko_tb.Enter += new System.EventHandler(this.uporabnisko_tb_Enter);
            this.uporabnisko_tb.Leave += new System.EventHandler(this.uporabnisko_tb_Leave);
            // 
            // geslo_tb
            // 
            this.geslo_tb.Location = new System.Drawing.Point(90, 274);
            this.geslo_tb.Name = "geslo_tb";
            this.geslo_tb.Size = new System.Drawing.Size(200, 20);
            this.geslo_tb.TabIndex = 5;
            this.geslo_tb.Enter += new System.EventHandler(this.geslo_tb_Enter);
            this.geslo_tb.Leave += new System.EventHandler(this.geslo_tb_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // prijava_btn
            // 
            this.prijava_btn.Location = new System.Drawing.Point(90, 300);
            this.prijava_btn.Name = "prijava_btn";
            this.prijava_btn.Size = new System.Drawing.Size(75, 23);
            this.prijava_btn.TabIndex = 3;
            this.prijava_btn.Text = "Prijava";
            this.prijava_btn.UseVisualStyleBackColor = true;
            this.prijava_btn.Click += new System.EventHandler(this.prijava_btn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.prijava_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(117)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.prijava_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.geslo_tb);
            this.Controls.Add(this.uporabnisko_tb);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Psarna Ratova";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uporabnisko_tb;
        private System.Windows.Forms.TextBox geslo_tb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button prijava_btn;
    }
}

