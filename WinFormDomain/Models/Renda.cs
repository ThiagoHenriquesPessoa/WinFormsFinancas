using System;
using System.ComponentModel.DataAnnotations;

namespace WinFormDomain.Models
{
    public class Renda
    {
        [Key]
        public Int64 IdRenda { get; set; }

        public double ValorRenda { get; set; }
        public string TipoRenda { get; set; }
        public DateTime DataEntrada { get; set; }
    }
}