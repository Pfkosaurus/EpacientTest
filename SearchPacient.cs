using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace E_Pacient
{
    public partial class SearchPacient : Form
    {
        public SearchPacient()
        {
            InitializeComponent();
            menoPriezviskoTxt.ReadOnly = true;
            kontaktTxt.ReadOnly = true;
            adresaTxt.ReadOnly = true;
            poistovnaTxt.ReadOnly = true;
            ineZaznamyTxt.ReadOnly = true;
       
        }
        dbcontrol sql = new dbcontrol();
        private void backBtn_Click(object sender, EventArgs e)
        {
            DoktorScreen DoktorScreen = new DoktorScreen();
            this.Hide();
            DoktorScreen.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(rodneCisloTxt.Text))
            {
                DialogResult res = MessageBox.Show("Vyplňte rodné číslo", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
            else
            {
                SqlConnection sqlconn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Dell\source\repos\E-Pacient\dbtest.mdf;Integrated Security = True");

                SqlCommand cmd = new SqlCommand("select * from Pacient where RodneCislo = '" + rodneCisloTxt.Text + "'", sqlconn);
                sqlconn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    //
                    string menopriezvisko = sdr.GetString(2);
                    string datumnarodenia = sdr.GetString(3);
                    string kontakt = sdr.GetString(4);
                    string adresa = sdr.GetString(5);
                    string poistovna = sdr.GetString(6);
                    string sex = sdr.GetString(7);
                    string krv = sdr.GetString(8);
                    string ine = sdr.GetString(9);
                    //                   
                    menoPriezviskoTxt.Text = menopriezvisko;
                    datumNarodeniaTxt.Text = datumnarodenia;
                    kontaktTxt.Text = kontakt;
                    adresaTxt.Text = adresa;
                    poistovnaTxt.Text = poistovna;
                    comboBox1.Text = sex;
                    comboBox2.Text = krv;
                    ineZaznamyTxt.Text = ine;
                }
                else
                {
                    DialogResult res = MessageBox.Show("Uzivatel neexistuje", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            rodneCisloTxt.ReadOnly = true;
            menoPriezviskoTxt.ReadOnly = false;
            kontaktTxt.ReadOnly = false;
            adresaTxt.ReadOnly = false;
            poistovnaTxt.ReadOnly = false;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            rodneCisloTxt.ReadOnly = false;
            rodneCisloTxt.Text = "";
            menoPriezviskoTxt.Text = "";
            datumNarodeniaTxt.Text = "";
            kontaktTxt.Text = "";
            adresaTxt.Text = "";
            poistovnaTxt.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            ineZaznamyTxt.Text = "";
        }

        private void SearchPacient_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Dell\source\repos\E-Pacient\dbtest.mdf;Integrated Security = True");
            
            sqlconn.Open();
            SqlCommand q = new SqlCommand("UPDATE Pacient SET MenoPriezvisko = @menopriezvisko, Kontakt = @kontakt, Adresa = @adresa, Poistovna = @poistovna, Ine = @ine WHERE RodneCislo = @rodnecislo ", sqlconn);
            q.Parameters.AddWithValue("@rodnecislo", rodneCisloTxt.Text);
            q.Parameters.AddWithValue("@menopriezvisko", menoPriezviskoTxt.Text);
            q.Parameters.AddWithValue("@kontakt", kontaktTxt.Text);
            q.Parameters.AddWithValue("@adresa", adresaTxt.Text);
            q.Parameters.AddWithValue("@poistovna", poistovnaTxt.Text);
            q.Parameters.AddWithValue("@ine", ineZaznamyTxt.Text);
            q.ExecuteNonQuery();

            if (sql.CheckForError(true))
                {
                    return;
                }
                rodneCisloTxt.ReadOnly = true;
                menoPriezviskoTxt.ReadOnly = true;
                kontaktTxt.ReadOnly = true;
                adresaTxt.ReadOnly = true;
                poistovnaTxt.ReadOnly = true;
                ineZaznamyTxt.ReadOnly = true;
            ///sdyfs
            MessageBox.Show("Pacient modifikovany", "Yissss", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
