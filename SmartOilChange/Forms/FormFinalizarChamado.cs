using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SmartOilChange.Models;
using SmartOilChange.Repositories;

namespace SmartOilChange.Forms
{
    public partial class FormFinalizarChamado : Form
    {
        private readonly ServiceLogRepository _serviceLogRepository = new ServiceLogRepository();

        // Serviços Realizados
        private bool _trocaOleo;
        private bool _trocaFiltro;
        private bool _tampaServico;
        private bool _luzOleoServico;
        private bool _vazamentoServico;
        private bool _nivelOleoServico;
        private bool _etiquetaServico;
        private bool _sobraOleoServico;

        private string _viscosidadeFormularioPrincipal;

        public FormFinalizarChamado(
            bool trocaOleo, bool trocaFiltro, bool tampaServico, bool luzOleoServico, 
            bool vazamentoServico, bool nivelOleoServico, bool etiquetaServico, bool sobraOleoServico,
            string viscosidade = "")
        {
            InitializeComponent();

            _trocaOleo = trocaOleo;
            _trocaFiltro = trocaFiltro;
            _tampaServico = tampaServico;
            _luzOleoServico = luzOleoServico;
            _vazamentoServico = vazamentoServico;
            _nivelOleoServico = nivelOleoServico;
            _etiquetaServico = etiquetaServico;
            _sobraOleoServico = sobraOleoServico;
            _viscosidadeFormularioPrincipal = viscosidade;
        }

        private void FormFinalizarChamado_Load(object sender, EventArgs e)
        {
            PopularCheckListView();
            ConfigurarCampoViscosidade();
        }

        private void ConfigurarCampoViscosidade()
        {
            // Se troca de óleo foi realizada, habilita o campo
            txtViscosidade.Enabled = _trocaOleo;

            // Auto-preenche se houver viscosidade disponível e não for "Informação indisponível"
            if (_trocaOleo && !string.IsNullOrWhiteSpace(_viscosidadeFormularioPrincipal) 
                && _viscosidadeFormularioPrincipal != "Informação indisponível")
            {
                txtViscosidade.Text = _viscosidadeFormularioPrincipal;
                txtViscosidade.ForeColor = System.Drawing.Color.Black;
            }
            else if (_trocaOleo)
            {
                txtViscosidade.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void PopularCheckListView()
        {
            listViewChecklist.Items.Clear();

            // Serviços Realizados
            listViewChecklist.Items.Add((_trocaOleo ? "☑ " : "☐ ") + "Troca de óleo realizada?");
            listViewChecklist.Items.Add((_trocaFiltro ? "☑ " : "☐ ") + "Troca de filtro realizada?");
            listViewChecklist.Items.Add((_tampaServico ? "☑ " : "☐ ") + "Tampa e parafuso conferido?");
            listViewChecklist.Items.Add((_luzOleoServico ? "☑ " : "☐ ") + "Luz de óleo conferido?");
            listViewChecklist.Items.Add((_vazamentoServico ? "☑ " : "☐ ") + "Vazamentos conferido?");
            listViewChecklist.Items.Add((_nivelOleoServico ? "☑ " : "☐ ") + "Nível de óleo conferido?");
            listViewChecklist.Items.Add((_etiquetaServico ? "☑ " : "☐ ") + "Etiqueta conferida?");
            listViewChecklist.Items.Add((_sobraOleoServico ? "☑ " : "☐ ") + "Sobras de óleo conferido?");
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlaca.Text))
            {
                MessageBox.Show("Por favor, informe a placa do veículo.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPlaca.Focus();
                return;
            }

            // Validar viscosidade apenas se troca de óleo foi realizada
            if (_trocaOleo && string.IsNullOrWhiteSpace(txtViscosidade.Text))
            {
                MessageBox.Show("Por favor, informe a viscosidade utilizada (obrigatório para troca de óleo).", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtViscosidade.Focus();
                return;
            }

            var serviceLog = new ServiceLog
            {
                Placa = txtPlaca.Text.Trim().ToUpper(),
                OleoUtilizado = txtViscosidade.Text.Trim().ToUpper(),
                OleoTrocado = _trocaOleo,
                FiltroTrocado = _trocaFiltro,
                TampaOk = _tampaServico,
                LuzOleoOk = _luzOleoServico,
                VazamentoOk = _vazamentoServico,
                NivelOleoOk = _nivelOleoServico,
                EtiquetaOk = _etiquetaServico,
                SobraOleoOk = _sobraOleoServico,
                Observacoes = txtObservacoes.Text.Trim()
            };

            try
            {
                _serviceLogRepository.Add(serviceLog);
                MessageBox.Show("Chamado finalizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao finalizar chamado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
