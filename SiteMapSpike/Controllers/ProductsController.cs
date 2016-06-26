using MvcSiteMapProvider.Web.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteMapSpike.Controllers
{
    public class ProductsController : Controller
    {
        private static List<Product> productsList =
            new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    ProductDescripion = "Product A",
                    Description = "Product A",
                    Price = 10
                },
                  new Product
                {
                    ProductId = 2,
                    ProductDescripion = "Product B",
                    Description = "Product B",
                    Price = 10
                },
                    new Product
                {
                        ProductId = 3,
                    ProductDescripion = "Product C",
                    Description = "Product C",
                    Price = 10
                },
                      new Product
                {
                          ProductId = 4,
                    ProductDescripion = "Product D",
                    Description = "Product D",
                    Price = 10
                },
                        new Product
                {
                            ProductId = 5,
                    ProductDescripion = "Product E",
                    Description = "Product E",
                    Price = 10
                }
            };


        [SiteMapTitle("Name")]
        public ActionResult Index(int warehouseId)
        {
            productsList.ForEach(p => { p.WarehouseId = warehouseId; p.Name = "Warehouse Name..."; });
            
            return View(productsList);
        }

        [SiteMapTitle("ProductDescripion")]
        public ActionResult Detail(int warehouseId, int productId)
        {
            var product = productsList.FirstOrDefault(p => p.ProductId == productId);
            return View(product);
        }
    }
}