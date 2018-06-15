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
    [RoutePrefix("api/delito")]
    public class delitoController : ApiController
    {
        [Route("")]
        [HttpGet]
        [ResponseType(typeof(Respuesta<List<delito>>))]
        public IHttpActionResult obtenerDelito()
        {
            Respuesta<List<delito>> respuesta = new Respuesta<List<delito>>();
            var delitoLN = FabricaIoC.Container.Resolver<DelitoLN>();
            return Json(delitoLN.lfObtener(), new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método obtenerpersonas.

        [Route("")]
        [HttpPost]
        [ResponseType(typeof(Respuesta<persona>))]
        public IHttpActionResult insertarDelito([FromBody]delito delito)
        {
            DelitoLN delitoLN = FabricaIoC.Container.Resolver<DelitoLN>();
            return Json(delitoLN.lfInsertar(delito), new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método agregarReserva.

        [Route("")]
        [HttpPut]
        [ResponseType(typeof(Respuesta<delito>))]
        public IHttpActionResult actualizarDelito([FromBody]delito delito)
        {
            DelitoLN delitoLN = FabricaIoC.Container.Resolver<DelitoLN>();
            return Json(delitoLN.lfActualizar(delito), new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método actualizarPersona.

        [Route("")]
        [HttpPut]
        [ResponseType(typeof(Respuesta<delito>))]
        public IHttpActionResult borrarDelito([FromBody]delito delito)
        {
            DelitoLN delitoLN = FabricaIoC.Container.Resolver<DelitoLN>();
            return Json(delitoLN.lfBorrar(delito), new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método borrarPersona.

    }//Fin de la clase 
}//Fin del namespace.