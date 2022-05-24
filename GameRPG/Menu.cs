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
        public Menu(int id)
        {
            CurrentUser = id;
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Show show = new Show();
            this.Hide();
            show.Show();
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            Form add = new AddCategory(CurrentUser, this);
            this.Hide();
            add.Show();
        }

        private void addArtefactButton_Click(object sender, EventArgs e)
        {
            Form art = new AddArtefact(CurrentUser, this);
            this.Hide();
            art.Show();
        }

        private void deleteCategorryButton_Click(object sender, EventArgs e)
        {
            //DeleteCategory delete = new DeleteCategory(CurrentUser, this);
            this.Hide();
            //delete.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditArtefact edit = new EditArtefact();
            this.Hide();
            edit.Show();
        }
    }
}
