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
    public partial class loginScreen : Form
    {
        static string constring = ("Data Source=BEYZAYOLDAS;Initial Catalog = TakvimUygulamasi; Integrated Security = True");
        SqlConnection connect = new SqlConnection(constring);
        public loginScreen()
        {
            InitializeComponent();
        }

        private void onlyLetter(object sender, KeyPressEventArgs e)     //Sadece harf girilir
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void onlyNumber(object sender, KeyPressEventArgs e)     //Sadece rakam girilir.
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void cmbUserType_TextChanged(object sender, EventArgs e) //Admin seçeneği sorulama
        {
            if (cmbUserType.Text == "Admin")
            {
                lblSignAdminPassword.Visible = true;
                txtSignAdminPassword.Visible = true;
            }
            else
            {
                lblSignAdminPassword.Visible = false;
                txtSignAdminPassword.Visible = false;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e) //Kayıt etme 
        {
            //Boş alan kontrolü
            if (
                String.IsNullOrEmpty(txtSignAddress.Text) || String.IsNullOrEmpty(txtSignEmail.Text) ||
                String.IsNullOrEmpty(txtSignPassword.Text) || String.IsNullOrEmpty(txtSignGSM.Text) ||
                String.IsNullOrEmpty(txtSignSurname.Text) || String.IsNullOrEmpty(txtSignIdNo.Text) ||
                String.IsNullOrEmpty(txtSignUserName.Text) || String.IsNullOrEmpty(txtSignName.Text) ||
                String.IsNullOrEmpty(cmbUserType.Text)
                )
            {
                MessageBox.Show("Boş Geçilemez");
            }
            else
            {
                try        
                {
                    int dataController = 0; // Kullanıcı var mı yok mu kontrolü
                    if (connect.State == ConnectionState.Closed)
                    {
                        connect.Open();
                        //Veri Çekme
                        string queryString = "SELECT userName,IdNo,Email,GSM FROM Users"; //Veri tabanından kullanıcı adı,password,email,gsm çekme
                        SqlCommand commandR = new SqlCommand(queryString, connect);
                        SqlDataReader reader = commandR.ExecuteReader();
                        
                        while (reader.Read())
                        {
                            if (
                                txtSignUserName.Text == reader["userName"].ToString() || txtSignIdNo.Text == reader["IdNo"].ToString() ||
                                txtSignEmail.Text == reader["Email"].ToString() || txtSignGSM.Text == reader["GSM"].ToString()
                               )
                            {
                                dataController = 1;
                                MessageBox.Show("Kullanıcı Kayıtlı!!! Şunlardan birini değiştirin [Kullanıcı adı,T.C Kimlik,Email,Telefon]");
                            }
                        }
                        reader.Close();
                        if (dataController == 0)
                        {
                            //Veri Gönderme
                            string execute = "INSERT INTO Users(name,surname,userName,password,IdNo,GSM,Address,AdminType,Email) " +
                                             "VALUES (@name,@surname,@userName,@password,@IdNo,@GSM,@Address,@AdminType,@Email)";
                            SqlCommand command = new SqlCommand(execute, connect);
                            //Verileri Aktarma
                            command.Parameters.AddWithValue("@name", txtSignName.Text);
                            command.Parameters.AddWithValue("@surname", txtSignSurname.Text);
                            command.Parameters.AddWithValue("@userName", txtSignUserName.Text);
                            command.Parameters.AddWithValue("@password", txtSignPassword.Text);
                            command.Parameters.AddWithValue("@IdNo", txtSignIdNo.Text);
                            command.Parameters.AddWithValue("@GSM", txtSignGSM.Text);
                            command.Parameters.AddWithValue("@Address", txtSignAddress.Text);
                            command.Parameters.AddWithValue("@Email", txtSignEmail.Text);
                            //Admin olup olmaması kontrolü
                            if (txtSignAdminPassword.Visible == false)
                            {
                                command.Parameters.AddWithValue("@AdminType", "0");
                                command.ExecuteNonQuery();
                                MessageBox.Show("Kayıt Başarılı");
                                connect.Close();
                            }
                            else
                            {
                                if (txtSignAdminPassword.Text == "12345")
                                {
                                    command.Parameters.AddWithValue("@AdminType", "1");
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Kayıt Başarılı");
                                    connect.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Hatalı Şifre!!!");
                                }
                            }
                        }
                        else
                        {
                            connect.Close();
                        }
                    }
                }
                catch (Exception ea)
                {
                    MessageBox.Show("Hata!!!" + ea.Message);
                    connect.Close();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e) //Giriş yapma
        {
            int loginCheck = 0; //Giriş kontrol
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                    string queryString = "SELECT userName,password FROM Users"; //Veri tabanından kullanıcı adı ve password çekme
                    SqlCommand command = new SqlCommand(queryString, connect);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {   //Veri tabanındaki ile Karşılaştırma
                        if (txtLoginUserName.Text == reader["userName"].ToString() && txtLoginPassword.Text == reader["password"].ToString())
                        {
                            MessageBox.Show("Giriş Başarılı!!!");
                            //İkinci form burada açılacak
                            CalendarScreen f2 = new CalendarScreen();
                            f2.Hide();
                            f2.Show();
                            loginCheck = 0;
                            break;
                        }
                        else
                        {
                            loginCheck = 1; //Başarısız girişi belirtme
                        }
                    }
                    if (loginCheck == 1)
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı!!!");
                    }
                    reader.Close();
                    connect.Close();
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show("Hata!!!" + ea.Message);
            }
        }

        private void loginScreen_Load(object sender, EventArgs e)
        {

        }

        private void tabLoginPage_Click(object sender, EventArgs e)
        {

        }
    }
}