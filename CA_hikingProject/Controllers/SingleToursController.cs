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

namespace CA_hikingProject.Controllers
{
    public class SingleToursController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public SingleToursController(ApplicationDbContext context, UserManager<ApplicationUser> _userManager,
             RoleManager<IdentityRole> _roleManager)
        {
            roleManager = _roleManager;
            userManager = _userManager;
            _context = context;
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
            return View("Create2");
        }

        // POST: SingleTours/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,StartDate,EndDate,Location,Price,MaxPersonLimit,IsActive,MeetAddress,SalePercent,LocationStory,Warning,TourTypeId")] SingleTour singleTour,List<string> guides)
        {
          
            if (ModelState.IsValid)
            {
              
                _context.Add(singleTour);
                await _context.SaveChangesAsync();

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
            


            return View("Create2");
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
            ViewData["TourTypeId"] = new SelectList(_context.TourTypes, "Id", "Name", singleTour.TourTypeId);
            return View(singleTour);
        }

        // POST: SingleTours/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,StartDate,EndDate,Location,Price,MaxPersonLimit,IsActive,MeetAddress,SalePercent,LocationStory,Warning,TourTypeId")] SingleTour singleTour)
        {
            if (id != singleTour.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(singleTour);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SingleTourExists(singleTour.Id))
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
            ViewData["TourTypeId"] = new SelectList(_context.TourTypes, "Id", "Name", singleTour.TourTypeId);
            return View(singleTour);
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
