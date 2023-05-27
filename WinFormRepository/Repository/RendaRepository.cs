using System;
using System.Data;
using System.Data.SQLite;
using WinFormDomain.Models;
using WinFormInfrastructure.Data;
using WinFormRepository.InterfaceRepository;

namespace WinFormRepository.Repository
{
    public class RendaRepository : IRendaRepository
    {
        public void InsertRenda(Renda renda)
        {
            try
            {
                using (var context = WinFormDbContext.DbConnection().CreateCommand())
                {
                    var sql = "INSERT INTO [Renda] ([ValorRenda] ,[TipoRenda] ,[DataEntrada]) VALUES  (@ValorRenda, @TipoRenda, @DataEntrada);";
                    context.CommandText = sql;
                    context.Parameters.AddWithValue("@ValorRenda", renda.ValorRenda);
                    context.Parameters.AddWithValue("@TipoRenda", renda.TipoRenda);
                    context.Parameters.AddWithValue("@DataEntrada", renda.DataEntrada);
                    context.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetRendaAll()
        {
            SQLiteDataAdapter adapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                using (var context = WinFormDbContext.DbConnection().CreateCommand())
                {
                    context.CommandText = "SELECT ValorRenda FROM [Renda];";
                    adapter = new SQLiteDataAdapter(context.CommandText, WinFormDbContext.DbConnection());
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}