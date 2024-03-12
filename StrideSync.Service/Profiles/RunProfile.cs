using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using StrideSync.Data.Entities;
using StrideSync.Service.DTOs;

namespace StrideSync.Service.Profiles
{
    public class RunProfile : Profile
    {
        public RunProfile()
        {
            CreateMap<Run, RunCreateEditDTO>()
                .ReverseMap();

            CreateMap<Run, RunDTO>()
                    .ReverseMap();
        } 
    }
}
