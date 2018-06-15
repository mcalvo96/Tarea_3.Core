
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
    public class RepositorioPersona : IRepositorioPersona
    {

        private readonly Tarea_3_Ing_b41250Entities1 SS_Contexto;

        public RepositorioPersona(Tarea_3_Ing_b41250Entities1 contexto)
        {
            SS_Contexto = contexto;
        }//Fin del constructor.

        public List<persona> obtener()
        {
            List<persona> listaCaracteristicasHabitacion = new List<persona>();
            try
            {
                listaCaracteristicasHabitacion = (from list in SS_Contexto.persona select list).ToList<persona>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
            return listaCaracteristicasHabitacion;
        }//Fin del método obtener.

        public void insertar(persona persona)
        {
            DbContextTransaction dbTransaccion = SS_Contexto.Database.BeginTransaction();

            try
            {
                SS_Contexto.persona.Add(persona);
                SS_Contexto.SaveChanges();
                dbTransaccion.Commit();
            }
            catch (Exception ex)
            {
                dbTransaccion.Rollback();
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
        }
        public void actualizar(persona persona)
        {
            DbContextTransaction dbTransaccion = SS_Contexto.Database.BeginTransaction();

            try
            {
                var entity = SS_Contexto.persona.Find(persona.identificacion);
                SS_Contexto.Entry(entity).CurrentValues.SetValues(persona);
                SS_Contexto.SaveChanges();
                dbTransaccion.Commit();
            }
            catch (Exception ex)
            {
                dbTransaccion.Rollback();
                throw new Exception(ex.ToString());
            }//Fin del try-catch.            
        }

        public void borrar(persona persona)
        {
            DbContextTransaction dbTransaccion = SS_Contexto.Database.BeginTransaction();

            try
            {
                SS_Contexto.persona.Remove(persona);
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