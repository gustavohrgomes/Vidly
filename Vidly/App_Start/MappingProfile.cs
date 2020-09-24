using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>()
                .ForMember(customer => customer.Id, option => option.Ignore());
            Mapper.CreateMap<CustomerDto, Customer>();

            Mapper.CreateMap<Movie, MovieDTO>()
                .ForMember(movie => movie.Id, option => option.Ignore());
            Mapper.CreateMap<MovieDTO, Movie>();
        }
    }
}