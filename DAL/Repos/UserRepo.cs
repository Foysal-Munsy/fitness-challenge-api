using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserRepo : IUserRepo
    {
        AppDbContext db = new AppDbContext();
        public bool Create(User user)
        {
            db.Users.Add(user);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var user = GetById(id);
            if (user != null)
            {
                db.Users.Remove(user);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User GetById(int id)
        {
            return db.Users.Find(id);
        }

        public bool Update(int id, User updatedUser)
        {
            var existingUser = db.Users.Find(id);
            if (existingUser == null)
                return false;

            db.Entry(existingUser).CurrentValues.SetValues(updatedUser);
            return db.SaveChanges() > 0;
        }
    }
}
