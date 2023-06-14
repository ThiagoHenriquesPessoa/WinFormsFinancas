using WinFormBusiness.InterfaceBusiness;
using WinFormDomain.Models;
using static SQLite.SQLite3;

namespace WinFormsFinancas.Forms
{
    public partial class FormAddRenda : Form
    {
        private readonly IRendaBusiness _rendaService;

        public FormAddRenda(IRendaBusiness rendaService)
        {
            InitializeComponent();
            txtNovaRenda.Text = "0";
            cbTipoRenda.Text = "";
            cldDataEntrada.SelectionStart = DateTime.Now;
            _rendaService = rendaService;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNovaRenda.Text != "0" && txtNovaRenda.Text != "")
            {
                var renda = new Renda
                {
                    ValorRenda = txtNovaRenda.Text != "" ? Convert.ToDouble(txtNovaRenda.Text) : 0,
                    TipoRenda = cbTipoRenda.Text != "" ? cbTipoRenda.Text : "Outros",
                    DataEntrada = cldDataEntrada.SelectionRange.Start
                };
                _rendaService.InsertRenda(renda);            
                btnCanelar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Valor da renda não pode ser zero!");
            }
        }

        private void btnCanelar_Click(object sender, EventArgs e)
        {
            txtNovaRenda.Text = "0";
            cbTipoRenda.Text = "";
            cldDataEntrada.SelectionStart = DateTime.Now;
        }
    }
}