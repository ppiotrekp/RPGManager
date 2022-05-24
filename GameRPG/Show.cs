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
    public partial class Show : Form
    {
        public Show()
        {
            InitializeComponent();
        }

        Select select = new Select();
        Artefacts artefact = new Artefacts();
        GameContext gameContext = new GameContext();
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

        private void Show_Load(object sender, EventArgs e)
        {
            comboBoxCategory();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)comboBox1.SelectedIndex != -1) { }
                ComboArtefact();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*GameContext gc = new GameContext();
            Artefact a = gc.Artefacts.First(s => s.Name == (comboBox2.SelectedItem.ToString()));

            gc.Artefacts.Remove(a);
            gc.SaveChanges();
            MessageBox.Show("Deleted");*/


        }
    }
}
