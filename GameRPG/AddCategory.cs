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
    public partial class AddCategory : Form
    {
        private string CategoryName;
        private List<string> Atributes = new List<string>();
        private List<string> AtributesTypes = new List<string>();
        private int CurrentUser { get; set; }
        private Form _f;

        public AddCategory(int id, Form f)
        {
            InitializeComponent();
           

            CurrentUser = id;
            _f = f;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                CategoryName = textBox1.Text;
            }


            if (CategoryName != null)
            {
               
                    DbController.AddCategory(CategoryName, CurrentUser);
                    MessageBox.Show("Category added!");
                    this.Hide();
                    _f.Show();
            }
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(CurrentUser);
            this.Hide();
            menu.Show();
        }
    }
}
