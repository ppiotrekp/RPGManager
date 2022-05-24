using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameRPG.Database.Model;

namespace GameRPG.Database
{
    public class DbManager
    {
        public static void AddUser(string username, string password)
        {
            using (var ctx = new GameContext.GameContext())
            {
                var user = new User
                {
                    Name = username,
                    Credentails = 4,
                    Password = password
                };
                ctx.Users.Add(user);
                ctx.SaveChanges();
            }
        }

        public static bool AuthenticateUser(string username, string password)
        {
            using (var ctx = new GameContext.GameContext())
            {
                foreach (User user in ctx.Users)
                {
                    if (user.Name.Equals(username) & user.Password.Equals(password))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public static int GetUserID(string username, string password)
        {
            using (var ctx = new GameContext.GameContext())
            {
                foreach (User user in ctx.Users)
                {
                    if (user.Name.Equals(username) & user.Password.Equals(password))
                    {
                        return user.ID;
                    }
                }
                return 0;
            }
        }

        public static int GetCategoryId(string name)
        {
            using (var ctx = new GameContext.GameContext())
            {
                foreach (Category c in ctx.Categories)
                {
                    if (c.Name.Equals(name))
                    {
                        return c.CategoryID;
                    }
                }
                return 0;
            }
        }

        public static int GetArtefactId(string name)
        {
            using (var ctx = new GameContext.GameContext())
            {
                foreach (Artefact a in ctx.Artefacts)
                {
                    if (a.Name.Equals(name))
                    {
                        return a.ArtefactID;
                    }
                }
                return 0;
            }
        }

        public static void AddCategory(string Name, int UserId, List<string> atributes, List<string> atributestypes)
        {
            using (var ctx = new GameContext.GameContext())
            {
                var category = new Category
                {
                    Name = Name,
                    UserID = UserId
                };

                ctx.Categories.Add(category);
                ctx.SaveChanges();

                int id = 0;
                foreach (var cat in ctx.Categories)
                {
                    if (cat.Name == Name)
                    {
                        id = cat.CategoryID;
                    }
                }

                for (int i = 0; i < atributes.Count; i++)
                {
                    var atr = new DefaultAtribute
                    {
                        Name = atributes[i],
                        Type = atributestypes[i],
                        CategoryID = id
                    };
                    ctx.DefaultAtributes.Add(atr);
                }
                ctx.SaveChanges();
            }
        }

        public static List<string> getArtefactsFromParticularCategory()
        {
            List<string> categories = new List<string>();
            using (var ctx = new GameContext.GameContext())
            {
                foreach (var cat in ctx.Categories)
                {
                    categories.Add(cat.Name);
                }
            }
            return categories;

        }

        public static List<string> GetCategories()
        {
            List<string> categories = new List<string>();
            using (var ctx = new GameContext.GameContext())
            {
                foreach (var cat in ctx.Categories)
                {
                    categories.Add(cat.Name);
                }
            }
            return categories;
        }

        public static List<string> GetDefaultAtributes(string category)
        {
            List<string> atrs = new List<string>();
            using (var ctx = new GameContext.GameContext())
            {
                foreach (var d in ctx.DefaultAtributes)
                {
                    atrs.Add(d.Name);
                }
            }
            return atrs;
        }

        public static void AddFeatures(List<string> Names, List<string> Types, List<string> Values, string artifactname, int categoryid, int userid)
        {
            using (var ctx = new GameContext.GameContext())
            {
                var art = new Artefact
                {
                    Name = artifactname,
                    UserID = userid,
                    CategoryID = categoryid
                };
                ctx.Artefacts.Add(art);
                ctx.SaveChanges();

                int artifactid = GetArtefactId(artifactname);
                for (int i = 0; i < Names.Count; i++)
                {
                    var feature = new Feature
                    {
                        ArtefactID = artifactid,
                        Name = Names[i],
                        Type = Types[i],
                        Value = Values[i]
                    };
                    ctx.Features.Add(feature);
                }
                ctx.SaveChanges();
            }
        }

        public static List<string> GetArtefacts()
        {
            List<string> artefacts = new List<string>();
            using (var ctx = new GameContext.GameContext())
            {
                foreach (var art in ctx.Artefacts)
                {
                    artefacts.Add(art.Name);
                }
            }
            return artefacts;
        }
    }
}
