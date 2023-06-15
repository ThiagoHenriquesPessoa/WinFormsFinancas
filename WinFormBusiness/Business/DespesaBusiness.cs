using System;
using System.Collections.Generic;
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
            Int64 parcelas = despesa.QuantidadeParcelas;
            double valor = despesa.ValorDespesa / parcelas;
            despesa.ValorDespesa = valor;
            for (int i = 1; i <= parcelas; i++)
            {
                despesa.DataVencimentoDespesa = i == 1 ? despesa.DataVencimentoDespesa : despesa.DataVencimentoDespesa.AddMonths(1);
                despesa.ParcelaAtual = i;
                _despesaRepository.InsertDespesa(despesa);
            }
        }

        public double GetDespesaTotal()
        {
            double valorTotal = 0;
            var listValores = _despesaRepository.GetValorDespesaAll();
            foreach (var valor in listValores)
            {
                valorTotal += valor;
            }
            return valorTotal;
        }

        public double GetDespesaAnoAtualAll()
        {
            double valorTotal = 0;
            var listValores = _despesaRepository.GetValorDespesaAnoAtualAll();
            foreach (var valor in listValores)
            {
                valorTotal += valor;
            }
            return valorTotal;
        }

        public double GetDespesaMesAtualAll()
        {
            double valorTotal = 0;
            var listValores = _despesaRepository.GetValorDespesaMesAtualAll();
            foreach (var valor in listValores)
            {
                valorTotal += valor;
            }
            return valorTotal;
        }

        public DataTable GetDespesaNaoPagasMesAtualAll()
        {
            var listDespesas = _despesaRepository.GetDespesaNaoPagasMesAtualAll();
            DataTable dt = new DataTable();
            dt.Columns.Add("IdDespesa", typeof(Int64));
            dt.Columns.Add("Tipo de despesa", typeof(string));
            dt.Columns.Add("Valor da despesa", typeof(string));
            dt.Columns.Add("Formato usado", typeof(string));
            foreach (var despesa in listDespesas)
            {
                if (despesa.DespesaPaga == false)
                {
                    dt.Rows.Add(
                        despesa.IdDespesa,
                        despesa.TipoDespesa,
                        despesa.ValorDespesa.ToString("C"),
                        despesa.FormaPagamento);
                }
            }
            return dt;
        }

        public List<Despesa> GetAllDespesaPorData(DateTime inicio, DateTime fim)
        {
            return _despesaRepository.GetAllDespesaPorData(inicio, fim);
        }

        public void UpdateDespesa(Despesa despesa)
        {
            _despesaRepository.UpdateDespesa(despesa);
        }

        public void DeleteDespesa(Int64 idDespesa)
        {
            _despesaRepository.DeleteDespesa(idDespesa);
        }
    }
}