
namespace SistemaOrcamento.View
{
    partial class TelaClientes
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
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.botaoeditar = new System.Windows.Forms.Button();
            this.botaosalvar = new System.Windows.Forms.Button();
            this.botaoexcluir = new System.Windows.Forms.Button();
            this.BotaoNovo = new System.Windows.Forms.Button();
            this.dgview = new System.Windows.Forms.DataGridView();
            this.lbluscar = new System.Windows.Forms.Label();
            this.txtbuscarnome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lbendereco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbcpf = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(92, 58);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(146, 25);
            this.txtCpf.TabIndex = 30;
            // 
            // botaoeditar
            // 
            this.botaoeditar.Location = new System.Drawing.Point(392, 408);
            this.botaoeditar.Name = "botaoeditar";
            this.botaoeditar.Size = new System.Drawing.Size(75, 23);
            this.botaoeditar.TabIndex = 29;
            this.botaoeditar.Text = "Editar";
            this.botaoeditar.UseVisualStyleBackColor = true;
            this.botaoeditar.Click += new System.EventHandler(this.botaoeditar_Click_1);
            // 
            // botaosalvar
            // 
            this.botaosalvar.Location = new System.Drawing.Point(311, 408);
            this.botaosalvar.Name = "botaosalvar";
            this.botaosalvar.Size = new System.Drawing.Size(75, 23);
            this.botaosalvar.TabIndex = 28;
            this.botaosalvar.Text = "Salvar";
            this.botaosalvar.UseVisualStyleBackColor = true;
            this.botaosalvar.Click += new System.EventHandler(this.botaosalvar_Click);
            // 
            // botaoexcluir
            // 
            this.botaoexcluir.Location = new System.Drawing.Point(473, 408);
            this.botaoexcluir.Name = "botaoexcluir";
            this.botaoexcluir.Size = new System.Drawing.Size(75, 23);
            this.botaoexcluir.TabIndex = 27;
            this.botaoexcluir.Text = "Excluir";
            this.botaoexcluir.UseVisualStyleBackColor = true;
            this.botaoexcluir.Click += new System.EventHandler(this.botaoexcluir_Click);
            // 
            // BotaoNovo
            // 
            this.BotaoNovo.Location = new System.Drawing.Point(230, 408);
            this.BotaoNovo.Name = "BotaoNovo";
            this.BotaoNovo.Size = new System.Drawing.Size(75, 23);
            this.BotaoNovo.TabIndex = 26;
            this.BotaoNovo.Text = "Novo";
            this.BotaoNovo.UseVisualStyleBackColor = true;
            this.BotaoNovo.Click += new System.EventHandler(this.BotaoNovo_Click);
            // 
            // dgview
            // 
            this.dgview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview.Location = new System.Drawing.Point(92, 128);
            this.dgview.Name = "dgview";
            this.dgview.RowTemplate.Height = 27;
            this.dgview.Size = new System.Drawing.Size(623, 274);
            this.dgview.TabIndex = 25;
            this.dgview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgview_CellClick);
            this.dgview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgview_CellClick);
            // 
            // lbluscar
            // 
            this.lbluscar.AutoSize = true;
            this.lbluscar.Location = new System.Drawing.Point(525, 95);
            this.lbluscar.Name = "lbluscar";
            this.lbluscar.Size = new System.Drawing.Size(49, 17);
            this.lbluscar.TabIndex = 24;
            this.lbluscar.Text = "Buscar:";
            // 
            // txtbuscarnome
            // 
            this.txtbuscarnome.Location = new System.Drawing.Point(584, 92);
            this.txtbuscarnome.Name = "txtbuscarnome";
            this.txtbuscarnome.Size = new System.Drawing.Size(195, 25);
            this.txtbuscarnome.TabIndex = 23;
            this.txtbuscarnome.TextChanged += new System.EventHandler(this.txtbuscarnome_TextChanged);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(586, 59);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(193, 25);
            this.txtEndereco.TabIndex = 22;
            // 
            // lbendereco
            // 
            this.lbendereco.AutoSize = true;
            this.lbendereco.Location = new System.Drawing.Point(508, 62);
            this.lbendereco.Name = "lbendereco";
            this.lbendereco.Size = new System.Drawing.Size(66, 17);
            this.lbendereco.TabIndex = 21;
            this.lbendereco.Text = "Endereço:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(92, 18);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(265, 25);
            this.txtNome.TabIndex = 20;
            // 
            // lbcpf
            // 
            this.lbcpf.AutoSize = true;
            this.lbcpf.Location = new System.Drawing.Point(22, 61);
            this.lbcpf.Name = "lbcpf";
            this.lbcpf.Size = new System.Drawing.Size(32, 17);
            this.lbcpf.TabIndex = 18;
            this.lbcpf.Text = "CPF:";
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Location = new System.Drawing.Point(22, 21);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(47, 17);
            this.lbnome.TabIndex = 17;
            this.lbnome.Text = "Nome:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(586, 20);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 25);
            this.txtEmail.TabIndex = 33;
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(522, 26);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(47, 17);
            this.lbemail.TabIndex = 32;
            this.lbemail.Text = "E-mail:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(92, 92);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(146, 25);
            this.txtCodigo.TabIndex = 35;
            this.txtCodigo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Código:";
            // 
            // TelaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.botaoeditar);
            this.Controls.Add(this.botaosalvar);
            this.Controls.Add(this.botaoexcluir);
            this.Controls.Add(this.BotaoNovo);
            this.Controls.Add(this.dgview);
            this.Controls.Add(this.lbluscar);
            this.Controls.Add(this.txtbuscarnome);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lbendereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbcpf);
            this.Controls.Add(this.lbnome);
            this.Name = "TelaClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.TelaClientes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Button botaoeditar;
        private System.Windows.Forms.Button botaosalvar;
        private System.Windows.Forms.Button botaoexcluir;
        private System.Windows.Forms.Button BotaoNovo;
        private System.Windows.Forms.DataGridView dgview;
        private System.Windows.Forms.Label lbluscar;
        private System.Windows.Forms.TextBox txtbuscarnome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lbendereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbcpf;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.Label label1;
    }
}