using Microsoft.AspNetCore.Mvc.Filters;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;



namespace MyProject.ActionFilter
{
    public class AddViewFilter : IActionFilter
    {
        private readonly IProductService _productService;

        public AddViewFilter(IProductService productService)
        {
            _productService = productService;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            int id = Convert.ToInt32(context.ActionArguments["id"]);
            var product = _productService.GetProductById(id);
            product.Views++;
            _productService.UpDateProduct(product);

        }
    }
}
