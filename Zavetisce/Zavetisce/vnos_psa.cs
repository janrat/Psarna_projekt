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
    public partial class vnos_psa : Form
    {
        public vnos_psa()
        {
            InitializeComponent();
        }

        private void nazaj_btn_Click(object sender, EventArgs e)
        {
            meni novoOkno = new meni();
            novoOkno.Show();
            this.Hide();
        }

        private void vnos_psa_Load(object sender, EventArgs e)
        {
            string povezava = "server=62.84.225.41;user=jan;database=vzreja_psov;port=3306;password=jan123;CharSet=utf8;";
            MySqlConnection conn = new MySqlConnection(povezava);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("vse_pasme", conn);
                cmd.CommandType = CommandType.StoredProcedure;               

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    pasma_cb.Items.Add(rdr.GetString("ime"));                   

                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }

        private void vnos_psa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dodaj_btn_Click(object sender, EventArgs e)
        {
            if (pasma_cb.Text != "Izberi pasmo")
            {
                //string datum_rojstva = datum_roj.ToString();
                string povezava = "server=62.84.225.41;user=jan;database=vzreja_psov;port=3306;password=jan123;CharSet=utf8;";
                MySqlConnection conn = new MySqlConnection(povezava);
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT dodaj_psa('" + pasma_cb.SelectedItem + "','" + ime_tb.Text + "','" + datum_roj.Text + "','" + vzdevek_tb.Text + "','" + cena_tb.Text + "');", conn);

                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        if (rdr.GetInt16(0) == 1)
                        {
                            MessageBox.Show("Uspešno ste dodali psa.");
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
                MessageBox.Show("Iberite pasmo.");
            }


        }
    }
}
