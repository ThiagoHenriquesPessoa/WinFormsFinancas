using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormDomain.Models;

namespace WinFormsFinancas.Forms
{
    public partial class FormAddDespesa : Form
    {
        public FormAddDespesa()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var renda = new Despesa
            {
                ValorDespesa = Convert.ToDouble(txtNovaDespesa.Text),
                TipoDespesa = cbTipoDespesa.Text,
                FixaDespesa = cbxValorDespesaFixo.Checked,
                QuantidadeParcelas = Convert.ToInt32(NumUpQtdParcelas.Value),
                DataCriacaoDespesa = cldDataVencimento.SelectionRange.Start
            };
            _rendaService.InsertRenda(renda);
            Close();
        }
    }
}
