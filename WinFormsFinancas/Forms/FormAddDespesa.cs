using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormBusiness.Business;
using WinFormBusiness.InterfaceBusiness;
using WinFormDomain.Models;

namespace WinFormsFinancas.Forms
{
    public partial class FormAddDespesa : Form
    {
        private readonly IDespesaBusiness _despesaBusiness;
        public FormAddDespesa(IDespesaBusiness despesaBusiness)
        {
            InitializeComponent();
            _despesaBusiness = despesaBusiness;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var renda = new Despesa
            {
                ValorDespesa = txtNovaDespesa.Text != "" ? Convert.ToDouble(txtNovaDespesa.Text) : 0,
                TipoDespesa = cbTipoDespesa.Text != "" ? cbTipoDespesa.Text : "Outros",
                QuantidadeParcelas = Convert.ToInt32(NumUpQtdParcelas.Value),
                DataCriacaoDespesa = cldDataVencimento.SelectionRange.Start,
                DespesaPaga = cbxDespesaPaga.Checked,
                FormaPagamento = cbxFormaPagamento.Text != "" ? cbxFormaPagamento.Text : "Outros"
            };
            _despesaBusiness.InsertDespesa(renda);
            Close();
        }

        private void btnCanelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
