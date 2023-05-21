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
        private readonly IRendaService _repository;
        public FormMainMenu(IRendaService repository)
        {
            InitializeComponent();
            random = new Random();
            _repository = repository;
            tbxRendaTotal.Text = Convert.ToString(_repository.GetRendaTotal());
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
            lblTitle.Text = childForm.Text;
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOrders(), sender);
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
            OpenChildForm(new Forms.FormAddRenda(new RendaService(new RendaRepository())), sender);
            tbxRendaTotal.Text = Convert.ToString(_repository.GetRendaTotal());
        }

        
    }
}