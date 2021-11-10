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
    public partial class TelaProdutos : Form
    {

        ProdutoModel model = new ProdutoModel();

        public TelaProdutos()
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
                //dgview.Columns[0].Visible = false;
                dgview.Columns[0].HeaderText = "Código";
                dgview.Columns[1].HeaderText = "Nome";
                dgview.Columns[2].HeaderText = "Descrição";
                dgview.Columns[3].HeaderText = "Unidade";
                dgview.Columns[4].HeaderText = "Valor";               

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

            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
            txtUnidade.Enabled = true;
            txtvalor.Enabled = true;
           
          

        }

        private void DesabilitarCampo()
        {
            // ao clicar no botão novo ele desabilita esses campos

            txtNome.Enabled = false;
            txtDescricao.Enabled = false;
            txtUnidade.Enabled = false;
            txtvalor.Enabled = false;
        }
        // chamada do método para limpar os campos
        private void Limpar()
        {

            txtNome.Text = "";
            txtDescricao.Text = "";
            txtUnidade.Text = "";
            txtvalor.Text = "";            

        }


        private void botaosalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o Campo Nome!");
                return;
            }

            Produtos dados = new Produtos();
            Salvar(dados);
            Listar();
            Limpar();
            DesabilitarCampo();
            botaosalvar.Enabled = false;
        }        


        // chamada do método para salvar um novo registro na tabela de clientes
        private void Salvar(Produtos dado)
        {

            try
            {
                dado.Nome = txtNome.Text;
                dado.Descricao = txtDescricao.Text;
                dado.Unidade = txtUnidade.Text;
                dado.Valor = txtUnidade.Text;
                model.Salvar(dado); // dados vindo da caixa de texto
                MessageBox.Show("Produto salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }




        private void botaoeditar_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para edição!");
                return;
            }

            Produtos dado = new Produtos();
            Editar(dado);
            Listar();
            Limpar();
            DesabilitarCampo();

        }

        public void Editar(Produtos dado)
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
        }



        // método buscar implementado
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Produtos dado = new Produtos();

            Buscar(dado);

            if (txtBuscar.Text == "")
            {
                Listar();
                return;
            }
        }

        // chamada do método buscar o cliente
        public void Buscar(Produtos dado)
        {
            try
            {
                dado.Nome = txtBuscar.Text;               
                dgview.DataSource = model.Buscar(dado);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Listar os Dados" + ex.Message);
            }
        }

        private void botaoexcluir_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para excluir!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja Excluir o produto?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            Produtos dados = new Produtos();
            Excluir(dados);
            Listar();
            Limpar();
            DesabilitarCampo();
        }
        public void Excluir(Produtos dados)
        {
            try
            {
                dados.Id_produto = Convert.ToInt32(txtcodigo.Text);


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

            txtcodigo.Text = dgview.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgview.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = dgview.CurrentRow.Cells[2].Value.ToString();
            txtUnidade.Text = dgview.CurrentRow.Cells[3].Value.ToString();
            txtvalor.Text = dgview.CurrentRow.Cells[4].Value.ToString();
            HabilitarCampo();
        }

        private void BotaoNovo_Click_1(object sender, EventArgs e)
        {
            HabilitarCampo();
            botaosalvar.Enabled = true;
            Limpar();
        }

        private void TelaProdutos_Load(object sender, EventArgs e)
        {

        }
    }
    
}
