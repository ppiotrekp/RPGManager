using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Database.Model
{
    internal class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Privileges { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
