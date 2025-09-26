using BLL.DTOs;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class GoalStatusHelper
    {
        public static UserGoalStatusDTO GetGoalStatus(User user, List<Workout> workouts)
        {
            var userWorkouts = workouts.Where(w => w.UserId == user.Id);
            double totalCalories = userWorkouts.Sum(w => w.CaloriesBurned);

            return new UserGoalStatusDTO
            {
                UserId = user.Id,
                Name = user.Name,
                DailyCalorieGoal = user.DailyCalorieGoal,
                TotalCaloriesBurned = totalCalories,
                GoalStatus = totalCalories >= user.DailyCalorieGoal ? "Achieved" : "Not Achieved"
            };
        }

    }
}
