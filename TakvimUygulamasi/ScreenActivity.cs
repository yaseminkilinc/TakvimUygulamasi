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

namespace TakvimUygulamasi
{
    public partial class ScreenActivity : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;



        public ScreenActivity()
        {
            InitializeComponent();
        }


        void ToplantiGetir()
        {
            baglanti = new SqlConnection("Data Source=BEYZAYOLDAS;Initial Catalog = TakvimUygulamasi; Integrated Security = True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM takvimPlanlama", baglanti);
            DataTable tablo= new DataTable();
            da .Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        //toplantıları sil ekle güncelle işleminden sonra yeni haliyle getirmek için metot oluşturduk.
        private void ScreenActivity_Load(object sender, EventArgs e)
        {
            ToplantiGetir();
        }

        //veritabanındaki verilerin gösterilmesi
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtOlayAciklamasi.Text=dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtOlayTipi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtOlayBaslangicZamani.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtOlayBitisZamani.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        // ekle butonuyla kullanıcı toplantı ekleyebilecektir
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO takvimPlanlama(dTarih,olayTipi,baslangicZamani,bitisZamani,olayAciklamasi) VALUES (@dTarih,@olayTipi,@baslangicZamani,@bitisZamani,@olayAciklamasi)";
            komut = new SqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@dTarih", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@olayTipi", txtOlayTipi.Text);
            komut.Parameters.AddWithValue("@baslangicZamani", txtOlayBaslangicZamani.Text);
            komut.Parameters.AddWithValue("@bitisZamani", txtOlayBitisZamani.Text);
            komut.Parameters.AddWithValue("@olayAciklamasi", txtOlayAciklamasi.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ToplantiGetir();
        }

        //sil butonuyla kullanıcı istediği toplantıyı/olayı silebilecektir.

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM takvimPlanlama WHERE ID=@ID";
            komut = new SqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ToplantiGetir();
        }

        //güncelle butonuyla kullanıcı istediği bir toplantıyı/olayı güncelleyebilecektir.
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE takvimPlanlama SET dTarih=@dTarih,olayTipi=@olayTipi,baslangicZamani=@baslangicZamani,bitisZamani=@bitisZamani,olayAciklamasi=@olayAciklamasi WHERE ID=@ID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            komut.Parameters.AddWithValue("@dTarih",dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@olayTipi",txtOlayTipi.Text);
            komut.Parameters.AddWithValue("@baslangicZamani", txtOlayBaslangicZamani.Text);
            komut.Parameters.AddWithValue("@bitisZamani", txtOlayBitisZamani.Text);
            komut.Parameters.AddWithValue("@olayAciklamasi", txtOlayAciklamasi.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            ToplantiGetir();
        }
    }
}
