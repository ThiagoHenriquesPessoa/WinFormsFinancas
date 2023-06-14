using System;
using System.Data;
using WinFormDomain.Models;

namespace WinFormRepository.InterfaceRepository
{
    public interface IRendaRepository
    {
        int InsertRenda(Renda renda);
        DataTable GetRendaAll();
        DataTable GetAllRendaPorData(DateTime inicail, DateTime fim);
        void UpdateRenda(Renda renda);
    }
}