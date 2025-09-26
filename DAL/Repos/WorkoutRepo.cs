using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class WorkoutRepo : IWorkoutRepo
    {
        AppDbContext db = new AppDbContext();
        public List<Workout> Get()
        {
            return db.Workouts.ToList();
        }

       

    }
}
