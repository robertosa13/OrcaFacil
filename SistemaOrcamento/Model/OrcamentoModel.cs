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
    class OrcamentoModel
    {
        OrcamentoController controller = new OrcamentoController();


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


        public void Salvar(Orcamento dado)
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


        public void Editar(Orcamento dado)
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

        public void Excluir(Orcamento dado)
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

        public object Buscar(Orcamento dado)
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
