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
    public class ObjetoLN : IObjetoLN
    {
        #region        
        private readonly IRepositorioObjeto DominioObjeto;
        #endregion

        public ObjetoLN(IRepositorioObjeto repositorio)
        {
            DominioObjeto = repositorio;
        }//Fin del constructor.

        public Respuesta<objeto> lfActualizar(objeto objeto)
        {
            Respuesta<objeto> respuesta = new Respuesta<objeto>();

            try
            {
                DominioObjeto.actualizar(objeto);
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

        public Respuesta<objeto> lfBorrar(objeto objeto)
        {
            Respuesta<objeto> respuesta = new Respuesta<objeto>();

            try
            {
                DominioObjeto.borrar(objeto);
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

        public Respuesta<objeto> lfInsertar(objeto objeto)
        {
            Respuesta<objeto> respuesta = new Respuesta<objeto>();

            try
            {
                DominioObjeto.insertar(objeto);
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

        public Respuesta<List<objeto>> lfObtener()
        {
            Respuesta<List<objeto>> respuesta = new Respuesta<List<objeto>>();
            try
            {
                respuesta.valorRetorno = DominioObjeto.obtener();
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

    }//Fin de la clase ObjetoLN.
}//Fin del namespace.
