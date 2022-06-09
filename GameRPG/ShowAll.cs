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
using GameRPG.Database.GameContext;
using GameRPG.Database.Model;

namespace GameRPG
{
    public partial class ShowAll : Form
    {
        private static int CurrentUser { get; set; }

        string userName = Login.name;
        public static string categoryName;
        public static string artefactName;
        public static int artefactId;
        public static int attrId;
        public static int value;
        int priv;
        
        public ShowAll(int id)
        {
            InitializeComponent();
            CurrentUser = id;
            
        }

        private void Show_Load(object sender, EventArgs e)
        {
            
           // comboBoxCategory();
            datagridFill();
            fillListBoxes();
            
            
        }

        private void fillListBoxes()
        {
            List<string> categories = DbController.GetUserCategories(CurrentUser);
            List<string> artefacts = DbController.GetUserArtefacts(CurrentUser);

            foreach (string c in categories)
            {
                listBox1.Items.Add(c);
            }

            foreach (string a in artefacts)
            {
                listBox2.Items.Add(a);
            }
        }

        private void datagridFill()
        {
            RPGEntities db = new RPGEntities();
            var query = (from a in db.Artefacts
                         join c in db.Categories on a.CategoryID equals c.CategoryID
                         join u in db.Users on a.UserID equals u.ID
                         join at in db.Attributes on a.ArtefactID equals at.ArtefactID
                         orderby c.Name
                         where u.Name == userName
                         select new { CategoryName = c.Name, a.Name, Attribute = at.Name, at.Value });

            dataGridView1.DataSource = query.Distinct().ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(CurrentUser);
            this.Hide();
            menu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            priv = DbController.GetUserPriv(Login.name);
            if (priv != 5)
            {
                try
                {
                    categoryName = listBox1.SelectedItem.ToString();
                    EditCategory edit = new EditCategory(CurrentUser);
                    edit.Show();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Select category");
                }
            }

            else
            {
                MessageBox.Show("You have not enough priviliges");
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            priv = DbController.GetUserPriv(Login.name);
            if (priv != 5 && priv != 1)
            {
                try
                {
                    artefactName = listBox2.SelectedItem.ToString();
                    EditArtefact edit = new EditArtefact(CurrentUser);
                    edit.Show();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Select artefact");
                }
            }
            else
            {
                MessageBox.Show("You have not enough priviliges");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RPGEntities db = new RPGEntities();
            var query = (from a in db.Artefacts
                         join c in db.Categories on a.CategoryID equals c.CategoryID
                         join u in db.Users on a.UserID equals u.ID
                         join at in db.Attributes on a.ArtefactID equals at.ArtefactID
                         orderby c.Name
                         where a.Name.Contains(textBox2.Text)
                         where u.Name == userName
                         select new { CategoryName = c.Name, a.Name, Attribute = at.Name, at.Value });
           
            dataGridView1.DataSource = query.ToList();
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            datagridFill();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RPGEntities db = new RPGEntities();
            var query = (from a in db.Artefacts
                         join c in db.Categories on a.CategoryID equals c.CategoryID
                         join u in db.Users on a.UserID equals u.ID
                         join at in db.Attributes on a.ArtefactID equals at.ArtefactID
                         orderby c.Name
                         where c.Name.Contains(textBox1.Text)
                         where u.Name == userName
                         select new { CategoryName = c.Name, a.Name, Attribute = at.Name, at.Value });

            dataGridView1.DataSource = query.ToList();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            fillListBoxes();

            dataGridView1.DataSource = null;
            datagridFill();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            priv = DbController.GetUserPriv(Login.name);
            if (priv == 3 || priv == 4 )
            {
                artefactName = listBox2.SelectedItem.ToString();
                int id = DbController.GetArtefactId(artefactName);
                MessageBox.Show("Item removed");
                DbController.RemoveArtefact(id);
            }

            else
            {
                MessageBox.Show("You have not enough priviliges");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            priv = DbController.GetUserPriv(Login.name);
            if (priv == 4)
            {
                categoryName = listBox1.SelectedItem.ToString();
                int id = DbController.GetCategoryId(categoryName);
                MessageBox.Show("Category removed");
                DbController.RemoveCategory(id);
            }
            else
            {
                MessageBox.Show("You have not enough priviliges");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            artefactName = listBox2.SelectedItem.ToString();
            artefactId = DbController.GetArtefactId(artefactName);
            attrId = DbController.GetAttributeId(artefactId);
            value = DbController.GetAttributeValue(attrId);
            EditAttribute edit = new EditAttribute(CurrentUser);
            edit.Show();
        }
    }
}
