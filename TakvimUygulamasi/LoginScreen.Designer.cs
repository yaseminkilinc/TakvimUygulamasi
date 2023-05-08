
namespace TakvimUygulamasi
{
    partial class loginScreen
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginScreen));
            this.tabUserLoginPage = new System.Windows.Forms.TabControl();
            this.tabLoginPage = new System.Windows.Forms.TabPage();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.txtLoginUserName = new System.Windows.Forms.TextBox();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.lblLoginUserName = new System.Windows.Forms.Label();
            this.tabSignPage = new System.Windows.Forms.TabPage();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtSignAdminPassword = new System.Windows.Forms.TextBox();
            this.lblSignAdminPassword = new System.Windows.Forms.Label();
            this.lblSignUserType = new System.Windows.Forms.Label();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.txtSignAddress = new System.Windows.Forms.TextBox();
            this.lblSignAddress = new System.Windows.Forms.Label();
            this.txtSignEmail = new System.Windows.Forms.TextBox();
            this.lblSignEmail = new System.Windows.Forms.Label();
            this.txtSignSurname = new System.Windows.Forms.TextBox();
            this.lblSignSurname = new System.Windows.Forms.Label();
            this.txtSignUserName = new System.Windows.Forms.TextBox();
            this.lblSignUserName = new System.Windows.Forms.Label();
            this.txtSignPassword = new System.Windows.Forms.TextBox();
            this.lblSignPassword = new System.Windows.Forms.Label();
            this.txtSignIdNo = new System.Windows.Forms.TextBox();
            this.lblSignIdNo = new System.Windows.Forms.Label();
            this.txtSignGSM = new System.Windows.Forms.TextBox();
            this.lblSignGSM = new System.Windows.Forms.Label();
            this.txtSignName = new System.Windows.Forms.TextBox();
            this.lblSignName = new System.Windows.Forms.Label();
            this.tabUserLoginPage.SuspendLayout();
            this.tabLoginPage.SuspendLayout();
            this.tabSignPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUserLoginPage
            // 
            this.tabUserLoginPage.Controls.Add(this.tabLoginPage);
            this.tabUserLoginPage.Controls.Add(this.tabSignPage);
            this.tabUserLoginPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabUserLoginPage.Location = new System.Drawing.Point(0, 0);
            this.tabUserLoginPage.Margin = new System.Windows.Forms.Padding(0);
            this.tabUserLoginPage.Name = "tabUserLoginPage";
            this.tabUserLoginPage.SelectedIndex = 0;
            this.tabUserLoginPage.Size = new System.Drawing.Size(833, 510);
            this.tabUserLoginPage.TabIndex = 0;
            // 
            // tabLoginPage
            // 
            this.tabLoginPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabLoginPage.BackgroundImage")));
            this.tabLoginPage.Controls.Add(this.btnLogin);
            this.tabLoginPage.Controls.Add(this.txtLoginPassword);
            this.tabLoginPage.Controls.Add(this.txtLoginUserName);
            this.tabLoginPage.Controls.Add(this.lblLoginPassword);
            this.tabLoginPage.Controls.Add(this.lblLoginUserName);
            this.tabLoginPage.Location = new System.Drawing.Point(4, 25);
            this.tabLoginPage.Margin = new System.Windows.Forms.Padding(0);
            this.tabLoginPage.Name = "tabLoginPage";
            this.tabLoginPage.Size = new System.Drawing.Size(825, 481);
            this.tabLoginPage.TabIndex = 0;
            this.tabLoginPage.Text = "Giriş Yap";
            this.tabLoginPage.UseVisualStyleBackColor = true;
            this.tabLoginPage.Click += new System.EventHandler(this.tabLoginPage_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Location = new System.Drawing.Point(461, 283);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(108, 32);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLoginPassword.Location = new System.Drawing.Point(321, 225);
            this.txtLoginPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginPassword.MaxLength = 32;
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(247, 34);
            this.txtLoginPassword.TabIndex = 3;
            // 
            // txtLoginUserName
            // 
            this.txtLoginUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLoginUserName.Location = new System.Drawing.Point(321, 166);
            this.txtLoginUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginUserName.MaxLength = 32;
            this.txtLoginUserName.Name = "txtLoginUserName";
            this.txtLoginUserName.Size = new System.Drawing.Size(247, 34);
            this.txtLoginUserName.TabIndex = 2;
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLoginPassword.Location = new System.Drawing.Point(220, 229);
            this.lblLoginPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(75, 29);
            this.lblLoginPassword.TabIndex = 1;
            this.lblLoginPassword.Text = "Şifre :";
            // 
            // lblLoginUserName
            // 
            this.lblLoginUserName.AutoSize = true;
            this.lblLoginUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLoginUserName.Location = new System.Drawing.Point(132, 170);
            this.lblLoginUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginUserName.Name = "lblLoginUserName";
            this.lblLoginUserName.Size = new System.Drawing.Size(157, 29);
            this.lblLoginUserName.TabIndex = 0;
            this.lblLoginUserName.Text = "Kullanıcı Adı :";
            // 
            // tabSignPage
            // 
            this.tabSignPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabSignPage.BackgroundImage")));
            this.tabSignPage.Controls.Add(this.btnSignIn);
            this.tabSignPage.Controls.Add(this.txtSignAdminPassword);
            this.tabSignPage.Controls.Add(this.lblSignAdminPassword);
            this.tabSignPage.Controls.Add(this.lblSignUserType);
            this.tabSignPage.Controls.Add(this.cmbUserType);
            this.tabSignPage.Controls.Add(this.txtSignAddress);
            this.tabSignPage.Controls.Add(this.lblSignAddress);
            this.tabSignPage.Controls.Add(this.txtSignEmail);
            this.tabSignPage.Controls.Add(this.lblSignEmail);
            this.tabSignPage.Controls.Add(this.txtSignSurname);
            this.tabSignPage.Controls.Add(this.lblSignSurname);
            this.tabSignPage.Controls.Add(this.txtSignUserName);
            this.tabSignPage.Controls.Add(this.lblSignUserName);
            this.tabSignPage.Controls.Add(this.txtSignPassword);
            this.tabSignPage.Controls.Add(this.lblSignPassword);
            this.tabSignPage.Controls.Add(this.txtSignIdNo);
            this.tabSignPage.Controls.Add(this.lblSignIdNo);
            this.tabSignPage.Controls.Add(this.txtSignGSM);
            this.tabSignPage.Controls.Add(this.lblSignGSM);
            this.tabSignPage.Controls.Add(this.txtSignName);
            this.tabSignPage.Controls.Add(this.lblSignName);
            this.tabSignPage.Location = new System.Drawing.Point(4, 25);
            this.tabSignPage.Margin = new System.Windows.Forms.Padding(0);
            this.tabSignPage.Name = "tabSignPage";
            this.tabSignPage.Size = new System.Drawing.Size(825, 481);
            this.tabSignPage.TabIndex = 1;
            this.tabSignPage.Text = "Kayıt Ol";
            this.tabSignPage.UseVisualStyleBackColor = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignIn.Location = new System.Drawing.Point(563, 335);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(197, 53);
            this.btnSignIn.TabIndex = 23;
            this.btnSignIn.Text = "Kayıt Ol";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtSignAdminPassword
            // 
            this.txtSignAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSignAdminPassword.Location = new System.Drawing.Point(563, 181);
            this.txtSignAdminPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignAdminPassword.MaxLength = 5;
            this.txtSignAdminPassword.Name = "txtSignAdminPassword";
            this.txtSignAdminPassword.Size = new System.Drawing.Size(196, 34);
            this.txtSignAdminPassword.TabIndex = 22;
            this.txtSignAdminPassword.Visible = false;
            this.txtSignAdminPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // lblSignAdminPassword
            // 
            this.lblSignAdminPassword.AutoSize = true;
            this.lblSignAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignAdminPassword.Location = new System.Drawing.Point(577, 134);
            this.lblSignAdminPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignAdminPassword.Name = "lblSignAdminPassword";
            this.lblSignAdminPassword.Size = new System.Drawing.Size(161, 29);
            this.lblSignAdminPassword.TabIndex = 21;
            this.lblSignAdminPassword.Text = "Admin Şifresi:";
            this.lblSignAdminPassword.Visible = false;
            // 
            // lblSignUserType
            // 
            this.lblSignUserType.AutoSize = true;
            this.lblSignUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignUserType.Location = new System.Drawing.Point(577, 34);
            this.lblSignUserType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignUserType.Name = "lblSignUserType";
            this.lblSignUserType.Size = new System.Drawing.Size(164, 29);
            this.lblSignUserType.TabIndex = 20;
            this.lblSignUserType.Text = "Kullanıcı Tipi :";
            // 
            // cmbUserType
            // 
            this.cmbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "Admin",
            "Kullanıcı"});
            this.cmbUserType.Location = new System.Drawing.Point(563, 74);
            this.cmbUserType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(196, 37);
            this.cmbUserType.TabIndex = 19;
            this.cmbUserType.TextChanged += new System.EventHandler(this.cmbUserType_TextChanged);
            // 
            // txtSignAddress
            // 
            this.txtSignAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSignAddress.Location = new System.Drawing.Point(243, 331);
            this.txtSignAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignAddress.MaxLength = 100;
            this.txtSignAddress.Multiline = true;
            this.txtSignAddress.Name = "txtSignAddress";
            this.txtSignAddress.Size = new System.Drawing.Size(247, 109);
            this.txtSignAddress.TabIndex = 18;
            // 
            // lblSignAddress
            // 
            this.lblSignAddress.AutoSize = true;
            this.lblSignAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignAddress.Location = new System.Drawing.Point(53, 335);
            this.lblSignAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignAddress.Name = "lblSignAddress";
            this.lblSignAddress.Size = new System.Drawing.Size(88, 29);
            this.lblSignAddress.TabIndex = 17;
            this.lblSignAddress.Text = "Adres :";
            // 
            // txtSignEmail
            // 
            this.txtSignEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSignEmail.Location = new System.Drawing.Point(243, 288);
            this.txtSignEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignEmail.MaxLength = 32;
            this.txtSignEmail.Name = "txtSignEmail";
            this.txtSignEmail.Size = new System.Drawing.Size(247, 34);
            this.txtSignEmail.TabIndex = 16;
            // 
            // lblSignEmail
            // 
            this.lblSignEmail.AutoSize = true;
            this.lblSignEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignEmail.Location = new System.Drawing.Point(53, 292);
            this.lblSignEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignEmail.Name = "lblSignEmail";
            this.lblSignEmail.Size = new System.Drawing.Size(86, 29);
            this.lblSignEmail.TabIndex = 15;
            this.lblSignEmail.Text = "Email :";
            // 
            // txtSignSurname
            // 
            this.txtSignSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSignSurname.Location = new System.Drawing.Point(243, 74);
            this.txtSignSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignSurname.MaxLength = 32;
            this.txtSignSurname.Name = "txtSignSurname";
            this.txtSignSurname.Size = new System.Drawing.Size(247, 34);
            this.txtSignSurname.TabIndex = 14;
            this.txtSignSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyLetter);
            // 
            // lblSignSurname
            // 
            this.lblSignSurname.AutoSize = true;
            this.lblSignSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignSurname.Location = new System.Drawing.Point(53, 78);
            this.lblSignSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignSurname.Name = "lblSignSurname";
            this.lblSignSurname.Size = new System.Drawing.Size(93, 29);
            this.lblSignSurname.TabIndex = 13;
            this.lblSignSurname.Text = "Soyad :";
            // 
            // txtSignUserName
            // 
            this.txtSignUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSignUserName.Location = new System.Drawing.Point(243, 116);
            this.txtSignUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignUserName.MaxLength = 32;
            this.txtSignUserName.Name = "txtSignUserName";
            this.txtSignUserName.Size = new System.Drawing.Size(247, 34);
            this.txtSignUserName.TabIndex = 12;
            // 
            // lblSignUserName
            // 
            this.lblSignUserName.AutoSize = true;
            this.lblSignUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignUserName.Location = new System.Drawing.Point(53, 119);
            this.lblSignUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignUserName.Name = "lblSignUserName";
            this.lblSignUserName.Size = new System.Drawing.Size(157, 29);
            this.lblSignUserName.TabIndex = 11;
            this.lblSignUserName.Text = "Kullanıcı Adı :";
            // 
            // txtSignPassword
            // 
            this.txtSignPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSignPassword.Location = new System.Drawing.Point(243, 159);
            this.txtSignPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignPassword.MaxLength = 32;
            this.txtSignPassword.Name = "txtSignPassword";
            this.txtSignPassword.Size = new System.Drawing.Size(247, 34);
            this.txtSignPassword.TabIndex = 10;
            // 
            // lblSignPassword
            // 
            this.lblSignPassword.AutoSize = true;
            this.lblSignPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignPassword.Location = new System.Drawing.Point(53, 162);
            this.lblSignPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignPassword.Name = "lblSignPassword";
            this.lblSignPassword.Size = new System.Drawing.Size(75, 29);
            this.lblSignPassword.TabIndex = 9;
            this.lblSignPassword.Text = "Şifre :";
            // 
            // txtSignIdNo
            // 
            this.txtSignIdNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSignIdNo.Location = new System.Drawing.Point(243, 202);
            this.txtSignIdNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignIdNo.MaxLength = 11;
            this.txtSignIdNo.Name = "txtSignIdNo";
            this.txtSignIdNo.Size = new System.Drawing.Size(247, 34);
            this.txtSignIdNo.TabIndex = 8;
            this.txtSignIdNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // lblSignIdNo
            // 
            this.lblSignIdNo.AutoSize = true;
            this.lblSignIdNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignIdNo.Location = new System.Drawing.Point(53, 206);
            this.lblSignIdNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignIdNo.Name = "lblSignIdNo";
            this.lblSignIdNo.Size = new System.Drawing.Size(180, 29);
            this.lblSignIdNo.TabIndex = 7;
            this.lblSignIdNo.Text = "T.C. Kimlik No :";
            // 
            // txtSignGSM
            // 
            this.txtSignGSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSignGSM.Location = new System.Drawing.Point(243, 245);
            this.txtSignGSM.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignGSM.MaxLength = 32;
            this.txtSignGSM.Name = "txtSignGSM";
            this.txtSignGSM.Size = new System.Drawing.Size(247, 34);
            this.txtSignGSM.TabIndex = 6;
            this.txtSignGSM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber);
            // 
            // lblSignGSM
            // 
            this.lblSignGSM.AutoSize = true;
            this.lblSignGSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignGSM.Location = new System.Drawing.Point(53, 249);
            this.lblSignGSM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignGSM.Name = "lblSignGSM";
            this.lblSignGSM.Size = new System.Drawing.Size(108, 29);
            this.lblSignGSM.TabIndex = 5;
            this.lblSignGSM.Text = "Telefon :";
            // 
            // txtSignName
            // 
            this.txtSignName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSignName.Location = new System.Drawing.Point(243, 31);
            this.txtSignName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignName.MaxLength = 32;
            this.txtSignName.Name = "txtSignName";
            this.txtSignName.Size = new System.Drawing.Size(247, 34);
            this.txtSignName.TabIndex = 4;
            this.txtSignName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyLetter);
            // 
            // lblSignName
            // 
            this.lblSignName.AutoSize = true;
            this.lblSignName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignName.Location = new System.Drawing.Point(53, 34);
            this.lblSignName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignName.Name = "lblSignName";
            this.lblSignName.Size = new System.Drawing.Size(54, 29);
            this.lblSignName.TabIndex = 3;
            this.lblSignName.Text = "Ad :";
            // 
            // loginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(833, 510);
            this.Controls.Add(this.tabUserLoginPage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "loginScreen";
            this.Text = "Giriş Yap";
            this.tabUserLoginPage.ResumeLayout(false);
            this.tabLoginPage.ResumeLayout(false);
            this.tabLoginPage.PerformLayout();
            this.tabSignPage.ResumeLayout(false);
            this.tabSignPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabUserLoginPage;
        private System.Windows.Forms.TabPage tabLoginPage;
        private System.Windows.Forms.TabPage tabSignPage;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.TextBox txtLoginUserName;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Label lblLoginUserName;
        private System.Windows.Forms.TextBox txtSignSurname;
        private System.Windows.Forms.Label lblSignSurname;
        private System.Windows.Forms.TextBox txtSignUserName;
        private System.Windows.Forms.Label lblSignUserName;
        private System.Windows.Forms.TextBox txtSignPassword;
        private System.Windows.Forms.Label lblSignPassword;
        private System.Windows.Forms.TextBox txtSignIdNo;
        private System.Windows.Forms.Label lblSignIdNo;
        private System.Windows.Forms.TextBox txtSignGSM;
        private System.Windows.Forms.Label lblSignGSM;
        private System.Windows.Forms.TextBox txtSignName;
        private System.Windows.Forms.Label lblSignName;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.TextBox txtSignAddress;
        private System.Windows.Forms.Label lblSignAddress;
        private System.Windows.Forms.TextBox txtSignEmail;
        private System.Windows.Forms.Label lblSignEmail;
        private System.Windows.Forms.Label lblSignUserType;
        private System.Windows.Forms.TextBox txtSignAdminPassword;
        private System.Windows.Forms.Label lblSignAdminPassword;
        private System.Windows.Forms.Button btnSignIn;
    }
}

