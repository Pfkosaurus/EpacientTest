using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_Pacient
{
    public partial class Register : Form
    {

        public Register()
        {
            InitializeComponent();
        }

        dbcontrol sql = new dbcontrol();

        void register()
        {

            sql.Param("@uuser", emailboxlog.Text);
            sql.Param("@password", heslo1boxlog.Text);
            sql.Param("@email", emailboxlog.Text);
            sql.Param("@firstname", menoboxlog.Text);
            sql.Param("@lastname", priezviskoboxlog.Text);

            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(heslo1boxlog.Text, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);

            sql.Param("@savedPasswordHash", savedPasswordHash);
            sql.Param("@salt", salt);
            sql.Param("@hash", hash);
            SqlConnection sqlconn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Dell\source\repos\E-Pacient\dbtest.mdf;Integrated Security = True");

            sql.query("INSERT INTO tbluser (uuser, password, firstname, lastname, email, salt, hash) VALUES (@uuser, @savedPasswordHash, @firstname, @lastname, @email, @salt, @hash)",sqlconn);
            if (sql.CheckForError(true))
            {
                return;
            }

            MessageBox.Show("registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            String meno = menoboxlog.Text;
            String priezvisko = priezviskoboxlog.Text;
            String heslo1 = heslo1boxlog.Text;
            String heslo2 = heslo2boxlog.Text;
            String email = emailboxlog.Text;

            if (heslo1.Equals(heslo2))
            {
                if (String.IsNullOrWhiteSpace(meno) || String.IsNullOrWhiteSpace(priezvisko) || String.IsNullOrWhiteSpace(heslo1) || String.IsNullOrWhiteSpace(heslo2) || String.IsNullOrWhiteSpace(email))
                {
                    DialogResult res = MessageBox.Show("Vyplňte všetky polia", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (res == DialogResult.OK)
                    {
                    }
                }
                else
                {
                    register();
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainScreen MainScreen = new MainScreen();
            MainScreen.Show();                //calling different frm and also //
            this.Hide();                    //is closing this one //
        }

        void Clear()
        {
            String meno = menoboxlog.Text;
            String priezvisko = priezviskoboxlog.Text;
            String heslo1 = heslo1boxlog.Text;
            String heslo2 = heslo2boxlog.Text;
            String email = emailboxlog.Text;
            meno = priezvisko = heslo1 = heslo2 = email = "";
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Priezvisko_Click(object sender, EventArgs e)
        {

        }
    }
}
