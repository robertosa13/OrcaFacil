// Created by Roberto Sá on 14/09/2021

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOrcamento
{
    class Conexao
    {
        string conexao = "SERVER = localhost;Port = 3306; DATABASE = sistemaorcamento; UID = root; PWD = *******;";


        public MySqlConnection con = null;

        public void Abrirconexao()
        {
            try
            {
                con = new MySqlConnection(conexao); // abrir a conexão
                con.Open();               
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao conectar" + ex.Message); // gerar mensagem de erro
            }
        }

        public void Fecharconexao()
        {
            try
            {
                con = new MySqlConnection(conexao); // Fechar a conexão
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fechar conexão" + ex.Message); // gerar mensagem de erro
            }
        }

        internal void FecharConexao()
        {
            throw new NotImplementedException();
        }

        internal void AbrirConexao()
        {
            throw new NotImplementedException();
        }
    }
}
