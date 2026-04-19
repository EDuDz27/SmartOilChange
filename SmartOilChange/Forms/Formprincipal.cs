using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SmartOilChange.Models;
using SmartOilChange.Repositories;

namespace SmartOilChange.Forms
{
    public partial class Formprincipal : Form
    {
        private readonly MarcaRepository _marcaRepository = new MarcaRepository();
        private readonly ModeloRepository _modeloRepository = new ModeloRepository();
        private readonly MotorRepository _motorRepository = new MotorRepository();
        private readonly ConsultaRepository _consultaRepository = new ConsultaRepository();

        private List<Motor> _motoresDoModelo = new List<Motor>();

        private class MotorOpcao
        {
            public int MotorId { get; set; }
            public string Nome { get; set; }
            public List<int> ModeloMotorIds { get; set; } = new List<int>();

            public override string ToString()
            {
                return Nome;
            }
        }

        public Formprincipal()
        {
            InitializeComponent();
        }

        private void Formprincipal_Load(object sender, EventArgs e)
        {
            CarregarMarcas();
            AtualizarEstadoConsulta();
        }

        private void CarregarMarcas()
        {
            var marcas = _marcaRepository.GetAll();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("-- Selecione --");
            foreach (var marca in marcas)
            {
                comboBox1.Items.Add(marca);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetModelo();
            ResetAno();
            ResetMotor();
            ResetResultados();

            if (comboBox1.SelectedIndex <= 0)
            {
                AtualizarEstadoConsulta();
                return;
            }

            var marcaSelecionada = comboBox1.SelectedItem as Marca;
            if (marcaSelecionada == null) return;

            var modelos = _modeloRepository.GetByMarcaId(marcaSelecionada.MarcaId);
            comboBox2.Items.Clear();
            comboBox2.Items.Add("-- Selecione --");
            foreach (var modelo in modelos)
            {
                comboBox2.Items.Add(modelo);
            }
            comboBox2.SelectedIndex = 0;
            comboBox2.Enabled = true;
            AtualizarEstadoConsulta();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetAno();
            ResetMotor();
            ResetResultados();

            if (comboBox2.SelectedIndex <= 0)
            {
                AtualizarEstadoConsulta();
                return;
            }

            var modeloSelecionado = comboBox2.SelectedItem as Modelo;
            if (modeloSelecionado == null) return;

            _motoresDoModelo = _motorRepository.GetByModeloId(modeloSelecionado.ModeloId);

            var anos = new SortedSet<int>();
            foreach (var motor in _motoresDoModelo)
            {
                for (int ano = motor.AnoInicio; ano <= motor.AnoFim; ano++)
                {
                    anos.Add(ano);
                }
            }

            comboBox4.Items.Clear();
            comboBox4.Items.Add("-- Selecione --");
            foreach (var ano in anos.Reverse())
            {
                comboBox4.Items.Add(ano);
            }
            comboBox4.SelectedIndex = 0;
            comboBox4.Enabled = true;
            AtualizarEstadoConsulta();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetMotor();
            ResetResultados();

            if (comboBox4.SelectedIndex <= 0)
            {
                AtualizarEstadoConsulta();
                return;
            }

            int anoSelecionado = (int)comboBox4.SelectedItem;

            var motoresFiltrados = _motoresDoModelo
                .Where(m => anoSelecionado >= m.AnoInicio && anoSelecionado <= m.AnoFim)
                .ToList();

            var motoresAgrupados = motoresFiltrados
                .GroupBy(m => new { m.MotorId, m.Nome })
                .Select(g => new MotorOpcao
                {
                    MotorId = g.Key.MotorId,
                    Nome = g.Key.Nome,
                    ModeloMotorIds = g.Select(x => x.ModeloMotorId).Distinct().ToList()
                })
                .OrderBy(m => m.Nome)
                .ToList();

            comboBox3.Items.Clear();
            comboBox3.Items.Add("-- Selecione --");
            foreach (var motor in motoresAgrupados)
            {
                comboBox3.Items.Add(motor);
            }
            comboBox3.SelectedIndex = 0;
            comboBox3.Enabled = true;
            AtualizarEstadoConsulta();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetResultados();
            AtualizarEstadoConsulta();
        }

        private void BotaoConsultar_Click(object sender, EventArgs e)
        {
            if (!TodosCamposSelecionados())
            {
                MessageBox.Show("Selecione Marca, Modelo, Ano e Motor antes de consultar.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var motorSelecionado = comboBox3.SelectedItem as MotorOpcao;
            if (motorSelecionado == null) return;

            var resultado = _consultaRepository.Consultar(motorSelecionado.ModeloMotorIds);

            PreencherLubrificante(resultado);
            PreencherFiltrosCompativeis(resultado);
        }

        private void PreencherLubrificante(ResultadoConsulta resultado)
        {
            const string textoPadrao = "Informação indisponível";

            if (resultado == null || resultado.Oleo == null)
            {
                txtViscosidadeValue.Text = textoPadrao;
                txtNormaApiValue.Text = textoPadrao;
                txtNormaAceaValue.Text = textoPadrao;
                txtCapacidadeValue.Text = textoPadrao;
                return;
            }

            txtViscosidadeValue.Text = ValorOuPadrao(resultado.Oleo.Viscosidade, textoPadrao);
            txtNormaApiValue.Text = ValorOuPadrao(resultado.Oleo.NormaApi, textoPadrao);
            txtNormaAceaValue.Text = ValorOuPadrao(resultado.Oleo.NormaAcea, textoPadrao);
            txtCapacidadeValue.Text = resultado.Oleo.CapacidadeLitros > 0
                ? resultado.Oleo.CapacidadeLitros.ToString("0.00") + " L"
                : textoPadrao;
        }

        private void PreencherFiltrosCompativeis(ResultadoConsulta resultado)
        {
            const string textoPadrao = "Dado não encontrado";

            var filtros = (resultado != null && resultado.Filtros != null)
                ? resultado.Filtros
                    .Where(f => f != null)
                    .Select(f => new Filtro
                    {
                        Tipo = ValorOuPadrao(f.Tipo, textoPadrao),
                        Marca = ValorOuPadrao(f.Marca, textoPadrao),
                        NumeroPeca = ValorOuPadrao(f.NumeroPeca, textoPadrao)
                    })
                    .ToList()
                : new List<Filtro>();

            if (filtros.Count == 0)
            {
                filtros.Add(new Filtro
                {
                    Tipo = textoPadrao,
                    Marca = textoPadrao,
                    NumeroPeca = textoPadrao
                });
            }

            dgvFiltrosEquivalentes.DataSource = null;
            dgvFiltrosEquivalentes.DataSource = filtros;
        }

        private static string ValorOuPadrao(string valor, string textoPadrao)
        {
            return string.IsNullOrWhiteSpace(valor) ? textoPadrao : valor.Trim();
        }

        private bool TodosCamposSelecionados()
        {
            return comboBox1.SelectedIndex > 0
                && comboBox2.SelectedIndex > 0
                && comboBox4.SelectedIndex > 0
                && comboBox3.SelectedIndex > 0;
        }

        private void AtualizarEstadoConsulta()
        {
            BotaoConsultar.Enabled = TodosCamposSelecionados();
        }

        private void ResetModelo()
        {
            comboBox2.Items.Clear();
            comboBox2.Enabled = false;
        }

        private void ResetAno()
        {
            comboBox4.Items.Clear();
            comboBox4.Enabled = false;
            _motoresDoModelo.Clear();
        }

        private void ResetMotor()
        {
            comboBox3.Items.Clear();
            comboBox3.Enabled = false;
            BotaoConsultar.Enabled = false;
        }

        private void ResetResultados()
        {
            txtViscosidadeValue.Text = "";
            txtNormaApiValue.Text = "";
            txtNormaAceaValue.Text = "";
            txtCapacidadeValue.Text = "";
            dgvFiltrosEquivalentes.DataSource = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Label6_Click_1(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void GroupBoxLubrificante_Enter(object sender, EventArgs e)
        {

        }

        private void LabelViscosidade_Click(object sender, EventArgs e)
        {

        }

        private void TxtViscosidadeValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelNormaApi_Click(object sender, EventArgs e)
        {

        }

        private void TxtNormaApiValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelCapacidade_Click(object sender, EventArgs e)
        {

        }

        private void TxtCapacidadeValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBoxFiltroEquivalente_Enter(object sender, EventArgs e)
        {

        }

        private void DgvFiltrosEquivalentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtNormaAceaValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
