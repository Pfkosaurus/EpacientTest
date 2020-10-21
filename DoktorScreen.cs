using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Pacient
{
    public partial class DoktorScreen : Form
    {
        public DoktorScreen()
        {
            InitializeComponent();
        }

        private void NewPatientForm_Click(object sender, EventArgs e)
        {
           NewPacient NewPacient = new NewPacient();
            this.Hide();                    //is closing this one //
            NewPacient.Show();
        }

        private void AppointmentForm_Click(object sender, EventArgs e)
        {

        }

        private void ToDoListForm_Click(object sender, EventArgs e)
        {

        }

        private void SearchPatientForm_Click(object sender, EventArgs e)
        {
            SearchPacient SearchPacient = new SearchPacient();
            this.Hide();                    //is closing this one //
            SearchPacient.Show();
        }

        private void SettingsForm_Click(object sender, EventArgs e)
        {

        }

        private void LogOutForm_Click(object sender, EventArgs e)
        {
            MainScreen MainScreen = new MainScreen();
            this.Hide();                    //is closing this one //
            MainScreen.Show();
        }

        private void DoktorScreen_Load(object sender, EventArgs e)
        {
        }

    }
}
