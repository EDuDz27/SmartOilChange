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
        private readonly AnoRepository _anoRepository = new AnoRepository();
        private readonly ConsultaRepository _consultaRepository = new ConsultaRepository();

        private List<Motor> _motoresDoModelo = new List<Motor>();

        public Formprincipal()
        {
            InitializeComponent();
        }

        private void Formprincipal_Load(object sender, EventArgs e)
        {
            CarregarMarcas();
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
            // Reset campos dependentes
            ResetModelo();
            ResetAno();
            ResetMotor();
            ResetResultados();

            if (comboBox1.SelectedIndex <= 0)
            {
                comboBox2.Enabled = false;
                return;
            }

            var marcaSelecionada = comboBox1.SelectedItem as Marca;
            if (marcaSelecionada == null) return;

            var modelos = _modeloRepository.GetByMarcaId(marcaSelecionada.Id);
            comboBox2.Items.Clear();
            comboBox2.Items.Add("-- Selecione --");
            foreach (var modelo in modelos)
            {
                comboBox2.Items.Add(modelo);
            }
            comboBox2.SelectedIndex = 0;
            comboBox2.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset campos dependentes
            ResetAno();
            ResetMotor();
            ResetResultados();

            if (comboBox2.SelectedIndex <= 0)
            {
                comboBox4.Enabled = false;
                return;
            }

            var modeloSelecionado = comboBox2.SelectedItem as Modelo;
            if (modeloSelecionado == null) return;

            // Busca todos os motores desse modelo para extrair os anos
            _motoresDoModelo = _motorRepository.GetByModeloId(modeloSelecionado.Id);

            // Coletar todos os anos unicos de todos os motores
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
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset campos dependentes
            ResetMotor();
            ResetResultados();

            if (comboBox4.SelectedIndex <= 0)
            {
                comboBox3.Enabled = false;
                return;
            }

            int anoSelecionado = (int)comboBox4.SelectedItem;

            // Filtrar motores que cobrem o ano selecionado
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
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetResultados();
            BotaoConsultar.Enabled = comboBox3.SelectedIndex > 0;
        }

        private void BotaoConsultar_Click(object sender, EventArgs e)
        {
            var motorSelecionado = comboBox3.SelectedItem as Motor;
            if (motorSelecionado == null) return;

            var resultado = _consultaRepository.Consultar(motorSelecionado.Id);

            // Preencher Lubrificante
            if (resultado.Oleo != null)
            {
                txtViscosidadeValue.Text = resultado.Oleo.Viscosidade;
                txtEspecificacaoValue.Text = resultado.Oleo.Especificacao;
                txtCapacidadeValue.Text = resultado.Oleo.CapacidadeLitros + " L";
            }

            // Preencher Filtro Original
            if (resultado.FiltroOriginal != null)
            {
                txtTipoOriginalValue.Text = resultado.FiltroOriginal.Tipo.ToString();
                txtMarcaOriginalValue.Text = resultado.FiltroOriginal.Marca;
                txtNumeracaoOriginalValue.Text = resultado.FiltroOriginal.NumeroPeca;
            }

            // Preencher Filtro Equivalente
            if (resultado.FiltroEquivalente != null)
            {
                txtMarcaEquivalenteValue.Text = resultado.FiltroEquivalente.Marca;
                txtNumeracaoEquivalenteValue.Text = resultado.FiltroEquivalente.NumeroPeca;
            }
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
            txtCapacidadeValue.Text = "";
            txtTipoOriginalValue.Text = "";
            txtMarcaOriginalValue.Text = "";
            txtNumeracaoOriginalValue.Text = "";
            txtMarcaEquivalenteValue.Text = "";
            txtNumeracaoEquivalenteValue.Text = "";
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
    }
}
