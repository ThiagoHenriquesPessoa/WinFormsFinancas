namespace WinFormsFinancas.Forms
{
    partial class FormAddRenda
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
            lblNovaRenda = new Label();
            txtNovaRenda = new TextBox();
            lblTipoRenda = new Label();
            lblDataEntrada = new Label();
            cldDataEntrada = new MonthCalendar();
            btnCanelar = new Button();
            btnSalvar = new Button();
            cbTipoRenda = new ComboBox();
            SuspendLayout();
            // 
            // lblNovaRenda
            // 
            lblNovaRenda.AutoSize = true;
            lblNovaRenda.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNovaRenda.Location = new Point(95, 72);
            lblNovaRenda.Name = "lblNovaRenda";
            lblNovaRenda.Size = new Size(131, 23);
            lblNovaRenda.TabIndex = 0;
            lblNovaRenda.Text = "Valor da Renda";
            // 
            // txtNovaRenda
            // 
            txtNovaRenda.Location = new Point(250, 68);
            txtNovaRenda.Name = "txtNovaRenda";
            txtNovaRenda.Size = new Size(171, 27);
            txtNovaRenda.TabIndex = 1;
            // 
            // lblTipoRenda
            // 
            lblTipoRenda.AutoSize = true;
            lblTipoRenda.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoRenda.Location = new Point(95, 150);
            lblTipoRenda.Name = "lblTipoRenda";
            lblTipoRenda.Size = new Size(126, 23);
            lblTipoRenda.TabIndex = 2;
            lblTipoRenda.Text = "Tipo de Renda";
            // 
            // lblDataEntrada
            // 
            lblDataEntrada.AutoSize = true;
            lblDataEntrada.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDataEntrada.Location = new Point(95, 225);
            lblDataEntrada.Name = "lblDataEntrada";
            lblDataEntrada.Size = new Size(140, 23);
            lblDataEntrada.TabIndex = 4;
            lblDataEntrada.Text = "Data de Entrada";
            // 
            // cldDataEntrada
            // 
            cldDataEntrada.Location = new Point(250, 225);
            cldDataEntrada.Name = "cldDataEntrada";
            cldDataEntrada.TabIndex = 5;
            // 
            // btnCanelar
            // 
            btnCanelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCanelar.Location = new Point(683, 564);
            btnCanelar.Name = "btnCanelar";
            btnCanelar.Size = new Size(94, 29);
            btnCanelar.TabIndex = 6;
            btnCanelar.Text = "Canelar";
            btnCanelar.UseVisualStyleBackColor = true;
            btnCanelar.Click += btnCanelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(811, 564);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // cbTipoRenda
            // 
            cbTipoRenda.FormattingEnabled = true;
            cbTipoRenda.Items.AddRange(new object[] { "Salario", "Extra", "Emprestimo", "Pis", "Outros" });
            cbTipoRenda.Location = new Point(250, 145);
            cbTipoRenda.Name = "cbTipoRenda";
            cbTipoRenda.Size = new Size(171, 28);
            cbTipoRenda.TabIndex = 10;
            // 
            // FormAddRenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(944, 626);
            Controls.Add(cbTipoRenda);
            Controls.Add(btnSalvar);
            Controls.Add(btnCanelar);
            Controls.Add(cldDataEntrada);
            Controls.Add(lblDataEntrada);
            Controls.Add(lblTipoRenda);
            Controls.Add(txtNovaRenda);
            Controls.Add(lblNovaRenda);
            Name = "FormAddRenda";
            Text = "Adicionar Renda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNovaRenda;
        private TextBox txtNovaRenda;
        private Label lblTipoRenda;
        private Label lblDataEntrada;
        private MonthCalendar cldDataEntrada;
        private Button btnCanelar;
        private Button btnSalvar;
        private ComboBox cbTipoRenda;
    }
}