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
    public partial class EditCategory : Form
    {
        public int CurrentUser { get; set; }
        public EditCategory(int id)
        {
            InitializeComponent();
            CurrentUser = id;
        }

        private void EditArtefact_Load(object sender, EventArgs e)
        {
            textBox1.Text = ShowAll.categoryName;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            DbController.EditCategory(textBox1.Text, textBox2.Text);
            MessageBox.Show("Category name changed successfully");
            this.Hide();
        }
    }
}
