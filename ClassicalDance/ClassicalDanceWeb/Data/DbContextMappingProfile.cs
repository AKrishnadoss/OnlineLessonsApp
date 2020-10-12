using AutoMapper;
using ClassicalDanceWeb.Data.Entities;
using ClassicalDanceWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassicalDanceWeb.Data
{
    public class DbContextMappingProfile : Profile
    {
        public DbContextMappingProfile()
        {
            CreateMap<Student, StudentViewModel>().ReverseMap();
        }
    }
}
