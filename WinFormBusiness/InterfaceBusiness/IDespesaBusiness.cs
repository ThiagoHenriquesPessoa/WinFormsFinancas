using System.Collections.Generic;
using System.Data;
using WinFormDomain.Models;

namespace WinFormBusiness.InterfaceBusiness
{
    public interface IDespesaBusiness
    {
        void InsertDespesa(Despesa despesa);
        double GetDespesaTotal();
        double GetDespesaAnoAtualAll();
        double GetDespesaMesAtualAll();
        DataTable GetDespesaNaoPagasMesAtualAll();
    }
}