using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        [Required]
        [StringLength(20)]
        public string Gender { get; set; }
        [Required]
        public int Age { get; set; }
        public string Role { get; set; } // admin, basic user
        [Required]
        public double Height { get; set; }
        [Required]
        public double Weight { get; set; }
        [Required]
        public int DailyCalorieGoal { get; set; }

        public ICollection<Workout> Workouts { get; set; } = new List<Workout>();
        public ICollection<Challenge> Challenges { get; set; } = new List<Challenge>();



    }
}
