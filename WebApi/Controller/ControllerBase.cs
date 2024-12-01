using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using CRUD;

namespace WebApi.Controllers
{
    /// <summary>
    /// Base controller providing common CRUD operations.
    /// </summary>
    /// <typeparam name="T">The type of the entity.</typeparam>
    public class ControllerBase<T> : ApiController where T : class
    {
        /// <summary>
        /// Retrieves all entities.
        /// </summary>
        /// <param name="appName">The name of the application.</param>
        /// <param name="function">The function name.</param>
        /// <param name="user">The user name.</param>
        /// <returns>A list of entities.</returns>
        [HttpGet]
        [Route("api/[controller]/all")]
        //[ResponseType(typeof(IEnumerable<T>))]
        public virtual IHttpActionResult GetAll(string appName = "", string function = "", string user = "")
        {
            Console.WriteLine($">HTTP Web Request : GetAll_{typeof(T).Name} | AppName :{appName} | Function : {function} | User : {user} ");

            var entities = Db.ReadAll<T>();

            if (entities == null || !entities.Any())
            {
                Console.WriteLine("\tNotFound");
                return NotFound();
            }

            Console.WriteLine("\tOk");
            return Ok(entities);
        }

        /// <summary>
        /// Retrieves an entity by its ID.
        /// </summary>
        /// <param name="id">The entity ID.</param>
        /// <param name="appName">The name of the application.</param>
        /// <param name="function">The function name.</param>
        /// <param name="user">The user name.</param>
        /// <returns>The entity.</returns>
        [HttpGet]
        [Route("api/[controller]")]
        //[ResponseType(typeof(T))]
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

        /// <summary>
        /// Creates a new entity.
        /// </summary>
        /// <param name="entity">The entity to create.</param>
        /// <returns>The result of the creation operation.</returns>
        [HttpPost]
        [Route("api/[controller]")]
        public virtual IHttpActionResult Create([FromBody] T entity)
        {
            Db.Create(entity);
            return Ok();
        }

        /// <summary>
        /// Updates an existing entity by its ID.
        /// </summary>
        /// <param name="id">The entity ID.</param>
        /// <param name="entity">The updated entity.</param>
        /// <returns>The result of the update operation.</returns>
        [HttpPut]
        [Route("api/[controller]")]
        public virtual IHttpActionResult Update(int id, [FromBody] T entity)
        {
            Db.UpdateById(id, entity);
            return Ok();
        }

        /// <summary>
        /// Deletes an entity by its ID.
        /// </summary>
        /// <param name="id">The entity ID.</param>
        /// <returns>The result of the deletion operation.</returns>
        [HttpDelete]
        [Route("api/[controller]")]
        public virtual IHttpActionResult Delete(int id)
        {
            Db.DeleteById<T>(id);
            return Ok();
        }
    }
}
