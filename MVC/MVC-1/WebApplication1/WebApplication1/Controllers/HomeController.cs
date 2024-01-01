using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BussinessLayer;
using DatabaseLayer.DBOperation;
namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        ManageRegistration ManageReg = new ManageRegistration();    

        [HttpPost]
        public void AddReg(FormCollection form)
        {
            registrationModel registrationModel = new registrationModel()
            {
                Id = Convert.ToInt32(form["txtname"]),
                Name = form["txtName"],
                Smester = form["textSmester"]
            };
            ManageReg.AddReg(registrationModel);
            Response.Write("Sucessful");



        }
    }
}