using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Database.Model
{
    internal class Attribute
    {
        public int AttributeID { get; set; }
        public int ArtefactID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Value { get; set; }
    }
}
