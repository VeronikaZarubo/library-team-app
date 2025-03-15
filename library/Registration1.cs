using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class Registration1 : Form
    {
        public Registration1()
        {
            InitializeComponent();
        }

        private void labelRegistration1SwitchToLogin_Click(object sender, EventArgs e)
        {
            Login newLevel = new Login();
            this.Hide();
            newLevel.Show();
        }

        private void Bt_RegistrationNext_Click(object sender, EventArgs e)
        {
            //Registration2 newLevel = new Registration2();
            //this.Hide();
            //newLevel.Show();
        }
    }
}
