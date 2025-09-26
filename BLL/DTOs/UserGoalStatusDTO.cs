using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class UserGoalStatusDTO
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int DailyCalorieGoal { get; set; }
        public double TotalCaloriesBurned { get; set; }
        public string GoalStatus { get; set; }
    }
}
