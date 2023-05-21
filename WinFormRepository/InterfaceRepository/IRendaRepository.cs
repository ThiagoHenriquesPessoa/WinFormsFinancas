using System.Data;
using WinFormDomain.Models;

namespace WinFormRepository.InterfaceRepository
{
    public interface IRendaRepository
    {
        void InsertRenda(Renda renda);
        DataTable GetRendaAll();
    }
}