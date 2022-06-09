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
        public static string name;
        public static string id;
        public static int priv;

        RPGEntities db = new RPGEntities();
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string s = DbController.getHash(passwordBox.Text);
            if (DbController.CheckUser(usernameBox.Text, s))
            {
                MessageBox.Show("Logged in");
                name = usernameBox.Text;
                priv = DbController.GetUserPriv(usernameBox.Text, s);
                Form menu = new Menu(DbController.GetUserID(usernameBox.Text, s));
                this.Hide();
                menu.Show();
            }

            else
            {
                MessageBox.Show("User does not exists !");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }
    }
}
