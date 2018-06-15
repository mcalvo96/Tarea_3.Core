using Tarea_3.Dominio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3.Dominio.IRepositorio
{
    public interface IRepositorioPersona
    {
        void insertar(persona persona);
        List<persona> obtener();
        void actualizar(persona persona);
        void borrar(persona persona);


    }//Fin de la interfaz IRepositorioPersona.
}//Fin del namespace.
