using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_3.Dominio.Entidades.Entidades;
using Tarea_3.Dominio.UTL;

namespace Tarea_3.Aplicacion.Interfaces
{
    public interface IDelitoLN
    {
        Respuesta<List<delito>> lfObtener();
        Respuesta<delito> lfActualizar(delito delito);
        Respuesta<delito> lfInsertar(delito delito);
        Respuesta<delito> lfBorrar(delito delito);
    }//Fin de la interfaz IDelitoLN.
}//Fin del namespace.

