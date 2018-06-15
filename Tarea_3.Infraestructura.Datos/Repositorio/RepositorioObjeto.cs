
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
    public class RepositorioObjeto : IRepositorioObjeto
    {

        private readonly Tarea_3_Ing_b41250Entities1 SS_Contexto;

        public RepositorioObjeto(Tarea_3_Ing_b41250Entities1 contexto)
        {
            SS_Contexto = contexto;
        }//Fin del constructor.

        public List<objeto> obtener()
        {
            List<objeto> listaObjeto = new List<objeto>();
            try
            {
                listaObjeto = (from list in SS_Contexto.objeto select list).ToList<objeto>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
            return listaObjeto;
        }//Fin del método obtener.

        public void insertar(objeto objeto)
        {
            DbContextTransaction dbTransaccion = SS_Contexto.Database.BeginTransaction();

            try
            {
                SS_Contexto.objeto.Add(objeto);
                SS_Contexto.SaveChanges();
                dbTransaccion.Commit();
            }
            catch (Exception ex)
            {
                dbTransaccion.Rollback();
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
        }
        public void actualizar(objeto objeto)
        {
            DbContextTransaction dbTransaccion = SS_Contexto.Database.BeginTransaction();

            try
            {
                var entity = SS_Contexto.objeto.Find(objeto.idObjeto);
                SS_Contexto.Entry(entity).CurrentValues.SetValues(objeto);
                SS_Contexto.SaveChanges();
                dbTransaccion.Commit();
            }
            catch (Exception ex)
            {
                dbTransaccion.Rollback();
                throw new Exception(ex.ToString());
            }//Fin del try-catch.            
        }

        public void borrar(objeto objeto)
        {
            DbContextTransaction dbTransaccion = SS_Contexto.Database.BeginTransaction();

            try
            {
                SS_Contexto.objeto.Remove(objeto);
                SS_Contexto.SaveChanges();
                dbTransaccion.Commit();
            }
            catch (Exception ex)
            {
                dbTransaccion.Rollback();
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
        }
    }//Fin de la clase Repositorioobjeto.
}//Fin del namespace.