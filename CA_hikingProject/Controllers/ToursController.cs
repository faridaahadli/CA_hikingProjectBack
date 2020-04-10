using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA_hikingProject.DbModels;
using CA_hikingProject.Models;
using Microsoft.AspNetCore.Mvc;


namespace CA_hikingProject.Controllers
{
    public class ToursController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ToursController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<TourLookViewModel> tours = new List<TourLookViewModel>();
            foreach(var item in _context.SingleTours.ToList())
            {
                var model = new TourLookViewModel();
                model.Tour = item;
                model.Tour.Requirements = _context.Requirements.Where(p => p.SingleTourId == item.Id).ToList();
                model.Images = _context.Images.Where(p => p.Id == _context.OneTourImages.First(m => m.SingleTourId == item.Id).AllImageId).ToList();
                model.Guides=_context.Users.Where(p=>p.Id==_context.GuideToTourPvts.First(m => m.TourId == item.Id).GuideId).ToList();
                tours.Add(model);
            }
            return View(tours);
        }
         //Price Filter Function
         [HttpPost]
        public IActionResult PriceFilter(string prcMin, string prcMax)
        {
            List<TourLookViewModel> tours = new List<TourLookViewModel>();
            //foreach (var item in _context.SingleTours.Where(p=>p.Price>Int32.Parse(prcFilter[0]) || p.Price< Int32.Parse(prcFilter[1])))
            //{
            //    var model = new TourLookViewModel();
            //    model.Tour = item;
            //    model.Tour.Requirements = _context.Requirements.Where(p => p.SingleTourId == item.Id).ToList();
            //    model.Images = _context.Images.Where(p => p.Id == _context.OneTourImages.First(m => m.SingleTourId == item.Id).AllImageId).ToList();
            //    model.Guides = _context.Users.Where(p => p.Id == _context.GuideToTourPvts.First(m => m.TourId == item.Id).GuideId).ToList();
            //    tours.Add(model);
            //}
            return View("Index",tours);
        }
    }
}