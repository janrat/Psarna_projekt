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

namespace Zavetisce
{
    public partial class vnos_pasme : Form
    {
        public vnos_pasme()
        {
            InitializeComponent();
        }

        private void preklici_btn_Click(object sender, EventArgs e)
        {
            meni novoOkno = new meni();
            novoOkno.Show();
            this.Hide();
        }

        private void dodaj_btn_Click(object sender, EventArgs e)
        {
            if (ime_tb.Text != "")
            {
                //string datum_rojstva = datum_roj.ToString();
                string povezava = "server=62.84.225.41;user=jan;database=vzreja_psov;port=3306;password=jan123;CharSet=utf8;";
                MySqlConnection conn = new MySqlConnection(povezava);
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT dodaj_pasmo('" + ime_tb.Text + "','" + doba_tb.Text + "','" + velikostM_tb.Text + "','" + velikostZ_tb.Text + "');", conn);

                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        if (rdr.GetInt16(0) == 1)
                        {
                            MessageBox.Show("Uspešno ste dodali pasmo.");
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
                MessageBox.Show("Vnesite ime pasme.");
            }
        }
    }
}
