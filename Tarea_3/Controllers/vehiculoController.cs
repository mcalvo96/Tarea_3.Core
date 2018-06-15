using Newtonsoft.Json;
using Tarea_3.Aplicacion.Implementacion;
using Tarea_3.Dominio.Entidades.Entidades;
using Tarea_3.Dominio.UTL;
using Tarea_3.Infraestructura.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Tarea_3.Core.Controllers
{
    [RoutePrefix("api/vehiculo")]
    public class vehiculoController : ApiController
    {
        [Route("")]
        [HttpGet]
        [ResponseType(typeof(Respuesta<List<vehiculo>>))]
        public IHttpActionResult obtenerVehiculo()
        {
            Respuesta<List<vehiculo>> respuesta = new Respuesta<List<vehiculo>>();
            var vehiculoLN = FabricaIoC.Container.Resolver<VehiculoLN>();
            return Json(vehiculoLN.lfObtener(), new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método obtenerpersonas.

        [Route("")]
        [HttpPost]
        [ResponseType(typeof(Respuesta<vehiculo>))]
        public IHttpActionResult insertarVehiculo([FromBody]vehiculo vehiculo)
        {
            VehiculoLN vehiculoLN = FabricaIoC.Container.Resolver<VehiculoLN>();
            return Json(vehiculoLN.lfInsertar(vehiculo), new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método agregarReserva.

        [Route("")]
        [HttpPut]
        [ResponseType(typeof(Respuesta<vehiculo>))]
        public IHttpActionResult actualizarVehiculo([FromBody]vehiculo vehiculo)
        {
            VehiculoLN vehiculoLN = FabricaIoC.Container.Resolver<VehiculoLN>();
            return Json(vehiculoLN.lfActualizar(vehiculo), new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método actualizarPersona.

        [Route("")]
        [HttpPut]
        [ResponseType(typeof(Respuesta<vehiculo>))]
        public IHttpActionResult borrarVehiculo([FromBody]vehiculo vehiculo)
        {
            VehiculoLN vehiculoLN = FabricaIoC.Container.Resolver<VehiculoLN>();
            return Json(vehiculoLN.lfBorrar(vehiculo), new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método borrarPersona.

    }//Fin de la clase 
}//Fin del namespace.