using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E_Pacient
{
    public partial class NewPacient : Form
    {
        public NewPacient()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        dbcontrol sql = new dbcontrol();
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(rodneCisloTxt.Text) || String.IsNullOrEmpty(menoPriezviskoTxt.Text) || String.IsNullOrEmpty(datumNarodeniaTxt.Text) || String.IsNullOrEmpty(poistovnaTxt.Text))
            {
                MessageBox.Show("Neco je zle", "No!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            createP();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void createP()
        {
            SqlConnection sqlconn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Dell\source\repos\E-Pacient\dbtest.mdf;Integrated Security = True");

            int id = 1;
            try
            {
                sql.Param("@rodnecislo", rodneCisloTxt.Text);
                sql.Param("@menopriezvisko", menoPriezviskoTxt.Text);
                sql.Param("@datumnarodenia", datumNarodeniaTxt.Text);
                sql.Param("@kontakt", kontaktTxt.Text);
                sql.Param("@adresa", adresaTxt.Text);
                sql.Param("@poistovna", poistovnaTxt.Text);
                sql.Param("@pohlavie", comboBox1.SelectedItem);
                sql.Param("@krv", comboBox2.SelectedItem);
                sql.Param("@ine", ineZaznamyTxt.Text);
                sql.Param("@id", id);

                sql.query("INSERT INTO Pacient (Id,RodneCislo, MenoPriezvisko, DatumNarodenia, Kontakt, Adresa, Poistovna, Pohlavie, Krv, Ine) VALUES (@id, @rodnecislo, @menopriezvisko, @datumnarodenia, @kontakt, @adresa, @poistovna, @pohlavie, @krv, @ine)",sqlconn);
            }
            catch
            {

            }
            finally
            {
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

            MessageBox.Show("Pacient vytvorený", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DoktorScreen DoktorScreen = new DoktorScreen();
            this.Hide();
            DoktorScreen.Show();
        }
    }
}
