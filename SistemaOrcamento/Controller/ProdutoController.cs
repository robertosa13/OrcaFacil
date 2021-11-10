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
    public class ProdutoController
    {

        MySqlCommand sql;

        Conexao con = new Conexao();


        // criação do método para listar OK
        public DataTable Listar()
        {
            try
            {
                con.Abrirconexao(); //abrir conexão
                sql = new MySqlCommand("SELECT * FROM PRODUTO order by NOME", con.con);
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

      
        // criação do método para editar
        public void Editar(Produtos dado)
        {
            try
            {
                con.Abrirconexao();
                sql = new MySqlCommand("UPDATE PRODUTO SET  nome = @nome,  descricao = @descricao, unidade = @unidade, valor = @valor WHERE id_produto = @id_produto", con.con);

                sql.Parameters.AddWithValue("@id_produto", dado.Id_produto);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@descricao", dado.Descricao);
                sql.Parameters.AddWithValue("@unidade", dado.Unidade);
                sql.Parameters.AddWithValue("@valor", dado.Valor);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Editar " + ex.Message);
                con.FecharConexao();
            }
        }

     

        public void Excluir(Produtos dados)
        {
            try
            {
                con.Abrirconexao();
                sql = new MySqlCommand("DELETE FROM PRODUTO WHERE id_produto = @id_produto", con.con);

                sql.Parameters.AddWithValue("@id_produto", dados.Id_produto);
                sql.ExecuteNonQuery();
                con.Fecharconexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                con.Fecharconexao();
            }
        }

        public void Inserir(Produtos dado)  //void não retorna dados
        {
            try
            {
                con.Abrirconexao(); //abrir conexão
                sql = new MySqlCommand("INSERT INTO PRODUTO ( nome, descricao, unidade , valor) values ( @nome, @descricao, @unidade, @valor)", con.con);
                sql.Parameters.AddWithValue("@id_produto", dado.Id_produto);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@descricao", dado.Descricao);
                sql.Parameters.AddWithValue("@unidade", dado.Unidade);
                sql.Parameters.AddWithValue("@valor", dado.Valor);

                sql.ExecuteNonQuery(); // executar o comando
                con.Fecharconexao(); // desligar a conexão
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
                con.FecharConexao();
            }
        }


        // ok
        public DataTable Buscar(Produtos dado)
        {
            try
            {
                con.Abrirconexao();
                sql = new MySqlCommand("SELECT * FROM PRODUTO where nome like @nome", con.con);
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
