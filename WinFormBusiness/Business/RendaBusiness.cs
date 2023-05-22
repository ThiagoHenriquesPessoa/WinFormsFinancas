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

        public void InsertRenda(Renda renda)
        {
            if (renda.ValorRenda > 0) 
            {
                _rendaRepository.InsertRenda(renda);
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