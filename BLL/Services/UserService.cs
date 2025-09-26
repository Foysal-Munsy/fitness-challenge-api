using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>().ReverseMap();
            });
            return new Mapper(config);
        }

        public static List<UserDTO> Get()
        {
            var data = DataAccessFactory.UserData().Get();
            return GetMapper().Map<List<UserDTO>>(data);
        }
        public static bool Create(UserDTO userDTO)
        {
            var user = GetMapper().Map<User>(userDTO);
            var data = DataAccessFactory.UserData().Create(user);

            return data;
            //return GetMapper().Map<bool>(data);
        }
    }
}
