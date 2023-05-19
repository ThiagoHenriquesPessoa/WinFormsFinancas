namespace WinFormsFinancas
{
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
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

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}