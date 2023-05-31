using System.Data;
using WinFormDomain.Models;

namespace WinFormRepository.InterfaceRepository
{
    public interface IRendaRepository
    {
        int InsertRenda(Renda renda);
        DataTable GetRendaAll();
    }
}