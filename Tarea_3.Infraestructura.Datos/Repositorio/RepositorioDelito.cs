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
    public class RepositorioDelito : IRepositorioDelito
    {

        private readonly Tarea_3_Ing_b41250Entities1 SS_Contexto;

        public RepositorioDelito(Tarea_3_Ing_b41250Entities1 contexto)
        {
            SS_Contexto = contexto;
        }//Fin del constructor.

        public List<delito> obtener()
        {
            List<delito> listaDelito = new List<delito>();
            try
            {
                listaDelito = (from list in SS_Contexto.delito select list).ToList<delito>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
            return listaDelito;
        }//Fin del método obtener.

        public void insertar(delito delito)
        {
            DbContextTransaction dbTransaccion = SS_Contexto.Database.BeginTransaction();

            try
            {
                SS_Contexto.delito.Add(delito);
                SS_Contexto.SaveChanges();
                dbTransaccion.Commit();
            }
            catch (Exception ex)
            {
                dbTransaccion.Rollback();
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
        }
        public void actualizar(delito delito)
        {
            DbContextTransaction dbTransaccion = SS_Contexto.Database.BeginTransaction();

            try
            {
                var entity = SS_Contexto.delito.Find(delito.idDelito);
                SS_Contexto.Entry(entity).CurrentValues.SetValues(delito);
                SS_Contexto.SaveChanges();
                dbTransaccion.Commit();
            }
            catch (Exception ex)
            {
                dbTransaccion.Rollback();
                throw new Exception(ex.ToString());
            }//Fin del try-catch.            
        }

        public void borrar(delito delito)
        {
            DbContextTransaction dbTransaccion = SS_Contexto.Database.BeginTransaction();

            try
            {
                SS_Contexto.delito.Remove(delito);
                SS_Contexto.SaveChanges();
                dbTransaccion.Commit();
            }
            catch (Exception ex)
            {
                dbTransaccion.Rollback();
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
        }
    }//Fin de la clase RepositorioDelito.
}//Fin del namespace.