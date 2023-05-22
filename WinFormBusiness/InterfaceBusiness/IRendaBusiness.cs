using WinFormDomain.Models;

namespace WinFormBusiness.InterfaceBusiness
{
    public interface IRendaBusiness
    {
        void InsertRenda(Renda renda);
        double GetRendaTotal();
    }
}