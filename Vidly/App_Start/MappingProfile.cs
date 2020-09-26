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
            // Domain to DTO
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDTO>();
            Mapper.CreateMap<MembershipType, MembershipTypeDTO>();

            // DTO to Domain
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(customer => customer.Id, option => option.Ignore());           
            Mapper.CreateMap<MovieDTO, Movie>()
                .ForMember(movie => movie.Id, option => option.Ignore());
        }
    }
}