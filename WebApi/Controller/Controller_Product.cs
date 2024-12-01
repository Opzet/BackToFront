using System.Web.Http;
using Models;

namespace WebApi.Controllers
{
    /// <summary>
    /// Controller for managing products.
    /// </summary>
    [RoutePrefix("api/product")]
    public class Controller_Product : Controller_Base<Product>
    {
        /// <summary>
        /// Retrieves all products.
        /// </summary>
        /// <param name="appName">The name of the application.</param>
        /// <param name="function">The function name.</param>
        /// <param name="user">The user name.</param>
        /// <returns>A list of products.</returns>
        [HttpGet]
        [Route("all")]
        public override IHttpActionResult GetAll(string appName = "", string function = "", string user = "")
        {
            return base.GetAll(appName, function, user);
        }

        /// <summary>
        /// Retrieves a product by its ID.
        /// </summary>
        /// <param name="id">The product ID.</param>
        /// <param name="appName">The name of the application.</param>
        /// <param name="function">The function name.</param>
        /// <param name="user">The user name.</param>
        /// <returns>The product.</returns>
        [HttpGet]
        [Route("{id:int}")]
        public override IHttpActionResult Get(int id, string appName = "", string function = "", string user = "")
        {
            return base.Get(id, appName, function, user);
        }

        /// <summary>
        /// Creates a new product.
        /// </summary>
        /// <param name="entity">The product to create.</param>
        /// <returns>The result of the creation operation.</returns>
        [HttpPost]
        [Route("")]
        public override IHttpActionResult Create([FromBody] Product entity)
        {
            return base.Create(entity);
        }

        /// <summary>
        /// Updates an existing product by its ID.
        /// </summary>
        /// <param name="id">The product ID.</param>
        /// <param name="entity">The updated product.</param>
        /// <returns>The result of the update operation.</returns>
        [HttpPut]
        [Route("{id:int}")]
        public override IHttpActionResult Update(int id, [FromBody] Product entity)
        {
            return base.Update(id, entity);
        }

        /// <summary>
        /// Deletes a product by its ID.
        /// </summary>
        /// <param name="id">The product ID.</param>
        /// <returns>The result of the deletion operation.</returns>
        [HttpDelete]
        [Route("{id:int}")]
        public override IHttpActionResult Delete(int id)
        {
            return base.Delete(id);
        }
    }
}
