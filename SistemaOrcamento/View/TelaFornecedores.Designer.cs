
using System;
using System.Windows.Forms;

namespace SistemaOrcamento.View
{
    partial class TelaFornecedores
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
            this.lbnome = new System.Windows.Forms.Label();
            this.lbcnpj = new System.Windows.Forms.Label();
            this.lbtelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbendereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lbluscarnome = new System.Windows.Forms.Label();
            this.txtbuscarnome = new System.Windows.Forms.TextBox();
            this.dgview = new System.Windows.Forms.DataGridView();
            this.BotaoNovo = new System.Windows.Forms.Button();
            this.botaoexcluir = new System.Windows.Forms.Button();
            this.botaosalvar = new System.Windows.Forms.Button();
            this.botaoeditar = new System.Windows.Forms.Button();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).BeginInit();
            this.SuspendLayout();
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Location = new System.Drawing.Point(12, 26);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(47, 17);
            this.lbnome.TabIndex = 0;
            this.lbnome.Text = "Nome:";
            this.lbnome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbcnpj
            // 
            this.lbcnpj.AutoSize = true;
            this.lbcnpj.Location = new System.Drawing.Point(19, 75);
            this.lbcnpj.Name = "lbcnpj";
            this.lbcnpj.Size = new System.Drawing.Size(40, 17);
            this.lbcnpj.TabIndex = 2;
            this.lbcnpj.Text = "CNPJ:";
            // 
            // lbtelefone
            // 
            this.lbtelefone.AutoSize = true;
            this.lbtelefone.Location = new System.Drawing.Point(507, 26);
            this.lbtelefone.Name = "lbtelefone";
            this.lbtelefone.Size = new System.Drawing.Size(60, 17);
            this.lbtelefone.TabIndex = 3;
            this.lbtelefone.Text = "Telefone:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(82, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(265, 25);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lbendereco
            // 
            this.lbendereco.AutoSize = true;
            this.lbendereco.Location = new System.Drawing.Point(504, 75);
            this.lbendereco.Name = "lbendereco";
            this.lbendereco.Size = new System.Drawing.Size(66, 17);
            this.lbendereco.TabIndex = 6;
            this.lbendereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(582, 67);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(193, 25);
            this.txtEndereco.TabIndex = 7;
            // 
            // lbluscarnome
            // 
            this.lbluscarnome.AutoSize = true;
            this.lbluscarnome.Location = new System.Drawing.Point(12, 124);
            this.lbluscarnome.Name = "lbluscarnome";
            this.lbluscarnome.Size = new System.Drawing.Size(49, 17);
            this.lbluscarnome.TabIndex = 9;
            this.lbluscarnome.Text = "Buscar:";
            // 
            // txtbuscarnome
            // 
            this.txtbuscarnome.Location = new System.Drawing.Point(67, 121);
            this.txtbuscarnome.Name = "txtbuscarnome";
            this.txtbuscarnome.Size = new System.Drawing.Size(271, 25);
            this.txtbuscarnome.TabIndex = 8;
            this.txtbuscarnome.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgview
            // 
            this.dgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview.Location = new System.Drawing.Point(95, 162);
            this.dgview.Name = "dgview";
            this.dgview.RowTemplate.Height = 27;
            this.dgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgview.Size = new System.Drawing.Size(610, 249);
            this.dgview.TabIndex = 10;
            this.dgview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgview_CellClick);
            this.dgview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgview_CellClick);
            // 
            // BotaoNovo
            // 
            this.BotaoNovo.Location = new System.Drawing.Point(237, 417);
            this.BotaoNovo.Name = "BotaoNovo";
            this.BotaoNovo.Size = new System.Drawing.Size(75, 23);
            this.BotaoNovo.TabIndex = 11;
            this.BotaoNovo.Text = "Novo";
            this.BotaoNovo.UseVisualStyleBackColor = true;
            this.BotaoNovo.Click += new System.EventHandler(this.button1_Click);
            // 
            // botaoexcluir
            // 
            this.botaoexcluir.Location = new System.Drawing.Point(480, 417);
            this.botaoexcluir.Name = "botaoexcluir";
            this.botaoexcluir.Size = new System.Drawing.Size(75, 23);
            this.botaoexcluir.TabIndex = 12;
            this.botaoexcluir.Text = "Excluir";
            this.botaoexcluir.UseVisualStyleBackColor = true;
            this.botaoexcluir.Click += new System.EventHandler(this.botaoexcluir_Click);
            // 
            // botaosalvar
            // 
            this.botaosalvar.Enabled = false;
            this.botaosalvar.Location = new System.Drawing.Point(318, 417);
            this.botaosalvar.Name = "botaosalvar";
            this.botaosalvar.Size = new System.Drawing.Size(75, 23);
            this.botaosalvar.TabIndex = 13;
            this.botaosalvar.Text = "Salvar";
            this.botaosalvar.UseVisualStyleBackColor = true;
            this.botaosalvar.Click += new System.EventHandler(this.botaosalvar_Click_1);
            // 
            // botaoeditar
            // 
            this.botaoeditar.Location = new System.Drawing.Point(399, 417);
            this.botaoeditar.Name = "botaoeditar";
            this.botaoeditar.Size = new System.Drawing.Size(75, 23);
            this.botaoeditar.TabIndex = 14;
            this.botaoeditar.Text = "Editar";
            this.botaoeditar.UseVisualStyleBackColor = true;
            this.botaoeditar.Click += new System.EventHandler(this.botaoeditar_Click);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(70, 72);
            this.txtCnpj.Mask = "00.000.000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(146, 25);
            this.txtCnpj.TabIndex = 15;
            this.txtCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtCnpj.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCnpj_MaskInputRejected);
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(579, 26);
            this.txttelefone.Mask = "(00) 0000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(191, 25);
            this.txttelefone.TabIndex = 16;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(582, 116);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(193, 25);
            this.txtcodigo.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Código:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TelaFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 452);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.botaoeditar);
            this.Controls.Add(this.botaosalvar);
            this.Controls.Add(this.botaoexcluir);
            this.Controls.Add(this.BotaoNovo);
            this.Controls.Add(this.dgview);
            this.Controls.Add(this.lbluscarnome);
            this.Controls.Add(this.txtbuscarnome);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lbendereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbtelefone);
            this.Controls.Add(this.lbcnpj);
            this.Controls.Add(this.lbnome);
            this.Name = "TelaFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedores";
            this.Load += new System.EventHandler(this.TelaFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.Label lbcnpj;
        private System.Windows.Forms.Label lbtelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbendereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lbluscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgview;
        private System.Windows.Forms.Button BotaoNovo;
        private System.Windows.Forms.Button botaoexcluir;
        private System.Windows.Forms.Button botaosalvar;
        private System.Windows.Forms.Button botaoeditar;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lbluscarnome;
        private System.Windows.Forms.TextBox txtbuscarnome;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
    }
}