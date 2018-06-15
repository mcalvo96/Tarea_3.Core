
using Tarea_3.Dominio.IRepositorio;
using Tarea_3.Dominio.Entidades;
using Tarea_3.Dominio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tarea_3.Infraestructura.Datos.Repositorio
{
    public class RepositorioVehiculo: IRepositorioVehiculo
    {

        private readonly Tarea_3_Ing_b41250Entities1 SS_Contexto;

        public RepositorioVehiculo(Tarea_3_Ing_b41250Entities1 contexto)
        {
            SS_Contexto = contexto;
        }//Fin del constructor.

        public List<vehiculo> obtener()
        {
            List<vehiculo> listavehiculo = new List<vehiculo>();
            try
            {
                listavehiculo = (from list in SS_Contexto.vehiculo select list).ToList<vehiculo>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
            return listavehiculo;
        }//Fin del método obtener.

        public void insertar(vehiculo vehiculo)
        {
            DbContextTransaction dbTransaccion = SS_Contexto.Database.BeginTransaction();

            try
            {
                SS_Contexto.vehiculo.Add(vehiculo);
                SS_Contexto.SaveChanges();
                dbTransaccion.Commit();
            }
            catch (Exception ex)
            {
                dbTransaccion.Rollback();
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
        }
        public void actualizar(vehiculo vehiculo)
        {
            DbContextTransaction dbTransaccion = SS_Contexto.Database.BeginTransaction();

            try
            {
                var entity = SS_Contexto.vehiculo.Find(vehiculo.idVehiculo);
                SS_Contexto.Entry(entity).CurrentValues.SetValues(vehiculo);
                SS_Contexto.SaveChanges();
                dbTransaccion.Commit();
            }
            catch (Exception ex)
            {
                dbTransaccion.Rollback();
                throw new Exception(ex.ToString());
            }//Fin del try-catch.            
        }

        public void borrar(vehiculo vehiculo)
        {
            DbContextTransaction dbTransaccion = SS_Contexto.Database.BeginTransaction();

            try
            {
                SS_Contexto.vehiculo.Remove(vehiculo);
                SS_Contexto.SaveChanges();
                dbTransaccion.Commit();
            }
            catch (Exception ex)
            {
                dbTransaccion.Rollback();
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
        }
    }//Fin de la clase RepositorioPersona.
}//Fin del namespace.