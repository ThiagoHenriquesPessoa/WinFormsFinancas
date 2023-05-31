using WinFormDomain.Models;

namespace WinFormBusiness.InterfaceBusiness
{
    public interface IRendaBusiness
    {
        int InsertRenda(Renda renda);
        double GetRendaTotal();
    }
}