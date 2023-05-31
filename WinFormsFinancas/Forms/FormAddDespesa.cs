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
            var result = _despesaBusiness.InsertDespesa(renda);
            if (result == 1)
            {
                btnCanelar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Campo Valor da despesa é obrigatorio!");
            }
        }

        private void btnCanelar_Click(object sender, EventArgs e)
        {
            txtNovaDespesa.Text = "";
            cbTipoDespesa.Text = "";
            NumUpQtdParcelas.Value = 1;
            cldDataVencimento.SelectionStart = DateTime.Now;
            cbxDespesaPaga.Checked = false;
            cbxFormaPagamento.Text = "";
        }
    }
}