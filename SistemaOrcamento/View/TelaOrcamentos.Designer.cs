
namespace SistemaOrcamento.View
{
    partial class txtData
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
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.MaskedTextBox();
            this.botaoeditar = new System.Windows.Forms.Button();
            this.botaosalvar = new System.Windows.Forms.Button();
            this.botaoexcluir = new System.Windows.Forms.Button();
            this.BotaoNovo = new System.Windows.Forms.Button();
            this.dgview = new System.Windows.Forms.DataGridView();
            this.lbbuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.txtCodigoOrcamento = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.CaixaData = new System.Windows.Forms.DateTimePicker();
            this.txtValorTotal = new System.Windows.Forms.MaskedTextBox();
            this.lblvalortotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(545, 49);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(237, 25);
            this.txtCliente.TabIndex = 53;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(477, 57);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(50, 17);
            this.lblCliente.TabIndex = 52;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(125, 46);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(263, 25);
            this.txtProduto.TabIndex = 50;
            // 
            // botaoeditar
            // 
            this.botaoeditar.Location = new System.Drawing.Point(626, 412);
            this.botaoeditar.Name = "botaoeditar";
            this.botaoeditar.Size = new System.Drawing.Size(75, 23);
            this.botaoeditar.TabIndex = 49;
            this.botaoeditar.Text = "Editar";
            this.botaoeditar.UseVisualStyleBackColor = true;
            // 
            // botaosalvar
            // 
            this.botaosalvar.Location = new System.Drawing.Point(545, 412);
            this.botaosalvar.Name = "botaosalvar";
            this.botaosalvar.Size = new System.Drawing.Size(75, 23);
            this.botaosalvar.TabIndex = 48;
            this.botaosalvar.Text = "Salvar";
            this.botaosalvar.UseVisualStyleBackColor = true;
            // 
            // botaoexcluir
            // 
            this.botaoexcluir.Location = new System.Drawing.Point(707, 412);
            this.botaoexcluir.Name = "botaoexcluir";
            this.botaoexcluir.Size = new System.Drawing.Size(75, 23);
            this.botaoexcluir.TabIndex = 47;
            this.botaoexcluir.Text = "Excluir";
            this.botaoexcluir.UseVisualStyleBackColor = true;
            // 
            // BotaoNovo
            // 
            this.BotaoNovo.Location = new System.Drawing.Point(464, 412);
            this.BotaoNovo.Name = "BotaoNovo";
            this.BotaoNovo.Size = new System.Drawing.Size(75, 23);
            this.BotaoNovo.TabIndex = 46;
            this.BotaoNovo.Text = "Novo";
            this.BotaoNovo.UseVisualStyleBackColor = true;
            // 
            // dgview
            // 
            this.dgview.AllowUserToResizeColumns = false;
            this.dgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgview.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgview.Location = new System.Drawing.Point(45, 170);
            this.dgview.Name = "dgview";
            this.dgview.RowTemplate.Height = 27;
            this.dgview.Size = new System.Drawing.Size(737, 236);
            this.dgview.TabIndex = 45;
            this.dgview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgview_CellContentClick);
            this.dgview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgview_CellContentClick);
            this.dgview.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgview_CellContentClick);
            // 
            // lbbuscar
            // 
            this.lbbuscar.AutoSize = true;
            this.lbbuscar.Location = new System.Drawing.Point(18, 415);
            this.lbbuscar.Name = "lbbuscar";
            this.lbbuscar.Size = new System.Drawing.Size(49, 17);
            this.lbbuscar.TabIndex = 44;
            this.lbbuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(77, 412);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(323, 25);
            this.txtBuscar.TabIndex = 43;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(547, 13);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(235, 25);
            this.txtQuantidade.TabIndex = 42;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(464, 13);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(79, 17);
            this.lblQuantidade.TabIndex = 41;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(123, 10);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(265, 25);
            this.txtNumero.TabIndex = 40;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(48, 49);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(58, 17);
            this.lblProduto.TabIndex = 39;
            this.lblProduto.Text = "Produto:";
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Location = new System.Drawing.Point(12, 13);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(94, 17);
            this.lbnome.TabIndex = 37;
            this.lbnome.Text = "Nº orçamento:";
            // 
            // txtCodigoOrcamento
            // 
            this.txtCodigoOrcamento.Location = new System.Drawing.Point(125, 80);
            this.txtCodigoOrcamento.Name = "txtCodigoOrcamento";
            this.txtCodigoOrcamento.Size = new System.Drawing.Size(98, 25);
            this.txtCodigoOrcamento.TabIndex = 57;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(56, 88);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 17);
            this.lblCodigo.TabIndex = 56;
            this.lblCodigo.Text = "Código:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(68, 128);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(38, 17);
            this.lblData.TabIndex = 58;
            this.lblData.Text = "Data:";
            // 
            // CaixaData
            // 
            this.CaixaData.Location = new System.Drawing.Point(123, 122);
            this.CaixaData.Name = "CaixaData";
            this.CaixaData.Size = new System.Drawing.Size(265, 25);
            this.CaixaData.TabIndex = 60;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(545, 120);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(235, 25);
            this.txtValorTotal.TabIndex = 62;
            // 
            // lblvalortotal
            // 
            this.lblvalortotal.AutoSize = true;
            this.lblvalortotal.Location = new System.Drawing.Point(436, 128);
            this.lblvalortotal.Name = "lblvalortotal";
            this.lblvalortotal.Size = new System.Drawing.Size(91, 17);
            this.lblvalortotal.TabIndex = 61;
            this.lblvalortotal.Text = "Valor do total:";
            // 
            // txtData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.lblvalortotal);
            this.Controls.Add(this.CaixaData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtCodigoOrcamento);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.botaoeditar);
            this.Controls.Add(this.botaosalvar);
            this.Controls.Add(this.botaoexcluir);
            this.Controls.Add(this.BotaoNovo);
            this.Controls.Add(this.dgview);
            this.Controls.Add(this.lbbuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lbnome);
            this.Name = "txtData";
            this.Text = "Orçamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.MaskedTextBox txtProduto;
        private System.Windows.Forms.Button botaoeditar;
        private System.Windows.Forms.Button botaosalvar;
        private System.Windows.Forms.Button botaoexcluir;
        private System.Windows.Forms.Button BotaoNovo;
        private System.Windows.Forms.DataGridView dgview;
        private System.Windows.Forms.Label lbbuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.TextBox txtCodigoOrcamento;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker CaixaData;
        private System.Windows.Forms.MaskedTextBox txtValorTotal;
        private System.Windows.Forms.Label lblvalortotal;
    }
}