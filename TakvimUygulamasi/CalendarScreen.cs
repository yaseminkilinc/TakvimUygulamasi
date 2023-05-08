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


namespace TakvimUygulamasi
{
    public partial class CalendarScreen : Form
    {
        static string constring = ("Data Source=DESKTOP-JO113JK\\SQLEXPRESS;Initial Catalog=TakvimUygulamasi;Integrated Security=True");
        SqlConnection connect = new SqlConnection(constring);
        public string ActiveTime;
        public string FinishTime;
        public CalendarScreen()
        {
            InitializeComponent();
        }   

        private void EnableChange()
        {
            time09.Enabled = true;
            time10.Enabled = true;
            time11.Enabled = true;
            time15.Enabled = true;
            time14.Enabled = true;
            time13.Enabled = true;
            time18.Enabled = true;
            time17.Enabled = true;
            time16.Enabled = true;
        }

        private void EnableChange2()
        {
            time1130.Enabled = true;
            time1030.Enabled = true;
            time1330.Enabled = true;
            time1530.Enabled = true;
            time1430.Enabled = true;
            time1630.Enabled = true;
            time1730.Enabled = true;
            time1830.Enabled = true;
        }

        //Buton arka plan rengi
        private void ColorChange()
        {
            time09.BackColor = Color.White;
            time10.BackColor = Color.White;
            time11.BackColor = Color.White;
            time15.BackColor = Color.White;
            time14.BackColor = Color.White;
            time13.BackColor = Color.White;
            time18.BackColor = Color.White;
            time17.BackColor = Color.White;
            time16.BackColor = Color.White;
        }

        private void ColorChange2()
        {
            time1130.BackColor = Color.White;
            time1030.BackColor = Color.White;
            time1330.BackColor = Color.White;
            time1530.BackColor = Color.White;
            time1430.BackColor = Color.White;
            time1630.BackColor = Color.White;
            time1730.BackColor = Color.White;
            time1830.BackColor = Color.White;
        }


        private void CalendarScreen_Load(object sender, EventArgs e)
        {
           
        }    

       
        //Başlangıç zamanı belirleme
        private void time09_Click(object sender, EventArgs e)
        {
            EnableChange();
            ColorChange();
            time09.BackColor = Color.Chartreuse;
            ActiveTime = "09.00";
        }

        //Başlangıç zamanı belirleme
        private void time10_Click(object sender, EventArgs e)
        {
            EnableChange();
            ColorChange();
            time10.BackColor = Color.Chartreuse;
            ActiveTime = "10.00";

        }

        //Başlangıç zamanı belirleme
        private void time11_Click(object sender, EventArgs e)
        {
            EnableChange();
            ColorChange();
            time11.BackColor = Color.Chartreuse;
            ActiveTime = "11.00";
        }

        //Başlangıç zamanı belirleme
        private void islemZamani_ValueChanged(object sender, EventArgs e)
        {

        }

        //Başlangıç zamanı belirleme
        private void time13_Click(object sender, EventArgs e)
        {
            EnableChange();
            ColorChange();
            time13.BackColor = Color.Chartreuse;
            ActiveTime = "13.00";
        }

        //Başlangıç zamanı belirleme
        private void time14_Click(object sender, EventArgs e)
        {
            EnableChange();
            ColorChange();
            time14.BackColor = Color.Chartreuse;
            ActiveTime = "14.00";
        }

        //Başlangıç zamanı belirleme
        private void time15_Click(object sender, EventArgs e)
        {
            EnableChange();
            ColorChange();
            time15.BackColor = Color.Chartreuse;
            ActiveTime = "15.00";
        }

        //Başlangıç zamanı belirleme
        private void time16_Click(object sender, EventArgs e)
        {
            EnableChange();
            ColorChange();
            time16.BackColor = Color.Chartreuse;
            ActiveTime = "16.00";
        }

