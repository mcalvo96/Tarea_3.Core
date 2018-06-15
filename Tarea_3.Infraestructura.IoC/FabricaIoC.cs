using Tarea_3.Dominio.IRepositorio;
using Tarea_3.Infraestructura.Datos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Tarea_3.Infraestructura.IoC
{
    public sealed class FabricaIoC
    {
        private static readonly FabricaIoC _container = new FabricaIoC();
        private readonly IUnityContainer _unityContainer;

        private FabricaIoC()
        {
            _unityContainer = new Unity.UnityContainer();
            _unityContainer.RegisterType<IRepositorioPersona, RepositorioPersona>();
            //_unityContainer.RegisterType<IRepositorioTipoHabitacion, RepositorioTipoHabitacion>();
            //_unityContainer.RegisterType<IRepositorioReserva, RepositorioReserva>();
            //_unityContainer.RegisterType<IRepositorioPagina, RepositorioPagina>();
            //_unityContainer.RegisterType<IRepositorioFacilidades, RepositorioFacilidades>();
            //_unityContainer.RegisterType<IRepositorioCaracteristicaHabitacion, RepositorioCaracteristicaHabitacion>();
        }//Fin del constructor.
        public static FabricaIoC Container
        {
            get { return _container; }
        }//Fin del método Container.
        public TService Resolver<TService>()
        {
            return _unityContainer.Resolve<TService>();
        }//Fin del método Resolver.
    }//Fin de la clase FabricaIoC.
}//Fin del namespace.