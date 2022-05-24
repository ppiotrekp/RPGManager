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
    public partial class Register : Form
    {
        private List<string> FeatureNames = new List<string>();
        public Register()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> artefacts = DbManager.GetArtefacts();
            foreach (string artefact in artefacts)
            {
               
            }
            //dataGridView1.DataSource = artefacts;
           

            Game7Entities db = new Game7Entities();
            var query = (from a in db.Artefacts
                         join f in db.Features on a.ArtefactID equals f.ArtefactID
                         join c in db.Categories on a.CategoryID equals c.CategoryID
                         orderby f.Value descending
                         select new {a.Name,  f.Value, f.Type});
            dataGridView1.DataSource = query.ToList();

            var query1 = (from a in db.Artefacts
                         join f in db.Features on a.ArtefactID equals f.ArtefactID
                         join c in db.Categories on a.CategoryID equals c.CategoryID
                         orderby f.Value descending
                         select new { a.Name, f.Value, f.Type });

            dataGridView2.DataSource = query1.ToList();

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if ((!textBox1.Text.Equals("")) & (!textBox2.Text.Equals("")) & textBox3.Text.Equals(textBox2.Text))
            {
                DbManager.AddUser(textBox1.Text, textBox2.Text);
                MessageBox.Show("Account created!");
                Login login = new Login();
                this.Hide();
                login.Show();
            }
            MessageBox.Show("Wrong data!");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            this.Hide();
            login.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
