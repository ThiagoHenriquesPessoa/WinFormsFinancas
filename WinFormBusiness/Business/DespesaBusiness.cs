﻿using System;
using System.Collections.Generic;
using System.Data;
using WinFormBusiness.InterfaceBusiness;
using WinFormDomain.Models;
using WinFormRepository.InterfaceRepository;

namespace WinFormBusiness.Business
{
    public class DespesaBusiness : IDespesaBusiness
    {
        private readonly IDespesaRepository _despesaRepository;

        public DespesaBusiness(IDespesaRepository despesaRepository)
        {
            _despesaRepository = despesaRepository;
        }

        public void InsertDespesa(Despesa despesa)
        {
            Int64 parcelas = despesa.QuantidadeParcelas;
            double valor = despesa.ValorDespesa / parcelas;
            despesa.ValorDespesa = valor;
            for (int i = 1; i <= parcelas; i++)
            {
                despesa.DataVencimentoDespesa = i == 1 ? despesa.DataVencimentoDespesa : despesa.DataVencimentoDespesa.AddMonths(1);
                despesa.ParcelaAtual = i;
                _despesaRepository.InsertDespesa(despesa);
            }
        }

        public double GetDespesaTotal()
        {
            double valorTotal = 0;
            var table = _despesaRepository.GetValorDespesaAll();
            foreach (DataRow row in table.Rows)
            {
                valorTotal += (double)row["ValorDespesa"];
            }
            return valorTotal;
        }

        public double GetDespesaAnoAtualAll()
        {
            double valorTotal = 0;
            var table = _despesaRepository.GetValorDespesaAnoAtualAll();
            foreach (DataRow row in table.Rows)
            {
                valorTotal += (double)row["ValorDespesa"];
            }
            return valorTotal;
        }

        public double GetDespesaMesAtualAll()
        {
            double valorTotal = 0;
            var table = _despesaRepository.GetValorDespesaMesAtualAll();
            foreach (DataRow row in table.Rows)
            {
                valorTotal += (double)row["ValorDespesa"];
            }
            return valorTotal;
        }

        public DataTable GetDespesaNaoPagasMesAtualAll()
        {
            double valorTotal = 0;
            var listDespesas = new List<Despesa>();
            var table = _despesaRepository.GetDespesaNaoPagasMesAtualAll();
            DataTable dt = new DataTable();
            dt.Columns.Add("IdDespesa", typeof(Int64));
            dt.Columns.Add("Tipo de despesa", typeof(string));
            dt.Columns.Add("Valor da despesa", typeof(string));
            dt.Columns.Add("Formato usado", typeof(string));
            foreach (DataRow row in table.Rows)
            {
                if ((Int64)row["DespesaPaga"] == 0)
                {
                    dt.Rows.Add(
                        (Int64)row["IdDespesa"],
                        (string)row["TipoDespesa"],
                        ((double)row["ValorDespesa"]).ToString("C"),
                        (string)row["FormaPagamento"]);
                }
            }
            return dt;
        }

        public List<Despesa> GetAllDespesaPorData(DateTime inicio, DateTime fim)
        {
            var listDespesas = new List<Despesa>();
            var table = _despesaRepository.GetAllDespesaPorData(inicio, fim);
            foreach (DataRow row in table.Rows)
            {
                listDespesas.Add(new Despesa
                {
                    IdDespesa = (Int64)row["IdDespesa"],
                    ValorDespesa = Convert.ToDouble(((double)row["ValorDespesa"]).ToString("F2")),
                    TipoDespesa = (string)row["TipoDespesa"],
                    QuantidadeParcelas = (Int64)row["QuantidadeParcelas"],
                    ParcelaAtual = (Int64)row["ParcelaAtual"],
                    DataCriacaoDespesa = Convert.ToDateTime((string)row["DataCriacaoDespesa"]),
                    DataVencimentoDespesa = Convert.ToDateTime((string)row["DataVencimentoDespesa"]),
                    DespesaPaga = Convert.ToBoolean((Int64)row["DespesaPaga"]),
                    FormaPagamento = (string)row["FormaPagamento"]
                });
            }
            return listDespesas;
        }

        public void UpdateDespesa(Despesa despesa)
        {
            _despesaRepository.UpdateDespesa(despesa);
        }

        public void DeleteDespesa(Int64 idDespesa)
        {
            _despesaRepository.DeleteDespesa(idDespesa);
        }
    }
}