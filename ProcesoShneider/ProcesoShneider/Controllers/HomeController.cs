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
    public class HomeController : Controller
    {

        private Models.DevicesDBEntities _db = new Models.DevicesDBEntities();

        // View for Water and Light Meter
        public PartialViewResult WaterMeter()
        {
            return PartialView("WaterMeter", new WaterMeter() );
        }

        public PartialViewResult LightMeter()
        {
            return PartialView("LightMeter", new LightMeter());
        }

        public PartialViewResult GatewayMeter()
        {
            return PartialView("GatewayMeter", new Gateway());
        }

        

        // GET: Home
        // This is a default method
        // When this app runs, this is the first method
        public ActionResult Index()
        {

            return View();
            //return View(_db.WaterAndLightMeter.ToList()); // return WaterAndLightMeter table
            //return MultiView(View(_db.WaterAndLightMeter.ToList()), View(_db.Gateway.ToList()));

            //var viewWL = View(_db.WaterAndLightMeter.ToList());
            //var viewG = View(_db.Gateway.ToList());

            //return viewWL, viewG;

        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();

            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Index");
            //}
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "Id")] Device deviceToCreate)
        {
            return View();
        
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            //else
            //{
            //    return RedirectToAction("Index");
            //}
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();

            //var deviceToEdit = (from d in _db.WaterAndLightMeter
            //
            //                   where d.Id == id
            //
            //                   select d).First();

            //return View(deviceToEdit);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(Device deviceToEdit)
        {

            //var originalDevice = (from d in _db.WaterAndLightMeter
            //
            //                     where d.Id == deviceToEdit.id
            //
            //                     select d).First();

            //if (!ModelState.IsValid)
            //
            //    return View(originalDevice);

            //_db.ApplyPropertyChanges(originalDevice.EntityKey.EntitySetName, deviceToEdit);

            //_db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
