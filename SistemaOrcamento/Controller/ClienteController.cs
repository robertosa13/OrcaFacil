using MySql.Data.MySqlClient;
using SistemaOrcamento.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOrcamento.Controller
{
    public class ClienteController
    {

        MySqlCommand sql;

        Conexao con = new Conexao();


        // criação do método para listar OK
        public DataTable Listar()
        {
            try
            {
                con.Abrirconexao(); //abrir conexão
                sql = new MySqlCommand("SELECT * FROM cliente order by ID_CLIENTE", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql; //guarda as informações do comando sql 
                DataTable dt = new DataTable();
                da.Fill(dt); // a tabela
                return dt; //vai retornar para a gridview
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        internal void Inserir(Produtos dado)
        {
            throw new NotImplementedException();
        }

        // criação do métod0 ara editar
        public void EditarCliente(Cliente dado)
        {
            try
            {
                con.Abrirconexao();
                sql = new MySqlCommand("UPDATE cliente SET  nome = @nome, email = @email, cpf = @cpf, endereco = @endereco WHERE id_cliente = @id_cliente", con.con);

                sql.Parameters.AddWithValue("@id_cliente", dado.Id_cliente);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@email", dado.Email);
                sql.Parameters.AddWithValue("@cpf", dado.Cpf);
                sql.Parameters.AddWithValue("@endereco", dado.Endereco);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Editar " + ex.Message);
                con.FecharConexao();
            }
        }
        /*
        public void Excluir(Cliente dados)  //void não retorna dados
        {
            try
            {
                con.Abrirconexao(); //abrir conexão
                sql = new MySqlCommand("DELETE  FROM CLIENTE WHERE id_cliente  = @id_cliente", con.con);

                sql.Parameters.AddWithValue("@id_cliente", dados.Id_cliente);
                sql.ExecuteNonQuery(); // executar o comando
                con.Fecharconexao(); // desligar a conexão
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Fecharconexao();
            }
        }*/

        public void ExcluirCliente(Cliente dados)
        {
            try
            {
                con.Abrirconexao();
                sql = new MySqlCommand("DELETE FROM CLIENTE WHERE id_cliente = @id_cliente", con.con);

                sql.Parameters.AddWithValue("@id_cliente", dados.Id_cliente);
                sql.ExecuteNonQuery();
                con.Fecharconexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                con.Fecharconexao();
            }
        }

        public void Inserir(Cliente dado)  //void não retorna dados
        {
            try
            {
                con.Abrirconexao(); //abrir conexão
                sql = new MySqlCommand("INSERT INTO cliente ( nome, email, cpf , endereco) values ( @nome, @email, @cpf, @endereco)", con.con);


                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@email", dado.Email);
                sql.Parameters.AddWithValue("@cpf", dado.Cpf);
                sql.Parameters.AddWithValue("@endereco", dado.Endereco);

                sql.ExecuteNonQuery(); // executar o comando
                con.Fecharconexao(); // desligar a conexão
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
                con.FecharConexao();
            }
        }

        public DataTable BuscarCliente(Cliente dado)
        {
            try
            {
                con.Abrirconexao();
                sql = new MySqlCommand("SELECT * FROM cliente where nome like @nome or cpf like @cpf", con.con);
                sql.Parameters.AddWithValue("@cpf", dado.Cpf + "%");
                sql.Parameters.AddWithValue("@nome", dado.Nome + "%");

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
                con.FecharConexao();
            }
        }

    }
}
