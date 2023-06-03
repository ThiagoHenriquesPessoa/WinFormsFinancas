using System;
using System.Data;
using WinFormDomain.Models;

namespace WinFormRepository.InterfaceRepository
{
    public interface IDespesaRepository
    {
        void InsertDespesa(Despesa despesa);
        DataTable GetValorDespesaAll();
        DataTable GetValorDespesaAnoAtualAll();
        DataTable GetValorDespesaMesAtualAll();
        DataTable GetDespesaNaoPagasMesAtualAll();
        DataTable GetAllDespesaPorData(DateTime inicail, DateTime fim);
    }
}