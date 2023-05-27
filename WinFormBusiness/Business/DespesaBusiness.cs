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
                int parcelas = despesa.QuantidadeParcelas;
                double valor = despesa.ValorDespesa / parcelas;
                despesa.ValorDespesa = valor;
                for (int i=1; i <= parcelas; i++)
                {
                    despesa.DataCriacaoDespesa = i == 1 ? despesa.DataCriacaoDespesa : despesa.DataCriacaoDespesa.AddMonths(1);
                    despesa.QuantidadeParcelas = i;                    
                    _despesaRepository.InsertDespesa(despesa);
                }                
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

        public double GetDespesaAnoAtualAll()
        {
            double valorTotal = 0;
            var table = _despesaRepository.GetValorDespesaAnoAtualAll();
            foreach (DataRow row in table.Rows)
            {

                valorTotal += (double)row["ValorDespesa"];
            }
            return valorTotal;
        }

        public double GetDespesaMesAtualAll()
        {
            double valorTotal = 0;
            var table = _despesaRepository.GetValorDespesaMesAtualAll();
            foreach (DataRow row in table.Rows)
            {

                valorTotal += (double)row["ValorDespesa"];
            }
            return valorTotal;
        }
    }
}