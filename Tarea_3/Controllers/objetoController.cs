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
    [RoutePrefix("api/objeto")]
    public class objetoController : ApiController
    {
        [Route("")]
        [HttpGet]
        [ResponseType(typeof(Respuesta<List<objeto>>))]
        public IHttpActionResult obtenerObjeto()
        {
            Respuesta<List<objeto>> respuesta = new Respuesta<List<objeto>>();
            var objetoLN = FabricaIoC.Container.Resolver<ObjetoLN>();
            return Json(objetoLN.lfObtener(), new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método obtenerpersonas.

        [Route("")]
        [HttpPost]
        [ResponseType(typeof(Respuesta<objeto>))]
        public IHttpActionResult insertarObjeto([FromBody]objeto objeto)
        {
            ObjetoLN objetoLN = FabricaIoC.Container.Resolver<ObjetoLN>();
            return Json(objetoLN.lfInsertar(objeto), new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método agregarReserva.

        [Route("")]
        [HttpPut]
        [ResponseType(typeof(Respuesta<objeto>))]
        public IHttpActionResult actualizarObjeto([FromBody]objeto objeto)
        {
            ObjetoLN objetoLN = FabricaIoC.Container.Resolver<ObjetoLN>();
            return Json(objetoLN.lfActualizar(objeto), new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método actualizarPersona.

        [Route("")]
        [HttpPut]
        [ResponseType(typeof(Respuesta<objeto>))]
        public IHttpActionResult borrarObjeto([FromBody]objeto objeto)
        {
            ObjetoLN objetoLN = FabricaIoC.Container.Resolver<ObjetoLN>();
            return Json(objetoLN.lfBorrar(objeto), new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método borrarPersona.

    }//Fin de la clase 
}//Fin del namespace.