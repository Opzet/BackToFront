using System.Web.Http;
using Models;

namespace WebApi.Controllers
{
    /// <summary>
    /// Controller for managing models.
    /// </summary>
    [RoutePrefix("api/model")]
    public class ControllerModel : ControllerBase<Model>
    {
        /// <summary>
        /// Retrieves all models.
        /// </summary>
        /// <param name="appName">The name of the application.</param>
        /// <param name="function">The function name.</param>
        /// <param name="user">The user name.</param>
        /// <returns>A list of models.</returns>
        [HttpGet]
        [Route("all")]
        public override IHttpActionResult GetAll(string appName = "", string function = "", string user = "")
        {
            return base.GetAll(appName, function, user);
        }

        /// <summary>
        /// Retrieves a model by its ID.
        /// </summary>
        /// <param name="id">The model ID.</param>
        /// <param name="appName">The name of the application.</param>
        /// <param name="function">The function name.</param>
        /// <param name="user">The user name.</param>
        /// <returns>The model.</returns>
        [HttpGet]
        [Route("{id:int}")]
        public override IHttpActionResult Get(int id, string appName = "", string function = "", string user = "")
        {
            return base.Get(id, appName, function, user);
        }

        /// <summary>
        /// Creates a new model.
        /// </summary>
        /// <param name="entity">The model to create.</param>
        /// <returns>The result of the creation operation.</returns>
        [HttpPost]
        [Route("")]
        public override IHttpActionResult Create([FromBody] Model entity)
        {
            return base.Create(entity);
        }

        /// <summary>
        /// Updates an existing model by its ID.
        /// </summary>
        /// <param name="id">The model ID.</param>
        /// <param name="entity">The updated model.</param>
        /// <returns>The result of the update operation.</returns>
        [HttpPut]
        [Route("{id:int}")]
        public override IHttpActionResult Update(int id, [FromBody] Model entity)
        {
            return base.Update(id, entity);
        }

        /// <summary>
        /// Deletes a model by its ID.
        /// </summary>
        /// <param name="id">The model ID.</param>
        /// <returns>The result of the deletion operation.</returns>
        [HttpDelete]
        [Route("{id:int}")]
        public override IHttpActionResult Delete(int id)
        {
            return base.Delete(id);
        }
    }
}
