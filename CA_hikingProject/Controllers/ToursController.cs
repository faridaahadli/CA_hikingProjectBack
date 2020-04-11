using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CA_hikingProject.DbModels;
using CA_hikingProject.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
            foreach (var item in _context.SingleTours.ToList())
            {
                var model = new TourLookViewModel();
                model.Tour = item;
                model.Tour.Requirements = _context.Requirements.Where(p => p.SingleTourId == item.Id).ToList();
                model.Images = _context.Images.Where(p => p.Id == _context.OneTourImages.First(m => m.SingleTourId == item.Id).AllImageId).ToList();
                model.Guides = _context.Users.Where(p => p.Id == _context.GuideToTourPvts.First(m => m.TourId == item.Id).GuideId).ToList();
                tours.Add(model);
            }
            return View(tours);
        }
        //Price Filter Function
        //[HttpGet]
        //public JsonResult PriceFilter(int? min, int? max)
        //{
        //    List<TourLookViewModel> tours = new List<TourLookViewModel>();



        //    foreach (var item in _context.SingleTours.Where(p => p.Price > min && p.Price < max))
        //    {
        //        var model = new TourLookViewModel();
        //        model.Tour = item;
        //        model.Tour.Requirements = new List<Requirement>() { };

        //        //if (_context.Requirements.Where(p => p.SingleTourId == item.Id).ToList() != null)
        //        //Xetali Yer
        //        foreach (var req in _context.Requirements.Where(p => p.SingleTourId == item.Id).ToList())
        //        {

        //              model.Tour.Requirements.Add(new Requirement() { 
        //              Id=req.Id,
        //              Description=req.Description,
        //              SingleTourId=item.Id
        //              }) ;       
        //        }

        //        model.Images = new List<AllImage>() { };
        //        //if (_context.Images.Where(p => p.Id == _context.OneTourImages.First(m => m.SingleTourId == item.Id).AllImageId).ToList() != null)
        //        foreach (var image in _context.Images.Where(p => p.Id == _context.OneTourImages.First(m => m.SingleTourId == item.Id).AllImageId).ToList())
        //        {
        //            model.Images.Add(image);
        //        }
        //        model.Guides = new List<ApplicationUser>() { };
        //        //if(_context.Users.Where(p => p.Id == _context.GuideToTourPvts.First(m => m.TourId == item.Id).GuideId).ToList()!=null)
        //        foreach (var guide in _context.Users.Where(p => p.Id == _context.GuideToTourPvts.First(m => m.TourId == item.Id).GuideId).ToList())
        //        {
        //            model.Guides.Add(guide);
        //        }
        //        tours.Add(model);
        //    }

        //    return Json(tours);
        //}

        [HttpGet]
        public PartialViewResult PriceFilter(int? min, int? max)
        {
            List<TourLookViewModel> tours = new List<TourLookViewModel>();
            foreach (var item in _context.SingleTours.Where(p => p.Price >= min && p.Price < max))
            {
                var model = new TourLookViewModel();
                model.Tour = item;
                model.Tour.Requirements = _context.Requirements.Where(p => p.SingleTourId == item.Id).ToList();
                model.Images = _context.Images.Where(p => p.Id == _context.OneTourImages.First(m => m.SingleTourId == item.Id).AllImageId).ToList();
                model.Guides = _context.Users.Where(p => p.Id == _context.GuideToTourPvts.First(m => m.TourId == item.Id).GuideId).ToList();
                tours.Add(model);
            }
            return PartialView("_PriceFilter",tours);
        }


    }
}
