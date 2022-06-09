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
    public partial class AdminZone : Form
    {
        private int CurrentUser { get; set; }
        public static int index;
        public static string name;
        string userName;
        string selectedPriv;
        public AdminZone(int id)
        {
            CurrentUser = id;
            InitializeComponent();
        }

        private void AdminZone_Load(object sender, EventArgs e)
        {
            datagridFill();
            fillListBox();
        }

        private void datagridFill()
        {
            RPGEntities db = new RPGEntities();
            var query = (from u in db.Users
                         where u.Name != "admin"
                         select new { u.ID, u.Name, u.Password, u.Privileges });
            dataGridView1.DataSource = query.ToList();
        }

        private void fillListBox()
        {
            List<string> users = DbController.GetUsernames();
            foreach (string user in users)
            {
                listBox1.Items.Add(user);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(CurrentUser);
            menu.Show();
            this.Hide();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            name = listBox1.SelectedItem.ToString();
            ChangeByAdmin change = new ChangeByAdmin(CurrentUser);
            change.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = listBox1.SelectedItem.ToString();
            ChangePriv change = new ChangePriv();
            change.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            fillListBox();

            dataGridView1.DataSource = null;
            datagridFill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userName = listBox1.SelectedItem.ToString();
            int id = DbController.GetUserID(userName);
            MessageBox.Show("User removed");
            DbController.RemoveUser(id);
        }

    }
}
