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
    public partial class novo_geslo : Form
    {
        public novo_geslo()
        {
            InitializeComponent();
        }

        private void preklici_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zamenjaj_btn_Click(object sender, EventArgs e)
        {
            if (stgeslo_tb.Text != "" && nvgeslo_tb.Text != "")
            {
                string povezava = "server=62.84.225.41;user=jan;database=vzreja_psov;port=3306;password=jan123;CharSet=utf8;";
                MySqlConnection conn = new MySqlConnection(povezava);
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT menjava_gesla('" + stgeslo_tb.Text + "','" + nvgeslo_tb.Text + "');", conn);

                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        if (rdr.GetInt16(0) == 1)
                        {
                            MessageBox.Show("Uspešna menjava gesla.");                            
                            this.Close();
                        }
                        else if (rdr.GetInt16(0) == 0)
                        {
                            MessageBox.Show("Niste vensli pravega gesla.");
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
                MessageBox.Show("Vnesite staro in novo geslo.");
            }
            stgeslo_tb.Text = "";
            nvgeslo_tb.Text = "";
        }
    }
}
