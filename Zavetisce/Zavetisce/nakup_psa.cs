using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

using System.IO;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Zavetisce
{
    public partial class nakup_psa : Form
    {
        public nakup_psa()
        {
            InitializeComponent();
        }
        private MySqlDataAdapter mySqlDataAdapter;

        private void nakup_psa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void iskanje_tb_TextChanged(object sender, EventArgs e)
        {
            string povezava = "server=62.84.225.41;user=jan;database=vzreja_psov;port=3306;password=jan123;CharSet=utf8;";
            MySqlConnection conn = new MySqlConnection(povezava);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("iskanje_psa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", iskanje_tb.Text);

                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                // dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderCell.Value = "Ime";
                dataGridView1.Columns[2].HeaderCell.Value = "Pasma";
                dataGridView1.Columns[3].HeaderCell.Value = "Datum rojstva";
                dataGridView1.Columns[4].HeaderCell.Value = "Vzdevek";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }

        private void nakup_psa_Load(object sender, EventArgs e)
        {

        }

        private void nazaj_btn_Click(object sender, EventArgs e)
        {
            meni novoOkno = new meni();
            novoOkno.Show();
            this.Hide();
        }

        private void potrdi_btn_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(dataGridView1.CurrentCell.Value.ToString());
            if (ime_tb.Text != "" && priimek_tb.Text != "" && cena_tb.Text != "")
            {
                //string datum_rojstva = datum_roj.ToString();
                string povezava = "server=62.84.225.41;user=jan;database=vzreja_psov;port=3306;password=jan123;CharSet=utf8;";
                MySqlConnection conn = new MySqlConnection(povezava);
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT nakup_psa('" + dataGridView1.CurrentCell.Value.ToString() + "','" + ime_tb.Text + "','" + priimek_tb.Text + "','" + cena_tb.Text + "');", conn);

                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        if (rdr.GetInt16(0) == 1)
                        {                            
                            MessageBox.Show("Uspešno ste prodali psa.");
                            meni novoOkno = new meni();
                            novoOkno.Show();
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Napaka" + rdr.GetInt16(0));
                        }

                    }
                    rdr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                conn.Close();
            }
            else
            {
                MessageBox.Show("Vnesite vse potrebne podatke.");
            }
        }

        private void pdf_btn_Click(object sender, EventArgs e)
        {
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                var FontColour = new BaseColor(0, 183, 255);                
                var MyFont = FontFactory.GetFont("Times New Roman", 14, FontColour);
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, MyFont));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);              
               
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                }
            }
            
            //Exporting to PDF
            string folderPath = "C:\\PDF_pesjarna\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "Psi_v_bazi-"+DateTime.Now.ToFileTime()+".pdf", FileMode.Create))
            {
                var FontBarva = new BaseColor(255, 0, 0);
                var title = FontFactory.GetFont("Times New Roman", 20, FontBarva);
                Document pdfDoc = new Document(PageSize.A4, 50f, 50f, 50f, 50f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(new Paragraph("Psi, ki so bili izbrani v bazi", title));
                pdfDoc.Add(new Paragraph(" ", title));
                pdfDoc.Add(pdfTable);                
                pdfDoc.Close();
                stream.Close();
                MessageBox.Show("Uspešno ste prenesli v PDF obliko. Nahaja se v C:\\PDF_pesjarna.");
            }
        }
    }
}
