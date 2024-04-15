using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormSarkiEkle : Form
    {
        string baglanti = "Server=localhost;Database=muzik;Uid=root;Pwd= ;";
        public FormSarkiEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using(MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu= "INSERT INTO sarkilar VALUES(NULL,@sarkiAd,@sanatciAd,@yil,@tur,@sure,@tarih,@favori);";
                MySqlCommand cmd = new MySqlCommand(sorgu,baglan);
                cmd.Parameters.AddWithValue("@sarkiAd", txtSarkiAdi.Text);
                cmd.Parameters.AddWithValue("@sanatciAd", txtSanatci.Text);
                cmd.Parameters.AddWithValue("@yil", txtYil.Text);
                cmd.Parameters.AddWithValue("@tur", cmbTur.Text);
                cmd.Parameters.AddWithValue("@sure", txtSure.Text);
                cmd.Parameters.AddWithValue("@tarih", dtTarih.Text);
                cmd.Parameters.AddWithValue("@favori", cbFovari.Checked);

                //sorguyu çalıştırma komutu kayıt eklenırse satır sayısı döner
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("kayıt eklendi");
                    this.Close();
                }
                


            }
        }
    }
}
