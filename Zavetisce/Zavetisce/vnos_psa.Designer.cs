namespace Zavetisce
{
    partial class vnos_psa
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
            this.pasma_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vzdevek_tb = new System.Windows.Forms.TextBox();
            this.dodaj_btn = new System.Windows.Forms.Button();
            this.ime_tb = new System.Windows.Forms.TextBox();
            this.nazaj_btn = new System.Windows.Forms.Button();
            this.datum_roj = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cena_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pasma:";
            // 
            // pasma_cb
            // 
            this.pasma_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pasma_cb.FormattingEnabled = true;
            this.pasma_cb.Location = new System.Drawing.Point(100, 31);
            this.pasma_cb.Name = "pasma_cb";
            this.pasma_cb.Size = new System.Drawing.Size(120, 21);
            this.pasma_cb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Datum rojstva:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vzdevek:";
            // 
            // vzdevek_tb
            // 
            this.vzdevek_tb.Location = new System.Drawing.Point(100, 163);
            this.vzdevek_tb.Name = "vzdevek_tb";
            this.vzdevek_tb.Size = new System.Drawing.Size(120, 20);
            this.vzdevek_tb.TabIndex = 5;
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.Location = new System.Drawing.Point(216, 326);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(75, 23);
            this.dodaj_btn.TabIndex = 7;
            this.dodaj_btn.Text = "Dodaj";
            this.dodaj_btn.UseVisualStyleBackColor = true;
            this.dodaj_btn.Click += new System.EventHandler(this.dodaj_btn_Click);
            // 
            // ime_tb
            // 
            this.ime_tb.Location = new System.Drawing.Point(100, 67);
            this.ime_tb.Name = "ime_tb";
            this.ime_tb.Size = new System.Drawing.Size(120, 20);
            this.ime_tb.TabIndex = 8;
            // 
            // nazaj_btn
            // 
            this.nazaj_btn.Location = new System.Drawing.Point(297, 326);
            this.nazaj_btn.Name = "nazaj_btn";
            this.nazaj_btn.Size = new System.Drawing.Size(75, 23);
            this.nazaj_btn.TabIndex = 9;
            this.nazaj_btn.Text = "Nazaj";
            this.nazaj_btn.UseVisualStyleBackColor = true;
            this.nazaj_btn.Click += new System.EventHandler(this.nazaj_btn_Click);
            // 
            // datum_roj
            // 
            this.datum_roj.CustomFormat = "yyyy-MM-dd";
            this.datum_roj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datum_roj.Location = new System.Drawing.Point(100, 99);
            this.datum_roj.Name = "datum_roj";
            this.datum_roj.Size = new System.Drawing.Size(200, 20);
            this.datum_roj.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cena:";
            // 
            // cena_tb
            // 
            this.cena_tb.Location = new System.Drawing.Point(100, 203);
            this.cena_tb.Name = "cena_tb";
            this.cena_tb.Size = new System.Drawing.Size(56, 20);
            this.cena_tb.TabIndex = 12;
            // 
            // vnos_psa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.cena_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datum_roj);
            this.Controls.Add(this.nazaj_btn);
            this.Controls.Add(this.ime_tb);
            this.Controls.Add(this.dodaj_btn);
            this.Controls.Add(this.vzdevek_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pasma_cb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "vnos_psa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vnos psa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.vnos_psa_FormClosed);
            this.Load += new System.EventHandler(this.vnos_psa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pasma_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vzdevek_tb;
        private System.Windows.Forms.Button dodaj_btn;
        private System.Windows.Forms.TextBox ime_tb;
        private System.Windows.Forms.Button nazaj_btn;
        private System.Windows.Forms.DateTimePicker datum_roj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cena_tb;
    }
}