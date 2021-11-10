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
    public partial class TelaClientes : Form
    {
        
        
        // instância o objeto

        ClienteModel model = new ClienteModel();
        public TelaClientes()
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
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // campo de buscar os dados
        private void txtbuscarnome_TextChanged(object sender, EventArgs e)
        {
            Cliente dado = new Cliente();

            BuscarCliente(dado);
         
            if (txtbuscarnome.Text == "")
            {
                Listar();
                return;
            }
        }

        // chamada do método buscar o cliente
        public void BuscarCliente(Cliente dado)
        {
            try
            {
                dado.Nome = txtbuscarnome.Text;
                dado.Cpf = txtbuscarnome.Text;
                dgview.DataSource = model.BuscarCliente(dado);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Listar os Dados" + ex.Message);
            }
        }
        
        private void dgview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtCodigo.Text = dgview.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgview.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dgview.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = dgview.CurrentRow.Cells[3].Value.ToString();           
            txtEndereco.Text = dgview.CurrentRow.Cells[4].Value.ToString();

            HabilitarCampo();
        }
            


        // chamada do método para excluir um registro
       
      

        
        // eventos ao clicar no botão para editar um registro
        private void botaoeditar_Click_1(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para edição!");
                return;
            }

            Cliente dado = new Cliente();
            EditarCliente(dado);           
            Listar();
            Limpar();
            DesabilitarCampo();
        }




       
        

        private void botaosalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o Campo Nome!");
                return;
            }

            Cliente dados = new Cliente();
            Salvar(dados);
            Listar();
            Limpar();
            DesabilitarCampo();
            botaosalvar.Enabled = false;
        }


        // chamada do método para salvar um novo registro na tabela de clientes
        private void Salvar(Cliente dado)
        {

            try
            {
                dado.Nome = txtNome.Text;
                dado.Cpf =  txtCpf.Text;
                dado.Endereco = txtEndereco.Text;
                dado.Email = txtEmail.Text;
                model.Salvar(dado); // dados vindo da caixa de texto
                MessageBox.Show("Cliente salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }

        // evento ao clicar no novo para salvar um novo registrp

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
            txtCpf.Enabled = true;
            txtEndereco.Enabled = true;
            txtEmail.Enabled = true;
            txtCodigo.Enabled = true;

        }

        private void DesabilitarCampo()
        {
            // ao clicar no botão novo ele desabilita esses campos

            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            txtEndereco.Enabled = false;
            txtEmail.Enabled = false;
            txtCodigo.Enabled = false;
        }
        // chamada do método para limpar os campos
        private void Limpar()
        {
            txtNome.Text = "";
            txtCpf.Text = "";
            txtEndereco.Text = "";
            txtEmail.Text = "";
            txtbuscarnome.Text = "";
            txtCodigo.Text = "";

        }

        public void EditarCliente(Cliente dado)
        {

            try
            {
                dado.Id_cliente = Convert.ToInt32(txtCodigo.Text);
                dado.Nome = txtNome.Text;
                dado.Email = txtEmail.Text;
                dado.Cpf = txtCpf.Text;
                dado.Endereco = txtEndereco.Text;


                model.EditarCliente(dado);
                MessageBox.Show("Registro Editado com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Editar " + ex.Message);
            }
        }


        // evento ao clicar no botão excluir 

        private void botaoexcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Selecione na tabela um registro para excluir!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Deseja Excluir o cliente?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            Cliente dados = new Cliente();
            Excluir(dados);
            Listar();
            Limpar();
            DesabilitarCampo();
        }

        public void Excluir(Cliente dados)
        {
            try
            {
                dados.Id_cliente = Convert.ToInt32(txtCodigo.Text);


                model.Excluir(dados);
                MessageBox.Show("Cliente excluído com sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Excluir " + ex.Message);
            }
        }

        private void TelaClientes_Load(object sender, EventArgs e)
        {

        }

        private void TelaClientes_Load_1(object sender, EventArgs e)
        {

        }
    }
}
