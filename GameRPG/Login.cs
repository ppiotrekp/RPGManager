using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameRPG.Database;

namespace GameRPG
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (DbManager.AuthenticateUser(usernameBox.Text, passwordBox.Text))
            {
                MessageBox.Show("Logged in");
                Form menu = new Menu(DbManager.GetUserID(usernameBox.Text, passwordBox.Text));
                this.Hide();
                menu.Show();
            }
        }
    }
}
