namespace WinFormsFinancas
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelMenu = new Panel();
            btnLogo = new Button();
            btnSetting = new Button();
            btnNotifications = new Button();
            btnReporting = new Button();
            btnCustomer = new Button();
            btnAddDespesa = new Button();
            btnAddRenda = new Button();
            panelTitleBar = new Panel();
            lblPage = new Label();
            lblTitle = new Label();
            panelDesctopPanel = new Panel();
            dgvListDespesasNaoPagas = new DataGridView();
            btnAtualizar = new Button();
            lblDespesaMesAtual = new Label();
            lblRendaMesAtual = new Label();
            tbxDespesaMesAtual = new TextBox();
            tbxRendaMesAtul = new TextBox();
            lblDespesaAnoAtual = new Label();
            lblRendaAnoAtual = new Label();
            tbxDespesaAnoAtual = new TextBox();
            tbxRendaAnoAtual = new TextBox();
            lblDespesaTotal = new Label();
            lblRendaTotal = new Label();
            tbxDespesaTotal = new TextBox();
            tbxRendaTotal = new TextBox();
            panelMenu.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelDesctopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListDespesasNaoPagas).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnLogo);
            panelMenu.Controls.Add(btnSetting);
            panelMenu.Controls.Add(btnNotifications);
            panelMenu.Controls.Add(btnReporting);
            panelMenu.Controls.Add(btnCustomer);
            panelMenu.Controls.Add(btnAddDespesa);
            panelMenu.Controls.Add(btnAddRenda);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 753);
            panelMenu.TabIndex = 0;
            // 
            // btnLogo
            // 
            btnLogo.BackColor = Color.FromArgb(39, 39, 58);
            btnLogo.Dock = DockStyle.Top;
            btnLogo.FlatStyle = FlatStyle.Flat;
            btnLogo.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogo.ForeColor = Color.White;
            btnLogo.Location = new Point(0, 0);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(220, 80);
            btnLogo.TabIndex = 14;
            btnLogo.Text = "LOGO";
            btnLogo.UseVisualStyleBackColor = false;
            btnLogo.Click += btnLogo_Click;
            // 
            // btnSetting
            // 
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetting.ForeColor = SystemColors.GradientInactiveCaption;
            btnSetting.Image = (Image)resources.GetObject("btnSetting.Image");
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(0, 305);
            btnSetting.Name = "btnSetting";
            btnSetting.Padding = new Padding(12, 0, 0, 0);
            btnSetting.Size = new Size(220, 45);
            btnSetting.TabIndex = 6;
            btnSetting.Text = "   =======";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSetting.UseVisualStyleBackColor = true;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnNotifications
            // 
            btnNotifications.FlatAppearance.BorderSize = 0;
            btnNotifications.FlatStyle = FlatStyle.Flat;
            btnNotifications.ForeColor = SystemColors.GradientInactiveCaption;
            btnNotifications.Image = (Image)resources.GetObject("btnNotifications.Image");
            btnNotifications.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotifications.Location = new Point(0, 260);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Padding = new Padding(12, 0, 0, 0);
            btnNotifications.Size = new Size(220, 45);
            btnNotifications.TabIndex = 5;
            btnNotifications.Text = "  =======";
            btnNotifications.TextAlign = ContentAlignment.MiddleLeft;
            btnNotifications.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNotifications.UseVisualStyleBackColor = true;
            btnNotifications.Click += btnNotifications_Click;
            // 
            // btnReporting
            // 
            btnReporting.FlatAppearance.BorderSize = 0;
            btnReporting.FlatStyle = FlatStyle.Flat;
            btnReporting.ForeColor = SystemColors.GradientInactiveCaption;
            btnReporting.Image = (Image)resources.GetObject("btnReporting.Image");
            btnReporting.ImageAlign = ContentAlignment.MiddleLeft;
            btnReporting.Location = new Point(0, 215);
            btnReporting.Name = "btnReporting";
            btnReporting.Padding = new Padding(12, 0, 0, 0);
            btnReporting.Size = new Size(220, 45);
            btnReporting.TabIndex = 4;
            btnReporting.Text = "   =======";
            btnReporting.TextAlign = ContentAlignment.MiddleLeft;
            btnReporting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporting.UseVisualStyleBackColor = true;
            btnReporting.Click += btnReporting_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.ForeColor = SystemColors.GradientInactiveCaption;
            btnCustomer.Image = (Image)resources.GetObject("btnCustomer.Image");
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(0, 170);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Padding = new Padding(12, 0, 0, 0);
            btnCustomer.Size = new Size(220, 45);
            btnCustomer.TabIndex = 3;
            btnCustomer.Text = "   =======";
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnAddDespesa
            // 
            btnAddDespesa.FlatAppearance.BorderSize = 0;
            btnAddDespesa.FlatStyle = FlatStyle.Flat;
            btnAddDespesa.ForeColor = SystemColors.GradientInactiveCaption;
            btnAddDespesa.Image = (Image)resources.GetObject("btnAddDespesa.Image");
            btnAddDespesa.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddDespesa.Location = new Point(0, 125);
            btnAddDespesa.Name = "btnAddDespesa";
            btnAddDespesa.Padding = new Padding(12, 0, 0, 0);
            btnAddDespesa.Size = new Size(220, 45);
            btnAddDespesa.TabIndex = 2;
            btnAddDespesa.Text = "   AddDespesa";
            btnAddDespesa.TextAlign = ContentAlignment.MiddleLeft;
            btnAddDespesa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddDespesa.UseVisualStyleBackColor = true;
            btnAddDespesa.Click += btnAddDespesa_Click;
            // 
            // btnAddRenda
            // 
            btnAddRenda.FlatAppearance.BorderSize = 0;
            btnAddRenda.FlatStyle = FlatStyle.Flat;
            btnAddRenda.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddRenda.ForeColor = SystemColors.GradientInactiveCaption;
            btnAddRenda.Image = Properties.Resources.icons8_apresentação_16;
            btnAddRenda.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddRenda.Location = new Point(0, 80);
            btnAddRenda.Name = "btnAddRenda";
            btnAddRenda.Padding = new Padding(12, 0, 0, 0);
            btnAddRenda.Size = new Size(220, 45);
            btnAddRenda.TabIndex = 1;
            btnAddRenda.Text = "   AddRenda";
            btnAddRenda.TextAlign = ContentAlignment.MiddleLeft;
            btnAddRenda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddRenda.UseVisualStyleBackColor = true;
            btnAddRenda.Click += btnAddRenda_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(lblPage);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(962, 80);
            panelTitleBar.TabIndex = 1;
            // 
            // lblPage
            // 
            lblPage.Anchor = AnchorStyles.None;
            lblPage.AutoSize = true;
            lblPage.Font = new Font("MS PGothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblPage.ForeColor = Color.White;
            lblPage.Location = new Point(442, 28);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(78, 24);
            lblPage.TabIndex = 1;
            lblPage.Text = "HOME";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("MS PGothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(443, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(78, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesctopPanel
            // 
            panelDesctopPanel.Controls.Add(dgvListDespesasNaoPagas);
            panelDesctopPanel.Controls.Add(btnAtualizar);
            panelDesctopPanel.Controls.Add(lblDespesaMesAtual);
            panelDesctopPanel.Controls.Add(lblRendaMesAtual);
            panelDesctopPanel.Controls.Add(tbxDespesaMesAtual);
            panelDesctopPanel.Controls.Add(tbxRendaMesAtul);
            panelDesctopPanel.Controls.Add(lblDespesaAnoAtual);
            panelDesctopPanel.Controls.Add(lblRendaAnoAtual);
            panelDesctopPanel.Controls.Add(tbxDespesaAnoAtual);
            panelDesctopPanel.Controls.Add(tbxRendaAnoAtual);
            panelDesctopPanel.Controls.Add(lblDespesaTotal);
            panelDesctopPanel.Controls.Add(lblRendaTotal);
            panelDesctopPanel.Controls.Add(tbxDespesaTotal);
            panelDesctopPanel.Controls.Add(tbxRendaTotal);
            panelDesctopPanel.Dock = DockStyle.Fill;
            panelDesctopPanel.Location = new Point(220, 80);
            panelDesctopPanel.Name = "panelDesctopPanel";
            panelDesctopPanel.Size = new Size(962, 673);
            panelDesctopPanel.TabIndex = 2;
            // 
            // dgvListDespesasNaoPagas
            // 
            dgvListDespesasNaoPagas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvListDespesasNaoPagas.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListDespesasNaoPagas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListDespesasNaoPagas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvListDespesasNaoPagas.DefaultCellStyle = dataGridViewCellStyle4;
            dgvListDespesasNaoPagas.Location = new Point(362, 135);
            dgvListDespesasNaoPagas.Name = "dgvListDespesasNaoPagas";
            dgvListDespesasNaoPagas.RowHeadersWidth = 5;
            dgvListDespesasNaoPagas.RowTemplate.Height = 20;
            dgvListDespesasNaoPagas.ScrollBars = ScrollBars.Vertical;
            dgvListDespesasNaoPagas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListDespesasNaoPagas.Size = new Size(390, 170);
            dgvListDespesasNaoPagas.TabIndex = 13;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(846, 621);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(94, 29);
            btnAtualizar.TabIndex = 12;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // lblDespesaMesAtual
            // 
            lblDespesaMesAtual.AutoSize = true;
            lblDespesaMesAtual.Location = new Point(10, 192);
            lblDespesaMesAtual.Name = "lblDespesaMesAtual";
            lblDespesaMesAtual.Size = new Size(135, 20);
            lblDespesaMesAtual.TabIndex = 11;
            lblDespesaMesAtual.Text = "Despesa Mês Atual";
            // 
            // lblRendaMesAtual
            // 
            lblRendaMesAtual.AutoSize = true;
            lblRendaMesAtual.Location = new Point(10, 155);
            lblRendaMesAtual.Name = "lblRendaMesAtual";
            lblRendaMesAtual.Size = new Size(121, 20);
            lblRendaMesAtual.TabIndex = 10;
            lblRendaMesAtual.Text = "Renda Mês Atual";
            // 
            // tbxDespesaMesAtual
            // 
            tbxDespesaMesAtual.Location = new Point(151, 189);
            tbxDespesaMesAtual.Name = "tbxDespesaMesAtual";
            tbxDespesaMesAtual.Size = new Size(125, 27);
            tbxDespesaMesAtual.TabIndex = 9;
            // 
            // tbxRendaMesAtul
            // 
            tbxRendaMesAtul.Location = new Point(151, 149);
            tbxRendaMesAtul.Name = "tbxRendaMesAtul";
            tbxRendaMesAtul.Size = new Size(125, 27);
            tbxRendaMesAtul.TabIndex = 8;
            // 
            // lblDespesaAnoAtual
            // 
            lblDespesaAnoAtual.AutoSize = true;
            lblDespesaAnoAtual.Location = new Point(362, 57);
            lblDespesaAnoAtual.Name = "lblDespesaAnoAtual";
            lblDespesaAnoAtual.Size = new Size(135, 20);
            lblDespesaAnoAtual.TabIndex = 7;
            lblDespesaAnoAtual.Text = "Despesa Ano Atual";
            // 
            // lblRendaAnoAtual
            // 
            lblRendaAnoAtual.AutoSize = true;
            lblRendaAnoAtual.Location = new Point(362, 20);
            lblRendaAnoAtual.Name = "lblRendaAnoAtual";
            lblRendaAnoAtual.Size = new Size(121, 20);
            lblRendaAnoAtual.TabIndex = 6;
            lblRendaAnoAtual.Text = "Renda Ano Atual";
            // 
            // tbxDespesaAnoAtual
            // 
            tbxDespesaAnoAtual.Location = new Point(503, 54);
            tbxDespesaAnoAtual.Name = "tbxDespesaAnoAtual";
            tbxDespesaAnoAtual.Size = new Size(125, 27);
            tbxDespesaAnoAtual.TabIndex = 5;
            // 
            // tbxRendaAnoAtual
            // 
            tbxRendaAnoAtual.Location = new Point(503, 14);
            tbxRendaAnoAtual.Name = "tbxRendaAnoAtual";
            tbxRendaAnoAtual.Size = new Size(125, 27);
            tbxRendaAnoAtual.TabIndex = 4;
            // 
            // lblDespesaTotal
            // 
            lblDespesaTotal.AutoSize = true;
            lblDespesaTotal.Location = new Point(10, 57);
            lblDespesaTotal.Name = "lblDespesaTotal";
            lblDespesaTotal.Size = new Size(102, 20);
            lblDespesaTotal.TabIndex = 3;
            lblDespesaTotal.Text = "Despesa Total";
            // 
            // lblRendaTotal
            // 
            lblRendaTotal.AutoSize = true;
            lblRendaTotal.Location = new Point(10, 20);
            lblRendaTotal.Name = "lblRendaTotal";
            lblRendaTotal.Size = new Size(88, 20);
            lblRendaTotal.TabIndex = 2;
            lblRendaTotal.Text = "Renda Total";
            // 
            // tbxDespesaTotal
            // 
            tbxDespesaTotal.Location = new Point(112, 57);
            tbxDespesaTotal.Name = "tbxDespesaTotal";
            tbxDespesaTotal.Size = new Size(125, 27);
            tbxDespesaTotal.TabIndex = 1;
            // 
            // tbxRendaTotal
            // 
            tbxRendaTotal.Location = new Point(112, 17);
            tbxRendaTotal.Name = "tbxRendaTotal";
            tbxRendaTotal.Size = new Size(125, 27);
            tbxRendaTotal.TabIndex = 0;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(panelDesctopPanel);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "FormMainMenu";
            Text = "Controle Financeiro";
            panelMenu.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelDesctopPanel.ResumeLayout(false);
            panelDesctopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListDespesasNaoPagas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnSetting;
        private Button btnNotifications;
        private Button btnReporting;
        private Button btnCustomer;
        private Button btnAddDespesa;
        private Button btnAddRenda;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label lblPage;
        private Panel panelDesctopPanel;
        private TextBox tbxRendaTotal;
        private TextBox tbxDespesaTotal;
        private Label lblDespesaMesAtual;
        private Label lblRendaMesAtual;
        private TextBox tbxDespesaMesAtual;
        private TextBox tbxRendaMesAtul;
        private Label lblDespesaAnoAtual;
        private Label lblRendaAnoAtual;
        private TextBox tbxDespesaAnoAtual;
        private TextBox tbxRendaAnoAtual;
        private Label lblDespesaTotal;
        private Label lblRendaTotal;
        private Button btnAtualizar;
        private DataGridView dgvListDespesasNaoPagas;
        private Button btnLogo;
    }
}