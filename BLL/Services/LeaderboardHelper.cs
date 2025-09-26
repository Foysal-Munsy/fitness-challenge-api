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
    public class LeaderboardHelper
    {
       public static List<UserLeaderboardDTO> GetLeaderboard(List<User> users, List<Workout> workouts)
        {
            //var users = DataAccessFactory.UserData().Get();
            //var workouts = DataAccessFactory.WorkoutData().Get();

            var leaderboard = new List<UserLeaderboardDTO>();
            foreach (var user in users)
            {
                var userWorkouts = workouts.Where(w => w.UserId == user.Id);
                double totalCalories = 0;
                foreach (var workout in userWorkouts)
                {
                    totalCalories += workout.CaloriesBurned;
                }
                leaderboard.Add(new UserLeaderboardDTO
                {
                    UserId = user.Id,
                    Name = user.Name,
                    TotalCalories = totalCalories
                });
                
            }
            return leaderboard
                .OrderByDescending(x => x.TotalCalories)
                .ToList();
        }

    }
}
