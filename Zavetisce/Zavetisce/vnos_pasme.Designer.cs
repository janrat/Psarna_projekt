namespace Zavetisce
{
    partial class vnos_pasme
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
            this.ime_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.doba_tb = new System.Windows.Forms.TextBox();
            this.velikostM_tb = new System.Windows.Forms.TextBox();
            this.velikostZ_tb = new System.Windows.Forms.TextBox();
            this.dodaj_btn = new System.Windows.Forms.Button();
            this.preklici_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // ime_tb
            // 
            this.ime_tb.Location = new System.Drawing.Point(125, 60);
            this.ime_tb.Name = "ime_tb";
            this.ime_tb.Size = new System.Drawing.Size(119, 20);
            this.ime_tb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Življenjska doba:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Velikost samca (cm):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Velikost samice (cm):";
            // 
            // doba_tb
            // 
            this.doba_tb.Location = new System.Drawing.Point(125, 95);
            this.doba_tb.Name = "doba_tb";
            this.doba_tb.Size = new System.Drawing.Size(100, 20);
            this.doba_tb.TabIndex = 5;
            // 
            // velikostM_tb
            // 
            this.velikostM_tb.Location = new System.Drawing.Point(125, 129);
            this.velikostM_tb.Name = "velikostM_tb";
            this.velikostM_tb.Size = new System.Drawing.Size(88, 20);
            this.velikostM_tb.TabIndex = 6;
            // 
            // velikostZ_tb
            // 
            this.velikostZ_tb.Location = new System.Drawing.Point(125, 165);
            this.velikostZ_tb.Name = "velikostZ_tb";
            this.velikostZ_tb.Size = new System.Drawing.Size(88, 20);
            this.velikostZ_tb.TabIndex = 7;
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.Location = new System.Drawing.Point(216, 326);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(75, 23);
            this.dodaj_btn.TabIndex = 8;
            this.dodaj_btn.Text = "Dodaj";
            this.dodaj_btn.UseVisualStyleBackColor = true;
            this.dodaj_btn.Click += new System.EventHandler(this.dodaj_btn_Click);
            // 
            // preklici_btn
            // 
            this.preklici_btn.Location = new System.Drawing.Point(297, 326);
            this.preklici_btn.Name = "preklici_btn";
            this.preklici_btn.Size = new System.Drawing.Size(75, 23);
            this.preklici_btn.TabIndex = 9;
            this.preklici_btn.Text = "Nazaj";
            this.preklici_btn.UseVisualStyleBackColor = true;
            this.preklici_btn.Click += new System.EventHandler(this.preklici_btn_Click);
            // 
            // vnos_pasme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.preklici_btn);
            this.Controls.Add(this.dodaj_btn);
            this.Controls.Add(this.velikostZ_tb);
            this.Controls.Add(this.velikostM_tb);
            this.Controls.Add(this.doba_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ime_tb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "vnos_pasme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vnos pasme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ime_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox doba_tb;
        private System.Windows.Forms.TextBox velikostM_tb;
        private System.Windows.Forms.TextBox velikostZ_tb;
        private System.Windows.Forms.Button dodaj_btn;
        private System.Windows.Forms.Button preklici_btn;
    }
}