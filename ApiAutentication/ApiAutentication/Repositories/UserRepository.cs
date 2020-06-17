using ApiAutentication.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApiAutentication.Repositories
{
    public class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { UserName = "lacerda", Password = "lacerda", Role = "admin" });
            return users.Where(x => x.UserName.ToLower() == username.ToLower() && x.Password == password).FirstOrDefault();
        }
    }
}
