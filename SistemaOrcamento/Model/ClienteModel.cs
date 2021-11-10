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
    public class ClienteModel
    {

        // o controller não consegue se comunicar com a tela (view), precisa do modelo que faz
        // a chamada dos métodos que tem dentro da controller

        // quem chama o modelo é a view

        ClienteController controller = new ClienteController();


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


        public void Salvar(Cliente dado)
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


        public void EditarCliente(Cliente dado)
        {
            try
            {
                controller.EditarCliente(dado);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Excluir(Cliente dado)
        {
            try
            {
                controller.ExcluirCliente(dado);
;            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public object BuscarCliente(Cliente dado)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = controller.BuscarCliente(dado);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
