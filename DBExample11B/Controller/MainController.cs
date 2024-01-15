using DBExample11B.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBExample11B.Controller
{
    internal class MainController
    {
        public bool CheckLogin(string userName, string password)
        {
            using (ExampleDBEntities db = new ExampleDBEntities())
            {
                List<User> users = db.User.ToList();
                return users.Where(u => u.UserName == userName && 
                u.Password == password).Any();
            }
        }
    }
}
