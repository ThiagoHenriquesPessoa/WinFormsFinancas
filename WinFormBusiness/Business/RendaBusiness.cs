using System;
using System.Collections.Generic;
using WinFormBusiness.InterfaceBusiness;
using WinFormDomain.Models;
using WinFormRepository.InterfaceRepository;

namespace WinFormBusiness.Business
{
    public class RendaBusiness : IRendaBusiness
    {
        private readonly IRendaRepository _rendaRepository;

        public RendaBusiness(IRendaRepository rendaRepository)
        {
            _rendaRepository = rendaRepository;
        }

        public void InsertRenda(Renda renda)
        {
            _rendaRepository.InsertRenda(renda);
        }

        public double GetRendaTotal()
        {
            double valorTotal = 0;
            var listaValores = _rendaRepository.GetRendaAll();
            foreach (var valor in listaValores)
            {
                valorTotal += valor;
            }
            return valorTotal;
        }

        public List<Renda> GetAllRendaPorData(DateTime inicio, DateTime fim)
        {
            return _rendaRepository.GetAllRendaPorData(inicio, fim);
        }

        public double GetRendaAnoAtualall()
        {
            double valorTotal = 0;
            var listaValores = _rendaRepository.GetRendaAnoAtualall();
            foreach (var valor in listaValores)
            {
                valorTotal += valor;
            }
            return valorTotal;
        }

        public double GetRendaMesAtualAll()
        {
            double valorTotal = 0;
            var listaValores = _rendaRepository.GetRendaMesAtualAll();
            foreach (var valor in listaValores)
            {
                valorTotal += valor;
            }
            return valorTotal;
        }

        public void UpdateRenda(Renda renda)
        {
            _rendaRepository.UpdateRenda(renda);
        }

        public void DeleteRenda(Int64 idRenda)
        {
            _rendaRepository.DeleteRenda(idRenda);
        }
    }
}