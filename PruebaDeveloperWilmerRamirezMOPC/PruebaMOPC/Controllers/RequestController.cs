using PruebaMOPC.Models;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace PruebaMOPC.Controllers
{
    public class RequestController : ApiController
    {
        DbContexto bd = new DbContexto();
        
        [HttpGet]
        [Route("api/Request/{id}")]
        public IHttpActionResult Get(int id)
        {
            //Tiene que crear uno antes de solicitarlo
            var record = bd.MOPCData.Where(b => b.Id == id).SingleOrDefault();
            var json = new JavaScriptSerializer().Serialize(record);
            return Ok(json);
        }


        [HttpGet]
        [Route("api/Request/ExisteCedula/{cedula}")]
        public IHttpActionResult ExisteCedula(int cedula)
        {
            var registroCedula = bd.MOPCData.Where(b => b.Cedula == cedula).SingleOrDefault();
            return registroCedula != null ? Ok(true) : Ok(false);
        }


        [HttpGet]
        [Route("api/Request/ExisteRNC/{rnc}")]
        public IHttpActionResult ExisteRNC(int rnc)
        {
            var registroRnc = bd.MOPCData.Where(b => b.RNC == rnc).SingleOrDefault();
            return registroRnc != null ? Ok(true) : Ok(false);
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] MOPCData record)
        {
               var rec = bd.MOPCData.Add(record);
                bd.SaveChanges();
                return Ok(record.Id);
        }
    }
}
