using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG
{
    internal class Select
    {
        public List<Categories> comboCategory()
        {
            using(Game7Entities db = new Game7Entities())
            {
                return db.Categories.ToList();
            }
        }

        public List<Artefacts> comboArtefacts(int Id)
        {
            using (Game7Entities db = new Game7Entities())
            {
                return db.Artefacts.Where(a=>a.CategoryID == Id).ToList();
            }
        }

        public List<DefaultAtributes> comboAttributes(int Id)
        {
            using (Game7Entities db = new Game7Entities())
            {
                return db.DefaultAtributes.Where(a => a.CategoryID == Id).ToList();
            }
        }
    }
}
