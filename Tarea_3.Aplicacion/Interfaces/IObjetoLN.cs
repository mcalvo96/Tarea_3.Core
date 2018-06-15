using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_3.Dominio.Entidades.Entidades;
using Tarea_3.Dominio.UTL;

namespace Tarea_3.Aplicacion.Interfaces
{
    public interface IObjetoLN
    {
        Respuesta<List<objeto>> lfObtener();
        Respuesta<objeto> lfActualizar(objeto objeto);
        Respuesta<objeto> lfInsertar(objeto objeto);
        Respuesta<objeto> lfBorrar(objeto objeto);
    }//Fin de la interfaz IObjetoLN.
}//Fin del namespace.

