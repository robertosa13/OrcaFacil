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
    public class FornecedorController
    {
        MySqlCommand sql;

        Conexao con = new Conexao();

        public DataTable Listar()
        {
            try
            {
                con.Abrirconexao(); //abrir conexão
                sql = new MySqlCommand("SELECT * FROM fornecedores order by ID_FORNECEDOR desc", con.con);
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


        public void Editar(Fornecedores dado)
        {
            try
            {
                con.Abrirconexao();
                sql = new MySqlCommand("UPDATE fornecedores SET  nome = @nome, cnpj = @cnpj, telefone = @telefone, endereco = @endereco WHERE id_fornecedor = @id", con.con);
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@cnpj", dado.Cnpj);
                sql.Parameters.AddWithValue("@telefone", dado.Telefone);
                sql.Parameters.AddWithValue("@endereco", dado.Endereco);
                sql.Parameters.AddWithValue("@id", dado.Id_fornecedor);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Editar " + ex.Message);
                con.FecharConexao();
            }
        }


        public void Excluir(Fornecedores dado)  //void não retorna dados
        {
            try
            {
                con.Abrirconexao(); //abrir conexão
                sql = new MySqlCommand("DELETE  FROM fornecedores  WHERE id_fornecedor  = @id_fornecedor ", con.con);
                
                sql.Parameters.AddWithValue("@id_fornecedor", dado.Id_fornecedor);
                sql.ExecuteNonQuery(); // executar o comando
                con.Fecharconexao(); // desligar a conexão
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Fecharconexao();
            }
        }

        public void Inserir(Fornecedores dado)  //void não retorna dados
        {
            try
            {
                con.Abrirconexao(); //abrir conexão
                sql = new MySqlCommand("INSERT INTO fornecedores ( nome, cnpj, telefone , endereco) values ( @nome, @cnpj, @telefone, @endereco)", con.con);
                               

                
                sql.Parameters.AddWithValue("@nome", dado.Nome);
                sql.Parameters.AddWithValue("@cnpj", dado.Cnpj);
                sql.Parameters.AddWithValue("@telefone", dado.Telefone);
                sql.Parameters.AddWithValue("@endereco", dado.Endereco);
                //sql.Parameters.AddWithValue("@id_fornecedor", dado.Id_fornecedor);
                
                sql.ExecuteNonQuery(); // executar o comando
                con.Fecharconexao(); // desligar a conexão
            }
             catch (Exception ex)
            {

                MessageBox.Show("Erro ao Salvar " + ex.Message);
                con.FecharConexao();
            }
        }

         public DataTable Buscar(Fornecedores dado)
        {
            try
            {
                con.Abrirconexao();
                sql = new MySqlCommand("SELECT * FROM fornecedores where nome like @nome or cnpj like @cnpj", con.con);
                sql.Parameters.AddWithValue("@cnpj", dado.Cnpj + "%");
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


