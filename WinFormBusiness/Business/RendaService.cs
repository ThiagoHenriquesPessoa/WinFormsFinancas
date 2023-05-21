using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using WinFormBusiness.InterfaceBusiness;
using WinFormDomain.Models;
using WinFormRepository.InterfaceRepository;

namespace WinFormBusiness.Business
{
    public class RendaService : IRendaService
    {
        private readonly IRendaRepository _rendaRepository;

        public RendaService(IRendaRepository rendaRepository)
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
            var table = _rendaRepository.GetRendaAll();
            foreach (DataRow row in table.Rows)
            {
                valorTotal += (double)row["ValorRenda"];
            }
            return valorTotal;
        }

        private Renda PreparaRenda(DataRow row)
        {
            var idRenda = (int)row["IdRenda"];
            var valorRenda = (double)row["ValorRenda"];
            var tipoRenda = (string)row["TipoRenda"];
            var valorFixo = (bool)row["ValorFixo"];
            var dataEntrada = (DateTime)row["DataEntrada"];
            var renda = new Renda { IdRenda = idRenda, ValorRenda = valorRenda, TipoRenda = tipoRenda, ValorFixo = valorFixo, DataEntrada = dataEntrada };
            return renda;
        }
    }
}