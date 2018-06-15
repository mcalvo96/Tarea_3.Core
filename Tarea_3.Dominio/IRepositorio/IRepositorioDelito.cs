using Tarea_3.Dominio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3.Dominio.IRepositorio
{
    public interface IRepositorioDelito
    {
        void insertar(delito delito);
        List<delito> obtener();
        void actualizar(delito delito);
        void borrar(delito delito);


    }//Fin de la interfaz IRepositorioDelito.
}//Fin del namespace.
