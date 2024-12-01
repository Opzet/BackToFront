using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Description;
using CRUD;

namespace WebApi.Controllers
{
    public class Controller_Base<T> : ApiController where T : class
    {

        [HttpGet]
        [Route("api/[controller]/all")]
        public virtual IHttpActionResult GetAll(string appName = "", string function = "", string user = "")
        {
            IEnumerable<T> entities = Db.ReadAll<T>();

            if (entities == null) // || entities.Count == 0)
            {
                return NotFound();
            }

            return Ok(entities);
        }

        [HttpGet]
        [Route("api/[controller]")]
        public virtual IHttpActionResult Get(int id, string appName = "", string function = "", string user = "")
        {
            Console.WriteLine($">HTTP Web Request : Get_{typeof(T).Name} (Id : {id} | AppName :{appName} | Function : {function}) | User : {user} ");

            T entity = Db.GetById<T>(id);

            if (entity == null)
            {
                Console.WriteLine("\tNotFound");
                return NotFound();
            }

            Console.WriteLine("\tOk");
            return Ok(entity);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public virtual IHttpActionResult Create([FromBody] T entity)
        {
            Db.Create(entity);
            return Ok();
        }

        [HttpPut]
        [Route("api/[controller]")]
        public virtual IHttpActionResult Update(int id, [FromBody] T entity)
        {
            Db.UpdateById(id, entity);
            return Ok();
        }

        [HttpDelete]
        [Route("api/[controller]")]
        public virtual IHttpActionResult Delete(int id)
        {
            Db.DeleteById<T>(id);
            return Ok();
        }
    }
}
