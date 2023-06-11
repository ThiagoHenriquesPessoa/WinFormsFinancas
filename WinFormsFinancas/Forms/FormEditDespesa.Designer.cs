namespace WinFormsFinancas.Forms
{
    partial class FormEditDespesa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExcluir = new Button();
            lblListaDespesa = new Label();
            dtpDataFim = new DateTimePicker();
            dtpDataInicial = new DateTimePicker();
            btnExibirLista = new Button();
            dgvListaDespesas = new DataGridView();
            btnSalvar = new Button();
            lblDataVencimento = new Label();
            cbxFormaPagamento = new ComboBox();
            lblFormaPagamento = new Label();
            lblQtdParcelas = new Label();
            cbTipoDespesa = new ComboBox();
            cbxDespesaPaga = new CheckBox();
            lblDespesaPaga = new Label();
            lblDataCriacao = new Label();
            lblTipoDespesa = new Label();
            txtNovaDespesa = new TextBox();
            lblNovaDespesa = new Label();
            cldDataCriacao = new DateTimePicker();
            cldDataVencimento = new DateTimePicker();
            txtQlbParcelas = new TextBox();
            txtParcelaAtual = new TextBox();
            lblParcelaAtual = new Label();
            lblIdDespesa = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListaDespesas).BeginInit();
            SuspendLayout();
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.Location = new Point(698, 576);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 30;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // lblListaDespesa
            // 
            lblListaDespesa.AutoSize = true;
            lblListaDespesa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaDespesa.Location = new Point(58, 38);
            lblListaDespesa.Name = "lblListaDespesa";
            lblListaDespesa.Size = new Size(149, 23);
            lblListaDespesa.TabIndex = 25;
            lblListaDespesa.Text = "Lista de Despesas";
            // 
            // dtpDataFim
            // 
            dtpDataFim.Format = DateTimePickerFormat.Short;
            dtpDataFim.Location = new Point(360, 38);
            dtpDataFim.Name = "dtpDataFim";
            dtpDataFim.Size = new Size(105, 27);
            dtpDataFim.TabIndex = 32;
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.Format = DateTimePickerFormat.Short;
            dtpDataInicial.ImeMode = ImeMode.NoControl;
            dtpDataInicial.Location = new Point(231, 38);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.Size = new Size(105, 27);
            dtpDataInicial.TabIndex = 33;
            // 
            // btnExibirLista
            // 
            btnExibirLista.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExibirLista.Location = new Point(516, 38);
            btnExibirLista.Name = "btnExibirLista";
            btnExibirLista.Size = new Size(94, 29);
            btnExibirLista.TabIndex = 34;
            btnExibirLista.Text = "Exibir";
            btnExibirLista.UseVisualStyleBackColor = true;
            btnExibirLista.Click += btnExibirLista_Click;
            // 
            // dgvListaDespesas
            // 
            dgvListaDespesas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaDespesas.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvListaDespesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaDespesas.Location = new Point(36, 82);
            dgvListaDespesas.Name = "dgvListaDespesas";
            dgvListaDespesas.RowHeadersWidth = 4;
            dgvListaDespesas.RowTemplate.Height = 29;
            dgvListaDespesas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaDespesas.Size = new Size(877, 221);
            dgvListaDespesas.TabIndex = 13;
            dgvListaDespesas.CellMouseClick += dgvListaDespesas_CellMouseClick;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(819, 576);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 35;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnEditar_Click;
            // 
            // lblDataVencimento
            // 
            lblDataVencimento.AutoSize = true;
            lblDataVencimento.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDataVencimento.Location = new Point(428, 459);
            lblDataVencimento.Name = "lblDataVencimento";
            lblDataVencimento.Size = new Size(172, 23);
            lblDataVencimento.TabIndex = 55;
            lblDataVencimento.Text = "Data de Vencimento";
            // 
            // cbxFormaPagamento
            // 
            cbxFormaPagamento.FormattingEnabled = true;
            cbxFormaPagamento.Items.AddRange(new object[] { "Cartão Nubanck Rayane", "Cartão Nubanck Thiago", "Cartão Riachuelo", "Cartão Renner Rayane", "Cartão Renner Mario", "Cartão Arnaldo", "Cartão Francisca", "Cartão Adalto", "Cartão Joyce", "Cartão Witami", "Cartão Thayse", "Cartão Auzi", "Dinheiro", "Outros" });
            cbxFormaPagamento.Location = new Point(616, 394);
            cbxFormaPagamento.Name = "cbxFormaPagamento";
            cbxFormaPagamento.Size = new Size(171, 28);
            cbxFormaPagamento.TabIndex = 54;
            // 
            // lblFormaPagamento
            // 
            lblFormaPagamento.AutoSize = true;
            lblFormaPagamento.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormaPagamento.Location = new Point(428, 399);
            lblFormaPagamento.Name = "lblFormaPagamento";
            lblFormaPagamento.Size = new Size(182, 23);
            lblFormaPagamento.TabIndex = 53;
            lblFormaPagamento.Text = "Forma de Pagamento";
            // 
            // lblQtdParcelas
            // 
            lblQtdParcelas.AutoSize = true;
            lblQtdParcelas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblQtdParcelas.Location = new Point(86, 509);
            lblQtdParcelas.Name = "lblQtdParcelas";
            lblQtdParcelas.Size = new Size(198, 23);
            lblQtdParcelas.TabIndex = 51;
            lblQtdParcelas.Text = "Quantidade de Parcelas";
            // 
            // cbTipoDespesa
            // 
            cbTipoDespesa.FormattingEnabled = true;
            cbTipoDespesa.Items.AddRange(new object[] { "Água", "Energia", "Internet", "Claro Rayane", "Claro Thiago", "Academia Rayane", "Academia Thiago", "Feira", "Farmácia", "Combustível", "Emprestimo", "Outros" });
            cbTipoDespesa.Location = new Point(241, 394);
            cbTipoDespesa.Name = "cbTipoDespesa";
            cbTipoDespesa.Size = new Size(171, 28);
            cbTipoDespesa.TabIndex = 50;
            // 
            // cbxDespesaPaga
            // 
            cbxDespesaPaga.AutoSize = true;
            cbxDespesaPaga.Location = new Point(583, 335);
            cbxDespesaPaga.Name = "cbxDespesaPaga";
            cbxDespesaPaga.Size = new Size(56, 24);
            cbxDespesaPaga.TabIndex = 49;
            cbxDespesaPaga.Text = "Sim";
            cbxDespesaPaga.UseVisualStyleBackColor = true;
            // 
            // lblDespesaPaga
            // 
            lblDespesaPaga.AutoSize = true;
            lblDespesaPaga.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDespesaPaga.Location = new Point(428, 336);
            lblDespesaPaga.Name = "lblDespesaPaga";
            lblDespesaPaga.Size = new Size(119, 23);
            lblDespesaPaga.TabIndex = 48;
            lblDespesaPaga.Text = "Despesa Paga";
            // 
            // lblDataCriacao
            // 
            lblDataCriacao.AutoSize = true;
            lblDataCriacao.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDataCriacao.Location = new Point(86, 459);
            lblDataCriacao.Name = "lblDataCriacao";
            lblDataCriacao.Size = new Size(137, 23);
            lblDataCriacao.TabIndex = 46;
            lblDataCriacao.Text = "Data de Criação";
            // 
            // lblTipoDespesa
            // 
            lblTipoDespesa.AutoSize = true;
            lblTipoDespesa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoDespesa.Location = new Point(86, 399);
            lblTipoDespesa.Name = "lblTipoDespesa";
            lblTipoDespesa.Size = new Size(141, 23);
            lblTipoDespesa.TabIndex = 45;
            lblTipoDespesa.Text = "Tipo de Despesa";
            // 
            // txtNovaDespesa
            // 
            txtNovaDespesa.Location = new Point(241, 332);
            txtNovaDespesa.Name = "txtNovaDespesa";
            txtNovaDespesa.Size = new Size(171, 27);
            txtNovaDespesa.TabIndex = 44;
            // 
            // lblNovaDespesa
            // 
            lblNovaDespesa.AutoSize = true;
            lblNovaDespesa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNovaDespesa.Location = new Point(86, 336);
            lblNovaDespesa.Name = "lblNovaDespesa";
            lblNovaDespesa.Size = new Size(146, 23);
            lblNovaDespesa.TabIndex = 43;
            lblNovaDespesa.Text = "Valor da Despesa";
            // 
            // cldDataCriacao
            // 
            cldDataCriacao.Format = DateTimePickerFormat.Short;
            cldDataCriacao.ImeMode = ImeMode.NoControl;
            cldDataCriacao.Location = new Point(241, 455);
            cldDataCriacao.Name = "cldDataCriacao";
            cldDataCriacao.Size = new Size(105, 27);
            cldDataCriacao.TabIndex = 57;
            cldDataCriacao.Value = new DateTime(2023, 6, 11, 1, 30, 0, 0);
            // 
            // cldDataVencimento
            // 
            cldDataVencimento.Format = DateTimePickerFormat.Short;
            cldDataVencimento.Location = new Point(616, 455);
            cldDataVencimento.Name = "cldDataVencimento";
            cldDataVencimento.Size = new Size(105, 27);
            cldDataVencimento.TabIndex = 56;
            // 
            // txtQlbParcelas
            // 
            txtQlbParcelas.Location = new Point(290, 509);
            txtQlbParcelas.Name = "txtQlbParcelas";
            txtQlbParcelas.Size = new Size(56, 27);
            txtQlbParcelas.TabIndex = 58;
            // 
            // txtParcelaAtual
            // 
            txtParcelaAtual.Location = new Point(616, 509);
            txtParcelaAtual.Name = "txtParcelaAtual";
            txtParcelaAtual.Size = new Size(56, 27);
            txtParcelaAtual.TabIndex = 60;
            // 
            // lblParcelaAtual
            // 
            lblParcelaAtual.AutoSize = true;
            lblParcelaAtual.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblParcelaAtual.Location = new Point(428, 509);
            lblParcelaAtual.Name = "lblParcelaAtual";
            lblParcelaAtual.Size = new Size(115, 23);
            lblParcelaAtual.TabIndex = 59;
            lblParcelaAtual.Text = "Parcela Atual";
            // 
            // lblIdDespesa
            // 
            lblIdDespesa.AutoSize = true;
            lblIdDespesa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdDespesa.Location = new Point(86, 552);
            lblIdDespesa.Name = "lblIdDespesa";
            lblIdDespesa.Size = new Size(20, 23);
            lblIdDespesa.TabIndex = 61;
            lblIdDespesa.Text = "0";
            lblIdDespesa.Visible = false;
            // 
            // FormEditDespesa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 626);
            Controls.Add(lblIdDespesa);
            Controls.Add(txtParcelaAtual);
            Controls.Add(lblParcelaAtual);
            Controls.Add(txtQlbParcelas);
            Controls.Add(cldDataCriacao);
            Controls.Add(cldDataVencimento);
            Controls.Add(lblDataVencimento);
            Controls.Add(cbxFormaPagamento);
            Controls.Add(lblFormaPagamento);
            Controls.Add(lblQtdParcelas);
            Controls.Add(cbTipoDespesa);
            Controls.Add(cbxDespesaPaga);
            Controls.Add(lblDespesaPaga);
            Controls.Add(lblDataCriacao);
            Controls.Add(lblTipoDespesa);
            Controls.Add(txtNovaDespesa);
            Controls.Add(lblNovaDespesa);
            Controls.Add(btnSalvar);
            Controls.Add(dgvListaDespesas);
            Controls.Add(btnExibirLista);
            Controls.Add(dtpDataInicial);
            Controls.Add(dtpDataFim);
            Controls.Add(btnExcluir);
            Controls.Add(lblListaDespesa);
            Name = "FormEditDespesa";
            Text = "FormEditDespesa";
            ((System.ComponentModel.ISupportInitialize)dgvListaDespesas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxFormaPagamento;
        private Label lblFormaPagamento;
        private Label lblQtdParcelas;
        private ComboBox cbTipoDespesa;
        private CheckBox cbxDespesaPaga;
        private Label lblDespesaPaga;
        private Button btnSalvar;
        private Button btnExcluir;
        private Label lblDataVencimento;
        private Label lblTipoDespesa;
        private TextBox txtNovaDespesa;
        private Label lblListaDespesa;
        private DateTimePicker dtpDataFim;
        private DateTimePicker dtpDataInicial;
        private Button btnExibirLista;
        private DataGridView dgvListaDespesas;
        private Label lblDataCriacao;
        private Label lblNovaDespesa;
        private DateTimePicker cldDataCriacao;
        private DateTimePicker cldDataVencimento;
        private TextBox txtQlbParcelas;
        private TextBox txtParcelaAtual;
        private Label lblParcelaAtual;
        private Label lblIdDespesa;
    }
}