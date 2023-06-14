namespace WinFormsFinancas.Forms
{
    partial class FormEditRenda
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
            dgvListaRenda = new DataGridView();
            btnExibirLista = new Button();
            dtpDataInicial = new DateTimePicker();
            dtpDataFim = new DateTimePicker();
            lblListaDespesa = new Label();
            btnSalvar = new Button();
            btnExcluir = new Button();
            cbTipoRenda = new ComboBox();
            lblDataEntrada = new Label();
            lblTipoRenda = new Label();
            txtNovaRenda = new TextBox();
            lblNovaRenda = new Label();
            cldDataEntrada = new DateTimePicker();
            lblIdRenda = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListaRenda).BeginInit();
            SuspendLayout();
            // 
            // dgvListaRenda
            // 
            dgvListaRenda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaRenda.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvListaRenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaRenda.Location = new Point(28, 91);
            dgvListaRenda.Name = "dgvListaRenda";
            dgvListaRenda.RowHeadersWidth = 4;
            dgvListaRenda.RowTemplate.Height = 29;
            dgvListaRenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaRenda.Size = new Size(877, 342);
            dgvListaRenda.TabIndex = 35;
            dgvListaRenda.CellMouseClick += dgvListaRenda_CellMouseClick;
            // 
            // btnExibirLista
            // 
            btnExibirLista.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExibirLista.Location = new Point(508, 47);
            btnExibirLista.Name = "btnExibirLista";
            btnExibirLista.Size = new Size(94, 29);
            btnExibirLista.TabIndex = 39;
            btnExibirLista.Text = "Exibir";
            btnExibirLista.UseVisualStyleBackColor = true;
            btnExibirLista.Click += btnExibirLista_Click;
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.Format = DateTimePickerFormat.Short;
            dtpDataInicial.ImeMode = ImeMode.NoControl;
            dtpDataInicial.Location = new Point(223, 47);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.Size = new Size(105, 27);
            dtpDataInicial.TabIndex = 38;
            // 
            // dtpDataFim
            // 
            dtpDataFim.Format = DateTimePickerFormat.Short;
            dtpDataFim.Location = new Point(352, 47);
            dtpDataFim.Name = "dtpDataFim";
            dtpDataFim.Size = new Size(105, 27);
            dtpDataFim.TabIndex = 37;
            // 
            // lblListaDespesa
            // 
            lblListaDespesa.AutoSize = true;
            lblListaDespesa.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblListaDespesa.Location = new Point(50, 47);
            lblListaDespesa.Name = "lblListaDespesa";
            lblListaDespesa.Size = new Size(127, 23);
            lblListaDespesa.TabIndex = 36;
            lblListaDespesa.Text = "Lista de Renda";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(811, 575);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 41;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.Location = new Point(690, 575);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 40;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // cbTipoRenda
            // 
            cbTipoRenda.FormattingEnabled = true;
            cbTipoRenda.Items.AddRange(new object[] { "Salario", "Extra", "Emprestimo", "Pis", "Outros" });
            cbTipoRenda.Location = new Point(431, 480);
            cbTipoRenda.Name = "cbTipoRenda";
            cbTipoRenda.Size = new Size(171, 28);
            cbTipoRenda.TabIndex = 47;
            // 
            // lblDataEntrada
            // 
            lblDataEntrada.AutoSize = true;
            lblDataEntrada.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDataEntrada.Location = new Point(654, 485);
            lblDataEntrada.Name = "lblDataEntrada";
            lblDataEntrada.Size = new Size(140, 23);
            lblDataEntrada.TabIndex = 45;
            lblDataEntrada.Text = "Data de Entrada";
            // 
            // lblTipoRenda
            // 
            lblTipoRenda.AutoSize = true;
            lblTipoRenda.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoRenda.Location = new Point(299, 485);
            lblTipoRenda.Name = "lblTipoRenda";
            lblTipoRenda.Size = new Size(126, 23);
            lblTipoRenda.TabIndex = 44;
            lblTipoRenda.Text = "Tipo de Renda";
            // 
            // txtNovaRenda
            // 
            txtNovaRenda.Location = new Point(166, 480);
            txtNovaRenda.Name = "txtNovaRenda";
            txtNovaRenda.Size = new Size(99, 27);
            txtNovaRenda.TabIndex = 43;
            // 
            // lblNovaRenda
            // 
            lblNovaRenda.AutoSize = true;
            lblNovaRenda.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNovaRenda.Location = new Point(29, 484);
            lblNovaRenda.Name = "lblNovaRenda";
            lblNovaRenda.Size = new Size(131, 23);
            lblNovaRenda.TabIndex = 42;
            lblNovaRenda.Text = "Valor da Renda";
            // 
            // cldDataEntrada
            // 
            cldDataEntrada.Format = DateTimePickerFormat.Short;
            cldDataEntrada.ImeMode = ImeMode.NoControl;
            cldDataEntrada.Location = new Point(800, 481);
            cldDataEntrada.Name = "cldDataEntrada";
            cldDataEntrada.Size = new Size(105, 27);
            cldDataEntrada.TabIndex = 48;
            // 
            // lblIdRenda
            // 
            lblIdRenda.AutoSize = true;
            lblIdRenda.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblIdRenda.Location = new Point(28, 538);
            lblIdRenda.Name = "lblIdRenda";
            lblIdRenda.Size = new Size(20, 23);
            lblIdRenda.TabIndex = 49;
            lblIdRenda.Text = "0";
            lblIdRenda.Visible = false;
            // 
            // FormEditRenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(944, 626);
            Controls.Add(lblIdRenda);
            Controls.Add(cldDataEntrada);
            Controls.Add(cbTipoRenda);
            Controls.Add(lblDataEntrada);
            Controls.Add(lblTipoRenda);
            Controls.Add(txtNovaRenda);
            Controls.Add(lblNovaRenda);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(dgvListaRenda);
            Controls.Add(btnExibirLista);
            Controls.Add(dtpDataInicial);
            Controls.Add(dtpDataFim);
            Controls.Add(lblListaDespesa);
            Name = "FormEditRenda";
            Text = "FormEditRenda";
            ((System.ComponentModel.ISupportInitialize)dgvListaRenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListaRenda;
        private Button btnExibirLista;
        private DateTimePicker dtpDataInicial;
        private DateTimePicker dtpDataFim;
        private Label lblListaDespesa;
        private Button btnSalvar;
        private Button btnExcluir;
        private ComboBox cbTipoRenda;
        private Label lblDataEntrada;
        private Label lblTipoRenda;
        private TextBox txtNovaRenda;
        private Label lblNovaRenda;
        private DateTimePicker cldDataEntrada;
        private Label lblIdRenda;
    }
}