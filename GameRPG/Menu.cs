using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRPG
{
    public partial class Menu : Form
    {
        private int CurrentUser { get; set; }
        public int privilige = Login.priv;
        

        public Menu(int id)
        {
            CurrentUser = id;
            InitializeComponent();
        }

        public Menu ()
        {
            InitializeComponent();
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowAll show = new ShowAll(CurrentUser);
            this.Hide();
            show.Show();
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            if (privilige != 5)
            {
                Form add = new AddCategory(CurrentUser, this);
                this.Hide();
                add.Show();
            }

            else
            {
                MessageBox.Show("You are admin and you can not create categories");
            }
            
        }

        private void addArtefactButton_Click(object sender, EventArgs e)
        {
            if (privilige != 5)
            {
                Form art = new AddArtefact(CurrentUser, this);
                this.Hide();
                art.Show();
            }
            else
            {
                MessageBox.Show("You are admin and you can not create artefacts");
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void manageaccountButton_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword(CurrentUser);
            this.Hide();
            change.Show();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            if (privilige == 5)
            {
                AdminZone adminZone = new AdminZone(CurrentUser);
                adminZone.Show();
                this.Hide();
            } 

            else
            {
                MessageBox.Show("You have not enough priviliges");
            }
        }
    }
}
