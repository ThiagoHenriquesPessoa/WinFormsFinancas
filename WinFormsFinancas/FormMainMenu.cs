using WinFormBusiness.Business;
using WinFormBusiness.InterfaceBusiness;
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
            lblRendaAnoAtual.Text += " " + DateTime.Now.Year.ToString();
            lblDespesaAnoAtual.Text += " " + DateTime.Now.Year.ToString();
            lblRendaMesAtual.Text += " " + MesAtual(DateTime.Now.Month);
            lblDespesaMesAtual.Text += " " + MesAtual(DateTime.Now.Month);
            random = new Random();
            _rendaBusiness = rendaBusiness;
            _despesaBusiness = despesaBusiness;
            AtualizaHome();
        }

        private string MesAtual(int mes)
        {
            string mesAtual = "";
            switch (mes)
            {
                case 1:
                    mesAtual = "janeiro";
                    break;
                case 2:
                    mesAtual = "fevereiro";
                    break;
                case 3:
                    mesAtual = "março";
                    break;
                case 4:
                    mesAtual = "abril";
                    break;
                case 5:
                    mesAtual = "maio";
                    break;
                case 6:
                    mesAtual = "junho";
                    break;
                case 7:
                    mesAtual = "julho";
                    break;
                case 8:
                    mesAtual = "agosto";
                    break;
                case 9:
                    mesAtual = "setembro";
                    break;
                case 10:
                    mesAtual = "outubro";
                    break;
                case 11:
                    mesAtual = "novembro";
                    break;
                case 12:
                    mesAtual = "dezembro";
                    break;
            }
            return mesAtual;
        }

        private void AtualizaHome()
        {
            tbxRendaTotal.Text = _rendaBusiness.GetRendaTotal().ToString("F2");
            tbxDespesaTotal.Text = _despesaBusiness.GetDespesaTotal().ToString("F2");
            tbxDespesaAnoAtual.Text = _despesaBusiness.GetDespesaAnoAtualAll().ToString("F2");
            tbxDespesaMesAtual.Text = _despesaBusiness.GetDespesaMesAtualAll().ToString("F2");
            tbxRendaAnoAtual.Text = _rendaBusiness.GetRendaAnoAtualall().ToString("F2");
            tbxRendaMesAtual.Text = _rendaBusiness.GetRendaMesAtualAll().ToString("F2");
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
                    btnLogo.BackColor = ThemerColor.ChangerColorBrightness(color, -0.3);
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

        private void btnEditDespesa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEditDespesa(new DespesaBusiness(new DespesaRepository())), sender);
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEditRenda(new RendaBusiness(new RendaRepository())), sender);
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

        private void btnLogo_Click(object sender, EventArgs e)
        {
            activeForm.Close();
            lblPage.Text = "HOME";
            AtualizaHome();
        }
    }
}