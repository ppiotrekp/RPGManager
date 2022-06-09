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
    public partial class EditAttribute : Form
    {
        public int CurrentUser { get; set; }
        public EditAttribute(int id)
        {
            CurrentUser = id;
            InitializeComponent();
        }

        private void EditAttribute_Load(object sender, EventArgs e)
        {
            textBox1.Text = ShowAll.artefactName;
            textBox2.Text = ShowAll.value.ToString();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            DbController.EditAttribute(textBox1.Text, int.Parse(textBox3.Text));
            MessageBox.Show("Attribute value changed successfully");
            this.Hide();
        }
    }
}
