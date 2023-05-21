using System;
using System.ComponentModel.DataAnnotations;

namespace WinFormDomain.Models
{
    public class Renda
    {
        [Key]
        public int IdRenda { get; set; }

        public double ValorRenda { get; set; }
        public string TipoRenda { get; set; }
        public bool ValorFixo { get; set; }
        public DateTime DataEntrada { get; set; }
    }
}