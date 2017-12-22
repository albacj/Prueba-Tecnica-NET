using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProcesoShneider.Controllers;
using System.Web.UI.WebControls;
using System.Web.Routing;

namespace ProcesoShneider.Controllers
{

    using Models;

    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        // View for Water
        public PartialViewResult WaterMeterView()
        {
            return PartialView("WaterMeter", WaterMeter.GetAll());
        }

        // View for Light
        public PartialViewResult LightMeterView()
        {
            return PartialView("LightMeter", LightMeter.GetAll());
        }

        // View for Gateway
        public PartialViewResult GatewayMeterView()
        {
            return PartialView("GatewayMeter", Gateway.GetAll());
        }

        public ActionResult WaterMeterDetails(int id)
        {
            WaterMeter waterMeter = WaterMeter.GetByID(id);
            if (waterMeter != null)
            {
                return View("WaterMeterDetails", waterMeter);
            }
            else
            {
                return Redirect("Index");
            }
        }

        public ActionResult LightMeterDetails(int id)
        {
            LightMeter lightMeter = LightMeter.GetByID(id);
            if (lightMeter != null)
            {
                return View("LightMeterDetails", lightMeter);
            }
            else
            {
                return Redirect("Index");
            }
        }

        public ActionResult GatewayDetails(int id)
        {
            Gateway gateway = Gateway.GetByID(id);
            if (gateway != null)
            {
                return View("GatewayDetails", gateway);
            }
            else
            {
                return Redirect("Index");
            }
        }



    }
}
