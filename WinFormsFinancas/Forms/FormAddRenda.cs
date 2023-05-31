using WinFormBusiness.InterfaceBusiness;
using WinFormDomain.Models;

namespace WinFormsFinancas.Forms
{
    public partial class FormAddRenda : Form
    {
        private readonly IRendaBusiness _rendaService;

        public FormAddRenda(IRendaBusiness rendaService)
        {
            InitializeComponent();
            _rendaService = rendaService;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var renda = new Renda
            {
                ValorRenda = txtNovaRenda.Text != "" ? Convert.ToDouble(txtNovaRenda.Text) : 0,
                TipoRenda = cbTipoRenda.Text != "" ? cbTipoRenda.Text : "Outros",
                DataEntrada = cldDataEntrada.SelectionRange.Start
            };
            var result = _rendaService.InsertRenda(renda);
            if (result == 1)
            {
                btnCanelar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Campo Valor da Renda é obrigatorio!");
            }
        }

        private void btnCanelar_Click(object sender, EventArgs e)
        {
            txtNovaRenda.Text = "";
            cbTipoRenda.Text = "";
            cldDataEntrada.SelectionStart = DateTime.Now;
        }
    }
}