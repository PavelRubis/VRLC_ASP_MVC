using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteASP.Models;

namespace WebSiteASP.Controllers
{
    public class HomeController : Controller
    {
        VRLCContext db = new VRLCContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Team()
        {
            return View();
        }

        public ActionResult Contacts()
        {
            return View();
        }

        [HttpGet]
        public new ActionResult Request()
        {
            return View();
        }

        [HttpPost]
        public new ViewResult Request(Request request)
        {
            if (request.SendRequest())
            {
                ViewBag.Msg = "Ваша заявка успешно отправлена";
                ViewBag.Src = "../images/success.png";
            }
            else
            {
                ViewBag.Msg = "Ошибка отправки заявки";
                ViewBag.Src = "../images/error.png";
            }

            ViewBag.Title = "Отправка заявки";
            return View("~/Views/Home/RequestStatus.cshtml");
        }

        public ActionResult Person(int id)
        {
            IEnumerable<Person> Persons = db.Persons;

            return View(Persons.Where(prsn => prsn.Id == id).Last());
        }

        public ActionResult Service(int id)
        {
            IEnumerable<Service> Service = db.Services;

            return View(Service.Where(srvc => srvc.Id == id).Last());
        }

        [HttpGet]
        public ActionResult PropertySearch()
        {
            return View();
        }

    }
}