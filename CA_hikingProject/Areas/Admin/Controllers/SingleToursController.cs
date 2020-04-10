using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CA_hikingProject.DbModels;
using Microsoft.AspNetCore.Identity;
using CA_hikingProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using CA_hikingProject.Areas.Admin.Models;

namespace CA_hikingProject.Areas.Admin.Controllers
{
    [Area("Admin")]
   [Authorize(Roles ="admin")]
    public class SingleToursController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IHostingEnvironment hostingEnvironment;
        public SingleToursController(ApplicationDbContext context, UserManager<ApplicationUser> _userManager,
             RoleManager<IdentityRole> _roleManager,IHostingEnvironment _hostingEnvironment)
        {
            roleManager = _roleManager;
            userManager = _userManager;
            _context = context;
            hostingEnvironment = _hostingEnvironment;
        }

        // GET: SingleTours
        public async Task<IActionResult> Index()
        {
            
            var applicationDbContext = _context.SingleTours.Include(s => s.TourType);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SingleTours/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var singleTour = await _context.SingleTours
                .Include(s => s.TourType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (singleTour == null)
            {
                return NotFound();
            }

            return View(singleTour);
        }

        // GET: SingleTours/Create
        public async Task<IActionResult> Create()
        {
            
            ViewData["TourTypeId"] = new SelectList(_context.TourTypes, "Id", "Name");

            ViewData["Guides"] = await userManager.GetUsersInRoleAsync("beledci");
            return View();
        }

        // POST: SingleTours/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( SingleTourViewModel model, List<IFormFile> sources)
        {
            ViewData["Guides"] = await userManager.GetUsersInRoleAsync("beledci");
            

            if (ModelState.IsValid)
            {
                if (model.Requirement == null || model.Guides.Count == 0)

                    return View();
              
                if(model.singleTour.StartDate>=model.singleTour.EndDate)
                {
                    ModelState.AddModelError("timeCheck", "Seyahetin Bitme tarixi baslangis tarixinden once ola bilmez");
                    return View();
                }
                _context.Add(model.singleTour);
                await _context.SaveChangesAsync();
                //Images of Place
                foreach (var item in sources)
                {
                    var res = await ImgUpload.SaveImage(Path.Combine(hostingEnvironment.WebRootPath, "img", "tours"), item);
                    var img = new AllImage();
                    img.Source = res;
                    _context.Images.Add(img);
                    await _context.SaveChangesAsync();
                    var tourImg = new OneTourImage();
                    tourImg.AllImageId = img.Id;
                    tourImg.SingleTourId = model.singleTour.Id;
                    tourImg.IsIntro = true;
                    _context.OneTourImages.Add(tourImg);
                }
                //Requirements
                ReqSeperator(model.singleTour, model.Requirement);
                //Guides for Tour
                foreach (var guide in model.Guides)
                {
                    var TourGuides = new GuideToTourPvt();
                    TourGuides.TourId = model.singleTour.Id;
                    TourGuides.GuideId = guide;
                    _context.GuideToTourPvts.Add(TourGuides);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TourTypeId"] = new SelectList(_context.TourTypes, "Id", "Name", model.singleTour.TourTypeId);

            return View();
        }
        #region
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Title,StartDate,EndDate,Location,Price,MaxPersonLimit,IsActive,MeetAddress,SalePercent,LocationStory,Warning,TourTypeId")] SingleTour singleTour,
        //    List<string> guides, string requirement, List<IFormFile> sources)
        //{
        //    ViewData["Guides"] = await userManager.GetUsersInRoleAsync("beledci");
        //    string[] stringSeparators = new string[] { "\r\n" };

        //    if (ModelState.IsValid)
        //    {
        //        if (requirement == null || guides.Count == 0)

        //            return View();
        //        //var boo = sources.Any(p => !ImgUpload.CheckImageSize(p, 10) || !ImgUpload.CheckImageType(p));
        //        foreach (var item in sources)
        //        {
        //            if (!ImgUpload.CheckImageSize(item, 10) || !ImgUpload.CheckImageType(item))
        //                return View();
        //        }
        //        _context.Add(singleTour);
        //        await _context.SaveChangesAsync();
        //        //Images of Place
        //        foreach (var item in sources)
        //        {
        //            var res = await ImgUpload.SaveImage(Path.Combine(hostingEnvironment.WebRootPath, "img", "tours"), item);
        //            var img = new AllImage();
        //            img.Source = res;
        //            _context.Images.Add(img);
        //            await _context.SaveChangesAsync();
        //            var tourImg = new OneTourImage();
        //            tourImg.AllImageId = img.Id;
        //            tourImg.SingleTourId = singleTour.Id;
        //            tourImg.IsIntro = true;
        //            _context.OneTourImages.Add(tourImg);
        //        }
        //        //Requirements
        //        var allreq = requirement.Split(stringSeparators, StringSplitOptions.None);
        //        for (int i = 0; i < allreq.Length; i++)
        //        {
        //            if (allreq[i] == "")
        //                continue;
        //            var req = new Requirement();
        //            req.Description = allreq[i];
        //            req.SingleTourId = singleTour.Id;
        //            _context.Requirements.Add(req);
        //        }
        //        //Guides for Tour
        //        foreach (var guide in guides)
        //        {
        //            var TourGuides = new GuideToTourPvt();
        //            TourGuides.TourId = singleTour.Id;
        //            TourGuides.GuideId = guide;
        //            _context.GuideToTourPvts.Add(TourGuides);
        //        }
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["TourTypeId"] = new SelectList(_context.TourTypes, "Id", "Name", singleTour.TourTypeId);

        //    return View();
        //}
        #endregion
        // GET: SingleTours/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var singleTour = await _context.SingleTours.FindAsync(id);
            if (singleTour == null)
            {
                return NotFound();
            }
            //singleTour.Requirements = _context.Requirements.Where(p => p.SingleTourId == singleTour.Id).ToList();
            singleTour.TourImages = _context.OneTourImages.Where(p => p.SingleTourId == singleTour.Id).ToList();
               
            var tour = new TourViewModel();
            tour.Tour = singleTour;
            tour.Photos = new List<EditImgViewModel>();
            foreach(var item in tour.Tour.TourImages)
            {
                EditImgViewModel image = new EditImgViewModel();
                image.Id = item.AllImageId;
                image.Source = _context.Images.First(p => p.Id == item.AllImageId).Source;
                tour.Photos.Add(image);
            }

            tour.Requirements = new List<EditReqViewModel>();
            foreach (var item in _context.Requirements.Where(p => p.SingleTourId == singleTour.Id).ToList())
            {
                EditReqViewModel requirement = new EditReqViewModel();
                requirement.Id = item.Id;
                requirement.Description = item.Description;
              
                tour.Requirements.Add(requirement);
            }


            ViewData["TourTypeId"] = new SelectList(_context.TourTypes, "Id", "Name", singleTour.TourTypeId);
            return View(tour);
        }

        // POST: SingleTours/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TourViewModel model,string requirement,IFormFile[] sources)
        {
            if (id != model.Tour.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
             
                return View(model.Tour);
            }

            
            model.Tour.Requirements = _context.Requirements.Where(p => p.SingleTourId == model.Tour.Id).ToList();
            if(sources.Length!=0)
                for (int i = 0; i < sources.Length; i++)
            {
                var res = await ImgUpload.SaveImage(Path.Combine(hostingEnvironment.WebRootPath, "img", "tours"), sources[i]);
                var img = new AllImage();
                img.Source = res;
                _context.Images.Add(img);
                await _context.SaveChangesAsync();
                var tourImg = new OneTourImage();
                tourImg.AllImageId = img.Id;
                tourImg.SingleTourId = model.Tour.Id;
                tourImg.IsIntro = true;
                _context.OneTourImages.Add(tourImg);
            }

            if (model.Photos!=null)
            {
                foreach (var item in model.Photos)
                {
                    if (!item.Selected)
                        continue;
                    var delImg = ImgUpload.DeleteImage(Path.Combine(hostingEnvironment.WebRootPath, "img", "tours"), item.Source);
                    if (delImg)
                    {
                        _context.OneTourImages.Remove(_context.OneTourImages.FirstOrDefault(p => p.AllImageId == item.Id));
                        _context.Images.Remove(_context.Images.FirstOrDefault(p => p.Id == item.Id));
                    }
                }
            }
           
            try
            {
                _context.Update(model.Tour);
                foreach (var item in model.Requirements)
                {
                    if (!item.Selected)
                    {
                        continue;
                    }
                    _context.Requirements.Remove(_context.Requirements.First(p => p.Id == item.Id));
                }


                if(requirement!=null)
                   ReqSeperator(model.Tour, requirement);
                await _context.SaveChangesAsync();
                 
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleTourExists(model.Tour.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            ViewData["TourTypeId"] = new SelectList(_context.TourTypes, "Id", "Name", model.Tour.TourTypeId);
            return RedirectToAction(nameof(Index));
        }

        // GET: SingleTours/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var singleTour = await _context.SingleTours
                .Include(s => s.TourType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (singleTour == null)
            {
                return NotFound();
            }

            return View(singleTour);
        }

        // POST: SingleTours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var singleTour = await _context.SingleTours.FindAsync(id);

            List<int> imgIdList = new List<int>();
            var imgoftours = _context.OneTourImages.Where(p => p.SingleTourId == id);
            foreach(var item in imgoftours)
            {
                if (!imgIdList.Exists(p => p == item.AllImageId))
                    imgIdList.Add(item.AllImageId);
                
                  _context.OneTourImages.Remove(item);
            }
            foreach (var imgId in imgIdList)
            {
                var delImg = ImgUpload.DeleteImage(Path.Combine(hostingEnvironment.WebRootPath, "img", "tours"), _context.Images.Find(imgId).Source);

                if (delImg)
                    _context.Images.Remove(_context.Images.Find(imgId));
            }

            var guideoftours = _context.GuideToTourPvts.Where(p => p.TourId == id);

            foreach (var item in guideoftours)
            {
                _context.GuideToTourPvts.Remove(item);
            }

            var reqsoftours = _context.Requirements.Where(p => p.SingleTourId == id);
            foreach (var item in reqsoftours)
            {
                _context.Requirements.Remove(item);
            }
            _context.SingleTours.Remove(singleTour);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SingleTourExists(int id)
        {
            return _context.SingleTours.Any(e => e.Id == id);
        }


        //Custom functions
        public void ReqSeperator(SingleTour model,string requirement)
        {
            string[] stringSeparators = new string[] { "\r\n" };
            var allreq =requirement.Split(stringSeparators, StringSplitOptions.None);
            for (int i = 0; i < allreq.Length; i++)
            {
                if (allreq[i] == "")
                    continue;
                var req = new Requirement();
                req.Description = allreq[i];
                req.SingleTourId = model.Id;
                _context.Requirements.Add(req);
            }
        }

        
    }
}
