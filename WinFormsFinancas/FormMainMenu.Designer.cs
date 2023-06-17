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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelMenu = new Panel();
            btnLogo = new Button();
            btnSetting = new Button();
            btnPagamentos = new Button();
            btnEditeRenda = new Button();
            btnCustomer = new Button();
            btnAddDespesa = new Button();
            btnAddRenda = new Button();
            panelTitleBar = new Panel();
            lblPage = new Label();
            panelDesctopPanel = new Panel();
            dgvListDespesasNaoPagas = new DataGridView();
            btnAtualizar = new Button();
            lblDespesaMesAtual = new Label();
            lblRendaMesAtual = new Label();
            tbxDespesaMesAtual = new TextBox();
            tbxRendaMesAtual = new TextBox();
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
            panelMenu.Controls.Add(btnPagamentos);
            panelMenu.Controls.Add(btnEditeRenda);
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
            btnLogo.BackColor = Color.FromArgb(39, 39, 70);
            btnLogo.Dock = DockStyle.Top;
            btnLogo.FlatAppearance.BorderSize = 0;
            btnLogo.FlatStyle = FlatStyle.Flat;
            btnLogo.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogo.ForeColor = SystemColors.GradientInactiveCaption;
            btnLogo.Location = new Point(0, 0);
            btnLogo.Margin = new Padding(0);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(220, 80);
            btnLogo.TabIndex = 1;
            btnLogo.Text = "HOME";
            btnLogo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogo.UseVisualStyleBackColor = false;
            btnLogo.Click += btnLogo_Click;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.FromArgb(39, 39, 58);
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
            btnSetting.TabIndex = 7;
            btnSetting.Text = "   =======";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSetting.UseVisualStyleBackColor = false;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnPagamentos
            // 
            btnPagamentos.BackColor = Color.FromArgb(39, 39, 58);
            btnPagamentos.FlatAppearance.BorderSize = 0;
            btnPagamentos.FlatStyle = FlatStyle.Flat;
            btnPagamentos.ForeColor = SystemColors.GradientInactiveCaption;
            btnPagamentos.Image = (Image)resources.GetObject("btnPagamentos.Image");
            btnPagamentos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPagamentos.Location = new Point(0, 260);
            btnPagamentos.Name = "btnPagamentos";
            btnPagamentos.Padding = new Padding(12, 0, 0, 0);
            btnPagamentos.Size = new Size(220, 45);
            btnPagamentos.TabIndex = 6;
            btnPagamentos.Text = "   Pagamentos";
            btnPagamentos.TextAlign = ContentAlignment.MiddleLeft;
            btnPagamentos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPagamentos.UseVisualStyleBackColor = false;
            btnPagamentos.Click += btnNotifications_Click;
            // 
            // btnEditeRenda
            // 
            btnEditeRenda.BackColor = Color.FromArgb(39, 39, 58);
            btnEditeRenda.FlatAppearance.BorderSize = 0;
            btnEditeRenda.FlatStyle = FlatStyle.Flat;
            btnEditeRenda.ForeColor = SystemColors.GradientInactiveCaption;
            btnEditeRenda.Image = (Image)resources.GetObject("btnEditeRenda.Image");
            btnEditeRenda.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditeRenda.Location = new Point(0, 170);
            btnEditeRenda.Name = "btnEditeRenda";
            btnEditeRenda.Padding = new Padding(12, 0, 0, 0);
            btnEditeRenda.Size = new Size(220, 45);
            btnEditeRenda.TabIndex = 4;
            btnEditeRenda.Text = "   Editar Renda";
            btnEditeRenda.TextAlign = ContentAlignment.MiddleLeft;
            btnEditeRenda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditeRenda.UseVisualStyleBackColor = false;
            btnEditeRenda.Click += btnReporting_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.FromArgb(39, 39, 58);
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.ForeColor = SystemColors.GradientInactiveCaption;
            btnCustomer.Image = (Image)resources.GetObject("btnCustomer.Image");
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(0, 215);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Padding = new Padding(12, 0, 0, 0);
            btnCustomer.Size = new Size(220, 45);
            btnCustomer.TabIndex = 5;
            btnCustomer.Text = "   Editar Despesa";
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnEditDespesa_Click;
            // 
            // btnAddDespesa
            // 
            btnAddDespesa.BackColor = Color.FromArgb(39, 39, 58);
            btnAddDespesa.FlatAppearance.BorderSize = 0;
            btnAddDespesa.FlatStyle = FlatStyle.Flat;
            btnAddDespesa.ForeColor = SystemColors.GradientInactiveCaption;
            btnAddDespesa.Image = (Image)resources.GetObject("btnAddDespesa.Image");
            btnAddDespesa.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddDespesa.Location = new Point(0, 125);
            btnAddDespesa.Name = "btnAddDespesa";
            btnAddDespesa.Padding = new Padding(12, 0, 0, 0);
            btnAddDespesa.Size = new Size(220, 45);
            btnAddDespesa.TabIndex = 3;
            btnAddDespesa.Text = "   Adicionar Despesa";
            btnAddDespesa.TextAlign = ContentAlignment.MiddleLeft;
            btnAddDespesa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddDespesa.UseVisualStyleBackColor = false;
            btnAddDespesa.Click += btnAddDespesa_Click;
            // 
            // btnAddRenda
            // 
            btnAddRenda.BackColor = Color.FromArgb(39, 39, 58);
            btnAddRenda.FlatAppearance.BorderSize = 0;
            btnAddRenda.FlatStyle = FlatStyle.Flat;
            btnAddRenda.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddRenda.ForeColor = SystemColors.GradientInactiveCaption;
            btnAddRenda.Image = Properties.Resources.icons8_apresentação_16;
            btnAddRenda.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddRenda.Location = new Point(0, 80);
            btnAddRenda.Margin = new Padding(0);
            btnAddRenda.Name = "btnAddRenda";
            btnAddRenda.Padding = new Padding(12, 0, 0, 0);
            btnAddRenda.Size = new Size(220, 45);
            btnAddRenda.TabIndex = 2;
            btnAddRenda.Text = "   Adicionar Renda";
            btnAddRenda.TextAlign = ContentAlignment.MiddleLeft;
            btnAddRenda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddRenda.UseVisualStyleBackColor = false;
            btnAddRenda.Click += btnAddRenda_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(39, 39, 58);
            panelTitleBar.Controls.Add(lblPage);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(220, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(962, 80);
            panelTitleBar.TabIndex = 1;
            // 
            // lblPage
            // 
            lblPage.Dock = DockStyle.Bottom;
            lblPage.FlatStyle = FlatStyle.System;
            lblPage.Font = new Font("MS PGothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblPage.ForeColor = Color.White;
            lblPage.Location = new Point(0, 30);
            lblPage.Margin = new Padding(0);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(962, 50);
            lblPage.TabIndex = 1;
            lblPage.Text = "HOME";
            lblPage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDesctopPanel
            // 
            panelDesctopPanel.BackColor = SystemColors.InactiveCaption;
            panelDesctopPanel.Controls.Add(dgvListDespesasNaoPagas);
            panelDesctopPanel.Controls.Add(btnAtualizar);
            panelDesctopPanel.Controls.Add(lblDespesaMesAtual);
            panelDesctopPanel.Controls.Add(lblRendaMesAtual);
            panelDesctopPanel.Controls.Add(tbxDespesaMesAtual);
            panelDesctopPanel.Controls.Add(tbxRendaMesAtual);
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
            dgvListDespesasNaoPagas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListDespesasNaoPagas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListDespesasNaoPagas.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListDespesasNaoPagas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListDespesasNaoPagas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListDespesasNaoPagas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListDespesasNaoPagas.Location = new Point(362, 135);
            dgvListDespesasNaoPagas.Name = "dgvListDespesasNaoPagas";
            dgvListDespesasNaoPagas.RowHeadersWidth = 5;
            dgvListDespesasNaoPagas.RowTemplate.Height = 20;
            dgvListDespesasNaoPagas.ScrollBars = ScrollBars.Vertical;
            dgvListDespesasNaoPagas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListDespesasNaoPagas.Size = new Size(455, 170);
            dgvListDespesasNaoPagas.TabIndex = 13;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            lblDespesaMesAtual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDespesaMesAtual.AutoSize = true;
            lblDespesaMesAtual.Location = new Point(10, 192);
            lblDespesaMesAtual.Name = "lblDespesaMesAtual";
            lblDespesaMesAtual.Size = new Size(86, 20);
            lblDespesaMesAtual.TabIndex = 11;
            lblDespesaMesAtual.Text = "Despesa de";
            // 
            // lblRendaMesAtual
            // 
            lblRendaMesAtual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblRendaMesAtual.AutoSize = true;
            lblRendaMesAtual.Location = new Point(10, 155);
            lblRendaMesAtual.Name = "lblRendaMesAtual";
            lblRendaMesAtual.Size = new Size(72, 20);
            lblRendaMesAtual.TabIndex = 10;
            lblRendaMesAtual.Text = "Renda de";
            // 
            // tbxDespesaMesAtual
            // 
            tbxDespesaMesAtual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxDespesaMesAtual.Location = new Point(151, 189);
            tbxDespesaMesAtual.Name = "tbxDespesaMesAtual";
            tbxDespesaMesAtual.Size = new Size(125, 27);
            tbxDespesaMesAtual.TabIndex = 9;
            // 
            // tbxRendaMesAtual
            // 
            tbxRendaMesAtual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxRendaMesAtual.Location = new Point(151, 149);
            tbxRendaMesAtual.Name = "tbxRendaMesAtual";
            tbxRendaMesAtual.Size = new Size(125, 27);
            tbxRendaMesAtual.TabIndex = 8;
            // 
            // lblDespesaAnoAtual
            // 
            lblDespesaAnoAtual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDespesaAnoAtual.AutoSize = true;
            lblDespesaAnoAtual.Location = new Point(362, 57);
            lblDespesaAnoAtual.Name = "lblDespesaAnoAtual";
            lblDespesaAnoAtual.Size = new Size(86, 20);
            lblDespesaAnoAtual.TabIndex = 7;
            lblDespesaAnoAtual.Text = "Despesa de";
            // 
            // lblRendaAnoAtual
            // 
            lblRendaAnoAtual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblRendaAnoAtual.AutoSize = true;
            lblRendaAnoAtual.Location = new Point(362, 20);
            lblRendaAnoAtual.Name = "lblRendaAnoAtual";
            lblRendaAnoAtual.Size = new Size(72, 20);
            lblRendaAnoAtual.TabIndex = 6;
            lblRendaAnoAtual.Text = "Renda de";
            // 
            // tbxDespesaAnoAtual
            // 
            tbxDespesaAnoAtual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxDespesaAnoAtual.Location = new Point(503, 54);
            tbxDespesaAnoAtual.Name = "tbxDespesaAnoAtual";
            tbxDespesaAnoAtual.Size = new Size(125, 27);
            tbxDespesaAnoAtual.TabIndex = 5;
            // 
            // tbxRendaAnoAtual
            // 
            tbxRendaAnoAtual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxRendaAnoAtual.Location = new Point(503, 14);
            tbxRendaAnoAtual.Name = "tbxRendaAnoAtual";
            tbxRendaAnoAtual.Size = new Size(125, 27);
            tbxRendaAnoAtual.TabIndex = 4;
            // 
            // lblDespesaTotal
            // 
            lblDespesaTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDespesaTotal.AutoSize = true;
            lblDespesaTotal.Location = new Point(10, 57);
            lblDespesaTotal.Name = "lblDespesaTotal";
            lblDespesaTotal.Size = new Size(102, 20);
            lblDespesaTotal.TabIndex = 3;
            lblDespesaTotal.Text = "Despesa Total";
            // 
            // lblRendaTotal
            // 
            lblRendaTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblRendaTotal.AutoSize = true;
            lblRendaTotal.Location = new Point(10, 20);
            lblRendaTotal.Name = "lblRendaTotal";
            lblRendaTotal.Size = new Size(88, 20);
            lblRendaTotal.TabIndex = 2;
            lblRendaTotal.Text = "Renda Total";
            // 
            // tbxDespesaTotal
            // 
            tbxDespesaTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxDespesaTotal.Location = new Point(112, 57);
            tbxDespesaTotal.Name = "tbxDespesaTotal";
            tbxDespesaTotal.Size = new Size(125, 27);
            tbxDespesaTotal.TabIndex = 1;
            // 
            // tbxRendaTotal
            // 
            tbxRendaTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle Financeiro";
            panelMenu.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelDesctopPanel.ResumeLayout(false);
            panelDesctopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListDespesasNaoPagas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnSetting;
        private Button btnPagamentos;
        private Button btnEditeRenda;
        private Button btnCustomer;
        private Button btnAddDespesa;
        private Button btnAddRenda;
        private Panel panelTitleBar;
        private Label lblPage;
        private Panel panelDesctopPanel;
        private TextBox tbxRendaTotal;
        private TextBox tbxDespesaTotal;
        private Label lblDespesaMesAtual;
        private Label lblRendaMesAtual;
        private TextBox tbxDespesaMesAtual;
        private TextBox tbxRendaMesAtual;
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