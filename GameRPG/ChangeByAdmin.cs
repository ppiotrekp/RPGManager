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
    
    public partial class ChangeByAdmin : Form
    {
        public int CurrentUser { get; set; }
        public ChangeByAdmin(int id)
        {   
            CurrentUser = id;
            InitializeComponent();
        }

        private void ChangeByAdmin_Load(object sender, EventArgs e)
        {
            textBox1.Text = AdminZone.name;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminZone admin = new AdminZone(CurrentUser);
            admin.Show();
            this.Hide();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            
            string s = DbController.getHash(textBox2.Text);
            if (textBox2.Text.Equals(textBox3.Text))
            {
                DbController.ChangePassword(textBox1.Text, s);
                MessageBox.Show("Password changed successfully");
                this.Hide();
            }

            else
            {
                MessageBox.Show("Fail");
            }
        }
    }
}
