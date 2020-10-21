using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace E_Pacient
{

    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            hesloboxlog.PasswordChar = '●';
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainScreen MainScreen = new MainScreen();
            MainScreen.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailboxlog.Text;
            string password = hesloboxlog.Text;
            if (String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(password))
            {
                DialogResult res = MessageBox.Show("Vyplňte všetky polia", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else

            {
                SqlConnection sqlconn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Dell\source\repos\E-Pacient\dbtest.mdf;Integrated Security = True");

                SqlCommand cmd = new SqlCommand("select * from tbluser where email = '" + email + "'", sqlconn);
                sqlconn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    string savedPasswordHash = sdr.GetString(1);  //get the user password from db if the user name is exist in that na poradi 2 z lava(0,1,2)
                    string hash_ = sdr.GetString(6);
                    byte[] hash = Encoding.ASCII.GetBytes(hash_);
                    string salt_ = sdr.GetString(5);
                    byte[] salt = Encoding.ASCII.GetBytes(salt_);

                    byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
                    salt = new byte[16];
                    Array.Copy(hashBytes, 0, salt, 0, 16);
                    var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
                    hash = pbkdf2.GetBytes(20);
                    for (int i = 0; i < 1; i++)
                        if (hashBytes[i + 16] != hash[i])
                        {
                            DialogResult res = MessageBox.Show("Zlé heslo", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DoktorScreen DoktorScreen = new DoktorScreen();
                            this.Hide();
                            DoktorScreen.Show();
                        }
                }
                else
                {
                    DialogResult res = MessageBox.Show("Uzivatel neexistuje", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void forgotBtn_Click(object sender, EventArgs e)
        {
        }
        private void Doktor()
        {

        }

        private void hesloboxlog_TextChanged(object sender, EventArgs e)
        {
            //cicina
        }

        private void passChechBox_CheckedChanged(object sender, EventArgs e)
        {
            hesloboxlog.PasswordChar = passChechBox.Checked ? '\0' : '●';
        }
    }
}
