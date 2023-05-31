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
            cldDataVencimento = new MonthCalendar();
            lblDataVencimento = new Label();
            lblTipoDespesa = new Label();
            txtNovaDespesa = new TextBox();
            lblNovaDespesa = new Label();
            lblQtdParcelas = new Label();
            NumUpQtdParcelas = new NumericUpDown();
            cbxFormaPagamento = new ComboBox();
            lblFormaPagamento = new Label();
            ((System.ComponentModel.ISupportInitialize)NumUpQtdParcelas).BeginInit();
            SuspendLayout();
            // 
            // cbTipoDespesa
            // 
            cbTipoDespesa.FormattingEnabled = true;
            cbTipoDespesa.Items.AddRange(new object[] { "Água", "Energia", "Internet", "Claro Rayane", "Claro Thiago", "Academia Rayane", "Academia Thiago", "Feira", "Farmácia", "Combustível", "Emprestimo", "Outros" });
            cbTipoDespesa.Location = new Point(218, 97);
            cbTipoDespesa.Name = "cbTipoDespesa";
            cbTipoDespesa.Size = new Size(171, 28);
            cbTipoDespesa.TabIndex = 20;
            // 
            // cbxDespesaPaga
            // 
            cbxDespesaPaga.AutoSize = true;
            cbxDespesaPaga.Location = new Point(218, 164);
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
            lblDespesaPaga.Location = new Point(63, 165);
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
            // cldDataVencimento
            // 
            cldDataVencimento.Location = new Point(279, 291);
            cldDataVencimento.Name = "cldDataVencimento";
            cldDataVencimento.TabIndex = 15;
            // 
            // lblDataVencimento
            // 
            lblDataVencimento.AutoSize = true;
            lblDataVencimento.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDataVencimento.Location = new Point(63, 291);
            lblDataVencimento.Name = "lblDataVencimento";
            lblDataVencimento.Size = new Size(172, 23);
            lblDataVencimento.TabIndex = 14;
            lblDataVencimento.Text = "Data de Vencimento";
            // 
            // lblTipoDespesa
            // 
            lblTipoDespesa.AutoSize = true;
            lblTipoDespesa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoDespesa.Location = new Point(63, 102);
            lblTipoDespesa.Name = "lblTipoDespesa";
            lblTipoDespesa.Size = new Size(141, 23);
            lblTipoDespesa.TabIndex = 13;
            lblTipoDespesa.Text = "Tipo de Despesa";
            // 
            // txtNovaDespesa
            // 
            txtNovaDespesa.Location = new Point(218, 35);
            txtNovaDespesa.Name = "txtNovaDespesa";
            txtNovaDespesa.Size = new Size(171, 27);
            txtNovaDespesa.TabIndex = 12;
            // 
            // lblNovaDespesa
            // 
            lblNovaDespesa.AutoSize = true;
            lblNovaDespesa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNovaDespesa.Location = new Point(63, 39);
            lblNovaDespesa.Name = "lblNovaDespesa";
            lblNovaDespesa.Size = new Size(146, 23);
            lblNovaDespesa.TabIndex = 11;
            lblNovaDespesa.Text = "Valor da Despesa";
            // 
            // lblQtdParcelas
            // 
            lblQtdParcelas.AutoSize = true;
            lblQtdParcelas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblQtdParcelas.Location = new Point(63, 227);
            lblQtdParcelas.Name = "lblQtdParcelas";
            lblQtdParcelas.Size = new Size(198, 23);
            lblQtdParcelas.TabIndex = 21;
            lblQtdParcelas.Text = "Quantidade de Parcelas";
            // 
            // NumUpQtdParcelas
            // 
            NumUpQtdParcelas.Location = new Point(267, 223);
            NumUpQtdParcelas.Name = "NumUpQtdParcelas";
            NumUpQtdParcelas.Size = new Size(52, 27);
            NumUpQtdParcelas.TabIndex = 22;
            NumUpQtdParcelas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbxFormaPagamento
            // 
            cbxFormaPagamento.FormattingEnabled = true;
            cbxFormaPagamento.Items.AddRange(new object[] { "Cartão Nubanck Rayane", "Cartão Nubanck Thiago", "Cartão Riachuelo", "Cartão Renner Rayane", "Cartão Renner Mario", "Cartão Arnaldo", "Cartão Francisca", "Cartão Adalto", "Cartão Joyce", "Cartão Witami", "Cartão Thayse", "Cartão Auzi", "Dinheiro", "Outros" });
            cbxFormaPagamento.Location = new Point(593, 97);
            cbxFormaPagamento.Name = "cbxFormaPagamento";
            cbxFormaPagamento.Size = new Size(171, 28);
            cbxFormaPagamento.TabIndex = 24;
            // 
            // lblFormaPagamento
            // 
            lblFormaPagamento.AutoSize = true;
            lblFormaPagamento.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormaPagamento.Location = new Point(405, 102);
            lblFormaPagamento.Name = "lblFormaPagamento";
            lblFormaPagamento.Size = new Size(182, 23);
            lblFormaPagamento.TabIndex = 23;
            lblFormaPagamento.Text = "Forma de Pagamento";
            // 
            // FormAddDespesa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 626);
            Controls.Add(cbxFormaPagamento);
            Controls.Add(lblFormaPagamento);
            Controls.Add(NumUpQtdParcelas);
            Controls.Add(lblQtdParcelas);
            Controls.Add(cbTipoDespesa);
            Controls.Add(cbxDespesaPaga);
            Controls.Add(lblDespesaPaga);
            Controls.Add(btnSalvar);
            Controls.Add(btnCanelar);
            Controls.Add(cldDataVencimento);
            Controls.Add(lblDataVencimento);
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
        private MonthCalendar cldDataVencimento;
        private Label lblDataVencimento;
        private Label lblTipoDespesa;
        private TextBox txtNovaDespesa;
        private Label lblNovaDespesa;
        private Label lblQtdParcelas;
        private NumericUpDown NumUpQtdParcelas;
        private ComboBox cbxFormaPagamento;
        private Label lblFormaPagamento;
    }
}