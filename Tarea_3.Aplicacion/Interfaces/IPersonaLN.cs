using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea_3.Dominio.Entidades.Entidades;
using Tarea_3.Dominio.UTL;

namespace Tarea_3.Aplicacion.Interfaces
{
    public interface IPersonaLN
    {
        Respuesta<List<persona>> lfObtener();
        Respuesta<persona> lfActualizar(persona persona);
        Respuesta<persona> lfInsertar(persona persona);
        Respuesta<persona> lfBorrar(persona persona);
    }//Fin de la interfaz IPersonaLN.
}//Fin del namespace.

