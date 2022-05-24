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
    public partial class AddArtefact : Form
    {
        private string Category;
        private string ArtifactName;
        private int CurrentUser;
        private Form _m;
        private List<string> DefaultArtifacts;
        private List<string> FeatureNames = new List<string>();
        private List<string> FeatureTypes = new List<string>();
        private List<string> FeatureValues = new List<string>();
        public AddArtefact(int id, Form m)
        {
            InitializeComponent();
            CurrentUser = id;
            _m = m;
            List<string> categories = DbManager.GetCategories();
            foreach (string category in categories)
            {
                comboBox1.Items.Add(category);
            }
            checkedListBox3.Items.Add("int");
            checkedListBox3.Items.Add("bool");
            checkedListBox3.Items.Add("float");
            checkedListBox3.Items.Add("bool");
        }

        private void AddArtefact_Load(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string Art = textBox3.Text;
            string Type = checkedListBox3.SelectedItems[0].ToString();
            string Value = textBox4.Text;
            FeatureNames.Add(Art);
            FeatureTypes.Add(Type);
            FeatureValues.Add(Value);
            textBox3.Text = "";
            checkedListBox3.ClearSelected();
            textBox4.Text = "";

            DbManager.AddFeatures(FeatureNames, FeatureTypes, FeatureValues, ArtifactName, DbManager.GetCategoryId(Category), CurrentUser);
            MessageBox.Show("Added successfully");
            this.Hide();
            _m.Show();

        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            Category = comboBox1.SelectedItem.ToString();
            ArtifactName = textBox1.Text;

            DefaultArtifacts = DbManager.GetDefaultAtributes(Category);

            foreach (string atr in DefaultArtifacts)
            {
                comboBox2.Items.Add(atr);
            }
        }

        private void select1Button_Click(object sender, EventArgs e)
        {
            string SelectedArt = comboBox2.SelectedItem.ToString();
            string SelectedValue = textBox2.Text;
            FeatureNames.Add(SelectedArt);
            FeatureTypes.Add("string");
            FeatureValues.Add(SelectedValue);
            comboBox2.Items.Remove(SelectedArt);
            textBox2.Text = "";
        }





















        Select select = new Select();
        private void comboBoxCategory()
        {
            var Lst = select.comboCategory();
            if (Lst.Count > 0)
            {
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "CategoryID";
                comboBox1.DataSource = Lst;
            }
        }

        private void ComboArtefact()
        {
            var Id = (int)comboBox1.SelectedValue;
            var Lst = select.comboArtefacts(Id);
            if (Lst.Count > 0)
            {
                comboBox2.DisplayMember = "Name";
                comboBox2.ValueMember = "Id";
                comboBox2.DataSource = Lst;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
