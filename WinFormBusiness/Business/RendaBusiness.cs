using System;
using System.Collections.Generic;
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

        public List<Renda> GetAllRendaPorData(DateTime inicio, DateTime fim)
        {
            var listRenda = new List<Renda>();
            var table = _rendaRepository.GetAllRendaPorData(inicio, fim);
            foreach (DataRow row in table.Rows)
            {
                listRenda.Add(new Renda
                {
                    IdRenda = (Int64)row["IdRenda"],
                    ValorRenda = Convert.ToDouble(((double)row["ValorRenda"]).ToString("F2")),
                    TipoRenda = (string)row["TipoRenda"],
                    DataEntrada = Convert.ToDateTime((string)row["DataEntrada"])
                });
            }
            return listRenda;
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