using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUserRepo
    {
        bool Create(User user);
        List<User> Get();
        User GetById(int id);
        bool Update(int id, User user);
        bool Delete(int id);


        
    }
}
