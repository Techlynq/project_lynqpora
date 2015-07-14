using Unilynq.BusinessEntities;
using Unilynq.BusinessServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Unilynq.WebApi.Filters;

namespace Unilynq.WebApi.Controllers
{
    public class LynQerController : ApiController
    {
        private ILynQerServices _lynQerServices;

        //CHANGE TO ASYNCHRONOUS


        public LynQerController(ILynQerServices lynQerServices)
        {
            _lynQerServices = lynQerServices;
        }

        // GET api/lynqer
        public HttpResponseMessage Get()
        {
            var lynQers = _lynQerServices.GetAllLynQers();
            if (lynQers != null)
            {
                var lynQerEntities = lynQers as List<LynQerEntity> ?? lynQers.ToList();
                if (lynQerEntities.Any())
                {
                    return Request.CreateResponse(HttpStatusCode.OK, lynQerEntities);
                }
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No LynQers Found");
        }

        // GET api/lynqer/5
        public HttpResponseMessage Get(int id)
        {
            var lynQer = _lynQerServices.GetLynQerById(id);
            if (lynQer != null)
                return Request.CreateResponse(HttpStatusCode.OK, lynQer);
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No LynQer found for this id");
        }

        // POST api/lynqer
        public int Post([FromBody] LynQerEntity lynQerEntity)
        {
            return _lynQerServices.CreateLynQer(lynQerEntity);
        }

        // PUT api/lynqer/5
        public bool Put(int id, [FromBody]LynQerEntity lynQerEntity)
        {
            if (id > 0)
            {
                return _lynQerServices.UpdateLynQer(id, lynQerEntity);
            }
            return false;
        }

        // DELETE api/lynqer/5
        public bool Delete(int id)
        {
            if (id > 0)
                return _lynQerServices.DeleteLynQer(id);
            return false;
        }
    }
}
