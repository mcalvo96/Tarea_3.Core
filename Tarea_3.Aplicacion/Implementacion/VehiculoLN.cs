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
    public class VehiculoLN : IVehiculoLN
    {
        #region        
        private readonly IRepositorioVehiculo DominioVehiculo;
        #endregion

        public VehiculoLN(IRepositorioVehiculo repositorio)
        {
            DominioVehiculo = repositorio;
        }//Fin del constructor.

        public Respuesta<vehiculo> lfActualizar(vehiculo vehiculo)
        {
            Respuesta<vehiculo> respuesta = new Respuesta<vehiculo>();

            try
            {
                DominioVehiculo.actualizar(vehiculo);
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

        public Respuesta<vehiculo> lfBorrar(vehiculo vehiculo)
        {
            Respuesta<vehiculo> respuesta = new Respuesta<vehiculo>();

            try
            {
                DominioVehiculo.borrar(vehiculo);
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

        public Respuesta<vehiculo> lfInsertar(vehiculo vehiculo)
        {
            Respuesta<vehiculo> respuesta = new Respuesta<vehiculo>();

            try
            {
                DominioVehiculo.insertar(vehiculo);
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

        public Respuesta<List<vehiculo>> lfObtener()
        {
            Respuesta<List<vehiculo>> respuesta = new Respuesta<List<vehiculo>>();
            try
            {
                respuesta.valorRetorno = DominioVehiculo.obtener();
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

    }//Fin de la clase vehiculoLN.
}//Fin del namespace.
