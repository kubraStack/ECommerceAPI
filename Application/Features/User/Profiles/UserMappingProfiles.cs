using Application.Features.User.Queries.GetByIdSelf;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.User.Profiles
{
    public class UserMappingProfiles :Profile
    {
        public UserMappingProfiles()
        {
            CreateMap<GetByIdUserSelfQuery, GetByIdUserSelfQueryResponse>().ReverseMap();
            CreateMap<Domain.Entities.User, GetByIdUserSelfQuery>().ReverseMap();
            CreateMap<Domain.Entities.User, GetByIdUserSelfQueryResponse>().ReverseMap();
        }
    }
}
