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
        public async Task<IActionResult> Create([Bind("Id,Title,StartDate,EndDate,Location,Price,MaxPersonLimit,IsActive,MeetAddress,SalePercent,LocationStory,Warning,TourTypeId")] SingleTour singleTour,
            List<string> guides,string requirement,List<IFormFile> sources)
        {
            string[] stringSeparators = new string[] { "\r\n" };
          
            if (ModelState.IsValid)
            {
              if(requirement==null || guides.Count==0)
                    return View("Create2");
                //var boo = sources.Any(p => !ImgUpload.CheckImageSize(p, 10) || !ImgUpload.CheckImageType(p));
                foreach (var item in sources)
                {
                    if (!ImgUpload.CheckImageSize(item, 10) || !ImgUpload.CheckImageType(item))
                        return View("Create2");
                }
                _context.Add(singleTour);
                await _context.SaveChangesAsync();
                //Images of Place
                foreach (var item in sources)
                {
                    var res = await ImgUpload.SaveImage(Path.Combine(hostingEnvironment.WebRootPath,"img","tours"), item);
                    var img = new AllImage();
                    img.Source = res;
                    _context.Images.Add(img);
                    await _context.SaveChangesAsync();
                    var tourImg = new OneTourImage();
                    tourImg.AllImageId = img.Id;
                    tourImg.SingleTourId = singleTour.Id;
                    tourImg.IsIntro = true;
                    _context.OneTourImages.Add(tourImg);
                }
                //Requirements
                var allreq = requirement.Split(stringSeparators, StringSplitOptions.None);
                for (int i = 0; i < allreq.Length; i++)
                {
                    if (allreq[i] == "")
                        continue;
                    var req = new Requirement();
                    req.Description = allreq[i];
                    req.SingleTourId = singleTour.Id;
                    _context.Requirements.Add(req);
                }
                //Guides for Tour
                foreach (var guide in guides)
                {
                    var TourGuides = new GuideToTourPvt();
                    TourGuides.TourId = singleTour.Id;
                    TourGuides.GuideId = guide;
                    _context.GuideToTourPvts.Add(TourGuides);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TourTypeId"] = new SelectList(_context.TourTypes, "Id", "Name", singleTour.TourTypeId);
            ViewData["Guides"] = await userManager.GetUsersInRoleAsync("beledci");
            return View();
        }

        // GET: SingleTours/Edit/5
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
            singleTour.Requirements = _context.Requirements.Where(p => p.SingleTourId == singleTour.Id).ToList();
            singleTour.TourImages= _context.OneTourImages.Where(p => p.SingleTourId == singleTour.Id).ToList();
            var tour = new TourViewModel();
            tour.Tour = singleTour;
            tour.Photos = _context.Images.ToList();
      
            ViewData["TourTypeId"] = new SelectList(_context.TourTypes, "Id", "Name", singleTour.TourTypeId);
            return View(tour);
        }

        // POST: SingleTours/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,  TourViewModel model)
        {
            if (id != model.Tour.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model.Tour);
                    model.Tour.Requirements= _context.Requirements.Where(p => p.SingleTourId == model.Tour.Id).ToList();
                    
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
                return RedirectToAction(nameof(Index));
            }
            ViewData["TourTypeId"] = new SelectList(_context.TourTypes, "Id", "Name", model.Tour.TourTypeId);
            return View(model.Tour);
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
            _context.SingleTours.Remove(singleTour);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SingleTourExists(int id)
        {
            return _context.SingleTours.Any(e => e.Id == id);
        }
    }
}
