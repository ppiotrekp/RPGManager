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
    public partial class EditArtefact : Form
    {
        public EditArtefact()
        {
            InitializeComponent();
        }

        private void EditArtefact_Load(object sender, EventArgs e)
        {
            Game7Entities db = new Game7Entities();
            var query = (from a in db.Artefacts
                        
                         select new { a.Name});
            dataGridView1.DataSource = query.ToList();
        }
    }
}
