using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameRPG.Database.Model;
using System.Data.Entity;

namespace GameRPG.Database.GameContext
{
    internal class GameContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Artefact> Artefacts { get; set; }
        public virtual DbSet<Model.Attribute> Attributes { get; set; }

        public GameContext() : base("MyConnectionString")
        {
        }

    }
}
