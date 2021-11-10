using SistemaOrcamento.Entidades;
using SistemaOrcamento.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOrcamento.View
{
    public partial class txtData : Form
    {
        OrcamentoModel model = new OrcamentoModel();
        public txtData()
        {
            InitializeComponent();
            Listar();
        }
        // chamada do método na model para listar os dados
        private void Listar()
        {
            try
            {
                dgview.DataSource = model.Listar();

                dgview.Columns[0].HeaderText = "Código";
                dgview.Columns[1].HeaderText = "Número orçamento";
                dgview.Columns[2].HeaderText = "Código produto";
                dgview.Columns[3].HeaderText = "Código cliente";
                dgview.Columns[4].HeaderText = "Quantidade";
                dgview.Columns[5].HeaderText = "Valor total";
                dgview.Columns[6].HeaderText = "Data";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BotaoNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampo();
            botaosalvar.Enabled = true;
            Limpar();
        }

        private void HabilitarCampo()
        {
            // ao clicar no botão novo ele habilita esses campos

            txtNumero.Enabled = true;
            txtQuantidade.Enabled = true;
            txtProduto.Enabled = true;
            txtCliente.Enabled = true;
        }

        private void DesabilitarCampo()
        {
            // ao clicar no botão novo ele desabilita esses campos

            txtNumero.Enabled = false;
            txtQuantidade.Enabled = false;
            txtProduto.Enabled = false;
            txtCliente.Enabled = false;
        }
        // chamada do método para limpar os campos
        private void Limpar()
        {

            txtNumero.Text = "";
            txtQuantidade.Text = "";
            txtProduto.Text = "";
            txtCliente.Text = "";
            txtValorTotal.Text = "";
            txtCodigoOrcamento.Text = "";

        }












        private void botaosalvar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                MessageBox.Show("Preencha o Campo Número!");
                return;
            }

            Orcamento dados = new Orcamento();
            Salvar(dados);
            Listar();
            Limpar();
            DesabilitarCampo();
            botaosalvar.Enabled = false;
        }


        // chamada do método para salvar um novo registro na tabela de clientes
        private void Salvar(Orcamento dado)
        {

            try
            {
                dado.Numero_orcamento = txtNumero.Text;
                dado.Id_cliente = Convert.ToInt32(txtCliente);
                dado.Id_produto = Convert.ToInt32(txtProduto.Text);
                dado.Quantidade = Convert.ToInt32(txtQuantidade.Text);                  
                dado.Valor_total = float.Parse(txtValorTotal.Text); 
                dado.Data = DateTime.Today;

                model.Salvar(dado); // dados vindo da caixa de texto
                MessageBox.Show("orçamento salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }


        /*

        private void botaoeditar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para edição!");
                return;
            }

            Orcamento dado = new Orcamento();
            Editar(dado);
            Listar();
            Limpar();
            DesabilitarCampo();

        }

        
        public void Editar(Orcamento dado)
        {

            try
            {
                dado.Id_produto = Convert.ToInt32(txtcodigo.Text);
                dado.Nome = txtNome.Text;
                dado.Descricao = txtDescricao.Text;
                dado.Unidade = txtUnidade.Text;
                dado.Valor = txtUnidade.Text;


                model.Editar(dado);
                MessageBox.Show("Registro Editado com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Editar " + ex.Message);
            }
        }*/



        // método buscar implementado
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {          

            Orcamento dado = new Orcamento();
                       

            Buscar(dado);

            if (txtNumero.Text == "")
            {
                Listar();
                return;
            }
        }

        // chamada do método buscar o cliente
        public void Buscar(Orcamento dado)
        {
            try
            {
                dado.Numero_orcamento= txtBuscar.Text;
                dgview.DataSource = model.Buscar(dado);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Listar os Dados" + ex.Message);
            }
        }

        private void botaoexcluir_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para excluir!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja Excluir o orçamento?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            Orcamento dados = new Orcamento();
            Excluir(dados);
            Listar();
            Limpar();
            DesabilitarCampo();
        }
        public void Excluir(Orcamento dados)
        {
            try
            {
                dados.Id_orcamento = Convert.ToInt32(txtCodigoOrcamento.Text);
                model.Excluir(dados);
                MessageBox.Show("Produto excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir " + ex.Message);
            }
        }

        private void dgview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtCodigoOrcamento.Text = dgview.CurrentRow.Cells[0].Value.ToString();
            txtNumero.Text = dgview.CurrentRow.Cells[1].Value.ToString();
            txtProduto.Text = dgview.CurrentRow.Cells[2].Value.ToString();
            txtCliente.Text = dgview.CurrentRow.Cells[3].Value.ToString();
            txtQuantidade.Text = dgview.CurrentRow.Cells[4].Value.ToString();
            txtValorTotal.Text = dgview.CurrentRow.Cells[5].Value.ToString();








            HabilitarCampo();
        }

        private void BotaoNovo_Click_1(object sender, EventArgs e)
        {
            HabilitarCampo();
            botaosalvar.Enabled = true;
            Limpar();

        }

       
    }

}
