﻿using System;
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
    public partial class EditArtefact : Form
    {
        public int CurrentUser { get; set; }
        public EditArtefact(int id)
        {
            CurrentUser = id;
            InitializeComponent();
        }

        private void EditArtefact_Load(object sender, EventArgs e)
        {
            textBox1.Text = ShowAll.artefactName;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            DbController.EditArtefact(textBox1.Text, textBox2.Text);
            MessageBox.Show("Artefact name changed successfully");
            this.Hide();
        }
    }
}
