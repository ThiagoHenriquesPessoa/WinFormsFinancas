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
    }
}