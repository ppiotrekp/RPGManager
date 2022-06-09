using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Database.Model
{
    internal class Category
    {
        public int CategoryID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Artefact> Artefacts { get; set; }
    }
}
