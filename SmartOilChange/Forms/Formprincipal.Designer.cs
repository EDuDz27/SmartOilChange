using System.Drawing;
using System.Windows.Forms;

namespace SmartOilChange.Forms
{
    partial class Formprincipal
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
            this.BotaoConsultar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxLubrificante = new System.Windows.Forms.GroupBox();
            this.labelViscosidade = new System.Windows.Forms.Label();
            this.txtViscosidadeValue = new System.Windows.Forms.TextBox();
            this.labelNormaApi = new System.Windows.Forms.Label();
            this.txtNormaApiValue = new System.Windows.Forms.TextBox();
            this.labelNormaAcea = new System.Windows.Forms.Label();
            this.txtNormaAceaValue = new System.Windows.Forms.TextBox();
            this.labelCapacidade = new System.Windows.Forms.Label();
            this.txtCapacidadeValue = new System.Windows.Forms.TextBox();
            this.groupBoxFiltroEquivalente = new System.Windows.Forms.GroupBox();
            this.dgvFiltrosEquivalentes = new System.Windows.Forms.DataGridView();
            this.panelAberturaChamado = new System.Windows.Forms.Panel();
            this.labelAberturaChamado = new System.Windows.Forms.Label();
            this.chkLuzOleoAbertura = new System.Windows.Forms.CheckBox();
            this.chkTampaParafusoAbertura = new System.Windows.Forms.CheckBox();
            this.chkVazamentosAbertura = new System.Windows.Forms.CheckBox();
            this.chkNivelOleoAbertura = new System.Windows.Forms.CheckBox();
            this.panelServicosRealizados = new System.Windows.Forms.Panel();
            this.labelServicosRealizados = new System.Windows.Forms.Label();
            this.chkSobraOleoServico = new System.Windows.Forms.CheckBox();
            this.chkEtiquetaServico = new System.Windows.Forms.CheckBox();
            this.chkNivelOleoServico = new System.Windows.Forms.CheckBox();
            this.chkVazamentosServico = new System.Windows.Forms.CheckBox();
            this.chkLuzOleoServico = new System.Windows.Forms.CheckBox();
            this.chkTampaParafusoServico = new System.Windows.Forms.CheckBox();
            this.chkTrocaFiltroServico = new System.Windows.Forms.CheckBox();
            this.chkTrocaOleoServico = new System.Windows.Forms.CheckBox();
            this.btnCancelarServico = new System.Windows.Forms.Button();
            this.btnFinalizarChamado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxLubrificante.SuspendLayout();
            this.groupBoxFiltroEquivalente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltrosEquivalentes)).BeginInit();
            this.panelAberturaChamado.SuspendLayout();
            this.panelServicosRealizados.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotaoConsultar
            // 
            this.BotaoConsultar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BotaoConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BotaoConsultar.Enabled = false;
            this.BotaoConsultar.Font = new System.Drawing.Font("Arial", 18F);
            this.BotaoConsultar.ForeColor = System.Drawing.Color.White;
            this.BotaoConsultar.Location = new System.Drawing.Point(440, 106);
            this.BotaoConsultar.Margin = new System.Windows.Forms.Padding(0);
            this.BotaoConsultar.Name = "BotaoConsultar";
            this.BotaoConsultar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BotaoConsultar.Size = new System.Drawing.Size(200, 45);
            this.BotaoConsultar.TabIndex = 9;
            this.BotaoConsultar.Text = "Consultar";
            this.BotaoConsultar.UseVisualStyleBackColor = false;
            this.BotaoConsultar.Click += new System.EventHandler(this.BotaoConsultar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBoxLubrificante);
            this.groupBox1.Controls.Add(this.groupBoxFiltroEquivalente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox1.Size = new System.Drawing.Size(1140, 538);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ContainerGeral";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consulta Tecnica de veiculos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.UseMnemonic = false;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.BotaoConsultar);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox2.Location = new System.Drawing.Point(30, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(12);
            this.groupBox2.Size = new System.Drawing.Size(1080, 168);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Enabled = false;
            this.comboBox4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(551, 62);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(244, 24);
            this.comboBox4.TabIndex = 8;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Enabled = false;
            this.comboBox3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(810, 62);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(244, 24);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Enabled = false;
            this.comboBox2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(292, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(244, 24);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(548, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ano";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.UseMnemonic = false;
            this.label6.Click += new System.EventHandler(this.Label6_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(807, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Motor";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.UseMnemonic = false;
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modelo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.UseMnemonic = false;
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.UseMnemonic = false;
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(33, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar veiculos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // groupBoxLubrificante
            // 
            this.groupBoxLubrificante.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxLubrificante.Controls.Add(this.labelViscosidade);
            this.groupBoxLubrificante.Controls.Add(this.txtViscosidadeValue);
            this.groupBoxLubrificante.Controls.Add(this.labelNormaApi);
            this.groupBoxLubrificante.Controls.Add(this.txtNormaApiValue);
            this.groupBoxLubrificante.Controls.Add(this.labelNormaAcea);
            this.groupBoxLubrificante.Controls.Add(this.txtNormaAceaValue);
            this.groupBoxLubrificante.Controls.Add(this.labelCapacidade);
            this.groupBoxLubrificante.Controls.Add(this.txtCapacidadeValue);
            this.groupBoxLubrificante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxLubrificante.Location = new System.Drawing.Point(44, 229);
            this.groupBoxLubrificante.Name = "groupBoxLubrificante";
            this.groupBoxLubrificante.Padding = new System.Windows.Forms.Padding(15);
            this.groupBoxLubrificante.Size = new System.Drawing.Size(350, 290);
            this.groupBoxLubrificante.TabIndex = 3;
            this.groupBoxLubrificante.TabStop = false;
            this.groupBoxLubrificante.Text = "Lubrificante";
            this.groupBoxLubrificante.Enter += new System.EventHandler(this.GroupBoxLubrificante_Enter);
            // 
            // labelViscosidade
            // 
            this.labelViscosidade.AutoSize = true;
            this.labelViscosidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelViscosidade.Location = new System.Drawing.Point(20, 35);
            this.labelViscosidade.Name = "labelViscosidade";
            this.labelViscosidade.Size = new System.Drawing.Size(83, 16);
            this.labelViscosidade.TabIndex = 0;
            this.labelViscosidade.Text = "Viscosidade";
            this.labelViscosidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelViscosidade.Click += new System.EventHandler(this.LabelViscosidade_Click);
            // 
            // txtViscosidadeValue
            // 
            this.txtViscosidadeValue.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtViscosidadeValue.Location = new System.Drawing.Point(20, 55);
            this.txtViscosidadeValue.Name = "txtViscosidadeValue";
            this.txtViscosidadeValue.ReadOnly = true;
            this.txtViscosidadeValue.Size = new System.Drawing.Size(310, 22);
            this.txtViscosidadeValue.TabIndex = 1;
            this.txtViscosidadeValue.TextChanged += new System.EventHandler(this.TxtViscosidadeValue_TextChanged);
            // 
            // labelNormaApi
            // 
            this.labelNormaApi.AutoSize = true;
            this.labelNormaApi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelNormaApi.Location = new System.Drawing.Point(20, 100);
            this.labelNormaApi.Name = "labelNormaApi";
            this.labelNormaApi.Size = new System.Drawing.Size(75, 16);
            this.labelNormaApi.TabIndex = 2;
            this.labelNormaApi.Text = "Norma API";
            this.labelNormaApi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNormaApi.Click += new System.EventHandler(this.LabelNormaApi_Click);
            // 
            // txtNormaApiValue
            // 
            this.txtNormaApiValue.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtNormaApiValue.Location = new System.Drawing.Point(20, 120);
            this.txtNormaApiValue.Name = "txtNormaApiValue";
            this.txtNormaApiValue.ReadOnly = true;
            this.txtNormaApiValue.Size = new System.Drawing.Size(310, 22);
            this.txtNormaApiValue.TabIndex = 3;
            this.txtNormaApiValue.TextChanged += new System.EventHandler(this.TxtNormaApiValue_TextChanged);
            // 
            // labelNormaAcea
            // 
            this.labelNormaAcea.AutoSize = true;
            this.labelNormaAcea.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelNormaAcea.Location = new System.Drawing.Point(20, 165);
            this.labelNormaAcea.Name = "labelNormaAcea";
            this.labelNormaAcea.Size = new System.Drawing.Size(88, 16);
            this.labelNormaAcea.TabIndex = 4;
            this.labelNormaAcea.Text = "Norma ACEA";
            this.labelNormaAcea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNormaAceaValue
            // 
            this.txtNormaAceaValue.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtNormaAceaValue.Location = new System.Drawing.Point(20, 185);
            this.txtNormaAceaValue.Name = "txtNormaAceaValue";
            this.txtNormaAceaValue.ReadOnly = true;
            this.txtNormaAceaValue.Size = new System.Drawing.Size(310, 22);
            this.txtNormaAceaValue.TabIndex = 5;
            this.txtNormaAceaValue.TextChanged += new System.EventHandler(this.TxtNormaAceaValue_TextChanged);
            // 
            // labelCapacidade
            // 
            this.labelCapacidade.AutoSize = true;
            this.labelCapacidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelCapacidade.Location = new System.Drawing.Point(20, 230);
            this.labelCapacidade.Name = "labelCapacidade";
            this.labelCapacidade.Size = new System.Drawing.Size(83, 16);
            this.labelCapacidade.TabIndex = 6;
            this.labelCapacidade.Text = "Capacidade";
            this.labelCapacidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCapacidade.Click += new System.EventHandler(this.LabelCapacidade_Click);
            // 
            // txtCapacidadeValue
            // 
            this.txtCapacidadeValue.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtCapacidadeValue.Location = new System.Drawing.Point(20, 250);
            this.txtCapacidadeValue.Name = "txtCapacidadeValue";
            this.txtCapacidadeValue.ReadOnly = true;
            this.txtCapacidadeValue.Size = new System.Drawing.Size(310, 22);
            this.txtCapacidadeValue.TabIndex = 7;
            this.txtCapacidadeValue.TextChanged += new System.EventHandler(this.TxtCapacidadeValue_TextChanged);
            // 
            // groupBoxFiltroEquivalente
            // 
            this.groupBoxFiltroEquivalente.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxFiltroEquivalente.Controls.Add(this.dgvFiltrosEquivalentes);
            this.groupBoxFiltroEquivalente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxFiltroEquivalente.Location = new System.Drawing.Point(409, 229);
            this.groupBoxFiltroEquivalente.Name = "groupBoxFiltroEquivalente";
            this.groupBoxFiltroEquivalente.Padding = new System.Windows.Forms.Padding(15);
            this.groupBoxFiltroEquivalente.Size = new System.Drawing.Size(685, 290);
            this.groupBoxFiltroEquivalente.TabIndex = 4;
            this.groupBoxFiltroEquivalente.TabStop = false;
            this.groupBoxFiltroEquivalente.Text = "Filtros Compatíveis";
            this.groupBoxFiltroEquivalente.Enter += new System.EventHandler(this.GroupBoxFiltroEquivalente_Enter);
            // 
            // dgvFiltrosEquivalentes
            // 
            this.dgvFiltrosEquivalentes.AllowUserToAddRows = false;
            this.dgvFiltrosEquivalentes.AllowUserToDeleteRows = false;
            this.dgvFiltrosEquivalentes.AllowUserToResizeColumns = false;
            this.dgvFiltrosEquivalentes.AllowUserToResizeRows = false;
            this.dgvFiltrosEquivalentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFiltrosEquivalentes.BackgroundColor = System.Drawing.Color.White;
            this.dgvFiltrosEquivalentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltrosEquivalentes.Location = new System.Drawing.Point(20, 35);
            this.dgvFiltrosEquivalentes.MultiSelect = false;
            this.dgvFiltrosEquivalentes.Name = "dgvFiltrosEquivalentes";
            this.dgvFiltrosEquivalentes.ReadOnly = true;
            this.dgvFiltrosEquivalentes.RowHeadersVisible = false;
            this.dgvFiltrosEquivalentes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvFiltrosEquivalentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiltrosEquivalentes.Size = new System.Drawing.Size(645, 240);
            this.dgvFiltrosEquivalentes.TabIndex = 0;
            this.dgvFiltrosEquivalentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFiltrosEquivalentes_CellContentClick);
            // 
            // panelAberturaChamado
            // 
            this.panelAberturaChamado.BackColor = System.Drawing.Color.LightGray;
            this.panelAberturaChamado.Controls.Add(this.labelAberturaChamado);
            this.panelAberturaChamado.Controls.Add(this.chkLuzOleoAbertura);
            this.panelAberturaChamado.Controls.Add(this.chkTampaParafusoAbertura);
            this.panelAberturaChamado.Controls.Add(this.chkVazamentosAbertura);
            this.panelAberturaChamado.Controls.Add(this.chkNivelOleoAbertura);
            this.panelAberturaChamado.Enabled = false;
            this.panelAberturaChamado.Location = new System.Drawing.Point(12, 557);
            this.panelAberturaChamado.Name = "panelAberturaChamado";
            this.panelAberturaChamado.Size = new System.Drawing.Size(1140, 57);
            this.panelAberturaChamado.TabIndex = 5;
            // 
            // labelAberturaChamado
            // 
            this.labelAberturaChamado.AutoSize = true;
            this.labelAberturaChamado.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.labelAberturaChamado.Location = new System.Drawing.Point(12, 8);
            this.labelAberturaChamado.Name = "labelAberturaChamado";
            this.labelAberturaChamado.Size = new System.Drawing.Size(161, 18);
            this.labelAberturaChamado.TabIndex = 4;
            this.labelAberturaChamado.Text = "Abertura de Chamado";
            // 
            // chkLuzOleoAbertura
            // 
            this.chkLuzOleoAbertura.AutoSize = true;
            this.chkLuzOleoAbertura.Font = new System.Drawing.Font("Arial", 10F);
            this.chkLuzOleoAbertura.Location = new System.Drawing.Point(935, 30);
            this.chkLuzOleoAbertura.Name = "chkLuzOleoAbertura";
            this.chkLuzOleoAbertura.Size = new System.Drawing.Size(170, 20);
            this.chkLuzOleoAbertura.TabIndex = 3;
            this.chkLuzOleoAbertura.Text = "Luz de óleo conferido?";
            this.chkLuzOleoAbertura.UseVisualStyleBackColor = true;
            this.chkLuzOleoAbertura.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // chkTampaParafusoAbertura
            // 
            this.chkTampaParafusoAbertura.AutoSize = true;
            this.chkTampaParafusoAbertura.Font = new System.Drawing.Font("Arial", 10F);
            this.chkTampaParafusoAbertura.Location = new System.Drawing.Point(610, 30);
            this.chkTampaParafusoAbertura.Name = "chkTampaParafusoAbertura";
            this.chkTampaParafusoAbertura.Size = new System.Drawing.Size(211, 20);
            this.chkTampaParafusoAbertura.TabIndex = 2;
            this.chkTampaParafusoAbertura.Text = "Tampa e parafuso conferido?";
            this.chkTampaParafusoAbertura.UseVisualStyleBackColor = true;
            this.chkTampaParafusoAbertura.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // chkVazamentosAbertura
            // 
            this.chkVazamentosAbertura.AutoSize = true;
            this.chkVazamentosAbertura.Font = new System.Drawing.Font("Arial", 10F);
            this.chkVazamentosAbertura.Location = new System.Drawing.Point(300, 30);
            this.chkVazamentosAbertura.Name = "chkVazamentosAbertura";
            this.chkVazamentosAbertura.Size = new System.Drawing.Size(184, 20);
            this.chkVazamentosAbertura.TabIndex = 1;
            this.chkVazamentosAbertura.Text = "Vazamentos detectados?";
            this.chkVazamentosAbertura.UseVisualStyleBackColor = true;
            this.chkVazamentosAbertura.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // chkNivelOleoAbertura
            // 
            this.chkNivelOleoAbertura.AutoSize = true;
            this.chkNivelOleoAbertura.Font = new System.Drawing.Font("Arial", 10F);
            this.chkNivelOleoAbertura.Location = new System.Drawing.Point(20, 30);
            this.chkNivelOleoAbertura.Name = "chkNivelOleoAbertura";
            this.chkNivelOleoAbertura.Size = new System.Drawing.Size(179, 20);
            this.chkNivelOleoAbertura.TabIndex = 0;
            this.chkNivelOleoAbertura.Text = "Nível de óleo conferido?";
            this.chkNivelOleoAbertura.UseVisualStyleBackColor = true;
            this.chkNivelOleoAbertura.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // panelServicosRealizados
            // 
            this.panelServicosRealizados.BackColor = System.Drawing.Color.LightGray;
            this.panelServicosRealizados.Controls.Add(this.labelServicosRealizados);
            this.panelServicosRealizados.Controls.Add(this.chkSobraOleoServico);
            this.panelServicosRealizados.Controls.Add(this.chkEtiquetaServico);
            this.panelServicosRealizados.Controls.Add(this.chkNivelOleoServico);
            this.panelServicosRealizados.Controls.Add(this.chkVazamentosServico);
            this.panelServicosRealizados.Controls.Add(this.chkLuzOleoServico);
            this.panelServicosRealizados.Controls.Add(this.chkTampaParafusoServico);
            this.panelServicosRealizados.Controls.Add(this.chkTrocaFiltroServico);
            this.panelServicosRealizados.Controls.Add(this.chkTrocaOleoServico);
            this.panelServicosRealizados.Enabled = false;
            this.panelServicosRealizados.Location = new System.Drawing.Point(12, 623);
            this.panelServicosRealizados.Name = "panelServicosRealizados";
            this.panelServicosRealizados.Size = new System.Drawing.Size(1140, 87);
            this.panelServicosRealizados.TabIndex = 6;
            // 
            // labelServicosRealizados
            // 
            this.labelServicosRealizados.AutoSize = true;
            this.labelServicosRealizados.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.labelServicosRealizados.Location = new System.Drawing.Point(12, 8);
            this.labelServicosRealizados.Name = "labelServicosRealizados";
            this.labelServicosRealizados.Size = new System.Drawing.Size(153, 18);
            this.labelServicosRealizados.TabIndex = 8;
            this.labelServicosRealizados.Text = "Serviços Realizados";
            // 
            // chkSobraOleoServico
            // 
            this.chkSobraOleoServico.AutoSize = true;
            this.chkSobraOleoServico.Font = new System.Drawing.Font("Arial", 10F);
            this.chkSobraOleoServico.Location = new System.Drawing.Point(935, 60);
            this.chkSobraOleoServico.Name = "chkSobraOleoServico";
            this.chkSobraOleoServico.Size = new System.Drawing.Size(193, 20);
            this.chkSobraOleoServico.TabIndex = 7;
            this.chkSobraOleoServico.Text = "Sobras de óleo conferido?";
            this.chkSobraOleoServico.UseVisualStyleBackColor = true;
            // 
            // chkEtiquetaServico
            // 
            this.chkEtiquetaServico.AutoSize = true;
            this.chkEtiquetaServico.Font = new System.Drawing.Font("Arial", 10F);
            this.chkEtiquetaServico.Location = new System.Drawing.Point(610, 60);
            this.chkEtiquetaServico.Name = "chkEtiquetaServico";
            this.chkEtiquetaServico.Size = new System.Drawing.Size(149, 20);
            this.chkEtiquetaServico.TabIndex = 6;
            this.chkEtiquetaServico.Text = "Etiqueta conferida?";
            this.chkEtiquetaServico.UseVisualStyleBackColor = true;
            // 
            // chkNivelOleoServico
            // 
            this.chkNivelOleoServico.AutoSize = true;
            this.chkNivelOleoServico.Font = new System.Drawing.Font("Arial", 10F);
            this.chkNivelOleoServico.Location = new System.Drawing.Point(300, 60);
            this.chkNivelOleoServico.Name = "chkNivelOleoServico";
            this.chkNivelOleoServico.Size = new System.Drawing.Size(179, 20);
            this.chkNivelOleoServico.TabIndex = 5;
            this.chkNivelOleoServico.Text = "Nível de óleo conferido?";
            this.chkNivelOleoServico.UseVisualStyleBackColor = true;
            // 
            // chkVazamentosServico
            // 
            this.chkVazamentosServico.AutoSize = true;
            this.chkVazamentosServico.Font = new System.Drawing.Font("Arial", 10F);
            this.chkVazamentosServico.Location = new System.Drawing.Point(20, 60);
            this.chkVazamentosServico.Name = "chkVazamentosServico";
            this.chkVazamentosServico.Size = new System.Drawing.Size(173, 20);
            this.chkVazamentosServico.TabIndex = 4;
            this.chkVazamentosServico.Text = "Vazamentos conferido?";
            this.chkVazamentosServico.UseVisualStyleBackColor = true;
            // 
            // chkLuzOleoServico
            // 
            this.chkLuzOleoServico.AutoSize = true;
            this.chkLuzOleoServico.Font = new System.Drawing.Font("Arial", 10F);
            this.chkLuzOleoServico.Location = new System.Drawing.Point(935, 30);
            this.chkLuzOleoServico.Name = "chkLuzOleoServico";
            this.chkLuzOleoServico.Size = new System.Drawing.Size(170, 20);
            this.chkLuzOleoServico.TabIndex = 3;
            this.chkLuzOleoServico.Text = "Luz de óleo conferido?";
            this.chkLuzOleoServico.UseVisualStyleBackColor = true;
            // 
            // chkTampaParafusoServico
            // 
            this.chkTampaParafusoServico.AutoSize = true;
            this.chkTampaParafusoServico.Font = new System.Drawing.Font("Arial", 10F);
            this.chkTampaParafusoServico.Location = new System.Drawing.Point(610, 30);
            this.chkTampaParafusoServico.Name = "chkTampaParafusoServico";
            this.chkTampaParafusoServico.Size = new System.Drawing.Size(211, 20);
            this.chkTampaParafusoServico.TabIndex = 2;
            this.chkTampaParafusoServico.Text = "Tampa e parafuso conferido?";
            this.chkTampaParafusoServico.UseVisualStyleBackColor = true;
            // 
            // chkTrocaFiltroServico
            // 
            this.chkTrocaFiltroServico.AutoSize = true;
            this.chkTrocaFiltroServico.Font = new System.Drawing.Font("Arial", 10F);
            this.chkTrocaFiltroServico.Location = new System.Drawing.Point(300, 30);
            this.chkTrocaFiltroServico.Name = "chkTrocaFiltroServico";
            this.chkTrocaFiltroServico.Size = new System.Drawing.Size(182, 20);
            this.chkTrocaFiltroServico.TabIndex = 1;
            this.chkTrocaFiltroServico.Text = "Troca de filtro realizada?";
            this.chkTrocaFiltroServico.UseVisualStyleBackColor = true;
            // 
            // chkTrocaOleoServico
            // 
            this.chkTrocaOleoServico.AutoSize = true;
            this.chkTrocaOleoServico.Font = new System.Drawing.Font("Arial", 10F);
            this.chkTrocaOleoServico.Location = new System.Drawing.Point(20, 30);
            this.chkTrocaOleoServico.Name = "chkTrocaOleoServico";
            this.chkTrocaOleoServico.Size = new System.Drawing.Size(182, 20);
            this.chkTrocaOleoServico.TabIndex = 0;
            this.chkTrocaOleoServico.Text = "Troca de óleo realizada?";
            this.chkTrocaOleoServico.UseVisualStyleBackColor = true;
            // 
            // btnCancelarServico
            // 
            this.btnCancelarServico.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelarServico.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancelarServico.ForeColor = System.Drawing.Color.White;
            this.btnCancelarServico.Location = new System.Drawing.Point(70, 723);
            this.btnCancelarServico.Name = "btnCancelarServico";
            this.btnCancelarServico.Size = new System.Drawing.Size(450, 40);
            this.btnCancelarServico.TabIndex = 0;
            this.btnCancelarServico.Text = "Cancelar Serviço";
            this.btnCancelarServico.UseVisualStyleBackColor = false;
            this.btnCancelarServico.Click += new System.EventHandler(this.BtnCancelarServico_Click);
            // 
            // btnFinalizarChamado
            // 
            this.btnFinalizarChamado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinalizarChamado.Enabled = false;
            this.btnFinalizarChamado.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnFinalizarChamado.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarChamado.Location = new System.Drawing.Point(622, 723);
            this.btnFinalizarChamado.Name = "btnFinalizarChamado";
            this.btnFinalizarChamado.Size = new System.Drawing.Size(450, 40);
            this.btnFinalizarChamado.TabIndex = 1;
            this.btnFinalizarChamado.Text = "Finalizar Chamado";
            this.btnFinalizarChamado.UseVisualStyleBackColor = false;
            // 
            // Formprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1164, 780);
            this.Controls.Add(this.btnFinalizarChamado);
            this.Controls.Add(this.btnCancelarServico);
            this.Controls.Add(this.panelServicosRealizados);
            this.Controls.Add(this.panelAberturaChamado);
            this.Controls.Add(this.groupBox1);
            this.Name = "Formprincipal";
            this.Text = "Óleos e Filtros";
            this.Load += new System.EventHandler(this.Formprincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxLubrificante.ResumeLayout(false);
            this.groupBoxLubrificante.PerformLayout();
            this.groupBoxFiltroEquivalente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltrosEquivalentes)).EndInit();
            this.panelAberturaChamado.ResumeLayout(false);
            this.panelAberturaChamado.PerformLayout();
            this.panelServicosRealizados.ResumeLayout(false);
            this.panelServicosRealizados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBoxLubrificante;
        private System.Windows.Forms.Label labelViscosidade;
        private System.Windows.Forms.Label labelNormaApi;
        private System.Windows.Forms.Label labelNormaAcea;
        private System.Windows.Forms.Label labelCapacidade;
        private System.Windows.Forms.TextBox txtViscosidadeValue;
        private System.Windows.Forms.TextBox txtNormaApiValue;
        private System.Windows.Forms.TextBox txtNormaAceaValue;
        private System.Windows.Forms.TextBox txtCapacidadeValue;
        private Button BotaoConsultar;
        private System.Windows.Forms.GroupBox groupBoxFiltroEquivalente;
        private System.Windows.Forms.DataGridView dgvFiltrosEquivalentes;
        private System.Windows.Forms.Panel panelAberturaChamado;
        private System.Windows.Forms.Label labelAberturaChamado;
        private System.Windows.Forms.CheckBox chkNivelOleoAbertura;
        private System.Windows.Forms.CheckBox chkVazamentosAbertura;
        private System.Windows.Forms.CheckBox chkTampaParafusoAbertura;
        private System.Windows.Forms.CheckBox chkLuzOleoAbertura;
        private System.Windows.Forms.Panel panelServicosRealizados;
        private System.Windows.Forms.Label labelServicosRealizados;
        private System.Windows.Forms.CheckBox chkSobraOleoServico;
        private System.Windows.Forms.CheckBox chkEtiquetaServico;
        private System.Windows.Forms.CheckBox chkNivelOleoServico;
        private System.Windows.Forms.CheckBox chkVazamentosServico;
        private System.Windows.Forms.CheckBox chkLuzOleoServico;
        private System.Windows.Forms.CheckBox chkTampaParafusoServico;
        private System.Windows.Forms.CheckBox chkTrocaFiltroServico;
        private System.Windows.Forms.CheckBox chkTrocaOleoServico;
        private System.Windows.Forms.Button btnCancelarServico;
        private System.Windows.Forms.Button btnFinalizarChamado;
    }
}