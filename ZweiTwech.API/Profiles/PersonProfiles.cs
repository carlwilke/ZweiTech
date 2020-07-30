using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ZweiTwech.API.Dto;
using ZweiTwech.API.Models;

namespace ZweiTwech.API.Profiles
{
    public class PersonProfiles : Profile
    {
        public PersonProfiles()
        {
            CreateMap<Person, CreatePersonDto>();
            CreateMap<CreatePersonDto, Person>();
        }
    }
}
