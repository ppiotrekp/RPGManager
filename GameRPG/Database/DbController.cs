using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GameRPG.Database.Model;
using Attribute = GameRPG.Database.Model.Attribute;

namespace GameRPG.Database
{
    public class DbController
    {
        public static void AddUser(string username, string password, int priv)
        {
            using (var ctx = new GameContext.GameContext())
            {
                var user = new User
                {
                    Name = username,
                    Privileges = priv,
                    Password = password
                };
                ctx.Users.Add(user);
                ctx.SaveChanges();
            }
        }

        public static bool CheckUser(string username, string password)
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

        public static int GetUserID(string username)
        {
            using (var ctx = new GameContext.GameContext())
            {
                foreach (User user in ctx.Users)
                {
                    if (user.Name.Equals(username))
                    {
                        return user.ID;
                    }
                }
                return 0;
            }
        }

        public static int GetUserIdByPriv(int priv)
        {
            using (var ctx = new GameContext.GameContext())
            {
                foreach (User user in ctx.Users)
                {
                    if (user.Privileges.Equals(priv))
                    {
                        return user.Privileges;
                    }
                }
                return 0;
            }
        }

        public static int GetUserPriv(string username, string password)
        {
            using (var ctx = new GameContext.GameContext())
            {
                foreach (User user in ctx.Users)
                {
                    if (user.Name.Equals(username) & user.Password.Equals(password))
                    {
                        return user.Privileges;
                    }
                }
                return 0;
            }
        }

        public static int GetUserPriv(string username)
        {
            using (var ctx = new GameContext.GameContext())
            {
                foreach (User user in ctx.Users)
                {
                    if (user.Name.Equals(username))
                    {
                        return user.Privileges;
                    }
                }
                return 0;
            }
        }

        public static List<string> GetUsernames()
        {
            List<string> usernames = new List<string>();
            using (var ctx = new GameContext.GameContext())
            {
                foreach (var us in ctx.Users)
                {   
                    usernames.Add(us.Name);
                }
            }
            return usernames;
        }

        public static List<int> GetPriviliges()
        {
            List<int> priviliges = new List<int>();
            using (var ctx = new GameContext.GameContext())
            {
                foreach (var us in ctx.Users)
                {
                    if (!priviliges.Contains(us.Privileges))
                    {
                        priviliges.Add(us.Privileges);
                    }
                }
            }
            return priviliges;
        }

        public static void ChangePassword(string username, string newpassword)
        {
            using (var ctx = new GameContext.GameContext())
            {
                var result = ctx.Users.SingleOrDefault(b => b.Name == username);
                if (result != null)
                {
                    result.Password = newpassword;
                    ctx.SaveChanges();
                }
            }
        }

        public static void ChangeUserPriv(string username, int newpriv)
        {
            using (var ctx = new GameContext.GameContext())
            {
                var result = ctx.Users.SingleOrDefault(b => b.Name == username);
                if (result != null)
                {
                    result.Privileges = newpriv;
                    ctx.SaveChanges();
                }
            }
        }
        public static void AddCategory(string Name, int UserId)
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

                ctx.SaveChanges();
            }
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

        public static List<string> GetUserCategories(int id)
        {
            List<string> categories = new List<string>();
            using (var ctx = new GameContext.GameContext())
            {
                foreach (var cat in ctx.Categories)
                {
                    if (cat.UserID.Equals(id))
                    {
                        categories.Add(cat.Name);
                    }

                }
            }
            return categories;
        }

