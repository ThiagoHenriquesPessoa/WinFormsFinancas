﻿namespace WinFormsFinancas.Forms
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
            listBox1 = new ListBox();
            lblDataEntrada = new Label();
            cldDataEntrada = new MonthCalendar();
            btnCanelar = new Button();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // lblNovaRenda
            // 
            lblNovaRenda.AutoSize = true;
            lblNovaRenda.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNovaRenda.Location = new Point(34, 21);
            lblNovaRenda.Name = "lblNovaRenda";
            lblNovaRenda.Size = new Size(106, 23);
            lblNovaRenda.TabIndex = 0;
            lblNovaRenda.Text = "Nova Renda";
            // 
            // txtNovaRenda
            // 
            txtNovaRenda.Location = new Point(189, 17);
            txtNovaRenda.Name = "txtNovaRenda";
            txtNovaRenda.Size = new Size(171, 27);
            txtNovaRenda.TabIndex = 1;
            // 
            // lblTipoRenda
            // 
            lblTipoRenda.AutoSize = true;
            lblTipoRenda.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipoRenda.Location = new Point(34, 73);
            lblTipoRenda.Name = "lblTipoRenda";
            lblTipoRenda.Size = new Size(126, 23);
            lblTipoRenda.TabIndex = 2;
            lblTipoRenda.Text = "Tipo de Renda";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Salario", "Extra", "Emprestimo", "Pis", "Outros" });
            listBox1.Location = new Point(189, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(171, 24);
            listBox1.TabIndex = 3;
            // 
            // lblDataEntrada
            // 
            lblDataEntrada.AutoSize = true;
            lblDataEntrada.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDataEntrada.Location = new Point(34, 126);
            lblDataEntrada.Name = "lblDataEntrada";
            lblDataEntrada.Size = new Size(140, 23);
            lblDataEntrada.TabIndex = 4;
            lblDataEntrada.Text = "Data de Entrada";
            // 
            // cldDataEntrada
            // 
            cldDataEntrada.Location = new Point(189, 126);
            cldDataEntrada.Name = "cldDataEntrada";
            cldDataEntrada.TabIndex = 5;
            // 
            // btnCanelar
            // 
            btnCanelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCanelar.Location = new Point(513, 398);
            btnCanelar.Name = "btnCanelar";
            btnCanelar.Size = new Size(94, 29);
            btnCanelar.TabIndex = 6;
            btnCanelar.Text = "Canelar";
            btnCanelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvar.Location = new Point(641, 398);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // FormAddRenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(btnCanelar);
            Controls.Add(cldDataEntrada);
            Controls.Add(lblDataEntrada);
            Controls.Add(listBox1);
            Controls.Add(lblTipoRenda);
            Controls.Add(txtNovaRenda);
            Controls.Add(lblNovaRenda);
            Name = "FormAddRenda";
            Text = "FormProducts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNovaRenda;
        private TextBox txtNovaRenda;
        private Label lblTipoRenda;
        private ListBox listBox1;
        private Label lblDataEntrada;
        private MonthCalendar cldDataEntrada;
        private Button btnCanelar;
        private Button btnSalvar;
    }
}