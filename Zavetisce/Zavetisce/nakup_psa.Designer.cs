namespace Zavetisce
{
    partial class nakup_psa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nakup_psa));
            this.iskanje_tb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nazaj_btn = new System.Windows.Forms.Button();
            this.potrdi_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cena_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ime_tb = new System.Windows.Forms.TextBox();
            this.priimek_tb = new System.Windows.Forms.TextBox();
            this.pdf_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iskanje_tb
            // 
            this.iskanje_tb.Location = new System.Drawing.Point(65, 20);
            this.iskanje_tb.Name = "iskanje_tb";
            this.iskanje_tb.Size = new System.Drawing.Size(116, 20);
            this.iskanje_tb.TabIndex = 0;
            this.iskanje_tb.TextChanged += new System.EventHandler(this.iskanje_tb_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime psa:";
            // 
            // nazaj_btn
            // 
            this.nazaj_btn.Location = new System.Drawing.Point(582, 326);
            this.nazaj_btn.Name = "nazaj_btn";
            this.nazaj_btn.Size = new System.Drawing.Size(75, 23);
            this.nazaj_btn.TabIndex = 3;
            this.nazaj_btn.Text = "Nazaj";
            this.nazaj_btn.UseVisualStyleBackColor = true;
            this.nazaj_btn.Click += new System.EventHandler(this.nazaj_btn_Click);
            // 
            // potrdi_btn
            // 
            this.potrdi_btn.Location = new System.Drawing.Point(8, 326);
            this.potrdi_btn.Name = "potrdi_btn";
            this.potrdi_btn.Size = new System.Drawing.Size(75, 23);
            this.potrdi_btn.TabIndex = 4;
            this.potrdi_btn.Text = "Nakup";
            this.potrdi_btn.UseVisualStyleBackColor = true;
            this.potrdi_btn.Click += new System.EventHandler(this.potrdi_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zadnja cena:";
            // 
            // cena_tb
            // 
            this.cena_tb.Location = new System.Drawing.Point(88, 227);
            this.cena_tb.Name = "cena_tb";
            this.cena_tb.Size = new System.Drawing.Size(58, 20);
            this.cena_tb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ime kupca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Priimek kupca:";
            // 
            // ime_tb
            // 
            this.ime_tb.Location = new System.Drawing.Point(88, 253);
            this.ime_tb.Name = "ime_tb";
            this.ime_tb.Size = new System.Drawing.Size(128, 20);
            this.ime_tb.TabIndex = 9;
            // 
            // priimek_tb
            // 
            this.priimek_tb.Location = new System.Drawing.Point(88, 279);
            this.priimek_tb.Name = "priimek_tb";
            this.priimek_tb.Size = new System.Drawing.Size(128, 20);
            this.priimek_tb.TabIndex = 10;
            // 
            // pdf_btn
            // 
            this.pdf_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pdf_btn.BackgroundImage")));
            this.pdf_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pdf_btn.Location = new System.Drawing.Point(607, 217);
            this.pdf_btn.Name = "pdf_btn";
            this.pdf_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pdf_btn.Size = new System.Drawing.Size(50, 50);
            this.pdf_btn.TabIndex = 11;
            this.pdf_btn.UseVisualStyleBackColor = true;
            this.pdf_btn.Click += new System.EventHandler(this.pdf_btn_Click);
            // 
            // nakup_psa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(669, 361);
            this.Controls.Add(this.pdf_btn);
            this.Controls.Add(this.priimek_tb);
            this.Controls.Add(this.ime_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cena_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.potrdi_btn);
            this.Controls.Add(this.nazaj_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.iskanje_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "nakup_psa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nakup psa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.nakup_psa_FormClosed);
            this.Load += new System.EventHandler(this.nakup_psa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox iskanje_tb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nazaj_btn;
        private System.Windows.Forms.Button potrdi_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cena_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ime_tb;
        private System.Windows.Forms.TextBox priimek_tb;
        private System.Windows.Forms.Button pdf_btn;
    }
}