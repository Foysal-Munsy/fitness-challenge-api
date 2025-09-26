using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class UserLeaderboardDTO
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public double TotalCalories { get; set; }
    }
}
