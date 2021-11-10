using SistemaOrcamento.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOrcamento.Model
{
    public class ProdutoModel
    {
        ProdutoController controller = new ProdutoController();


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


        public void Salvar(Produtos dado)
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


        public void Editar(Produtos dado)
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

        public void Excluir(Produtos dado)
        {
            try
            {
                controller.Excluir(dado);
                ;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public object Buscar(Produtos dado)
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