        //Başlangıç zamanı belirleme
        private void time17_Click(object sender, EventArgs e)
        {
            EnableChange();
            ColorChange();
            time17.BackColor = Color.Chartreuse;
            ActiveTime = "17.00";
        }

        //Başlangıç zamanı belirleme
        private void time18_Click(object sender, EventArgs e)
        {
            EnableChange();
            ColorChange();
            time18.BackColor = Color.Chartreuse;
            ActiveTime = "18.00";
        }

        //Bitiş zamanı belirleme
        private void time1030_Click(object sender, EventArgs e)
        {
            EnableChange2();
            ColorChange2();
            time1030.BackColor = Color.IndianRed;
            FinishTime = "10.30";
        }

        //Bitiş zamanı belirleme
        private void time1130_Click(object sender, EventArgs e)
        {
            EnableChange2();
            ColorChange2();
            time1130.BackColor = Color.IndianRed;
            FinishTime = "11.30";
        }

        //Bitiş zamanı belirleme
        private void time1330_Click(object sender, EventArgs e)
        {
            EnableChange2();
            ColorChange2();
            time1330.BackColor = Color.IndianRed;
            FinishTime = "13.30";
        }

        //Bitiş zamanı belirleme
        private void time1430_Click(object sender, EventArgs e)
        {
            EnableChange2();
            ColorChange2();
            time1430.BackColor = Color.IndianRed;
            FinishTime = "14.30";
        }

        //Bitiş zamanı belirleme
        private void time1530_Click(object sender, EventArgs e)
        {
            EnableChange2();
            ColorChange2();
            time1530.BackColor = Color.IndianRed;
            FinishTime = "15.30";
        }

        //Bitiş zamanı belirleme
        private void time1630_Click(object sender, EventArgs e)
        {
            EnableChange2();
            ColorChange2();
            time1630.BackColor = Color.IndianRed;
            FinishTime = "16.30";
        }

        //Bitiş zamanı belirleme
        private void time1730_Click(object sender, EventArgs e)
        {
            EnableChange2();
            ColorChange2();
            time1730.BackColor = Color.IndianRed;
            FinishTime = "17.30";
        }

        //Bitiş zamanı belirleme
        private void time1830_Click(object sender, EventArgs e)
        {
            EnableChange2();
            ColorChange2();
            time1830.BackColor = Color.IndianRed;
            FinishTime = "18.30";
        }

        private void save_Click(object sender, EventArgs e)
        {
            loginScreen ls = new loginScreen();
            //Sql bağlanma
            try
            {
                if (string.IsNullOrWhiteSpace(aciklama.Text))
                {
                    throw new Exception("Açıklama boş bırakılamaz.");
                }
                SqlConnection connect = new SqlConnection(constring);
                connect.Open();
                if (connect.State == System.Data.ConnectionState.Open)
                {
                    string query = "insert into takvimPlanlama(dTarih,olayTipi,baslangicZamani,bitisZamani,olayAciklamasi) values(@tarih,@olayTipi,@baslangicZamani,@bitisZamani,@aciklama)";

                    SqlCommand cmnd1 = new SqlCommand();
                    //Verileri Aktarma
                    cmnd1.CommandText = query;
                    cmnd1.Connection = connect;
                    cmnd1.Parameters.AddWithValue("@tarih", islemZamani.Value.ToShortDateString());
                    cmnd1.Parameters.AddWithValue("@baslangicZamani", ActiveTime);
                    cmnd1.Parameters.AddWithValue("@bitisZamani", FinishTime);
                    cmnd1.Parameters.AddWithValue("@olayTipi", olayinTipi.SelectedItem);
                    cmnd1.Parameters.AddWithValue("@aciklama", aciklama.Text);
                    cmnd1.ExecuteNonQuery();
                    MessageBox.Show("Kaydedildi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            {

            }
        }

        //Bitiş zamanı belirleme
        private void time1930_Click(object sender, EventArgs e)
        {
            EnableChange2();
            ColorChange2();
            time1730.BackColor = Color.IndianRed;
            FinishTime = "19.30";
        }
    }
}
