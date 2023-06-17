using WinFormBusiness.InterfaceBusiness;
using WinFormDomain.Models;

namespace WinFormsFinancas.Forms
{
    public partial class FormEditDespesa : Form
    {
        private readonly IDespesaBusiness _despesaBusiness;

        public FormEditDespesa(IDespesaBusiness despesaBusiness)
        {
            InitializeComponent();
            lblIdDespesa.Text = "0";
            txtNovaDespesa.Text = "0";
            cbTipoDespesa.Text = "";
            cbxDespesaPaga.Checked = false;
            cbxFormaPagamento.Text = "";
            cldDataCriacao.Value = DateTime.Now;
            cldDataVencimento.Value = DateTime.Now;
            txtQlbParcelas.Text = "0";
            txtParcelaAtual.Text = "0";
            _despesaBusiness = despesaBusiness;
        }

        private void btnExibirLista_Click(object sender, EventArgs e)
        {
            dgvListaDespesas.DataSource = _despesaBusiness.GetAllDespesaPorData(dtpDataInicial.Value.Date, dtpDataFim.Value);
            dgvListaDespesas.Columns["IdDespesa"].Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblIdDespesa.Text != "0" && txtNovaDespesa.Text != "0" && txtNovaDespesa.Text != "")
            {
                var despesa = new Despesa
                {
                    IdDespesa = Convert.ToInt64(lblIdDespesa.Text),
                    ValorDespesa = Convert.ToDouble(txtNovaDespesa.Text),
                    TipoDespesa = cbTipoDespesa.Text,
                    QuantidadeParcelas = Convert.ToInt64(txtQlbParcelas.Text),
                    ParcelaAtual = Convert.ToInt64(txtParcelaAtual.Text),
                    DataCriacaoDespesa = cldDataCriacao.Value,
                    DataVencimentoDespesa = cldDataVencimento.Value,
                    DespesaPaga = cbxDespesaPaga.Checked,
                    FormaPagamento = cbxFormaPagamento.Text
                };
                _despesaBusiness.UpdateDespesa(despesa);
                Atualizar();
            }
            else
            {
                MessageBox.Show("Valor da despesa não pode ser zero!");
            }
        }

        private void Atualizar()
        {
            lblIdDespesa.Text = "0";
            txtNovaDespesa.Text = "0";
            cbTipoDespesa.Text = "";
            cbxDespesaPaga.Checked = false;
            cbxFormaPagamento.Text = "";
            cldDataCriacao.Value = DateTime.Now;
            cldDataVencimento.Value = DateTime.Now;
            txtQlbParcelas.Text = "0";
            txtParcelaAtual.Text = "0";
            dgvListaDespesas.DataSource = _despesaBusiness.GetAllDespesaPorData(dtpDataInicial.Value.Date, dtpDataFim.Value);
        }

        private void dgvListaDespesas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow linha = dgvListaDespesas.Rows[e.RowIndex];
            lblIdDespesa.Text = linha.Cells[0].Value.ToString();
            txtNovaDespesa.Text = linha.Cells[1].Value.ToString();
            cbTipoDespesa.Text = linha.Cells[2].Value.ToString();
            cbxDespesaPaga.Checked = Convert.ToBoolean(linha.Cells[7].Value);
            cbxFormaPagamento.Text = linha.Cells[8].Value.ToString();
            cldDataCriacao.Value = Convert.ToDateTime(linha.Cells[5].Value.ToString());
            cldDataVencimento.Value = Convert.ToDateTime(linha.Cells[6].Value.ToString());
            txtQlbParcelas.Text = linha.Cells[3].Value.ToString();
            txtParcelaAtual.Text = linha.Cells[4].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lblIdDespesa.Text != "0")
            {
                Int64 idDespesa = Convert.ToInt64(lblIdDespesa.Text);
                _despesaBusiness.DeleteDespesa(idDespesa);
                Atualizar();
            }
            else
            {
                MessageBox.Show("Não há despesa para ser excluida!");
            }
        }
    }
}