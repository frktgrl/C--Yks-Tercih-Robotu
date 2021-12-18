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


namespace YksTercihRobotu4
{
    public partial class girisekrani : Form
    {

        SqlDataReader dr;

        public girisekrani()
        {
            InitializeComponent();
        }

        static string constring = "Data Source=DESKTOP-NU510C0;Initial Catalog=Ogrenciler;Integrated Security=True";

        SqlConnection connect = new SqlConnection(constring);


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kayit_ol_Click(object sender, EventArgs e)

        {
        
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string kayit = "insert into ogrencikayit(kullaniciadi,sifre)values(@kullaniciadi,@sifre)";
                SqlCommand komut = new SqlCommand(kayit, connect);
                komut.Parameters.AddWithValue("@kullaniciadi",txt_kad.Text);
                komut.Parameters.AddWithValue("@sifre",txt_sifre.Text);

                komut.ExecuteNonQuery();
                
                MessageBox.Show("Kayıt Tamamlandı.");
                


            }
            catch(Exception hata)
            {
                MessageBox.Show("hata meydana geldi"+hata.Message);
                
            }

            


        }

        private void giris_yap_Click(object sender, EventArgs e)
        {

            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string user = txt_kad.Text;
                string password = txt_sifre.Text;
                SqlCommand komut = connect.CreateCommand();

                komut.CommandText = "select *from ogrencikayit where kullaniciadi='" + txt_kad.Text + "' and sifre='" + txt_sifre.Text + "'";

                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Giriş Yapıldı.");
                    tercihekrani gecis = new tercihekrani();
                    gecis.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Hatalı Şifre veya Kullanıcı Adı");
             
                }
                connect.Close();
                


            }
            catch (Exception hata)
            {
                MessageBox.Show("hata meydana geldi" + hata.Message);
            }


        }

    }
}