        public static void EditCategory(string oldName, string newName)
        {
            int id = GetCategoryId(oldName);
            using (var ctx = new GameContext.GameContext())
            {
                var result = ctx.Categories.SingleOrDefault(b => b.CategoryID == id);
                if (result != null)
                {
                    result.Name = newName;
                    ctx.SaveChanges();
                }
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

        public static void EditArtefact(string oldName, string newName)
        {
            int id = GetArtefactId(oldName);
            using (var ctx = new GameContext.GameContext())
            {
                var result = ctx.Artefacts.SingleOrDefault(b => b.ArtefactID == id);
                if (result != null)
                {
                    result.Name = newName;
                    ctx.SaveChanges();
                }
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

        public static List<int> GetArtefactIdsByCategoryId(int id)
        {
            List<int> idList = new List<int>();
            using (var ctx = new GameContext.GameContext())
            {
                foreach (Category c in ctx.Categories)
                {
                    if (c.CategoryID.Equals(id))
                    {
                        foreach (Artefact a in ctx.Artefacts)
                        {
                            idList.Add(a.ArtefactID);
                        }
                    }
                }
                return idList;
            }
        }

        public static List<string> GetUserArtefacts(int id)
        {
            List<string> artefacts = new List<string>();
            using (var ctx = new GameContext.GameContext())
            {
                foreach (var art in ctx.Artefacts)
                {
                    if (art.UserID.Equals(id))
                    {
                        artefacts.Add(art.Name);
                    }

                }
            }
            return artefacts;
        }   

        public static void AddAttributes(List<string> Names, List<string> Types, List<int> Values, string artifactname, int categoryid, int userid)
        {
            using (var ctx = new GameContext.GameContext())
            {
                var art = new Artefact
                {
                    Name = artifactname,
                    UserID = userid,
                    CategoryID = categoryid,
                    AddData = DateTime.Now
                };
                ctx.Artefacts.Add(art);
                ctx.SaveChanges();

                int artifactid = GetArtefactId(artifactname);
                for (int i = 0; i < Names.Count; i++)
                {
                    var feature = new Model.Attribute
                    {
                        ArtefactID = artifactid,
                        Name = Names[i],
                        Type = Types[i],
                        Value = Values[i],
                        
                    };
                    ctx.Attributes.Add(feature);
                }
                ctx.SaveChanges();
            }
        }
            
        public static int GetMaxValue()
        {
            List<int> attributes = new List<int>();
            using (var ctx = new GameContext.GameContext())
            {
                foreach (var atr in ctx.Attributes)
                {
                    attributes.Add(atr.Value);
                }
            }
            return attributes.Max(); 
        }

        public static int GetAttributeId(int artefactid)
        {   using (var ctx = new GameContext.GameContext())
            {
                foreach (Attribute a in ctx.Attributes)
                {
                    if (a.ArtefactID.Equals(artefactid))
                    {
                        return a.AttributeID;
                    }
                }
                return 0;
            }
        }

        public static int GetAttributeValue(int attributeid)
        {
            using (var ctx = new GameContext.GameContext())
            {
                foreach (Attribute a in ctx.Attributes)
                {
                    if (a.AttributeID.Equals(attributeid))
                    {
                        return a.Value;
                    }
                }
                return 0;
            }
        }

        public static string GetAttributeName(int artefactid)
        {
            using (var ctx = new GameContext.GameContext())
            {
                foreach (Attribute a in ctx.Attributes)
                {
                    if (a.ArtefactID.Equals(artefactid))
                    {
                        return a.Name;
                    }
                }
                return "a";
            }
        }

        public static void EditAttribute(string artefactName, int newvalue)
        {
            int id = GetAttributeId(GetArtefactId(artefactName));
            using (var ctx = new GameContext.GameContext())
            {
                var result = ctx.Attributes.SingleOrDefault(a => a.AttributeID == id);
                if (result != null)
                {
                    result.Value = newvalue;
                    ctx.SaveChanges();
                }
            }
        }

        public static void RemoveArtefact(int id)
        {
            using (var ctx = new GameContext.GameContext())
            {
                var atr = ctx.Attributes.SingleOrDefault(i => i.ArtefactID == id);
                while (atr != null)
                {
                    if (atr != null)
                    {
                        ctx.Attributes.Remove(atr);
                        ctx.SaveChanges();
                    }
                    atr = ctx.Attributes.SingleOrDefault(i => i.ArtefactID == id);
                }
                
                var art = ctx.Artefacts.SingleOrDefault(i => i.ArtefactID == id);

                if (art != null)
                {
                    ctx.Artefacts.Remove(art);
                    ctx.SaveChanges();
                }
            }
        }

        public static void RemoveCategory(int categoryid)
        {
            using (var ctx = new GameContext.GameContext())
            {
                ctx.Artefacts.RemoveRange(ctx.Artefacts.Where(x => x.CategoryID == categoryid));
                ctx.Categories.RemoveRange(ctx.Categories.Where(x => x.CategoryID == categoryid));
                ctx.SaveChanges();
            }
        }

        public static void RemoveUser(int id)
        {
            using (var ctx = new GameContext.GameContext())
            {
               
                ctx.Artefacts.RemoveRange(ctx.Artefacts.Where(x => x.UserID == id));
                ctx.Categories.RemoveRange(ctx.Categories.Where(x => x.UserID == id));
                ctx.Users.RemoveRange(ctx.Users.Where(x => x.ID == id));
                ctx.SaveChanges();
            }
        }

        public static void RemoveUsersByPriviliges(int priv)
        {
            using (var ctx = new GameContext.GameContext())
            {
                int id = GetUserIdByPriv(priv);
                ctx.Artefacts.RemoveRange(ctx.Artefacts.Where(x => x.UserID == id));
                ctx.Categories.RemoveRange(ctx.Categories.Where(x => x.UserID == id));
                ctx.Users.RemoveRange(ctx.Users.Where(x => x.Privileges == priv));
                ctx.SaveChanges();
            }
        }

        public static string getHash(string text)
        {
            var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
            return BitConverter.ToString(bytes).Replace("-", "").ToLower();
        }
    }
}
