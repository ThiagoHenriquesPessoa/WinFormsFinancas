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
            txtNovaDespesa.Text = "0";
            cbTipoDespesa.Text = "";
            NumUpQtdParcelas.Value = 1;
            cldDataCriacao.SelectionStart = DateTime.Now;
            cbxDespesaPaga.Checked = false;
            cbxFormaPagamento.Text = "";
            _despesaBusiness = despesaBusiness;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNovaDespesa.Text != "0" && txtNovaDespesa.Text != "")
            {
                var renda = new Despesa
                {
                    ValorDespesa = Convert.ToDouble(txtNovaDespesa.Text),
                    DespesaPaga = cbxDespesaPaga.Checked,
                    TipoDespesa = cbTipoDespesa.Text != "" ? cbTipoDespesa.Text : "Outros",
                    FormaPagamento = cbxFormaPagamento.Text != "" ? cbxFormaPagamento.Text : "Outros",
                    DataCriacaoDespesa = cldDataCriacao.SelectionRange.Start,
                    DataVencimentoDespesa = cldDataVencimento.SelectionRange.Start,
                    QuantidadeParcelas = Convert.ToInt32(NumUpQtdParcelas.Value)
                };
                _despesaBusiness.InsertDespesa(renda);
                btnCanelar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Valor da despesa não pode ser zero!");
            }
        }

        private void btnCanelar_Click(object sender, EventArgs e)
        {
            txtNovaDespesa.Text = "0";
            cbTipoDespesa.Text = "";
            NumUpQtdParcelas.Value = 1;
            cldDataCriacao.SelectionStart = DateTime.Now;
            cbxDespesaPaga.Checked = false;
            cbxFormaPagamento.Text = "";
        }
    }
}