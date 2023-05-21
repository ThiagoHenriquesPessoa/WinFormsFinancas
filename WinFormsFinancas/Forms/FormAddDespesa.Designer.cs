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
            cbxValorDespesaFixo = new CheckBox();
            lblValorDespesaFixa = new Label();
            btnSalvar = new Button();
            btnCanelar = new Button();
            cldDataVencimento = new MonthCalendar();
            lblDataVencimento = new Label();
            lblTipoDespesa = new Label();
            txtNovaDespesa = new TextBox();
            lblNovaDespesa = new Label();
            lblQtdParcelas = new Label();
            NumUpQtdParcelas = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NumUpQtdParcelas).BeginInit();
            SuspendLayout();
            // 
            // cbTipoDespesa
            // 
            cbTipoDespesa.FormattingEnabled = true;
            cbTipoDespesa.Items.AddRange(new object[] { "Salario", "Extra", "Emprestimo", "Pis", "Outros" });
            cbTipoDespesa.Location = new Point(205, 71);
            cbTipoDespesa.Name = "cbTipoDespesa";
            cbTipoDespesa.Size = new Size(171, 28);
            cbTipoDespesa.TabIndex = 20;
            // 
            // cbxValorDespesaFixo
            // 
            cbxValorDespesaFixo.AutoSize = true;
            cbxValorDespesaFixo.Location = new Point(205, 126);
            cbxValorDespesaFixo.Name = "cbxValorDespesaFixo";
            cbxValorDespesaFixo.Size = new Size(56, 24);
            cbxValorDespesaFixo.TabIndex = 19;
            cbxValorDespesaFixo.Text = "Sim";
            cbxValorDespesaFixo.UseVisualStyleBackColor = true;
            // 
            // lblValorDespesaFixa
            // 
            lblValorDespesaFixa.AutoSize = true;
            lblValorDespesaFixa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblValorDespesaFixa.Location = new Point(50, 127);
            lblValorDespesaFixa.Name = "lblValorDespesaFixa";
            lblValorDespesaFixa.Size = new Size(89, 23);
            lblValorDespesaFixa.TabIndex = 18;
            lblValorDespesaFixa.Text = "Valor Fixo";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(657, 401);
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
            btnCanelar.Location = new Point(529, 401);
            btnCanelar.Name = "btnCanelar";
            btnCanelar.Size = new Size(94, 29);
            btnCanelar.TabIndex = 16;
            btnCanelar.Text = "Canelar";
            btnCanelar.UseVisualStyleBackColor = true;
            // 
            // cldDataVencimento
            // 
            cldDataVencimento.Location = new Point(234, 223);
            cldDataVencimento.Name = "cldDataVencimento";
            cldDataVencimento.TabIndex = 15;
            // 
            // lblDataVencimento
            // 
            lblDataVencimento.AutoSize = true;
            lblDataVencimento.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDataVencimento.Location = new Point(50, 223);
            lblDataVencimento.Name = "lblDataVencimento";
            lblDataVencimento.Size = new Size(172, 23);
            lblDataVencimento.TabIndex = 14;
            lblDataVencimento.Text = "Data de Vencimento";
            // 
            // lblTipoDespesa
            // 
            lblTipoDespesa.AutoSize = true;
            lblTipoDespesa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoDespesa.Location = new Point(50, 76);
            lblTipoDespesa.Name = "lblTipoDespesa";
            lblTipoDespesa.Size = new Size(126, 23);
            lblTipoDespesa.TabIndex = 13;
            lblTipoDespesa.Text = "Tipo de Renda";
            // 
            // txtNovaDespesa
            // 
            txtNovaDespesa.Location = new Point(205, 20);
            txtNovaDespesa.Name = "txtNovaDespesa";
            txtNovaDespesa.Size = new Size(171, 27);
            txtNovaDespesa.TabIndex = 12;
            // 
            // lblNovaDespesa
            // 
            lblNovaDespesa.AutoSize = true;
            lblNovaDespesa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNovaDespesa.Location = new Point(50, 24);
            lblNovaDespesa.Name = "lblNovaDespesa";
            lblNovaDespesa.Size = new Size(121, 23);
            lblNovaDespesa.TabIndex = 11;
            lblNovaDespesa.Text = "Nova Despesa";
            // 
            // lblQtdParcelas
            // 
            lblQtdParcelas.AutoSize = true;
            lblQtdParcelas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblQtdParcelas.Location = new Point(50, 177);
            lblQtdParcelas.Name = "lblQtdParcelas";
            lblQtdParcelas.Size = new Size(198, 23);
            lblQtdParcelas.TabIndex = 21;
            lblQtdParcelas.Text = "Quantidade de Parcelas";
            // 
            // NumUpQtdParcelas
            // 
            NumUpQtdParcelas.Location = new Point(254, 173);
            NumUpQtdParcelas.Name = "NumUpQtdParcelas";
            NumUpQtdParcelas.Size = new Size(52, 27);
            NumUpQtdParcelas.TabIndex = 22;
            NumUpQtdParcelas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FormAddDespesa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NumUpQtdParcelas);
            Controls.Add(lblQtdParcelas);
            Controls.Add(cbTipoDespesa);
            Controls.Add(cbxValorDespesaFixo);
            Controls.Add(lblValorDespesaFixa);
            Controls.Add(btnSalvar);
            Controls.Add(btnCanelar);
            Controls.Add(cldDataVencimento);
            Controls.Add(lblDataVencimento);
            Controls.Add(lblTipoDespesa);
            Controls.Add(txtNovaDespesa);
            Controls.Add(lblNovaDespesa);
            Name = "FormAddDespesa";
            Text = "FormOrders";
            ((System.ComponentModel.ISupportInitialize)NumUpQtdParcelas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTipoDespesa;
        private CheckBox cbxValorDespesaFixo;
        private Label lblValorDespesaFixa;
        private Button btnSalvar;
        private Button btnCanelar;
        private MonthCalendar cldDataVencimento;
        private Label lblDataVencimento;
        private Label lblTipoDespesa;
        private TextBox txtNovaDespesa;
        private Label lblNovaDespesa;
        private Label lblQtdParcelas;
        private NumericUpDown NumUpQtdParcelas;
    }
}