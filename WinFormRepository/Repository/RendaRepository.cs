using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Threading.Tasks;
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
                    var sql = "INSERT INTO [Renda] ([ValorRenda] ,[TipoRenda] ,[ValorFixo] ,[DataEntrada]) VALUES  (@ValorRenda ,'@TipoRenda' ,@ValorFixo ,@DataEntrada);";
                    context.CommandText = sql;
                    context.Parameters.AddWithValue("@ValorRenda", renda.ValorRenda);
                    context.Parameters.AddWithValue("@TipoRenda", renda.TipoRenda);
                    context.Parameters.AddWithValue("@ValorFixo", renda.ValorFixo);
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
                    context.CommandText = "SELECT * FROM [Renda];";
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