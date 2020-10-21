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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {         
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Hide();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Register Register = new Register();
            Register.Show();
            this.Hide();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Would do you like contact developer of this application?", "Help", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
            }
            if (res == DialogResult.Cancel)
            {
            }
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
        }
    }
}
