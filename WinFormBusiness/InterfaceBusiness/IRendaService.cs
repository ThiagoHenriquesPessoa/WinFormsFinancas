using WinFormDomain.Models;

namespace WinFormBusiness.InterfaceBusiness
{
    public interface IRendaService
    {
        void InsertRenda(Renda renda);
        double GetRendaTotal();
    }
}