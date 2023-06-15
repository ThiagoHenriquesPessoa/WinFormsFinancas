using System;
using System.Collections.Generic;
using WinFormDomain.Models;

namespace WinFormRepository.InterfaceRepository
{
    public interface IDespesaRepository
    {
        void InsertDespesa(Despesa despesa);

        List<double> GetValorDespesaAll();

        List<double> GetValorDespesaAnoAtualAll();

        List<double> GetValorDespesaMesAtualAll();

        List<Despesa> GetDespesaNaoPagasMesAtualAll();

        List<Despesa> GetAllDespesaPorData(DateTime inicail, DateTime fim);

        void UpdateDespesa(Despesa despesa);

        void DeleteDespesa(Int64 idDespesa);
    }
}