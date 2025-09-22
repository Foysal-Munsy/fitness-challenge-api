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
        [Required, StringLength(50)]
        public string Email { get; set; }
        [Required, StringLength(50)]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public int? Age {  get; set; }
        public float? Weight { get; set; }
        public float? Height { get; set; }
        [Required, StringLength(50)]
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
       
        

    }
}
