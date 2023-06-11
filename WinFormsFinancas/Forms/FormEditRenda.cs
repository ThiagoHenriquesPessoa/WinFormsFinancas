using WinFormBusiness.InterfaceBusiness;

namespace WinFormsFinancas.Forms
{
    public partial class FormEditRenda : Form
    {
        private readonly IRendaBusiness _rendaBusiness;
        public FormEditRenda(IRendaBusiness rendaBusiness)
        {
            InitializeComponent();
            _rendaBusiness = rendaBusiness;
        }

        private void btnExibirLista_Click(object sender, EventArgs e)
        {
            dgvListaRenda.DataSource = _rendaBusiness.GetAllRendaPorData(dtpDataInicial.Value.Date, dtpDataFim.Value);
            dgvListaRenda.Columns["IdRenda"].Visible = false;
        }

        private void dgvListaRenda_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow linha = dgvListaRenda.Rows[e.RowIndex];
            lblIdRenda.Text = linha.Cells[0].Value.ToString();
            txtNovaRenda.Text = linha.Cells[1].Value.ToString();
            cbTipoRenda.Text = linha.Cells[2].Value.ToString();
            cldDataEntrada.Value = Convert.ToDateTime(linha.Cells[3].Value.ToString());
        }
    }
}