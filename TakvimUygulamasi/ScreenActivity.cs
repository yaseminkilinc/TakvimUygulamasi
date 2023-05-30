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
using System.Media;

namespace TakvimUygulamasi
{
    public partial class ScreenActivity : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1LFMM0Q\\SQLEXPRESS;Initial Catalog=TakvimUygulamasi;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;

        public ScreenActivity()
        {
            InitializeComponent();
        }

        void ToplantiGetir()
        {
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM takvimPlanlama", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        //toplantıları sil ekle güncelle işleminden sonra yeni haliyle getirmek için metot oluşturduk.
        private void ScreenActivity_Load(object sender, EventArgs e)
        {
            ToplantiGetir();
            tmrAlarm.Start();
        }

        //veritabanındaki verilerin gösterilmesi
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtOlayAciklamasi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtOlayBaslangicZamani.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtOlayBitisZamani.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtOlayHatirlatmaZamani.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmbOlayTipi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        // ekle butonuyla kullanıcı toplantı ekleyebilecektir
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO takvimPlanlama(dTarih,olayTipi,baslangicZamani,bitisZamani,hatirlatmaZamani,olayAciklamasi,alarm) VALUES(@dTarih,@olayTipi,@baslangicZamani,@bitisZamani,@hatirlatmaZamani,@olayAciklamasi,@alarm)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@dTarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@olayTipi", cmbOlayTipi.SelectedItem);
            komut.Parameters.AddWithValue("@baslangicZamani", txtOlayBaslangicZamani.Text);
            komut.Parameters.AddWithValue("@bitisZamani", txtOlayBitisZamani.Text);
            komut.Parameters.AddWithValue("@hatirlatmaZamani", txtOlayHatirlatmaZamani.Text);
            komut.Parameters.AddWithValue("@olayAciklamasi", txtOlayAciklamasi.Text);
            komut.Parameters.AddWithValue("@alarm", chkAlarm.Checked);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ToplantiGetir();
        }

        //sil butonuyla kullanıcı istediği toplantıyı/olayı silebilecektir.
        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM takvimPlanlama WHERE ID=@ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ToplantiGetir();
        }

        //güncelle butonuyla kullanıcı istediği bir toplantıyı/olayı güncelleyebilecektir.
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE takvimPlanlama SET dTarih=@dTarih,olayTipi=@olayTipi,baslangicZamani=@baslangicZamani,bitisZamani=@bitisZamani,hatirlatmaZamani=@hatirlatmaZamani,olayAciklamasi=@olayAciklamasi,alarm=@alarm WHERE ID=@ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            komut.Parameters.AddWithValue("@dTarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@olayTipi", cmbOlayTipi.SelectedItem);
            komut.Parameters.AddWithValue("@baslangicZamani", txtOlayBaslangicZamani.Text);
            komut.Parameters.AddWithValue("@bitisZamani", txtOlayBitisZamani.Text);
            komut.Parameters.AddWithValue("@hatirlatmaZamani", txtOlayHatirlatmaZamani.Text);
            komut.Parameters.AddWithValue("@olayAciklamasi", txtOlayAciklamasi.Text);
            komut.Parameters.AddWithValue("@alarm", chkAlarm.Checked);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ToplantiGetir();
        }

        //zamanı gelince uygulama kişiye tercihe göre sesli ya da sessiz uyarı gönderecektir
        private void tmrAlarm_Tick(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("SELECT alarm,dTarih,hatirlatmaZamani,baslangicZamani,olayAciklamasi FROM takvimPlanlama", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            SoundPlayer ses = new SoundPlayer();
            ses.SoundLocation = Application.StartupPath + "\\alarm.wav";

            while (dr.Read())
            {
                string acikMi = dr["alarm"].ToString();
                string olayAciklamasi = dr["olayAciklamasi"].ToString();
                string hatirlatmaZamani = dr["hatirlatmaZamani"].ToString();
                string baslangicZamani = dr["baslangicZamani"].ToString();
                string tarih = dr["dTarih"].ToString().Substring(0, 10);
                var olayTarihi = DateTime.Parse(tarih);

                if (acikMi == "True")
                {
                    if(olayTarihi == DateTime.Today && hatirlatmaZamani == DateTime.Now.TimeOfDay.ToString().Substring(0,5))
                    {
                        ses.Play();
                        MessageBox.Show(olayAciklamasi + " hatırlatması!!!");
                        ses.Stop();
                    }
                    else if (olayTarihi == DateTime.Today && baslangicZamani == DateTime.Now.TimeOfDay.ToString().Substring(0, 5))
                    {
                        ses.Play();
                        MessageBox.Show(olayAciklamasi + " başlangıcı!!!");
                        ses.Stop();
                    }
                }
                else if (acikMi == "False")
                {
                    if (olayTarihi == DateTime.Today && hatirlatmaZamani == DateTime.Now.TimeOfDay.ToString().Substring(0, 5))
                    {
                        MessageBox.Show(olayAciklamasi + " hatırlatması!!!");
                    }
                    else if (olayTarihi == DateTime.Today && baslangicZamani == DateTime.Now.TimeOfDay.ToString().Substring(0, 5))
                    {
                        MessageBox.Show(olayAciklamasi + " başlangıcı!!!");
                    }
                }
            }
            dr.Close();
            baglanti.Close();
        }
    }
}
