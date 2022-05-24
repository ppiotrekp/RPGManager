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
        private int CurrentUser;
        private Form _m;

        public AddCategory(int id, Form m)
        {
            InitializeComponent();
            checkedListBox1.Items.Add("int");
            checkedListBox1.Items.Add("float");
            checkedListBox1.Items.Add("string");
            checkedListBox1.Items.Add("bool");

            CurrentUser = id;
            _m = m;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                CategoryName = textBox1.Text;
            }

            if (!textBox2.Text.Equals(""))
            {
                Atributes.Add(textBox2.Text);
                AtributesTypes.Add(checkedListBox1.CheckedItems[0].ToString());

                textBox2.Text = "";
                checkedListBox1.ClearSelected();
            }

            if (CategoryName != null & Atributes.Count != 0 & AtributesTypes.Count != 0)
            {
                DbManager.AddCategory(CategoryName, CurrentUser, Atributes, AtributesTypes);
                MessageBox.Show("Category added!");
                this.Hide();
                _m.Show();
            }
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
