using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class WorkoutDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Type { get; set; } //running, cycling
        public int DurationMinutes { get; set; }
        public int CaloriesBurned { get; set; }
        public DateTime Date { get; set; }
    }
}
