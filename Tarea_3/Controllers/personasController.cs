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
    [RoutePrefix("api/TSH_persona")]
    public class personasController : ApiController
    {
        [Route("")]
        [HttpGet]
        [ResponseType(typeof(Respuesta<List<personasController>>))]
        public IHttpActionResult obtenerCaracteristicasHabitaciones()
        {
            Respuesta<List<personasController>> respuesta = new Respuesta<List<personasController>>();
            var caracteristicaHabitacionLN = FabricaIoC.Container.Resolver<PersonaLN>();
            return Json(caracteristicaHabitacionLN.lfObtener(), new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método obtenerpersonas.

        [Route("")]
        [HttpPost]
        [ResponseType(typeof(Respuesta<persona>))]
        public IHttpActionResult insertarPersona([FromBody]persona persona)
        {
            PersonaLN personaLN = FabricaIoC.Container.Resolver<PersonaLN>();
            return Json(personaLN.lfInsertar(persona), new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método agregarReserva.

        [Route("")]
        [HttpPut]
        [ResponseType(typeof(Respuesta<persona>))]
        public IHttpActionResult actualizarPersonas([FromBody]persona persona)
        {
            PersonaLN personasLN = FabricaIoC.Container.Resolver<PersonaLN>();
            return Json(personasLN.lfActualizar(persona), new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método actualizarPersona.

        [Route("")]
        [HttpPut]
        [ResponseType(typeof(Respuesta<persona>))]
        public IHttpActionResult borrarPersonas([FromBody]persona persona)
        {
            PersonaLN personasLN = FabricaIoC.Container.Resolver<PersonaLN>();
            return Json(personasLN.lfBorrar(persona), new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método borrarPersona.

    }//Fin de la clase 
}//Fin del namespace.