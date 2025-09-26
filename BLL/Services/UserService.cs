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
        public static UserDTO GetById(int id)
        {
            var data = DataAccessFactory.UserData().GetById(id);
            return GetMapper().Map<UserDTO>(data);
        }
        public static bool Update(int id, UserDTO updatedUser)
        {
            var user = GetMapper().Map<User>(updatedUser);
            var data = DataAccessFactory.UserData().Update(id, user);
            return data;

        }
        public static bool Delete(int id)
        {
            var data = DataAccessFactory.UserData().Delete(id);
            return data;
        }
        public static UserDTO CalcBMI(int id)
        {
            var user = DataAccessFactory.UserData().GetById(id);
            if(user == null) return null;

            var dto = GetMapper().Map<UserDTO>(user);
            dto.BMI = BMIHelper.CalculateBMI(user.Height, user.Weight);
            return dto;
        }

        public static UserDTO GetRecommendation(int id)
        {
            var user = DataAccessFactory.UserData().GetById(id);
            if (user == null) return null;

            var dto = GetMapper().Map<UserDTO>(user);
            dto.BMI = BMIHelper.CalculateBMI(user.Height, user.Weight);
            dto.Recommendation = RecommendationHelper.GetRecommendation(dto.BMI);
            return dto;
        }

        public static List<UserLeaderboardDTO> GetLeaderboard()
        {
            var users = DataAccessFactory.UserData().Get();
            var workouts = DataAccessFactory.WorkoutData().Get();
            return LeaderboardHelper.GetLeaderboard(users,workouts);
        }
        public static UserGoalStatusDTO GetGoalStatus(int id)
        {
            var user = DataAccessFactory.UserData().GetById(id);
            if (user == null) return null;

            var workouts = DataAccessFactory.WorkoutData().Get();
            return GoalStatusHelper.GetGoalStatus(user, workouts);
        }

    }
}
