using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartOilChange.Models;
using SmartOilChange.Repositories;

namespace SmartOilChange.Forms
{
    public partial class FormBuscaLogs : Form
    {
        private readonly ServiceLogRepository _serviceLogRepository = new ServiceLogRepository();
        private const int ITENS_POR_PAGINA = 50;

        private string _placaBuscada = "";
        private int _totalItens = 0;
        private int _paginaAtual = 0;

        public FormBuscaLogs()
        {
            InitializeComponent();
        }

        private void FormBuscaLogs_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            AtualizarBotoesPaginacao();
        }

        private void ConfigurarDataGridView()
        {
            dgvLogs.AllowUserToAddRows = false;
            dgvLogs.AllowUserToDeleteRows = false;
            dgvLogs.AllowUserToResizeColumns = true;
            dgvLogs.ReadOnly = true;
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            dgvLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvLogs.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                _placaBuscada = txtPlaca.Text.Trim();
                _totalItens = _serviceLogRepository.GetTotalCountByPlaca(_placaBuscada);

                if (_totalItens == 0)
                {
                    if (string.IsNullOrWhiteSpace(txtPlaca.Text))
                    {
                        MessageBox.Show("Nenhum registro encontrado no banco de dados.", "Sem resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado para a placa informada.", "Sem resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dgvLogs.DataSource = null;
                    _paginaAtual = 0;
                    AtualizarBotoesPaginacao();
                    return;
                }

                _paginaAtual = 0;
                CarregarPagina();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar logs: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarPagina()
        {
            int offset = _paginaAtual * ITENS_POR_PAGINA;
            var logs = _serviceLogRepository.GetByPlacaPagenado(_placaBuscada, offset, ITENS_POR_PAGINA);

            dgvLogs.DataSource = logs;
            AjustarColunas();
            AtualizarBotoesPaginacao();
        }

        private void AjustarColunas()
        {
            if (dgvLogs.Columns.Contains("LogsId"))
                dgvLogs.Columns["LogsId"].Visible = false;

            if (dgvLogs.Columns.Contains("Placa"))
                dgvLogs.Columns["Placa"].HeaderText = "Placa";

            if (dgvLogs.Columns.Contains("OleoUtilizado"))
                dgvLogs.Columns["OleoUtilizado"].HeaderText = "Óleo Utilizado";

            if (dgvLogs.Columns.Contains("OleoTrocado"))
                dgvLogs.Columns["OleoTrocado"].HeaderText = "Óleo Trocado";

            if (dgvLogs.Columns.Contains("FiltroTrocado"))
                dgvLogs.Columns["FiltroTrocado"].HeaderText = "Filtro Trocado";

            if (dgvLogs.Columns.Contains("TampaOk"))
                dgvLogs.Columns["TampaOk"].HeaderText = "Tampa OK";

            if (dgvLogs.Columns.Contains("LuzOleoOk"))
                dgvLogs.Columns["LuzOleoOk"].HeaderText = "Luz Óleo OK";

            if (dgvLogs.Columns.Contains("VazamentoOk"))
                dgvLogs.Columns["VazamentoOk"].HeaderText = "Vazamento OK";

            if (dgvLogs.Columns.Contains("NivelOleoOk"))
                dgvLogs.Columns["NivelOleoOk"].HeaderText = "Nível Óleo OK";

            if (dgvLogs.Columns.Contains("EtiquetaOk"))
                dgvLogs.Columns["EtiquetaOk"].HeaderText = "Etiqueta OK";

            if (dgvLogs.Columns.Contains("SobraOleoOk"))
                dgvLogs.Columns["SobraOleoOk"].HeaderText = "Sobra Óleo OK";

            if (dgvLogs.Columns.Contains("Observacoes"))
                dgvLogs.Columns["Observacoes"].HeaderText = "Observações";

            if (dgvLogs.Columns.Contains("CriadoEm"))
                dgvLogs.Columns["CriadoEm"].HeaderText = "Data/Hora";
        }

        private void AtualizarBotoesPaginacao()
        {
            int primeiroItem = (_paginaAtual * ITENS_POR_PAGINA) + 1;
            int ultimoItem = Math.Min((_paginaAtual + 1) * ITENS_POR_PAGINA, _totalItens);

            if (_totalItens == 0)
            {
                lblPaginacao.Text = "< 0 - 0 >";
                btnAnterior.Enabled = false;
                btnProximo.Enabled = false;
            }
            else
            {
                lblPaginacao.Text = $"< {primeiroItem} - {ultimoItem} >";
                btnAnterior.Enabled = _paginaAtual > 0;
                btnProximo.Enabled = ultimoItem < _totalItens;
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            if (_paginaAtual > 0)
            {
                _paginaAtual--;
                CarregarPagina();
            }
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            int ultimoItem = Math.Min((_paginaAtual + 1) * ITENS_POR_PAGINA, _totalItens);
            if (ultimoItem < _totalItens)
            {
                _paginaAtual++;
                CarregarPagina();
            }
        }

        private void TxtPlaca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                BtnBuscar_Click(sender, e);
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
