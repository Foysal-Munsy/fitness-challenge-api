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
    public class WorkoutService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Workout, WorkoutDTO>().ReverseMap();
            });
            return new Mapper(config);
        }

        public static List<WorkoutDTO> Get()
        {
            var data = DataAccessFactory.WorkoutData().Get();
            return GetMapper().Map<List<WorkoutDTO>>(data);
        }
    }
}
