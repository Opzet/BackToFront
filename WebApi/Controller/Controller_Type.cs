using System.Web.Http;
using Models;

namespace WebApi.Controllers
{
    /// <summary>
    /// Controller for managing types.
    /// </summary>
    [RoutePrefix("api/type")]
    public class Controller_Type : Controller_Base<Type>
    {
        /// <summary>
        /// Retrieves all types.
        /// </summary>
        /// <param name="appName">The name of the application.</param>
        /// <param name="function">The function name.</param>
        /// <param name="user">The user name.</param>
        /// <returns>A list of types.</returns>
        [HttpGet]
        [Route("all")]
        public override IHttpActionResult GetAll(string appName = "", string function = "", string user = "")
        {
            return base.GetAll(appName, function, user);
        }

        /// <summary>
        /// Retrieves a type by its ID.
        /// </summary>
        /// <param name="id">The type ID.</param>
        /// <param name="appName">The name of the application.</param>
        /// <param name="function">The function name.</param>
        /// <param name="user">The user name.</param>
        /// <returns>The type.</returns>
        [HttpGet]
        [Route("{id:int}")]
        public override IHttpActionResult Get(int id, string appName = "", string function = "", string user = "")
        {
            return base.Get(id, appName, function, user);
        }

        /// <summary>
        /// Creates a new type.
        /// </summary>
        /// <param name="entity">The type to create.</param>
        /// <returns>The result of the creation operation.</returns>
        [HttpPost]
        [Route("")]
        public override IHttpActionResult Create([FromBody] Type entity)
        {
            return base.Create(entity);
        }

        /// <summary>
        /// Updates an existing type by its ID.
        /// </summary>
        /// <param name="id">The type ID.</param>
        /// <param name="entity">The updated type.</param>
        /// <returns>The result of the update operation.</returns>
        [HttpPut]
        [Route("{id:int}")]
        public override IHttpActionResult Update(int id, [FromBody] Type entity)
        {
            return base.Update(id, entity);
        }

        /// <summary>
        /// Deletes a type by its ID.
        /// </summary>
        /// <param name="id">The type ID.</param>
        /// <returns>The result of the deletion operation.</returns>
        [HttpDelete]
        [Route("{id:int}")]
        public override IHttpActionResult Delete(int id)
        {
            return base.Delete(id);
        }
    }
}
