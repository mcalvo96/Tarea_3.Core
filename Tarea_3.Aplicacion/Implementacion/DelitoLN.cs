using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_3.Aplicacion.Interfaces;
using Tarea_3.Dominio.IRepositorio;
using Tarea_3.Dominio.Entidades.Entidades;
using Tarea_3.Dominio.UTL;

namespace Tarea_3.Aplicacion.Implementacion
{
    public class DelitoLN : IDelitoLN
    {
        #region        
        private readonly IRepositorioDelito DominioDelito;
        #endregion

        public DelitoLN(IRepositorioDelito repositorio)
        {
            DominioDelito = repositorio;
        }//Fin del constructor.

        public Respuesta<delito> lfActualizar(delito delito)
        {
            Respuesta<delito> respuesta = new Respuesta<delito>();

            try
            {
                DominioDelito.actualizar(delito);
                respuesta.resultado = 1;
            }
            catch (Exception ex)
            {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
                respuesta.resultado = 0;
            }//Fin del try-catch.
            return respuesta;
        }

        public Respuesta<delito> lfBorrar(delito delito)
        {
            Respuesta<delito> respuesta = new Respuesta<delito>();

            try
            {
                DominioDelito.borrar(delito);
                respuesta.resultado = 1;
            }
            catch (Exception ex)
            {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
                respuesta.resultado = 0;
            }//Fin del try-catch.
            return respuesta;
        }

        public Respuesta<delito> lfInsertar(delito delito)
        {
            Respuesta<delito> respuesta = new Respuesta<delito>();

            try
            {
                DominioDelito.insertar(delito);
                respuesta.resultado = 1;
            }
            catch (Exception ex)
            {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
                respuesta.resultado = 0;
            }//Fin del try-catch.
            return respuesta;
        }//fin del insertar

        public Respuesta<List<delito>> lfObtener()
        {
            Respuesta<List<delito>> respuesta = new Respuesta<List<delito>>();
            try
            {
                respuesta.valorRetorno = DominioDelito.obtener();
                respuesta.resultado = 1;
            }
            catch (Exception ex)
            {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
                respuesta.resultado = 0;
            }//Fin del try-catch.
            return respuesta;
        }//Fin del método lfObtener.

    }//Fin de la clase DelitoLN.
}//Fin del namespace.
