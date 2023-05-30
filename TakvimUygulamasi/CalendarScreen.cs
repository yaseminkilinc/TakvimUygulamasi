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
        static string constring = ("Data Source=DESKTOP-1LFMM0Q\\SQLEXPRESS;Initial Catalog=TakvimUygulamasi;Integrated Security=True");
        public string ActiveTime;
        public string FinishTime;
        public string ReminderTime;
        public bool Alarm;
        public CalendarScreen()
        {
            InitializeComponent();
        }
        int clockDif = 0;

        private void EnableChange()
        {
            time09.Enabled = true;
            time10.Enabled = true;
            time11.Enabled = true;
            time13.Enabled = true;
            time14.Enabled = true;
            time15.Enabled = true;
            time16.Enabled = true;
            time17.Enabled = true;
            time18.Enabled = true;
        }

        private void EnableChange2()
        {
            time1030.Enabled = true;
            time1130.Enabled = true;
            time1330.Enabled = true;
            time1430.Enabled = true;
            time1530.Enabled = true;
            time1630.Enabled = true;
            time1730.Enabled = true;
            time1830.Enabled = true;
            time1930.Enabled = true;
        }

        private void EnableChange3()
        {
            time0830_.Enabled = true;
            time0930_.Enabled = true;
            time1030_.Enabled = true;
            time1230_.Enabled = true;
            time1330_.Enabled = true;
            time1430_.Enabled = true;
            time1530_.Enabled = true;
            time1630_.Enabled = true;
            time1730_.Enabled = true;
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
            time1930.BackColor = Color.White;
        }

        private void ColorChange3()
        {
            time0830_.BackColor = Color.White;
            time0930_.BackColor = Color.White;
            time1030_.BackColor = Color.White;
            time1230_.BackColor = Color.White;
            time1330_.BackColor = Color.White;
            time1430_.BackColor = Color.White;
            time1530_.BackColor = Color.White;
            time1630_.BackColor = Color.White;
            time1730_.BackColor = Color.White;
        }

        //Başlangıç zamanı belirleme
        private void time09_Click(object sender, EventArgs e)
        {
            EnableChange();
            if (time09.BackColor == Color.Chartreuse)
            {
                time09.BackColor = Color.White;
                clockDif = 0;
                ActiveTime = null;
                islemZamani.Enabled = true;
                return;
            }
            ColorChange();
            ColorChange2();
            ColorChange3();
            time09.BackColor = Color.Chartreuse;
            ActiveTime = "09:00";
            clockDif = 1;
            islemZamani.Enabled = false;
        }

        //Başlangıç zamanı belirleme
        private void time10_Click(object sender, EventArgs e)
        {
            EnableChange();
            if (time10.BackColor == Color.Chartreuse)
            {
                time10.BackColor = Color.White;
                clockDif = 0;
                ActiveTime = null;
                islemZamani.Enabled = true;
                return;
            }
            ColorChange();
            ColorChange2();
            ColorChange3();
            time10.BackColor = Color.Chartreuse;
            ActiveTime = "10:00";
            clockDif = 2;
            islemZamani.Enabled = false;

        }

        //Başlangıç zamanı belirleme
        private void time11_Click(object sender, EventArgs e)
        {
            EnableChange();
            if (time11.BackColor == Color.Chartreuse)
            {
                time11.BackColor = Color.White;
                clockDif = 0;
                ActiveTime = null;
                islemZamani.Enabled = true;
                return;
            }
            ColorChange();
            ColorChange2();
            ColorChange3();
            time11.BackColor = Color.Chartreuse;
            ActiveTime = "11:00";
            clockDif = 3;
            islemZamani.Enabled = false;
        }

        //Başlangıç zamanı belirleme
        private void time13_Click(object sender, EventArgs e)
        {
            EnableChange();
            if (time13.BackColor == Color.Chartreuse)
            {
                time13.BackColor = Color.White;
                clockDif = 0;
                ActiveTime = null;
                islemZamani.Enabled = true;
                return;
            }
            ColorChange();
            ColorChange2();
            ColorChange3();
            time13.BackColor = Color.Chartreuse;
            ActiveTime = "13:00";
            clockDif = 4;
            islemZamani.Enabled = false;
        }

        //Başlangıç zamanı belirleme
        private void time14_Click(object sender, EventArgs e)
        {
            EnableChange();
            if (time14.BackColor == Color.Chartreuse)
            {
                time14.BackColor = Color.White;
                clockDif = 0;
                ActiveTime = null;
                islemZamani.Enabled = true;
                return;
            }
            ColorChange();
            ColorChange2();
            ColorChange3();
            time14.BackColor = Color.Chartreuse;
            ActiveTime = "14:00";
            clockDif = 5;
            islemZamani.Enabled = false;
        }

        //Başlangıç zamanı belirleme
        private void time15_Click(object sender, EventArgs e)
        {
            EnableChange();
            if (time15.BackColor == Color.Chartreuse)
            {
                time15.BackColor = Color.White;
                clockDif = 0;
                ActiveTime = null;
                islemZamani.Enabled = true;
                return;
            }
            ColorChange();
            ColorChange2();
            ColorChange3();
            time15.BackColor = Color.Chartreuse;
            ActiveTime = "15:00";
            clockDif = 6;
            islemZamani.Enabled = false;
        }

        //Başlangıç zamanı belirleme
        private void time16_Click(object sender, EventArgs e)
        {
            EnableChange();
            if (time16.BackColor == Color.Chartreuse)
            {
                time16.BackColor = Color.White;
                clockDif = 0;
                ActiveTime = null;
                islemZamani.Enabled = true;
                return;
            }
            ColorChange();
            ColorChange2();
            ColorChange3();
            time16.BackColor = Color.Chartreuse;
            ActiveTime = "16:00";
            clockDif = 7;
            islemZamani.Enabled = false;
        }

        //Başlangıç zamanı belirleme
        private void time17_Click(object sender, EventArgs e)
        {
            EnableChange();
            if (time17.BackColor == Color.Chartreuse)
            {
                time17.BackColor = Color.White;
                clockDif = 0;
                ActiveTime = null;
                islemZamani.Enabled = true;
                return;
            }
            ColorChange();
            ColorChange2();
            ColorChange3();
            time17.BackColor = Color.Chartreuse;
            ActiveTime = "17:00";
            clockDif = 8;
            islemZamani.Enabled = false;
        }

        //Başlangıç zamanı belirleme
        private void time18_Click(object sender, EventArgs e)
        {
            EnableChange();
            if (time18.BackColor == Color.Chartreuse)
            {
                time18.BackColor = Color.White;
                clockDif = 0;
                ActiveTime = null;
                islemZamani.Enabled = true;
                return;
            }
            ColorChange();
            ColorChange2();
            ColorChange3();
            time18.BackColor = Color.Chartreuse;
            ActiveTime = "18:00";
            clockDif = 9;
            islemZamani.Enabled = false;
        }

        //Bitiş zamanı belirleme
        private void time1030_Click(object sender, EventArgs e)
        {
            EnableChange2();
            if (clockDif > 2)
            {
                MessageBox.Show("Geçersiz Zaman Dilimi!!!");
                return;
            }
            ColorChange2();
            time1030.BackColor = Color.IndianRed;
            FinishTime = "10:30";
        }

        //Bitiş zamanı belirleme
        private void time1130_Click(object sender, EventArgs e)
        {
            EnableChange2();
            if (clockDif > 3)
            {
                MessageBox.Show("Geçersiz Zaman Dilimi!!!");
                return;
            }
            ColorChange2();
            time1130.BackColor = Color.IndianRed;
            FinishTime = "11:30";
        }

        //Bitiş zamanı belirleme
        private void time1330_Click(object sender, EventArgs e)
        {
            EnableChange2();
            if (clockDif > 4)
            {
                MessageBox.Show("Geçersiz Zaman Dilimi!!!");
                return;
            }
            ColorChange2();
            time1330.BackColor = Color.IndianRed;
            FinishTime = "13:30";
        }

        //Bitiş zamanı belirleme
        private void time1430_Click(object sender, EventArgs e)
        {
            EnableChange2();
            if (clockDif > 5)
            {
                MessageBox.Show("Geçersiz Zaman Dilimi!!!");
                return;
            }
            ColorChange2();
            time1430.BackColor = Color.IndianRed;
            FinishTime = "14:30";
        }

        //Bitiş zamanı belirleme
        private void time1530_Click(object sender, EventArgs e)
        {
            EnableChange2();
            if (clockDif > 6)
            {
                MessageBox.Show("Geçersiz Zaman Dilimi!!!");
                return;
            }
            ColorChange2();
            time1530.BackColor = Color.IndianRed;
            FinishTime = "15:30";
        }

        //Bitiş zamanı belirleme
        private void time1630_Click(object sender, EventArgs e)
        {
            EnableChange2();
            if (clockDif > 7)
            {
                MessageBox.Show("Geçersiz Zaman Dilimi!!!");
                return;
            }
            ColorChange2();
            time1630.BackColor = Color.IndianRed;
            FinishTime = "16:30";
        }

        //Bitiş zamanı belirleme
        private void time1730_Click(object sender, EventArgs e)
        {
            EnableChange2();
            if (clockDif > 8)
            {
                MessageBox.Show("Geçersiz Zaman Dilimi!!!");
                return;
            }
            ColorChange2();
            time1730.BackColor = Color.IndianRed;
            FinishTime = "17:30";
        }

        //Bitiş zamanı belirleme
        private void time1830_Click(object sender, EventArgs e)
        {
            EnableChange2();
            if (clockDif > 9)
            {
                MessageBox.Show("Geçersiz Zaman Dilimi!!!");
                return;
            }
            ColorChange2();
            time1830.BackColor = Color.IndianRed;
            FinishTime = "18:30";
        }

        //Bitiş zamanı belirleme
        private void time1930_Click(object sender, EventArgs e)
        {
            EnableChange2();
            if (clockDif > 10)
            {
                MessageBox.Show("Geçersiz Zaman Dilimi!!!");
                return;
            }
            ColorChange2();
            time1930.BackColor = Color.IndianRed;
            FinishTime = "19:30";
        }

        //Hatırlatma görünürlüğü
        private void chkHatirlatma_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHatirlatma.Checked)
            {
                ColorChange3();
                hatirlatma1.Visible = true;
                time0830_.Visible = true;
                time0930_.Visible = true;
                time1030_.Visible = true;
                time1230_.Visible = true;
                time1330_.Visible = true;
                time1430_.Visible = true;
                time1530_.Visible = true;
                time1630_.Visible = true;
                time1730_.Visible = true;
            }
            else
            {
                hatirlatma1.Visible = false;
                time0830_.Visible = false;
                time0930_.Visible = false;
                time1030_.Visible = false;
                time1230_.Visible = false;
                time1330_.Visible = false;
                time1430_.Visible = false;
                time1530_.Visible = false;
                time1630_.Visible = false;
                time1730_.Visible = false;
                ReminderTime = "-";
            }
        }

        //Hatırlatma zamanı belirleme
        private void time0830__Click(object sender, EventArgs e)
        {
            EnableChange3();
            if (clockDif < 1)
            {
                MessageBox.Show("Geçersiz Zaman Dilimi!!!");
                return;
            }
            ColorChange3();
            time0830_.BackColor = Color.Turquoise;
            ReminderTime = "08:30";
        }

        //Hatırlatma zamanı belirleme
        private void time0930__Click(object sender, EventArgs e)
        {
            EnableChange3();
            if (clockDif < 2)
            {
                MessageBox.Show("Geçersiz Zaman Dilimi!!!");
                return;
            }
            ColorChange3();
            time0930_.BackColor = Color.Turquoise;
            ReminderTime = "09:30";
        }

        //Hatırlatma zamanı belirleme
        private void time1030__Click(object sender, EventArgs e)
        {
            EnableChange3();
            if (clockDif < 3)
            {
                MessageBox.Show("Geçersiz Zaman Dilimi!!!");
                return;
            }
            ColorChange3();
            time1030_.BackColor = Color.Turquoise;
            ReminderTime = "10:30";
        }

        //Hatırlatma zamanı belirleme
        private void time1230__Click(object sender, EventArgs e)
        {
            EnableChange3();
            if (clockDif < 4)
            {
                MessageBox.Show("Geçersiz Zaman Dilimi!!!");
                return;
            }
            ColorChange3();
            time1230_.BackColor = Color.Turquoise;
            ReminderTime = "12:30";
        }

        //Hatırlatma zamanı belirleme
        private void time1330__Click(object sender, EventArgs e)
        {
            EnableChange3();
            if (clockDif < 5)
            {
                MessageBox.Show("Geçersiz Zaman Dilimi!!!");
                return;
            }
            ColorChange3();
            time1330_.BackColor = Color.Turquoise;
            ReminderTime = "13:30";
        }

        //Hatırlatma zamanı belirleme
        private void time1430__Click(object sender, EventArgs e)
        {
            EnableChange3();
            if (clockDif < 6)
            {
                MessageBox.Show("Geçersiz Zaman Dilimi!!!");
                return;
            }
            ColorChange3();
            time1430_.BackColor = Color.Turquoise;
            ReminderTime = "14:30";
        }

        //Hatırlatma zamanı belirleme
        private void time1530__Click(object sender, EventArgs e)
        {
            EnableChange3();
            if (clockDif < 7)
            {
                MessageBox.Show("Geçersiz Zaman Dilimi!!!");
                return;
            }
            ColorChange3();
            time1530_.BackColor = Color.Turquoise;
            ReminderTime = "15:30";
        }

        //Hatırlatma zamanı belirleme
        private void time1630__Click(object sender, EventArgs e)
        {
            EnableChange3();
            if (clockDif < 8)
            {
                MessageBox.Show("Geçersiz Zaman Dilimi!!!");
                return;
            }
            ColorChange3();
            time1630_.BackColor = Color.Turquoise;
            ReminderTime = "16:30";
        }

        //Hatırlatma zamanı belirleme
        private void time1730__Click(object sender, EventArgs e)
        {
            EnableChange3();
            if (clockDif < 9)
            {
                MessageBox.Show("Geçersiz Zaman Dilimi!!!");
                return;
            }
            ColorChange3();
            time1730_.BackColor = Color.Turquoise;
            ReminderTime = "17:30";
        }

        //Alarm
        private void chkAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlarm.Checked)
            {
                Alarm = true;
            }
            else
            {
                Alarm = false;
            }
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
                if(islemZamani.Value < DateTime.Today){
                    throw new Exception("Geçmiş zaman dilimi.");
                }
                SqlConnection connect = new SqlConnection(constring);
                connect.Open();
                if (connect.State == System.Data.ConnectionState.Open)
                {
                    string query = "INSERT INTO takvimPlanlama(dTarih,olayTipi,baslangicZamani,bitisZamani,hatirlatmaZamani,olayAciklamasi,alarm) VALUES(@tarih,@olayTipi,@baslangicZamani,@bitisZamani,@hatirlatmaZamani,@aciklama,@alarm)";

                    SqlCommand cmnd1 = new SqlCommand();
                    //Verileri Aktarma
                    cmnd1.CommandText = query;
                    cmnd1.Connection = connect;
                    cmnd1.Parameters.AddWithValue("@tarih", islemZamani.Value);
                    cmnd1.Parameters.AddWithValue("@baslangicZamani", ActiveTime);
                    cmnd1.Parameters.AddWithValue("@bitisZamani", FinishTime);
                    cmnd1.Parameters.AddWithValue("@hatirlatmaZamani", ReminderTime);
                    cmnd1.Parameters.AddWithValue("@olayTipi", olayinTipi.SelectedItem);
                    cmnd1.Parameters.AddWithValue("@aciklama", aciklama.Text);
                    cmnd1.Parameters.AddWithValue("@alarm", Alarm);
                    cmnd1.ExecuteNonQuery();
                    MessageBox.Show("Kaydedildi!");
                    //Üçüncü form burada açılacak
                    ScreenActivity f3 = new ScreenActivity();
                    f3.Hide();
                    f3.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
