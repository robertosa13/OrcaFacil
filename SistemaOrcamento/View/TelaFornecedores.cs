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
    public partial class TelaFornecedores : Form
    {

        FornecedorModel model = new FornecedorModel();
        public TelaFornecedores()
        {
            InitializeComponent();
            Listar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaFornecedores_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HabilitarCampo();
            botaosalvar.Enabled = true;
            Limpar();
            
        }

        private void HabilitarCampo()
        {
            // ao clicar no botão novo ele habilita esses campos

            txtNome.Enabled = true;
            txtCnpj.Enabled = true;
            txtEndereco.Enabled = true;
            txttelefone.Enabled = true;
            
        }

        private void DesabilitarCampo()
        {
            // ao clicar no botão novo ele desabilita esses campos

            txtNome.Enabled = false;
            txtCnpj.Enabled = false;
            txtEndereco.Enabled = false;
            txttelefone.Enabled = false;
        }

        private void Limpar()
        {
            txtNome.Text = "";
            txtCnpj.Text = "";
            txtEndereco.Text = "";
            txttelefone.Text = "";
            txtbuscarnome.Text = "";
            txtcodigo.Text = "";

        }      



        private void Salvar(Fornecedores dado)
        {
            
            try
            {
                dado.Nome = txtNome.Text;
                dado.Cnpj = txtCnpj.Text;
                dado.Endereco = txtEndereco.Text;
                dado.Telefone = txttelefone.Text;
                model.Salvar(dado); // dados vindo da caixa de texto
                MessageBox.Show("Fornecedor salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }

           
        }

        private void txtCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaosalvar_Click_1(object sender, EventArgs e)
        {

            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o Campo Nome!");
                return;
            }

            Fornecedores dados = new Fornecedores();
            Salvar(dados);
            Listar();
            Limpar();
            //DesabilitarCampos();
            botaosalvar.Enabled = false;
        }

        private void Listar()
        {
            try
            {
                dgview.DataSource = model.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void dgview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dgview.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgview.CurrentRow.Cells[1].Value.ToString();
            txtCnpj.Text = dgview.CurrentRow.Cells[2].Value.ToString();
            txttelefone.Text = dgview.CurrentRow.Cells[3].Value.ToString();
            txtEndereco.Text = dgview.CurrentRow.Cells[4].Value.ToString();

            HabilitarCampo();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Fornecedores dado = new Fornecedores();

            Buscar(dado);

            if (txtbuscarnome.Text == "")
            {

                Listar();
                return;
            }


        }

        public void Buscar(Fornecedores dado)
        {
            try
            {
                dado.Nome = txtbuscarnome.Text;
                dado.Cnpj = txtbuscarnome.Text; 
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

            if (MessageBox.Show("Deseja Excluir o fornecedor?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }
            Fornecedores dados = new Fornecedores();
            Excluir(dados);
            Listar();
            Limpar();
            DesabilitarCampo();
        }

        public void Excluir(Fornecedores dado)
        {

            try
            {
                dado.Id_fornecedor = Convert.ToInt32(txtcodigo.Text);


                model.Excluir(dado);
                MessageBox.Show("Registro excluido com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir " + ex.Message);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void botaoeditar_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para edição!");
                return;
            }

            Fornecedores dados = new Fornecedores();
            Editar(dados);
            Listar();
            Limpar();
            DesabilitarCampo();
        }



        public void Editar(Fornecedores dado)
        {

            try
            {
                dado.Id_fornecedor = Convert.ToInt32(txtcodigo.Text);
                dado.Nome = txtNome.Text;
                dado.Telefone = txttelefone.Text;
                dado.Endereco = txtEndereco.Text;
                dado.Cnpj = txtCnpj.Text;

                model.Editar(dado);
                MessageBox.Show("Registro Editado com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Editar " + ex.Message);
            }
        }
       
    }
}
