using System.Web.Http;
using Models;

namespace WebApi.Controllers
{
    /// <summary>
    /// Controller for managing makes.
    /// </summary>
    [RoutePrefix("api/make")]
    public class ControllerMake : ControllerBase<Make>
    {
        /// <summary>
        /// Retrieves all makes.
        /// </summary>
        /// <param name="appName">The name of the application.</param>
        /// <param name="function">The function name.</param>
        /// <param name="user">The user name.</param>
        /// <returns>A list of makes.</returns>
        [HttpGet]
        [Route("all")]
        public override IHttpActionResult GetAll(string appName = "", string function = "", string user = "")
        {
            return base.GetAll(appName, function, user);
        }

        /// <summary>
        /// Retrieves a make by its ID.
        /// </summary>
        /// <param name="id">The make ID.</param>
        /// <param name="appName">The name of the application.</param>
        /// <param name="function">The function name.</param>
        /// <param name="user">The user name.</param>
        /// <returns>The make.</returns>
        [HttpGet]
        [Route("{id:int}")]
        public override IHttpActionResult Get(int id, string appName = "", string function = "", string user = "")
        {
            return base.Get(id, appName, function, user);
        }

        /// <summary>
        /// Creates a new make.
        /// </summary>
        /// <param name="entity">The make to create.</param>
        /// <returns>The result of the creation operation.</returns>
        [HttpPost]
        [Route("")]
        public override IHttpActionResult Create([FromBody] Make entity)
        {
            return base.Create(entity);
        }

        /// <summary>
        /// Updates an existing make by its ID.
        /// </summary>
        /// <param name="id">The make ID.</param>
        /// <param name="entity">The updated make.</param>
        /// <returns>The result of the update operation.</returns>
        [HttpPut]
        [Route("{id:int}")]
        public override IHttpActionResult Update(int id, [FromBody] Make entity)
        {
            return base.Update(id, entity);
        }

        /// <summary>
        /// Deletes a make by its ID.
        /// </summary>
        /// <param name="id">The make ID.</param>
        /// <returns>The result of the deletion operation.</returns>
        [HttpDelete]
        [Route("{id:int}")]
        public override IHttpActionResult Delete(int id)
        {
            return base.Delete(id);
        }
    }
}
