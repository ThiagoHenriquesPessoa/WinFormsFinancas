namespace WinFormsFinancas.Forms
{
    partial class FormAddDespesa
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
            cbTipoDespesa = new ComboBox();
            cbxDespesaPaga = new CheckBox();
            lblDespesaPaga = new Label();
            btnSalvar = new Button();
            btnCanelar = new Button();
            cldDataCriacao = new MonthCalendar();
            lblDataCriacao = new Label();
            lblTipoDespesa = new Label();
            txtNovaDespesa = new TextBox();
            lblNovaDespesa = new Label();
            lblQtdParcelas = new Label();
            NumUpQtdParcelas = new NumericUpDown();
            cbxFormaPagamento = new ComboBox();
            lblFormaPagamento = new Label();
            cldDataVencimento = new MonthCalendar();
            lblDataVencimento = new Label();
            ((System.ComponentModel.ISupportInitialize)NumUpQtdParcelas).BeginInit();
            SuspendLayout();
            // 
            // cbTipoDespesa
            // 
            cbTipoDespesa.FormattingEnabled = true;
            cbTipoDespesa.Items.AddRange(new object[] { "Água", "Energia", "Internet", "Claro Rayane", "Claro Thiago", "Academia Rayane", "Academia Thiago", "Feira", "Farmácia", "Combustível", "Emprestimo", "Outros" });
            cbTipoDespesa.Location = new Point(241, 134);
            cbTipoDespesa.Name = "cbTipoDespesa";
            cbTipoDespesa.Size = new Size(171, 28);
            cbTipoDespesa.TabIndex = 20;
            // 
            // cbxDespesaPaga
            // 
            cbxDespesaPaga.AutoSize = true;
            cbxDespesaPaga.Location = new Point(583, 75);
            cbxDespesaPaga.Name = "cbxDespesaPaga";
            cbxDespesaPaga.Size = new Size(56, 24);
            cbxDespesaPaga.TabIndex = 19;
            cbxDespesaPaga.Text = "Sim";
            cbxDespesaPaga.UseVisualStyleBackColor = true;
            // 
            // lblDespesaPaga
            // 
            lblDespesaPaga.AutoSize = true;
            lblDespesaPaga.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDespesaPaga.Location = new Point(428, 76);
            lblDespesaPaga.Name = "lblDespesaPaga";
            lblDespesaPaga.Size = new Size(119, 23);
            lblDespesaPaga.TabIndex = 18;
            lblDespesaPaga.Text = "Despesa Paga";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(798, 564);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCanelar
            // 
            btnCanelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCanelar.Location = new Point(670, 564);
            btnCanelar.Name = "btnCanelar";
            btnCanelar.Size = new Size(94, 29);
            btnCanelar.TabIndex = 16;
            btnCanelar.Text = "Canelar";
            btnCanelar.UseVisualStyleBackColor = true;
            btnCanelar.Click += btnCanelar_Click;
            // 
            // cldDataCriacao
            // 
            cldDataCriacao.Location = new Point(157, 231);
            cldDataCriacao.Name = "cldDataCriacao";
            cldDataCriacao.TabIndex = 15;
            // 
            // lblDataCriacao
            // 
            lblDataCriacao.AutoSize = true;
            lblDataCriacao.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDataCriacao.Location = new Point(86, 199);
            lblDataCriacao.Name = "lblDataCriacao";
            lblDataCriacao.Size = new Size(137, 23);
            lblDataCriacao.TabIndex = 14;
            lblDataCriacao.Text = "Data de Criação";
            // 
            // lblTipoDespesa
            // 
            lblTipoDespesa.AutoSize = true;
            lblTipoDespesa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoDespesa.Location = new Point(86, 139);
            lblTipoDespesa.Name = "lblTipoDespesa";
            lblTipoDespesa.Size = new Size(141, 23);
            lblTipoDespesa.TabIndex = 13;
            lblTipoDespesa.Text = "Tipo de Despesa";
            // 
            // txtNovaDespesa
            // 
            txtNovaDespesa.Location = new Point(241, 72);
            txtNovaDespesa.Name = "txtNovaDespesa";
            txtNovaDespesa.Size = new Size(171, 27);
            txtNovaDespesa.TabIndex = 12;
            // 
            // lblNovaDespesa
            // 
            lblNovaDespesa.AutoSize = true;
            lblNovaDespesa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNovaDespesa.Location = new Point(86, 76);
            lblNovaDespesa.Name = "lblNovaDespesa";
            lblNovaDespesa.Size = new Size(146, 23);
            lblNovaDespesa.TabIndex = 11;
            lblNovaDespesa.Text = "Valor da Despesa";
            // 
            // lblQtdParcelas
            // 
            lblQtdParcelas.AutoSize = true;
            lblQtdParcelas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblQtdParcelas.Location = new Point(86, 477);
            lblQtdParcelas.Name = "lblQtdParcelas";
            lblQtdParcelas.Size = new Size(198, 23);
            lblQtdParcelas.TabIndex = 21;
            lblQtdParcelas.Text = "Quantidade de Parcelas";
            // 
            // NumUpQtdParcelas
            // 
            NumUpQtdParcelas.Location = new Point(290, 473);
            NumUpQtdParcelas.Name = "NumUpQtdParcelas";
            NumUpQtdParcelas.Size = new Size(52, 27);
            NumUpQtdParcelas.TabIndex = 22;
            NumUpQtdParcelas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbxFormaPagamento
            // 
            cbxFormaPagamento.FormattingEnabled = true;
            cbxFormaPagamento.Items.AddRange(new object[] { "Cartão Nubanck Rayane", "Cartão Nubanck Thiago", "Cartão Riachuelo", "Cartão Renner Rayane", "Cartão Renner Mario", "Cartão Arnaldo", "Cartão Francisca", "Cartão Adalto", "Cartão Joyce", "Cartão Witami", "Cartão Thayse", "Cartão Auzi", "Dinheiro", "Outros" });
            cbxFormaPagamento.Location = new Point(616, 134);
            cbxFormaPagamento.Name = "cbxFormaPagamento";
            cbxFormaPagamento.Size = new Size(171, 28);
            cbxFormaPagamento.TabIndex = 24;
            // 
            // lblFormaPagamento
            // 
            lblFormaPagamento.AutoSize = true;
            lblFormaPagamento.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormaPagamento.Location = new Point(428, 139);
            lblFormaPagamento.Name = "lblFormaPagamento";
            lblFormaPagamento.Size = new Size(182, 23);
            lblFormaPagamento.TabIndex = 23;
            lblFormaPagamento.Text = "Forma de Pagamento";
            // 
            // cldDataVencimento
            // 
            cldDataVencimento.Location = new Point(501, 231);
            cldDataVencimento.Name = "cldDataVencimento";
            cldDataVencimento.TabIndex = 26;
            // 
            // lblDataVencimento
            // 
            lblDataVencimento.AutoSize = true;
            lblDataVencimento.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDataVencimento.Location = new Point(428, 199);
            lblDataVencimento.Name = "lblDataVencimento";
            lblDataVencimento.Size = new Size(172, 23);
            lblDataVencimento.TabIndex = 25;
            lblDataVencimento.Text = "Data de Vencimento";
            // 
            // FormAddDespesa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 626);
            Controls.Add(cldDataVencimento);
            Controls.Add(lblDataVencimento);
            Controls.Add(cbxFormaPagamento);
            Controls.Add(lblFormaPagamento);
            Controls.Add(NumUpQtdParcelas);
            Controls.Add(lblQtdParcelas);
            Controls.Add(cbTipoDespesa);
            Controls.Add(cbxDespesaPaga);
            Controls.Add(lblDespesaPaga);
            Controls.Add(btnSalvar);
            Controls.Add(btnCanelar);
            Controls.Add(cldDataCriacao);
            Controls.Add(lblDataCriacao);
            Controls.Add(lblTipoDespesa);
            Controls.Add(txtNovaDespesa);
            Controls.Add(lblNovaDespesa);
            Name = "FormAddDespesa";
            Text = "Adicionar Despesa";
            ((System.ComponentModel.ISupportInitialize)NumUpQtdParcelas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTipoDespesa;
        private CheckBox cbxDespesaPaga;
        private Label lblDespesaPaga;
        private Button btnSalvar;
        private Button btnCanelar;
        private MonthCalendar cldDataCriacao;
        private Label lblDataCriacao;
        private Label lblTipoDespesa;
        private TextBox txtNovaDespesa;
        private Label lblNovaDespesa;
        private Label lblQtdParcelas;
        private NumericUpDown NumUpQtdParcelas;
        private ComboBox cbxFormaPagamento;
        private Label lblFormaPagamento;
        private MonthCalendar cldDataVencimento;
        private Label lblDataVencimento;
    }
}