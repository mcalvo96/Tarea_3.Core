using Tarea_3.Dominio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3.Dominio.IRepositorio
{
    public interface IRepositorioVehiculo
    {
        void insertar(vehiculo vehiculo);
        List<vehiculo> obtener();
        void actualizar(vehiculo vehiculo);
        void borrar(vehiculo vehiculo);
    }//Fin de la interfaz IRepositorioVehiculo.
}//Fin del namespace.
