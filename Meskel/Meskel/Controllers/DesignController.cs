using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Meskel.Models;

namespace Meskel.Controllers
{
    public class DesignController : Controller
    {

        private MeskelContext db = new MeskelContext(); 



        public ViewResult Index()
        {
            var model = new DesignPageViewModel();

            using (var context = new MeskelContext())
            {
                DesignData sqlData = new DesignData(context);
                model.DesignCrosses = sqlData.GetAll();
            }
            return View(db.Design.ToList());
        }

    }

    public class DesignData
    {
        private MeskelContext _context { get; set; }
        public DesignData(MeskelContext context)
        {
            _context = context;
        }
        public void Add(Design emp)
        {
            _context.Add(emp);
            _context.SaveChanges();
        }
        public Design Get(int ID)
        {
            return _context.Design.FirstOrDefault(e => e.Id == ID);
        }
        public IEnumerable<Design> GetAll()
        {
            return _context.Design.ToList<Design>();
        }
    }

    public class DesignPageViewModel
    {
        public IEnumerable<Design> DesignCrosses { get; set; }
    }

}