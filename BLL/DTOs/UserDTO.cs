using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class UserDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string Gender { get; set; }
        public int Age { get; set; }
        public string Role { get; set; } // admin, basic user
        public double Height { get; set; }
        public double Weight { get; set; }
        public int DailyCalorieGoal { get; set; }

        //public ICollection<Workout> Workouts { get; set; } = new List<Workout>();
        //public ICollection<Challenge> Challenges { get; set; } = new List<Challenge>();
    }
}
