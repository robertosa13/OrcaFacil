using SistemaOrcamento.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOrcamento
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // fechar o programa
        }

    

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaFornecedores frm = new TelaFornecedores(); //abrir tela de fornecedores
            frm.ShowDialog();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaClientes frm = new TelaClientes(); //abrir tela de clientes
            frm.ShowDialog();
        }


        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaProdutos frm = new TelaProdutos(); // tela de produtos
            frm.ShowDialog();
        }

        private void novoOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtData frm = new txtData(); // tela de orçamentos
            frm.ShowDialog();

        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}


