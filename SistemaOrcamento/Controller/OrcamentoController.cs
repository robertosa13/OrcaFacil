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
    class OrcamentoController
    {
        MySqlCommand sql;

        Conexao con = new Conexao();

        public DataTable Listar()
        {
            try
            {
                con.Abrirconexao(); //abrir conexão
                sql = new MySqlCommand("SELECT * FROM orcamento order by data desc", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql; //guarda as informações do comando sql 
                DataTable dt = new DataTable();
                da.Fill(dt); // a tabela
                return dt;
            }     
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void Editar(Orcamento dado)
        {
            try
            {
                con.Abrirconexao();
                sql = new MySqlCommand("UPDATE orcamento SET  numero_orcamento = @numero_orcamento, id_produto = @id_produto, id_cliente = @id_cliente, quantidade = @quantidade, valor_total = @valor_total data = @data WHERE id_orcamento = @id", con.con);
                sql.Parameters.AddWithValue("@numero_orcamento", dado.Numero_orcamento);
                sql.Parameters.AddWithValue("@id_produto", dado.Id_produto);
                sql.Parameters.AddWithValue("@id_cliente", dado.Id_cliente);
                sql.Parameters.AddWithValue("@quantidade", dado.Quantidade);
                sql.Parameters.AddWithValue("@valor_total", dado.Valor_total);
                sql.Parameters.AddWithValue("@data", dado.Data);
                sql.Parameters.AddWithValue("@id", dado.Id_orcamento);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Editar " + ex.Message);
                con.FecharConexao();
            }
        }


        public void Excluir(Orcamento dado)  //void não retorna dados
        {
            try
            {
                con.Abrirconexao(); //abrir conexão
                sql = new MySqlCommand("DELETE  FROM orcamento  WHERE id_orcamento  = @id_orcamento ", con.con);

                sql.Parameters.AddWithValue("@id_orcamento", dado.Id_orcamento);
                sql.ExecuteNonQuery(); // executar o comando
                con.Fecharconexao(); // desligar a conexão
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Fecharconexao();
            }
        }

        public void Inserir(Orcamento dado)  //void não retorna dados
        {
            try
            {
                con.Abrirconexao(); //abrir conexão
                sql = new MySqlCommand("INSERT INTO orcamento (numero_orcamento, id_produto, id_cliente , quantidade, valor_total, data) values ( @numero_orcamento, @id_produto, @id_cliente, @quantidade, @valor_total, @data)", con.con);


   


                sql.Parameters.AddWithValue("@numero_orcamento", dado.Numero_orcamento);
                sql.Parameters.AddWithValue("@id_produto", dado.Id_produto);
                sql.Parameters.AddWithValue("@id_cliente", dado.Id_cliente);
                sql.Parameters.AddWithValue("@quantidade", dado.Quantidade);
                sql.Parameters.AddWithValue("@valor_total", dado.Valor_total);
                sql.Parameters.AddWithValue("@data", dado.Data);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar " + ex.Message);
                con.FecharConexao();
            }
        }

        public DataTable Buscar(Orcamento dado)
        {
            try
            {
                con.Abrirconexao();
                sql = new MySqlCommand("SELECT * FROM orcamento where numero_orcamento like @numero_orcamento", con.con);
                sql.Parameters.AddWithValue("@numero_orcamento", dado.Numero_orcamento + "%");        

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
