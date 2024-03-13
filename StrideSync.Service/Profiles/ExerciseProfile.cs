using AutoMapper;
using StrideSync.Data.Entities;
using StrideSync.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrideSync.Service.Profiles
{
    internal class ExerciseProfile : Profile
    {
        public ExerciseProfile()
        {
            CreateMap<Run, ExerciseCreateEditDTO>()
                .ReverseMap();

            CreateMap<Exercise, ExerciseDTO>()
                    .ReverseMap();
        }
    }
}
