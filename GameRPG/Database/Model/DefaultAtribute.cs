using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Database.Model
{
    internal class DefaultAtribute
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }
}
