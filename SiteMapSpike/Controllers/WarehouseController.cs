
using MvcSiteMapProvider.Web.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteMapSpike.Controllers
{
    public class WarehouseController : Controller
    {
        private static List<Warehouse> warehouseList =
            new List<Warehouse>()
            {
                 new Warehouse {WarehouseId = 1, Name ="ZXD5",Location= "Midrand" },
                new Warehouse {WarehouseId = 2, Name = "DFF4",Location = "Centurion" },
                new Warehouse {WarehouseId = 3, Name = "ZXC",Location = "Pretoria" }
            };
        // GET: Warehouse
        public ActionResult Index()
        {
            return View(warehouseList);
        }

        [SiteMapTitle("Name")]
        public ActionResult Detail(int warehouseId)
        {
            var warehouse = warehouseList.FirstOrDefault(x => x.WarehouseId == warehouseId);
            return View(warehouse);
        }

        public ActionResult Contact()
        {
            return View();

        }
    }

}