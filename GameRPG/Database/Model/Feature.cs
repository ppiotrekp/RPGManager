using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Database.Model
{
    internal class Feature
    {
        public int FeatureID { get; set; }
        public int ArtefactID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
    }
}
