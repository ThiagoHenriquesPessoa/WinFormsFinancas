using System;
using System.Data.SQLite;
using System.Data;
using WinFormDomain.Models;
using WinFormInfrastructure.Data;
using WinFormRepository.InterfaceRepository;

namespace WinFormRepository.Repository
{
    public class DespesaRepository : IDespesaRepository
    {
        public void InsertDespesa(Despesa despesa)
        {
            try
            {
                using (var context = WinFormDbContext.DbConnection().CreateCommand())
                {
                    var sql = "INSERT INTO [Despesa] ([ValorDespesa], [TipoDespesa], [QuantidadeParcelas], [DataCriacaoDespesa], [DespesaPaga], [FormaPagamento]) VALUES  (@ValorDespesa, '@TipoDespesa', @QuantidadeParcelas, @DataCriacaoDespesa, @DespesaPaga, @FormaPagamento);";
                    context.CommandText = sql;
                    context.Parameters.AddWithValue("@ValorDespesa", despesa.ValorDespesa);
                    context.Parameters.AddWithValue("@TipoDespesa", despesa.TipoDespesa);   
                    context.Parameters.AddWithValue("@QuantidadeParcelas", despesa.QuantidadeParcelas);
                    context.Parameters.AddWithValue("@DataCriacaoDespesa", despesa.DataCriacaoDespesa);
                    context.Parameters.AddWithValue("@DespesaPaga", despesa.DespesaPaga);
                    context.Parameters.AddWithValue("@FormaPagamento", despesa.FormaPagamento);
                    context.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetValorDespesaAll()
        {
            SQLiteDataAdapter adapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                using (var context = WinFormDbContext.DbConnection().CreateCommand())
                {
                    context.CommandText = "SELECT ValorDespesa FROM [Despesa];";
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