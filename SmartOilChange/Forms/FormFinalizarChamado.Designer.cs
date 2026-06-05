namespace SmartOilChange.Forms
{
    partial class FormFinalizarChamado
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
            this.labelPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.labelViscosidade = new System.Windows.Forms.Label();
            this.txtViscosidade = new System.Windows.Forms.TextBox();
            this.labelObservacoes = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.labelChecklist = new System.Windows.Forms.Label();
            this.listViewChecklist = new System.Windows.Forms.ListView();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelPlaca.Location = new System.Drawing.Point(20, 20);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(118, 16);
            this.labelPlaca.TabIndex = 0;
            this.labelPlaca.Text = "Placa do Veículo:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPlaca.Location = new System.Drawing.Point(20, 40);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(280, 23);
            this.txtPlaca.TabIndex = 1;
            // 
            // labelViscosidade
            // 
            this.labelViscosidade.AutoSize = true;
            this.labelViscosidade.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelViscosidade.Location = new System.Drawing.Point(310, 20);
            this.labelViscosidade.Name = "labelViscosidade";
            this.labelViscosidade.Size = new System.Drawing.Size(130, 16);
            this.labelViscosidade.TabIndex = 2;
            this.labelViscosidade.Text = "Viscosidade Utilizada:";
            // 
            // txtViscosidade
            // 
            this.txtViscosidade.Enabled = false;
            this.txtViscosidade.Font = new System.Drawing.Font("Arial", 10F);
            this.txtViscosidade.Location = new System.Drawing.Point(310, 40);
            this.txtViscosidade.Name = "txtViscosidade";
            this.txtViscosidade.Size = new System.Drawing.Size(280, 23);
            this.txtViscosidade.TabIndex = 3;
            // 
            // labelObservacoes
            // 
            this.labelObservacoes.AutoSize = true;
            this.labelObservacoes.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelObservacoes.Location = new System.Drawing.Point(20, 80);
            this.labelObservacoes.Name = "labelObservacoes";
            this.labelObservacoes.Size = new System.Drawing.Size(86, 16);
            this.labelObservacoes.TabIndex = 4;
            this.labelObservacoes.Text = "Observações:";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Font = new System.Drawing.Font("Arial", 10F);
            this.txtObservacoes.Location = new System.Drawing.Point(20, 100);
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(570, 60);
            this.txtObservacoes.TabIndex = 5;
            // 
            // labelChecklist
            // 
            this.labelChecklist.AutoSize = true;
            this.labelChecklist.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelChecklist.Location = new System.Drawing.Point(20, 175);
            this.labelChecklist.Name = "labelChecklist";
            this.labelChecklist.Size = new System.Drawing.Size(229, 16);
            this.labelChecklist.TabIndex = 6;
            this.labelChecklist.Text = "Serviços Realizados - Resumo:";
            // 
            // listViewChecklist
            // 
            this.listViewChecklist.Enabled = false;
            this.listViewChecklist.Font = new System.Drawing.Font("Arial", 9F);
            this.listViewChecklist.Location = new System.Drawing.Point(20, 195);
            this.listViewChecklist.Name = "listViewChecklist";
            this.listViewChecklist.Size = new System.Drawing.Size(570, 120);
            this.listViewChecklist.TabIndex = 7;
            this.listViewChecklist.UseCompatibleStateImageBehavior = false;
            this.listViewChecklist.View = System.Windows.Forms.View.List;
            this.listViewChecklist.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnFinalizar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.BtnFinalizar.ForeColor = System.Drawing.Color.White;
            this.BtnFinalizar.Location = new System.Drawing.Point(310, 330);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(280, 35);
            this.BtnFinalizar.TabIndex = 8;
            this.BtnFinalizar.Text = "Finalizar Chamado";
            this.BtnFinalizar.UseVisualStyleBackColor = false;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCancelar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(20, 330);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(280, 35);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FormFinalizarChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(610, 380);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.listViewChecklist);
            this.Controls.Add(this.labelChecklist);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.labelObservacoes);
            this.Controls.Add(this.txtViscosidade);
            this.Controls.Add(this.labelViscosidade);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.labelPlaca);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFinalizarChamado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Finalizar Chamado";
            this.Load += new System.EventHandler(this.FormFinalizarChamado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label labelViscosidade;
        private System.Windows.Forms.TextBox txtViscosidade;
        private System.Windows.Forms.Label labelObservacoes;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label labelChecklist;
        private System.Windows.Forms.ListView listViewChecklist;
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}
