using System.Data;
using WinFormBusiness.InterfaceBusiness;
using WinFormDomain.Models;
using WinFormRepository.InterfaceRepository;

namespace WinFormBusiness.Business
{
    public class DespesaBusiness : IDespesaBusiness
    {
        private readonly IDespesaRepository _despesaRepository;

        public DespesaBusiness(IDespesaRepository despesaRepository)
        {
            _despesaRepository = despesaRepository;
        }

        public void InsertDespesa(Despesa despesa)
        {
            if (despesa.ValorDespesa > 0)
            {
                _despesaRepository.InsertDespesa(despesa);
            }            
        }

        public double GetDespesaTotal()
        {
            double valorTotal = 0;
            var table = _despesaRepository.GetValorDespesaAll();
            foreach (DataRow row in table.Rows)
            {
                valorTotal += (double)row["ValorDespesa"];
            }
            return valorTotal;
        }
    }
}