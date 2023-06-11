﻿using System;
using System.Data;
using System.Data.SQLite;
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
                    var sql = "INSERT INTO [Despesa] ([ValorDespesa], [TipoDespesa], [QuantidadeParcelas], [ParcelaAtual], [DataCriacaoDespesa], [DataVencimentoDespesa], [DespesaPaga], [FormaPagamento]) VALUES  (@ValorDespesa, @TipoDespesa, @QuantidadeParcelas, @ParcelaAtual, @DataCriacaoDespesa, @DataVencimentoDespesa, @DespesaPaga, @FormaPagamento);";
                    context.CommandText = sql;
                    context.Parameters.AddWithValue("@ValorDespesa", despesa.ValorDespesa);
                    context.Parameters.AddWithValue("@TipoDespesa", despesa.TipoDespesa);
                    context.Parameters.AddWithValue("@QuantidadeParcelas", despesa.QuantidadeParcelas);
                    context.Parameters.AddWithValue("@ParcelaAtual", despesa.ParcelaAtual);
                    context.Parameters.AddWithValue("@DataCriacaoDespesa", despesa.DataCriacaoDespesa);
                    context.Parameters.AddWithValue("@DataVencimentoDespesa", despesa.DataVencimentoDespesa);
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
                    context.CommandText = "SELECT ValorDespesa FROM [Despesa] ;";
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

        public DataTable GetValorDespesaAnoAtualAll()
        {
            SQLiteDataAdapter adapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                using (var context = WinFormDbContext.DbConnection().CreateCommand())
                {
                    var param0 = DateTime.Now.Date.Year.ToString();
                    var param1 = DateTime.Now.Date.AddYears(1).Year.ToString();
                    context.CommandText = String.Format($"SELECT ValorDespesa FROM [Despesa] WHERE DataVencimentoDespesa>'{param0}-01-01 00:00:00' and DataVencimentoDespesa<'{param1}-01-01 00:00:00';");
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

        public DataTable GetValorDespesaMesAtualAll()
        {
            SQLiteDataAdapter adapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                using (var context = WinFormDbContext.DbConnection().CreateCommand())
                {
                    var param0 = string.Format($"{DateTime.Now.Date.Year}-0{DateTime.Now.Date.Month}-01 00:00:00");
                    var param1 = string.Format($"{DateTime.Now.Date.Year}-0{DateTime.Now.Date.AddMonths(1).Month}-01 00:00:00");

                    context.CommandText = String.Format($"SELECT ValorDespesa FROM [Despesa] WHERE DataVencimentoDespesa >= '{param0}' and DataVencimentoDespesa < '{param1}';");
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

        public DataTable GetDespesaNaoPagasMesAtualAll()
        {
            SQLiteDataAdapter adapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                using (var context = WinFormDbContext.DbConnection().CreateCommand())
                {
                    var param0 = string.Format($"{DateTime.Now.Date.Year}-0{DateTime.Now.Date.Month}-01 00:00:00");
                    var param1 = string.Format($"{DateTime.Now.Date.Year}-0{DateTime.Now.Date.AddMonths(1).Month}-01 00:00:00");

                    context.CommandText = String.Format($"SELECT * FROM [Despesa] WHERE DataVencimentoDespesa >= '{param0}' and DataVencimentoDespesa < '{param1}';");
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

        public DataTable GetAllDespesaPorData(DateTime inicail, DateTime fim)
        {
            SQLiteDataAdapter adapter = null;
            DataTable dataTable = new DataTable();
            try
            {
                using (var context = WinFormDbContext.DbConnection().CreateCommand())
                {
                    var param0 = string.Format($"{inicail.ToString("yyyy-MM-dd")} 00:00:00");
                    var param1 = string.Format($"{fim.ToString("yyyy-MM-dd")} 23:59:00");

                    context.CommandText = String.Format($"SELECT * FROM [Despesa] WHERE DataVencimentoDespesa >= '{param0}' and DataVencimentoDespesa < '{param1}';");
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
        
        public void UpdateDespesa(Despesa despesa)
        {
            try
            {
                using (var context = WinFormDbContext.DbConnection().CreateCommand())
                {
                    var sql = "UPDATE [Despesa] SET [ValorDespesa] = @ValorDespesa, [TipoDespesa] = @TipoDespesa, [QuantidadeParcelas] = @QuantidadeParcelas, [ParcelaAtual] = @ParcelaAtual, [DataCriacaoDespesa] = @DataCriacaoDespesa, [DataVencimentoDespesa] = @DataVencimentoDespesa, [DespesaPaga] = @DespesaPaga, [FormaPagamento] = @FormaPagamento WHERE [IdDespesa] == @IdDespesa;";
                    context.CommandText = sql;
                    context.Parameters.AddWithValue("@IdDespesa", despesa.IdDespesa);
                    context.Parameters.AddWithValue("@ValorDespesa", despesa.ValorDespesa);
                    context.Parameters.AddWithValue("@TipoDespesa", despesa.TipoDespesa);
                    context.Parameters.AddWithValue("@QuantidadeParcelas", despesa.QuantidadeParcelas);
                    context.Parameters.AddWithValue("@ParcelaAtual", despesa.ParcelaAtual);
                    context.Parameters.AddWithValue("@DataCriacaoDespesa", despesa.DataCriacaoDespesa);
                    context.Parameters.AddWithValue("@DataVencimentoDespesa", despesa.DataVencimentoDespesa);
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
    }
}