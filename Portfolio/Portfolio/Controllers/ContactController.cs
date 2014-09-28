using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/
        Models.PortfolioEntities db = new Models.PortfolioEntities();
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Models.ContactForm());
        }

        [HttpPost]
        public ActionResult Index(Models.ContactForm contactForm)
        {
            db.ContactForms.Add(contactForm);
            db.SaveChanges();
            return RedirectToAction("ThankYou", "Contact");
        }

        public ActionResult ThankYou()
        {
            return View();
        }
    }
}
