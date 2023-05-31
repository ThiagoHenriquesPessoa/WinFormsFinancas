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
    }
}