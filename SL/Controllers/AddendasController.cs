using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL.Controllers
{
    public class AddendasController : ApiController
    {
        [HttpGet]
        [Route("Api/Addendas/GetAll")]
        
        public IHttpActionResult AddendaGetAll ()
        {
            var result = BL.Addendas.AddendaGetAll();
            if (result.Correct)
            {
                return Ok(result);
            } else
            {
                return BadRequest();
            }
        }

        public IHttpActionResult AddByList()
        {

            //ADD
            return Ok();
        }
    }
}
