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
            dgvListaDespesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaDespesas.Location = new Point(36, 82);
            dgvListaDespesas.Name = "dgvListaDespesas";
            dgvListaDespesas.RowHeadersWidth = 51;
            dgvListaDespesas.RowTemplate.Height = 29;
            dgvListaDespesas.Size = new Size(877, 464);
            dgvListaDespesas.TabIndex = 35;
            // 
            // FormEditDespesa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 626);
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
        private NumericUpDown NumUpQtdParcelas;
        private Label lblQtdParcelas;
        private ComboBox cbTipoDespesa;
        private CheckBox cbxDespesaPaga;
        private Label lblDespesaPaga;
        private Button btnSalvar;
        private Button btnExcluir;
        private MonthCalendar cldDataVencimento;
        private Label lblDataVencimento;
        private Label lblTipoDespesa;
        private TextBox txtNovaDespesa;
        private Label lblListaDespesa;
        private DateTimePicker dtpDataFim;
        private DateTimePicker dtpDataInicial;
        private Button btnExibirLista;
        private DataGridView dgvListaDespesas;
    }
}