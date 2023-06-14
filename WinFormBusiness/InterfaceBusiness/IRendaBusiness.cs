using System;
using System.Collections.Generic;
using WinFormDomain.Models;

namespace WinFormBusiness.InterfaceBusiness
{
    public interface IRendaBusiness
    {
        int InsertRenda(Renda renda);

        double GetRendaTotal();

        List<Renda> GetAllRendaPorData(DateTime inicio, DateTime fim);

        void UpdateRenda(Renda renda);
    }
}