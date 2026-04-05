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
            this.labelEspecificacao = new System.Windows.Forms.Label();
            this.txtEspecificacaoValue = new System.Windows.Forms.TextBox();
            this.labelCapacidade = new System.Windows.Forms.Label();
            this.txtCapacidadeValue = new System.Windows.Forms.TextBox();
            this.groupBoxFiltroOriginal = new System.Windows.Forms.GroupBox();
            this.labelTipoOriginal = new System.Windows.Forms.Label();
            this.txtTipoOriginalValue = new System.Windows.Forms.TextBox();
            this.labelMarcaOriginal = new System.Windows.Forms.Label();
            this.txtMarcaOriginalValue = new System.Windows.Forms.TextBox();
            this.labelNumeracaoOriginal = new System.Windows.Forms.Label();
            this.txtNumeracaoOriginalValue = new System.Windows.Forms.TextBox();
            this.groupBoxFiltroEquivalente = new System.Windows.Forms.GroupBox();
            this.dgvFiltrosEquivalentes = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxLubrificante.SuspendLayout();
            this.groupBoxFiltroOriginal.SuspendLayout();
            this.groupBoxFiltroEquivalente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltrosEquivalentes)).BeginInit();
            this.SuspendLayout();
            // 
            // BotaoConsultar
            // 
            this.BotaoConsultar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BotaoConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BotaoConsultar.Enabled = false;
            this.BotaoConsultar.Font = new System.Drawing.Font("Arial", 18F);
            this.BotaoConsultar.ForeColor = System.Drawing.Color.White;
            this.BotaoConsultar.Location = new System.Drawing.Point(440, 139);
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
            this.groupBox1.Controls.Add(this.groupBoxFiltroOriginal);
            this.groupBox1.Controls.Add(this.groupBoxFiltroEquivalente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox1.Size = new System.Drawing.Size(1140, 640);
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
            this.groupBox2.Size = new System.Drawing.Size(1080, 240);
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
            this.comboBox4.Location = new System.Drawing.Point(551, 81);
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
            this.comboBox3.Location = new System.Drawing.Point(810, 81);
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
            this.comboBox2.Location = new System.Drawing.Point(292, 81);
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
            this.label6.Location = new System.Drawing.Point(548, 62);
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
            this.label5.Location = new System.Drawing.Point(807, 62);
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
            this.label4.Location = new System.Drawing.Point(289, 62);
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
            this.label3.Location = new System.Drawing.Point(30, 62);
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
            this.comboBox1.Location = new System.Drawing.Point(33, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
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
            this.groupBoxLubrificante.Controls.Add(this.labelEspecificacao);
            this.groupBoxLubrificante.Controls.Add(this.txtEspecificacaoValue);
            this.groupBoxLubrificante.Controls.Add(this.labelCapacidade);
            this.groupBoxLubrificante.Controls.Add(this.txtCapacidadeValue);
            this.groupBoxLubrificante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxLubrificante.Location = new System.Drawing.Point(30, 310);
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
            // labelEspecificacao
            // 
            this.labelEspecificacao.AutoSize = true;
            this.labelEspecificacao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelEspecificacao.Location = new System.Drawing.Point(20, 100);
            this.labelEspecificacao.Name = "labelEspecificacao";
            this.labelEspecificacao.Size = new System.Drawing.Size(94, 16);
            this.labelEspecificacao.TabIndex = 2;
            this.labelEspecificacao.Text = "Especificação";
            this.labelEspecificacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelEspecificacao.Click += new System.EventHandler(this.LabelEspecificacao_Click);
            // 
            // txtEspecificacaoValue
            // 
            this.txtEspecificacaoValue.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtEspecificacaoValue.Location = new System.Drawing.Point(20, 120);
            this.txtEspecificacaoValue.Name = "txtEspecificacaoValue";
            this.txtEspecificacaoValue.ReadOnly = true;
            this.txtEspecificacaoValue.Size = new System.Drawing.Size(310, 22);
            this.txtEspecificacaoValue.TabIndex = 3;
            this.txtEspecificacaoValue.TextChanged += new System.EventHandler(this.TxtEspecificacaoValue_TextChanged);
            // 
            // labelCapacidade
            // 
            this.labelCapacidade.AutoSize = true;
            this.labelCapacidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelCapacidade.Location = new System.Drawing.Point(20, 165);
            this.labelCapacidade.Name = "labelCapacidade";
            this.labelCapacidade.Size = new System.Drawing.Size(83, 16);
            this.labelCapacidade.TabIndex = 4;
            this.labelCapacidade.Text = "Capacidade";
            this.labelCapacidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCapacidade.Click += new System.EventHandler(this.LabelCapacidade_Click);
            // 
            // txtCapacidadeValue
            // 
            this.txtCapacidadeValue.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtCapacidadeValue.Location = new System.Drawing.Point(20, 185);
            this.txtCapacidadeValue.Name = "txtCapacidadeValue";
            this.txtCapacidadeValue.ReadOnly = true;
            this.txtCapacidadeValue.Size = new System.Drawing.Size(310, 22);
            this.txtCapacidadeValue.TabIndex = 5;
            this.txtCapacidadeValue.TextChanged += new System.EventHandler(this.TxtCapacidadeValue_TextChanged);
            // 
            // groupBoxFiltroOriginal
            // 
            this.groupBoxFiltroOriginal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxFiltroOriginal.Controls.Add(this.labelTipoOriginal);
            this.groupBoxFiltroOriginal.Controls.Add(this.txtTipoOriginalValue);
            this.groupBoxFiltroOriginal.Controls.Add(this.labelMarcaOriginal);
            this.groupBoxFiltroOriginal.Controls.Add(this.txtMarcaOriginalValue);
            this.groupBoxFiltroOriginal.Controls.Add(this.labelNumeracaoOriginal);
            this.groupBoxFiltroOriginal.Controls.Add(this.txtNumeracaoOriginalValue);
            this.groupBoxFiltroOriginal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxFiltroOriginal.Location = new System.Drawing.Point(395, 310);
            this.groupBoxFiltroOriginal.Name = "groupBoxFiltroOriginal";
            this.groupBoxFiltroOriginal.Padding = new System.Windows.Forms.Padding(15);
            this.groupBoxFiltroOriginal.Size = new System.Drawing.Size(350, 290);
            this.groupBoxFiltroOriginal.TabIndex = 4;
            this.groupBoxFiltroOriginal.TabStop = false;
            this.groupBoxFiltroOriginal.Text = "Filtro (Original)";
            this.groupBoxFiltroOriginal.Enter += new System.EventHandler(this.GroupBoxFiltroOriginal_Enter);
            // 
            // labelTipoOriginal
            // 
            this.labelTipoOriginal.AutoSize = true;
            this.labelTipoOriginal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelTipoOriginal.Location = new System.Drawing.Point(20, 35);
            this.labelTipoOriginal.Name = "labelTipoOriginal";
            this.labelTipoOriginal.Size = new System.Drawing.Size(35, 16);
            this.labelTipoOriginal.TabIndex = 0;
            this.labelTipoOriginal.Text = "Tipo";
            this.labelTipoOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTipoOriginal.Click += new System.EventHandler(this.LabelTipoOriginal_Click);
            // 
            // txtTipoOriginalValue
            // 
            this.txtTipoOriginalValue.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtTipoOriginalValue.Location = new System.Drawing.Point(20, 55);
            this.txtTipoOriginalValue.Name = "txtTipoOriginalValue";
            this.txtTipoOriginalValue.ReadOnly = true;
            this.txtTipoOriginalValue.Size = new System.Drawing.Size(310, 22);
            this.txtTipoOriginalValue.TabIndex = 1;
            this.txtTipoOriginalValue.TextChanged += new System.EventHandler(this.TxtTipoOriginalValue_TextChanged);
            // 
            // labelMarcaOriginal
            // 
            this.labelMarcaOriginal.AutoSize = true;
            this.labelMarcaOriginal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelMarcaOriginal.Location = new System.Drawing.Point(20, 100);
            this.labelMarcaOriginal.Name = "labelMarcaOriginal";
            this.labelMarcaOriginal.Size = new System.Drawing.Size(46, 16);
            this.labelMarcaOriginal.TabIndex = 2;
            this.labelMarcaOriginal.Text = "Marca";
            this.labelMarcaOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMarcaOriginal.Click += new System.EventHandler(this.LabelMarcaOriginal_Click);
            // 
            // txtMarcaOriginalValue
            // 
            this.txtMarcaOriginalValue.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtMarcaOriginalValue.Location = new System.Drawing.Point(20, 120);
            this.txtMarcaOriginalValue.Name = "txtMarcaOriginalValue";
            this.txtMarcaOriginalValue.ReadOnly = true;
            this.txtMarcaOriginalValue.Size = new System.Drawing.Size(310, 22);
            this.txtMarcaOriginalValue.TabIndex = 3;
            this.txtMarcaOriginalValue.TextChanged += new System.EventHandler(this.TxtMarcaOriginalValue_TextChanged);
            // 
            // labelNumeracaoOriginal
            // 
            this.labelNumeracaoOriginal.AutoSize = true;
            this.labelNumeracaoOriginal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelNumeracaoOriginal.Location = new System.Drawing.Point(20, 165);
            this.labelNumeracaoOriginal.Name = "labelNumeracaoOriginal";
            this.labelNumeracaoOriginal.Size = new System.Drawing.Size(80, 16);
            this.labelNumeracaoOriginal.TabIndex = 4;
            this.labelNumeracaoOriginal.Text = "Numeração";
            this.labelNumeracaoOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNumeracaoOriginal.Click += new System.EventHandler(this.LabelNumeracaoOriginal_Click);
            // 
            // txtNumeracaoOriginalValue
            // 
            this.txtNumeracaoOriginalValue.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtNumeracaoOriginalValue.Location = new System.Drawing.Point(20, 185);
            this.txtNumeracaoOriginalValue.Name = "txtNumeracaoOriginalValue";
            this.txtNumeracaoOriginalValue.ReadOnly = true;
            this.txtNumeracaoOriginalValue.Size = new System.Drawing.Size(310, 22);
            this.txtNumeracaoOriginalValue.TabIndex = 5;
            this.txtNumeracaoOriginalValue.TextChanged += new System.EventHandler(this.TxtNumeracaoOriginalValue_TextChanged);
            // 
            // groupBoxFiltroEquivalente
            // 
            this.groupBoxFiltroEquivalente.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBoxFiltroEquivalente.Controls.Add(this.dgvFiltrosEquivalentes);
            this.groupBoxFiltroEquivalente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxFiltroEquivalente.Location = new System.Drawing.Point(760, 310);
            this.groupBoxFiltroEquivalente.Name = "groupBoxFiltroEquivalente";
            this.groupBoxFiltroEquivalente.Padding = new System.Windows.Forms.Padding(15);
            this.groupBoxFiltroEquivalente.Size = new System.Drawing.Size(350, 290);
            this.groupBoxFiltroEquivalente.TabIndex = 5;
            this.groupBoxFiltroEquivalente.TabStop = false;
            this.groupBoxFiltroEquivalente.Text = "Filtro (Equivalente)";
            this.groupBoxFiltroEquivalente.Enter += new System.EventHandler(this.GroupBoxFiltroEquivalente_Enter);
            // 
            // dgvFiltrosEquivalentes
            // 
            this.dgvFiltrosEquivalentes.AllowUserToAddRows = false;
            this.dgvFiltrosEquivalentes.AllowUserToDeleteRows = false;
            this.dgvFiltrosEquivalentes.BackgroundColor = System.Drawing.Color.White;
            this.dgvFiltrosEquivalentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltrosEquivalentes.Location = new System.Drawing.Point(20, 35);
            this.dgvFiltrosEquivalentes.MultiSelect = false;
            this.dgvFiltrosEquivalentes.Name = "dgvFiltrosEquivalentes";
            this.dgvFiltrosEquivalentes.ReadOnly = true;
            this.dgvFiltrosEquivalentes.RowHeadersVisible = false;
            this.dgvFiltrosEquivalentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiltrosEquivalentes.Size = new System.Drawing.Size(310, 240);
            this.dgvFiltrosEquivalentes.TabIndex = 0;
            this.dgvFiltrosEquivalentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFiltrosEquivalentes_CellContentClick);
            // 
            // Formprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1164, 670);
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
            this.groupBoxFiltroOriginal.ResumeLayout(false);
            this.groupBoxFiltroOriginal.PerformLayout();
            this.groupBoxFiltroEquivalente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltrosEquivalentes)).EndInit();
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
        private System.Windows.Forms.Label labelEspecificacao;
        private System.Windows.Forms.Label labelCapacidade;
        private System.Windows.Forms.TextBox txtViscosidadeValue;
        private System.Windows.Forms.TextBox txtEspecificacaoValue;
        private System.Windows.Forms.TextBox txtCapacidadeValue;
        private Button BotaoConsultar;
        private System.Windows.Forms.GroupBox groupBoxFiltroOriginal;
        private System.Windows.Forms.Label labelTipoOriginal;
        private System.Windows.Forms.TextBox txtTipoOriginalValue;
        private System.Windows.Forms.Label labelMarcaOriginal;
        private System.Windows.Forms.TextBox txtMarcaOriginalValue;
        private System.Windows.Forms.Label labelNumeracaoOriginal;
        private System.Windows.Forms.TextBox txtNumeracaoOriginalValue;
        private System.Windows.Forms.GroupBox groupBoxFiltroEquivalente;
        private System.Windows.Forms.DataGridView dgvFiltrosEquivalentes;
    }
}