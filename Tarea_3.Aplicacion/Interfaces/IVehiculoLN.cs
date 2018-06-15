using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_3.Dominio.Entidades.Entidades;
using Tarea_3.Dominio.UTL;

namespace Tarea_3.Aplicacion.Interfaces
{
    public interface IVehiculoLN
    {
        Respuesta<List<vehiculo>> lfObtener();
        Respuesta<vehiculo> lfActualizar(vehiculo vehiculo);
        Respuesta<vehiculo> lfInsertar(vehiculo vehiculo);
        Respuesta<vehiculo> lfBorrar(vehiculo vehiculo);
    }//Fin de la interfaz IvehiculoLN.
}//Fin del namespace.


