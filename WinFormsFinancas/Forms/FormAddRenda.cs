using WinFormBusiness.InterfaceBusiness;
using WinFormDomain.Models;

namespace WinFormsFinancas.Forms
{
    public partial class FormAddRenda : Form
    {
        private readonly IRendaService _rendaService;
        public FormAddRenda(IRendaService rendaService)
        {
            InitializeComponent();
            _rendaService = rendaService;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var renda = new Renda
            {
                ValorRenda = Convert.ToDouble(txtNovaRenda.Text),
                TipoRenda = cbTipoRenda.Text,
                ValorFixo = ckbValorFixo.Checked,
                DataEntrada = cldDataEntrada.SelectionRange.Start
            };
            _rendaService.InsertRenda(renda);
           Close();            
        }
    }
}