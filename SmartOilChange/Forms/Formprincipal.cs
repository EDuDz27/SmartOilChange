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

            comboBox3.Items.Clear();
            comboBox3.Items.Add("-- Selecione --");
            foreach (var motor in motoresFiltrados)
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

            var motorSelecionado = comboBox3.SelectedItem as Motor;
            if (motorSelecionado == null) return;

            var resultado = _consultaRepository.Consultar(motorSelecionado.ModeloMotorId, motorSelecionado.MotorId);

            if (resultado.Oleo != null)
            {
                txtViscosidadeValue.Text = resultado.Oleo.Viscosidade;
                txtEspecificacaoValue.Text = resultado.Oleo.NormaApi;
                txtNormaAceaValue.Text = resultado.Oleo.NormaAcea;
                txtCapacidadeValue.Text = resultado.Oleo.CapacidadeLitros.ToString("0.00") + " L";
            }

            dgvFiltrosEquivalentes.DataSource = null;
            dgvFiltrosEquivalentes.DataSource = resultado.Filtros;
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
            txtEspecificacaoValue.Text = "";
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

        private void LabelEspecificacao_Click(object sender, EventArgs e)
        {

        }

        private void TxtEspecificacaoValue_TextChanged(object sender, EventArgs e)
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
    }
}
