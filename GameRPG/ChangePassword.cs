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
    public partial class ChangePassword : Form
    {
        private int CurrentUser { get; set; }
        public ChangePassword(int id)
        {
            InitializeComponent();
            CurrentUser = id;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string s1 = DbController.getHash(textBox1.Text);
            if (DbController.CheckUser(Login.name, s1))
            {
                if (textBox2.Text.Equals(textBox3.Text))
                {
                    string s = DbController.getHash(textBox2.Text);
                    DbController.ChangePassword(Login.name, s);
                    MessageBox.Show("Password changed successfully");
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(CurrentUser);
            this.Hide();
            menu.Show();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
