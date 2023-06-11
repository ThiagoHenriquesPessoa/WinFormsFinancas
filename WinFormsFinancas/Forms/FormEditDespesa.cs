using WinFormBusiness.InterfaceBusiness;

namespace WinFormsFinancas.Forms
{
    public partial class FormEditDespesa : Form
    {
        private readonly IDespesaBusiness _despesaBusiness;

        public FormEditDespesa(IDespesaBusiness despesaBusiness)
        {
            InitializeComponent();
            _despesaBusiness = despesaBusiness;
        }

        private void btnExibirLista_Click(object sender, EventArgs e)
        {
            dgvListaDespesas.DataSource = _despesaBusiness.GetAllDespesaPorData(dtpDataInicial.Value.Date, dtpDataFim.Value);
            dgvListaDespesas.Columns["IdDespesa"].Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var editar = new FormEditar();
            editar.Show();
        }

        private void dgvListaDespesas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow linha = dgvListaDespesas.Rows[e.RowIndex];
            Int64 id = Convert.ToInt64(linha.Cells[0].Value);
            txtNovaDespesa.Text = linha.Cells[1].Value.ToString();
            cbTipoDespesa.Text = linha.Cells[2].Value.ToString();
            cbxDespesaPaga.Checked = Convert.ToBoolean(linha.Cells[7].Value);
            cbxFormaPagamento.Text = linha.Cells[8].Value.ToString();
            cldDataCriacao.Value = Convert.ToDateTime(linha.Cells[5].Value.ToString());
            cldDataVencimento.Value = Convert.ToDateTime(linha.Cells[6].Value.ToString());
            NumUpQtdParcelas.Value = Convert.ToDecimal(linha.Cells[3].Value.ToString());
        }
    }
}