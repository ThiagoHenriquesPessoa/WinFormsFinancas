using System.Collections.Generic;
using System;
using System.Data;
using WinFormDomain.Models;

namespace WinFormBusiness.InterfaceBusiness
{
    public interface IDespesaBusiness
    {
        int InsertDespesa(Despesa despesa);

        double GetDespesaTotal();

        double GetDespesaAnoAtualAll();

        double GetDespesaMesAtualAll();

        DataTable GetDespesaNaoPagasMesAtualAll();
        List<Despesa> GetAllDespesaPorData(DateTime inicio, DateTime fim);
        void UpdateDespesa(Despesa despesa);
        void DeleteDespesa(Int64 idDespesa);
    }
}