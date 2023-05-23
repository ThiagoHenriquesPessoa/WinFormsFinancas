using WinFormDomain.Models;

namespace WinFormBusiness.InterfaceBusiness
{
    public interface IDespesaBusiness
    {
        void InsertDespesa(Despesa despesa);
        double GetDespesaTotal();
        double GetDespesaAnoAtualAll();
    }
}