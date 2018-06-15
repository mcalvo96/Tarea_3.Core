using Tarea_3.Dominio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3.Dominio.IRepositorio
{
    public interface IRepositorioObjeto
    {
        void insertar(objeto objeto);
        List<objeto> obtener();
        void actualizar(objeto objeto);
        void borrar(objeto objeto);


    }//Fin de la interfaz IRepositorioObjeto.
}//Fin del namespace.
