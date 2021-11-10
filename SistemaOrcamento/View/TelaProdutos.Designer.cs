
namespace SistemaOrcamento.View
{
    partial class TelaProdutos
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
            this.txtcodigo = new System.Windows.Forms.MaskedTextBox();
            this.botaoeditar = new System.Windows.Forms.Button();
            this.botaosalvar = new System.Windows.Forms.Button();
            this.botaoexcluir = new System.Windows.Forms.Button();
            this.BotaoNovo = new System.Windows.Forms.Button();
            this.dgview = new System.Windows.Forms.DataGridView();
            this.lbbuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbcodigo = new System.Windows.Forms.Label();
            this.lbdescricao = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.lbunidade = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.lbvalor = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(588, 10);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(195, 25);
            this.txtcodigo.TabIndex = 31;
            // 
            // botaoeditar
            // 
            this.botaoeditar.Location = new System.Drawing.Point(626, 408);
            this.botaoeditar.Name = "botaoeditar";
            this.botaoeditar.Size = new System.Drawing.Size(75, 23);
            this.botaoeditar.TabIndex = 29;
            this.botaoeditar.Text = "Editar";
            this.botaoeditar.UseVisualStyleBackColor = true;
            this.botaoeditar.Click += new System.EventHandler(this.botaoeditar_Click);
            // 
            // botaosalvar
            // 
            this.botaosalvar.Location = new System.Drawing.Point(545, 408);
            this.botaosalvar.Name = "botaosalvar";
            this.botaosalvar.Size = new System.Drawing.Size(75, 23);
            this.botaosalvar.TabIndex = 28;
            this.botaosalvar.Text = "Salvar";
            this.botaosalvar.UseVisualStyleBackColor = true;
            this.botaosalvar.Click += new System.EventHandler(this.botaosalvar_Click);
            // 
            // botaoexcluir
            // 
            this.botaoexcluir.Location = new System.Drawing.Point(707, 408);
            this.botaoexcluir.Name = "botaoexcluir";
            this.botaoexcluir.Size = new System.Drawing.Size(75, 23);
            this.botaoexcluir.TabIndex = 27;
            this.botaoexcluir.Text = "Excluir";
            this.botaoexcluir.UseVisualStyleBackColor = true;
            this.botaoexcluir.Click += new System.EventHandler(this.botaoexcluir_Click);
            // 
            // BotaoNovo
            // 
            this.BotaoNovo.Location = new System.Drawing.Point(464, 408);
            this.BotaoNovo.Name = "BotaoNovo";
            this.BotaoNovo.Size = new System.Drawing.Size(75, 23);
            this.BotaoNovo.TabIndex = 26;
            this.BotaoNovo.Text = "Novo";
            this.BotaoNovo.UseVisualStyleBackColor = true;
            this.BotaoNovo.Click += new System.EventHandler(this.BotaoNovo_Click_1);
            // 
            // dgview
            // 
            this.dgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview.Location = new System.Drawing.Point(22, 157);
            this.dgview.Name = "dgview";
            this.dgview.RowTemplate.Height = 27;
            this.dgview.Size = new System.Drawing.Size(759, 231);
            this.dgview.TabIndex = 25;
            this.dgview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgview_CellContentClick);
            this.dgview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgview_CellContentClick);
            // 
            // lbbuscar
            // 
            this.lbbuscar.AutoSize = true;
            this.lbbuscar.Location = new System.Drawing.Point(18, 411);
            this.lbbuscar.Name = "lbbuscar";
            this.lbbuscar.Size = new System.Drawing.Size(49, 17);
            this.lbbuscar.TabIndex = 24;
            this.lbbuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(77, 408);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(323, 25);
            this.txtBuscar.TabIndex = 23;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(589, 41);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(192, 25);
            this.txtFornecedor.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Fornecedor:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(105, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(265, 25);
            this.txtNome.TabIndex = 20;
            // 
            // lbcodigo
            // 
            this.lbcodigo.AutoSize = true;
            this.lbcodigo.Location = new System.Drawing.Point(520, 10);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(54, 17);
            this.lbcodigo.TabIndex = 19;
            this.lbcodigo.Text = "Código:";
            // 
            // lbdescricao
            // 
            this.lbdescricao.AutoSize = true;
            this.lbdescricao.Location = new System.Drawing.Point(12, 78);
            this.lbdescricao.Name = "lbdescricao";
            this.lbdescricao.Size = new System.Drawing.Size(68, 17);
            this.lbdescricao.TabIndex = 18;
            this.lbdescricao.Text = "Descrição:";
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Location = new System.Drawing.Point(46, 9);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(47, 17);
            this.lbnome.TabIndex = 17;
            this.lbnome.Text = "Nome:";
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(588, 72);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(193, 25);
            this.txtUnidade.TabIndex = 34;
            // 
            // lbunidade
            // 
            this.lbunidade.AutoSize = true;
            this.lbunidade.Location = new System.Drawing.Point(520, 75);
            this.lbunidade.Name = "lbunidade";
            this.lbunidade.Size = new System.Drawing.Size(60, 17);
            this.lbunidade.TabIndex = 33;
            this.lbunidade.Text = "Unidade:";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(588, 103);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(193, 25);
            this.txtvalor.TabIndex = 36;
            // 
            // lbvalor
            // 
            this.lbvalor.AutoSize = true;
            this.lbvalor.Location = new System.Drawing.Point(533, 106);
            this.lbvalor.Name = "lbvalor";
            this.lbvalor.Size = new System.Drawing.Size(41, 17);
            this.lbvalor.TabIndex = 35;
            this.lbvalor.Text = "Valor:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(105, 75);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(265, 25);
            this.txtDescricao.TabIndex = 37;
            // 
            // TelaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.lbvalor);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.lbunidade);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.botaoeditar);
            this.Controls.Add(this.botaosalvar);
            this.Controls.Add(this.botaoexcluir);
            this.Controls.Add(this.BotaoNovo);
            this.Controls.Add(this.dgview);
            this.Controls.Add(this.lbbuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbcodigo);
            this.Controls.Add(this.lbdescricao);
            this.Controls.Add(this.lbnome);
            this.Name = "TelaProdutos";
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.TelaProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtcodigo;
        private System.Windows.Forms.Button botaoeditar;
        private System.Windows.Forms.Button botaosalvar;
        private System.Windows.Forms.Button botaoexcluir;
        private System.Windows.Forms.Button BotaoNovo;
        private System.Windows.Forms.DataGridView dgview;
        private System.Windows.Forms.Label lbbuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.Label lbdescricao;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.Label lbunidade;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label lbvalor;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}