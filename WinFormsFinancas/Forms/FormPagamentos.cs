using WinFormBusiness.Business;
using WinFormBusiness.InterfaceBusiness;

namespace WinFormsFinancas.Forms
{
    public partial class FormPagamentos : Form
    {
        private readonly IServiceBusiness _serviceBusiness;
        private readonly IDespesaBusiness _despesaBusiness;
        public FormPagamentos(IServiceBusiness serviceBusiness, IDespesaBusiness despesaBusiness)
        {
            InitializeComponent();
            _serviceBusiness = serviceBusiness;
            _despesaBusiness = despesaBusiness;
            lblRendaMesAtual.Text += " " + _serviceBusiness.MesAtual(DateTime.Now.Month);
            lblDespesaMesAtual.Text += " " + _serviceBusiness.MesAtual(DateTime.Now.Month);
            dgvListaDespesas.DataSource = _despesaBusiness.GetDespesaMesAtualAll();
            dgvListaDespesas.Columns["IdDespesa"].Visible = false;
            dgvListaDespesas.Columns["Valor da despesa"].ReadOnly = true;
            dgvListaDespesas.Columns["Tipo de despesa"].ReadOnly = true;
            dgvListaDespesas.Columns["Quantidade de parcelas"].ReadOnly = true;
            dgvListaDespesas.Columns["Parcela atual"].ReadOnly = true;
            dgvListaDespesas.Columns["Criação da despesa"].ReadOnly = true;
            dgvListaDespesas.Columns["Vencimento da despesa"].ReadOnly = true;
            dgvListaDespesas.Columns["Despesa Paga"].ReadOnly = true;
            dgvListaDespesas.Columns["Forma de pagamento"].ReadOnly = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
        }
    }
}