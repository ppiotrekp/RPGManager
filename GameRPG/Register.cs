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
using System.Security.Cryptography;
namespace GameRPG
{
    public partial class Register : Form
    {
       // private List<string> FeatureNames = new List<string>();
        public Register()
        {
            InitializeComponent();
        }

       private List<string> usernames = DbController.GetUsernames();

        private void fillCombo()
        {
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(2);
            comboBox1.Items.Add(3);
            comboBox1.Items.Add(4);
            comboBox1.Items.Add(5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillCombo();
            List<string> artefacts = DbController.GetArtefacts();
            
            RPGEntities db = new RPGEntities();
            var query = (from a in db.Artefacts
                         join f in db.Attributes on a.ArtefactID equals f.ArtefactID
                         join c in db.Categories on a.CategoryID equals c.CategoryID
                         orderby f.Value descending

                         select new {a.Name, Attribute = f.Name,  f.Value});
            dataGridView1.DataSource = query.ToList();

            for (int i = 5; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Visible = false;
            }

            var query1 = (from a in db.Artefacts
                         join at in db.Attributes on a.ArtefactID equals at.ArtefactID
                         join c in db.Categories on a.CategoryID equals c.CategoryID
                         orderby a.AddData descending
                         select new {Category = c.Name, a.Name, a.AddData });

            dataGridView2.DataSource = query1.ToList();

            for (int i = 5; i < dataGridView2.Rows.Count; i++)
            {
                dataGridView2.Rows[i].Visible = false;
            }

           

            label6.Text = "Max amount - " + dataGridView1.Rows.Count;
            label9.Text = "Max amount - " + dataGridView2.Rows.Count;

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            

            if (usernames.Contains(textBox5.Text))
            {
                MessageBox.Show("User exists!");
            }

            else if ((!textBox5.Text.Equals("")) & (!textBox2.Text.Equals("")) & textBox3.Text.Equals(textBox2.Text))
            {
                string s = DbController.getHash(textBox2.Text);
                DbController.AddUser(textBox5.Text, s, Convert.ToInt32(comboBox1.SelectedItem));
                MessageBox.Show("Account created!");
                Login login = new Login();
                this.Hide();
                login.Show();
            }

            else
            {
                MessageBox.Show("Incorrect data!");
                textBox5.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            
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

        private void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                int val = 0;
                if (Int32.TryParse(textBox4.Text, out val))
                {
                    if (val <= dataGridView1.Rows.Count && val != 0)
                    {
                        for (int i = val; i < dataGridView1.Rows.Count; i++)
                        {
                            dataGridView1.Rows[i].Visible = false;
                        }

                        for (int i = 0; i < val; i++)
                        {
                            dataGridView1.Rows[i].Visible = true;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("It must be a digit !");
            }
            
        }

        private void defaultButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Rows[i].Visible = true;
            }

            for (int i = 5; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int val = 0;
                if (Int32.TryParse(textBox6.Text, out val))
                {
                    if (val <= dataGridView2.Rows.Count && val != 0)
                    {
                        for (int i = val; i < dataGridView2.Rows.Count; i++)
                        {
                            dataGridView2.Rows[i].Visible = false;
                        }

                        for (int i = 0; i < val; i++)
                        {
                            dataGridView2.Rows[i].Visible = true;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("It must be a digit !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                dataGridView2.Rows[i].Visible = true;
            }

            for (int i = 5; i < dataGridView2.Rows.Count; i++)
            {
                dataGridView2.Rows[i].Visible = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
