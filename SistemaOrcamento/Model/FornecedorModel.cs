using SistemaOrcamento.Controller;
using SistemaOrcamento.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOrcamento.Model
{
    public class FornecedorModel
    {
        // o controller não consegue se comunicar com a tela (view), precisa do modelo que faz
        // a chamada dos métodos que tem dentro da controller

        // quem chama o modelo é a view

        FornecedorController controller = new FornecedorController();


        public DataTable Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = controller.Listar();
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    

        public void Salvar(Fornecedores dado)
        {
            try
            {
                controller.Inserir(dado);
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
                controller.Editar(dado);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Excluir(Fornecedores dado)
        {
            try
            {
                controller.Excluir(dado);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        public object Buscar(Fornecedores dado)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = controller.Buscar(dado);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
