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

        DataTable GetRendaAnoAtualall();

        DataTable GetRendaMesAtualAll();

        void UpdateRenda(Renda renda);

        void DeleteRenda(Int64 idRenda);
    }
}