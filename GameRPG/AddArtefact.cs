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
        private Form _f;
        private List<string> FeatureNames = new List<string>();
        private List<string> FeatureTypes = new List<string>();
        private List<int> FeatureValues = new List<int>();
        public AddArtefact(int id, Form f)
        {
            InitializeComponent();
            CurrentUser = id;
            _f = f;
            List<string> categories = DbController.GetUserCategories(CurrentUser);
            foreach (string category in categories)
            {
                comboBox1.Items.Add(category);
            }
            checkedListBox3.Items.Add("int");
        }

        private void AddArtefact_Load(object sender, EventArgs e)
        {
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Art = textBox3.Text;
                string Type = checkedListBox3.SelectedItems[0].ToString();
                int Value = int.Parse(textBox4.Text);
                FeatureNames.Add(Art);
                FeatureTypes.Add(Type);
                FeatureValues.Add(Value);

                if (Value < DbController.GetMaxValue())
                {
                    DbController.AddAttributes(FeatureNames, FeatureTypes, FeatureValues, ArtifactName, DbController.GetCategoryId(Category), CurrentUser);
                    MessageBox.Show("Added successfully");
                    this.Hide();
                    _f.Show();

                }

                else
                {
                    FeatureValues.Remove(Value);
                    FeatureValues.Add(20);
                    MessageBox.Show("Your value is too high. Default value is " + 20.ToString());
                    DbController.AddAttributes(FeatureNames, FeatureTypes, FeatureValues, ArtifactName, DbController.GetCategoryId(Category), CurrentUser);
                    MessageBox.Show("Added successfully");
                    this.Hide();
                    _f.Show();
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Pass category, name and atribute !");
            }
            
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            Category = comboBox1.SelectedItem.ToString();
            ArtifactName = textBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
