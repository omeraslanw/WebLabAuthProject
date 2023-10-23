using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WebLabAuthProject
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        SqlConn connect = new SqlConn();
        public string kullanici;

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            lblKullaniciAdi.Text = kullanici;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblKullaniciAdi.Text = "Null";
            this.Close();
            FrmGiris frm = new FrmGiris();
            frm.Show();
        }
    }
}
