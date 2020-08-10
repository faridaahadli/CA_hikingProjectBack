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
        #region
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

        #endregion

        //Filters Function
        [HttpPost]
        public PartialViewResult Filters(int? min, int? max,DateTime? begin,DateTime? end,string? searchKey)
        {
            IQueryable<SingleTour> searchRes;


            if (searchKey == null || searchKey == String.Empty || searchKey.Count() == 0)
            {
                searchRes = _context.SingleTours;

            }
            else
            {
                searchRes = _context.SingleTours.Where(p => p.Title.Contains(searchKey));
            }
            List<TourLookViewModel> tours = new List<TourLookViewModel>();
            foreach (var item in searchRes.Where(p => p.Price >= min && p.Price < max 
            && (p.StartDate>=begin && p.StartDate<=end)))
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

        [HttpPost]
        public PartialViewResult Search(string? searchKey)
        {
            IQueryable<SingleTour> searchRes;


            if (searchKey == null || searchKey == String.Empty || searchKey.Count() == 0)
            {
                searchRes = _context.SingleTours;
               
            }
            else
            {
                searchRes = _context.SingleTours.Where(p => p.Title.Contains(searchKey));
            }
          
            List<TourLookViewModel> tours = new List<TourLookViewModel>();

            foreach (var item in searchRes)
            {
                var model = new TourLookViewModel();
                model.Tour = item;
                model.Tour.Requirements = _context.Requirements.Where(p => p.SingleTourId == item.Id).ToList();
                model.Images = _context.Images.Where(p => p.Id == _context.OneTourImages.First(m => m.SingleTourId == item.Id).AllImageId).ToList();
                model.Guides = _context.Users.Where(p => p.Id == _context.GuideToTourPvts.First(m => m.TourId == item.Id).GuideId).ToList();
                tours.Add(model);
            }
            return PartialView("_PriceFilter", tours);
        }

        [HttpGet]
        public IActionResult GetTour(int id)
        {
            var item = _context.SingleTours.FirstOrDefault(p => p.Id == id);
            var model = new TourLookViewModel();
            model.Tour = item;
            model.Tour.Requirements = _context.Requirements.Where(p => p.SingleTourId == item.Id).ToList();
            model.Images = _context.Images.Where(p => p.Id == _context.OneTourImages.First(m => m.SingleTourId == item.Id).AllImageId).ToList();
            model.Guides = _context.Users.Where(p => p.Id == _context.GuideToTourPvts.First(m => m.TourId == item.Id).GuideId).ToList();

            return View("SingleTour",model);
        }

        [HttpPost]
        public IActionResult PostTour(int id,string comment)
        {
            var item = _context.SingleTours.FirstOrDefault(p => p.Id == id);
            var model = new TourLookViewModel();
            model.Tour = item;
            model.Tour.Requirements = _context.Requirements.Where(p => p.SingleTourId == item.Id).ToList();
            model.Images = _context.Images.Where(p => p.Id == _context.OneTourImages.First(m => m.SingleTourId == item.Id).AllImageId).ToList();
            model.Guides = _context.Users.Where(p => p.Id == _context.GuideToTourPvts.First(m => m.TourId == item.Id).GuideId).ToList();

            return View("SingleTour", model);
        }
    }
}
