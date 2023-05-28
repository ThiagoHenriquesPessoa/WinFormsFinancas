using System.Globalization;
using WinFormBusiness.Business;
using WinFormBusiness.InterfaceBusiness;
using WinFormDomain.Models;
using WinFormRepository.Repository;

namespace WinFormsFinancas
{
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private readonly IRendaBusiness _rendaBusiness;
        private readonly IDespesaBusiness _despesaBusiness;
        public FormMainMenu(IRendaBusiness rendaBusiness, IDespesaBusiness despesaBusiness)
        {
            InitializeComponent();
            random = new Random();
            _rendaBusiness = rendaBusiness;
            _despesaBusiness = despesaBusiness;
            AtualizaHome();
        }

        private void AtualizaHome()
        {
            tbxRendaTotal.Text = _rendaBusiness.GetRendaTotal().ToString("F2");
            tbxDespesaTotal.Text = _despesaBusiness.GetDespesaTotal().ToString("F2");
            tbxDespesaAnoAtual.Text = _despesaBusiness.GetDespesaAnoAtualAll().ToString("F2");
            tbxDespesaMesAtual.Text = _despesaBusiness.GetDespesaMesAtualAll().ToString("F2");
            dgvListDespesasNaoPagas.DataSource = _despesaBusiness.GetDespesaNaoPagasMesAtualAll();
            dgvListDespesasNaoPagas.Columns["IdDespesa"].Visible = false;
        }

        private Color SelectthemeColor()
        {
            int index = random.Next(ThemerColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemerColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemerColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectthemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemerColor.ChangerColorBrightness(color, -0.3);

                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(25, 25, 112);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btmSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btmSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesctopPanel.Controls.Add(childForm);
            this.panelDesctopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblPage.Text = childForm.Text;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCostumers(), sender);
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormReporting(), sender);
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormNotifications(), sender);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSetting(), sender);
        }

        private void btnAddRenda_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAddRenda(new RendaBusiness(new RendaRepository())), sender);
        }

        private void btnAddDespesa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAddDespesa(new DespesaBusiness(new DespesaRepository())), sender);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizaHome();
        }
    }
}