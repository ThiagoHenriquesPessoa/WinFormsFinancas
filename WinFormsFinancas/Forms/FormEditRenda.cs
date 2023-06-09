﻿using WinFormBusiness.Business;
using WinFormBusiness.InterfaceBusiness;
using WinFormDomain.Models;

namespace WinFormsFinancas.Forms
{
    public partial class FormEditRenda : Form
    {
        private readonly IRendaBusiness _rendaBusiness;
        public FormEditRenda(IRendaBusiness rendaBusiness)
        {
            InitializeComponent();
            lblIdRenda.Text = "0";
            txtNovaRenda.Text = "0";
            cbTipoRenda.Text = "";
            cldDataEntrada.Value = DateTime.Now;
            _rendaBusiness = rendaBusiness;
        }

        private void btnExibirLista_Click(object sender, EventArgs e)
        {
            dgvListaRenda.DataSource = _rendaBusiness.GetAllRendaPorData(dtpDataInicial.Value.Date, dtpDataFim.Value);
            dgvListaRenda.Columns["IdRenda"].Visible = false;
            dgvListaRenda.Columns["Valor da renda"].ReadOnly = true;
            dgvListaRenda.Columns["Tipo de renda"].ReadOnly = true;
            dgvListaRenda.Columns["data de entrada"].ReadOnly = true;
        }

        private void dgvListaRenda_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow linha = dgvListaRenda.Rows[e.RowIndex];
            lblIdRenda.Text = linha.Cells[0].Value.ToString();
            txtNovaRenda.Text = linha.Cells[1].Value.ToString();
            cbTipoRenda.Text = linha.Cells[2].Value.ToString();
            cldDataEntrada.Value = Convert.ToDateTime(linha.Cells[3].Value);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var rendaList = new List<string> { "0", "0,00", "" };
            if (lblIdRenda.Text != "0" && !rendaList.Contains(txtNovaRenda.Text.Replace("R$ ", "")))
            {
                var renda = new Renda
                {
                    IdRenda = Convert.ToInt64(lblIdRenda.Text),
                    ValorRenda = Convert.ToDouble(txtNovaRenda.Text.Replace("R$ ", "")),
                    TipoRenda = cbTipoRenda.Text,
                    DataEntrada = Convert.ToDateTime(cldDataEntrada.Value)
                };
                _rendaBusiness.UpdateRenda(renda);
                Atualizar();
            }
            else
            {
                MessageBox.Show("Valor da renda não pode ser zero!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Realmente deseja excluir essa renda ?", "Excluir", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (lblIdRenda.Text != "0")
                {
                    Int64 idRenda = Convert.ToInt64(lblIdRenda.Text);
                    _rendaBusiness.DeleteRenda(idRenda);
                    Atualizar();
                }
                else
                {
                    MessageBox.Show("Não há renda para ser excluida!");
                }
            }
        }

        private void Atualizar()
        {
            lblIdRenda.Text = "0";
            txtNovaRenda.Text = "0";
            cbTipoRenda.Text = "";
            cldDataEntrada.Value = DateTime.Now;
            dgvListaRenda.DataSource = _rendaBusiness.GetAllRendaPorData(dtpDataInicial.Value.Date, dtpDataFim.Value);
        }
    }
}