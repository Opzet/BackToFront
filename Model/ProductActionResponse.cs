using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProductActionResponse : ActionResponse
    {
        public Product ProductDetail { get; }

        public ProductActionResponse(bool success, Product productDetail, string errorMessage = null) : base(success, errorMessage)
        {
            ProductDetail = productDetail;
        }
    }
}
