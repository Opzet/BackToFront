using System;
using System.Web.Http.Description;
using System.Web.Http;
using CRUD;
using Models;

namespace WebApi.Controllers
{
    public class Controller_Type : Controller_Base<Product>
    {
    }

    public class Controller_Product : Controller_Base<Product>
    {
    }

    public class Controller_Make : Controller_Base<Make>
    {
    }

    public class Controller_Model : Controller_Base<Model>
    {
    }
}
