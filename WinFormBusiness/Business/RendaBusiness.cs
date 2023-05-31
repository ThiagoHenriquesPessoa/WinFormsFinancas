using System;
using System.Data;
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

        public int InsertRenda(Renda renda)
        {
            if (renda.ValorRenda > 0) 
            {
                return _rendaRepository.InsertRenda(renda);               
            }
            else
            {
               return 0;
            }
        }

        public double GetRendaTotal()
        {
            double valorTotal = 0;
            var table = _rendaRepository.GetRendaAll();
            foreach (DataRow row in table.Rows)
            {
                valorTotal += (double)row["ValorRenda"];
            }
            return valorTotal;
        }
    }
}