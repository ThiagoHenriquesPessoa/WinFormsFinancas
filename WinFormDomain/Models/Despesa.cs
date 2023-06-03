using SQLite;
using System;

namespace WinFormDomain.Models
{
    public class Despesa
    {
        [PrimaryKey, AutoIncrement]
        public Int64 IdDespesa { get; set; }

        public double ValorDespesa { get; set; }
        public string TipoDespesa { get; set; }
        public Int64 QuantidadeParcelas { get; set; }
        public DateTime DataCriacaoDespesa { get; set; }
        public bool DespesaPaga { get; set; }
        public string FormaPagamento { get; set; }
    }
}