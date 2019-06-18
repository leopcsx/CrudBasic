using AutoMapper;
using CRUDBasic.Application.Interface;
using CRUDBasic.Application.ViewModel;
using CRUDBasic.Domain.Entities;
using CRUDBasic.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBasic.Application.Services
{
    public class ColaboradorAppService : IColaboradorAppService
    {
        private readonly IColaboradorRepository _colaboradorRepository;

        public ColaboradorAppService(IColaboradorRepository colaboradorRepository)
        {   
            _colaboradorRepository = colaboradorRepository;
        }

        public void Add(ColaboradorViewModel obj)
        {
            var colaborador = Mapper.Map<Colaborador>(obj);
            _colaboradorRepository.Add(colaborador);
        }

        public IEnumerable<ColaboradorViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Colaborador>, IEnumerable<ColaboradorViewModel>>(_colaboradorRepository.GetAll());
        }
    }
}
