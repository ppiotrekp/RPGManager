using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Database.Model
{
    internal class Artefact
    {
        public int ArtefactID { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Feature> Features { get; set; }
    }
}
