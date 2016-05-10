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
    public partial class meni : Form
    {
        public meni()
        {
            InitializeComponent();
        }

        private void odjaviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 novoOkno = new Form1();
            novoOkno.Show();
            this.Hide();
        }

        private void meni_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void zamenjajGesloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novo_geslo novoOkno = new novo_geslo();
            novoOkno.Show();            
        }

        private void meni_Load(object sender, EventArgs e)
        {
            string povezava = "server=62.84.225.41;user=jan;database=vzreja_psov;port=3306;password=jan123;CharSet=utf8;";
            MySqlConnection conn = new MySqlConnection(povezava);
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(id) FROM psi;", conn);

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    st_psov_progBar.Value = rdr.GetInt16(0);
                    procenti_label.Text = rdr.GetInt16(0).ToString();
                }
               
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();        
   
            st_psov_progBar.Visible = true;
            st_psov_progBar.Minimum = 0;
            st_psov_progBar.Maximum = 50;
                      
        }

        private void vnospsa_btn_Click(object sender, EventArgs e)
        {
            vnos_psa novoOkno = new vnos_psa();
            novoOkno.Show();
            this.Hide();
        }

        private void vnospasme_btn_Click(object sender, EventArgs e)
        {
            vnos_pasme novoOkno = new vnos_pasme();
            novoOkno.Show();
            this.Hide();
        }

        private void nakuppsa_btn_Click(object sender, EventArgs e)
        {
            nakup_psa novoOkno = new nakup_psa();
            novoOkno.Show();
            this.Hide();
        }
    }
}
