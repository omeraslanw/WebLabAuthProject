using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebLabAuthProject
{
    public partial class FrmKaydol : Form
    {
        public FrmKaydol()
        {
            InitializeComponent();
        }

        SqlConn connect = new SqlConn();

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSifre.Text != txtSifre2.Text)
                {
                    MessageBox.Show("Girdiğiniz şifreler aynı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtAd.Text == "" || txtSifre.Text == "" || txtSifre2.Text == "")
                {
                    MessageBox.Show("Boş değerler giremezsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into Kullanicilar (ad,sifre) values (@p1,@p2)", connect.connection());
                    cmd.Parameters.AddWithValue("@p1", txtAd.Text);
                    cmd.Parameters.AddWithValue("@p2", txtSifre.Text);
                    cmd.ExecuteNonQuery();
                    connect.connection().Close();
                    MessageBox.Show("Kullanıcı kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connect.connection().Close();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Girdiğiniz değerler 20 karakterden fazla olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
