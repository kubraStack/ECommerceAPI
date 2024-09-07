using Application.Features.Product.Command.AdminCommands.AddProductCommand;
using Application.Features.Product.Queries.AdminQueries.GetById;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Product.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<AddProductCommand, Domain.Entities.Product>();
            CreateMap<Domain.Entities.Product, GetProductByIdResponse>();
                  
        }
    }
}
