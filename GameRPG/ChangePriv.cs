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
    public partial class ChangePriv : Form
    {
        public ChangePriv()
        {
            InitializeComponent();
        }

        private void ChangePriv_Load(object sender, EventArgs e)
        {
            int priv = DbController.GetUserPriv(AdminZone.name);
            textBox1.Text = AdminZone.name;
            textBox2.Enabled = false;
            textBox2.Text = priv.ToString();
            textBox2.Enabled = false;

            comboBox1.Items.Add(1);
            comboBox1.Items.Add(2);
            comboBox1.Items.Add(3);
            comboBox1.Items.Add(4);
            comboBox1.Items.Add(5);
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            
            DbController.ChangeUserPriv(textBox1.Text, int.Parse(comboBox1.SelectedItem.ToString()));
            MessageBox.Show("Priviliges changed successfully");
            this.Hide();

            
        }
    }
}
