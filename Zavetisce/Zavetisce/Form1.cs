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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uporabnisko_tb.Text = "Uporabniško ime";
            geslo_tb.Text = "Geslo";
        }

        private void prijava_btn_Click(object sender, EventArgs e)
        {
            if(uporabnisko_tb.Text != "Uporabniško ime" && geslo_tb.Text != "Geslo")
            {
                string povezava = "server=62.84.225.41;user=jan;database=vzreja_psov;port=3306;password=jan123;CharSet=utf8;";
                MySqlConnection conn = new MySqlConnection(povezava);
                try
                {                    
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT prijava('" + uporabnisko_tb.Text + "','" + geslo_tb.Text + "');", conn);

                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        if (rdr.GetInt16(0) == 1)
                        {
                            meni novoOkno = new meni();
                            novoOkno.Show();
                            this.Hide();
                            //MessageBox.Show("Prijava uspešna");
                        }
                        else if (rdr.GetInt16(0) == 0)
                        {
                            MessageBox.Show("Uporabnik ne obstaja");
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
                MessageBox.Show("Vnesite uporabniško ime in geslo.");
            }
            

        }

        private void uporabnisko_tb_Enter(object sender, EventArgs e)
        {
            if (uporabnisko_tb.Text == "Uporabniško ime")
            {
                uporabnisko_tb.Text = "";
            }
        }

        private void uporabnisko_tb_Leave(object sender, EventArgs e)
        {
            if (uporabnisko_tb.Text == "")
            {
                uporabnisko_tb.Text = "Uporabniško ime";
            }
        }

        private void geslo_tb_Enter(object sender, EventArgs e)
        {
            if (geslo_tb.Text == "Geslo")
            {
                geslo_tb.Text = "";
                geslo_tb.UseSystemPasswordChar = true;
                geslo_tb.PasswordChar = '•'; 
            }
        }

        private void geslo_tb_Leave(object sender, EventArgs e)
        {
            if (geslo_tb.Text == "")
            {
                geslo_tb.UseSystemPasswordChar = false;
                geslo_tb.PasswordChar = '\0';
                geslo_tb.Text = "Geslo";
                
                
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
