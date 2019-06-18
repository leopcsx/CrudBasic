using AutoMapper;
using CRUDBasic.Application.ViewModel;
using CRUDBasic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBasic.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Colaborador, ColaboradorViewModel>();            
        }

        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
    }
}
