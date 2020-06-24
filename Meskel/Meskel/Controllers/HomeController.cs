using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Meskel.Models;
using System.Net.Mail;

namespace Meskel.Controllers
{
    public class HomeController : Controller
    {
        private MeskelContext db = new MeskelContext();
 
        public ViewResult Index()
        {
            var model = new HomePageViewModel();

            using (var context = new MeskelContext())
            {
                ProductData sqlData = new ProductData(context);
                model.Products = sqlData.GetAll();
            }
            return View(db.Product.ToList());
        }
        public IActionResult Details(int id)
        {
            var model = new HomePageViewModel();

            var context = new MeskelContext();
            
            ProductData sqlData = new ProductData(context);
            var found = context.Product.Where(p => p.Id == id).FirstOrDefault();
            
            return View(found);
        }
        public IActionResult Cart(int id)
        {
            var model = new HomePageViewModel();

            var context = new MeskelContext();

            ProductData sqlData = new ProductData(context);
            var found = context.Product.Where(p => p.Id == id).FirstOrDefault();

            return View(found);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                var mail = new MailMessage();
                mail.To.Add(new MailAddress(model.SenderEmail));
                mail.Subject = "Your Email Subject";
                mail.Body = string.Format("<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>", model.SenderName, model.SenderEmail, model.Message);
                mail.IsBodyHtml = true;
                using (var smtp = new SmtpClient())
                {
  //                  await smtp.SendMailAsync(mail);
                    return RedirectToAction("SuccessMessage");
                }
            }
            return View(model);
        }

        public ActionResult SuccessMessage()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
    public class ProductData
    {
        private MeskelContext _context { get; set; }
        public ProductData(MeskelContext context)
        {
            _context = context;
        }
        public void Add(Product emp)
        {
            _context.Add(emp);
            _context.SaveChanges();
        }
        public Product Get(int ID)
        {
            return _context.Product.FirstOrDefault(e => e.Id == ID);
        }
        public IEnumerable<Product> GetAll()
        {
            return _context.Product.ToList<Product>();
        }
    }

    public class HomePageViewModel
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
