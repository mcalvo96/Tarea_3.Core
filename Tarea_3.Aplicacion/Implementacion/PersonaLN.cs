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
    public class PersonaLN : IPersonaLN
    {
        #region        
        private readonly IRepositorioPersona DominioPersona;
        #endregion

        public PersonaLN(IRepositorioPersona repositorio)
        {
            DominioPersona = repositorio;
        }//Fin del constructor.

        public Respuesta<persona> lfActualizar(persona persona)
        {
            Respuesta<persona> respuesta = new Respuesta<persona>();

            try
            {
                DominioPersona.actualizar(persona);
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

        public Respuesta<persona> lfBorrar(persona persona)
        {
            Respuesta<persona> respuesta = new Respuesta<persona>();

            try
            {
                DominioPersona.borrar(persona);
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

        public Respuesta<persona> lfInsertar(persona persona)
        {
            Respuesta<persona> respuesta = new Respuesta<persona>();

            try
            {
                DominioPersona.insertar(persona);
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

        public Respuesta<List<persona>> lfObtener()
        {
            Respuesta<List<persona>> respuesta = new Respuesta<List<persona>>();
            try
            {
                respuesta.valorRetorno = DominioPersona.obtener();
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
  
    }//Fin de la clase CaracteristicaHabitacionLN.
}//Fin del namespace.
