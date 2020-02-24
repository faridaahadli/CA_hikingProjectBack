using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CA_hikingProject.DbModels;

namespace CA_hikingProject.Areas.Admin.Controllers
{
    public class OneTourImagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OneTourImagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OneTourImages
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.OneTourImages.Include(o => o.SingleTour).Include(o => o.myImage);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: OneTourImages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oneTourImage = await _context.OneTourImages
                .Include(o => o.SingleTour)
                .Include(o => o.myImage)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (oneTourImage == null)
            {
                return NotFound();
            }

            return View(oneTourImage);
        }

        // GET: OneTourImages/Create
        public IActionResult Create()
        {
            ViewData["SingleTourId"] = new SelectList(_context.SingleTours, "Id", "Location");
            ViewData["AllImageId"] = new SelectList(_context.Images, "Id", "Source");
            return View();
        }

        // POST: OneTourImages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SingleTourId,AllImageId,IsIntro,IsDeleted")] OneTourImage oneTourImage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(oneTourImage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SingleTourId"] = new SelectList(_context.SingleTours, "Id", "Location", oneTourImage.SingleTourId);
            ViewData["AllImageId"] = new SelectList(_context.Images, "Id", "Source", oneTourImage.AllImageId);
            return View(oneTourImage);
        }

        // GET: OneTourImages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oneTourImage = await _context.OneTourImages.FindAsync(id);
            if (oneTourImage == null)
            {
                return NotFound();
            }
            ViewData["SingleTourId"] = new SelectList(_context.SingleTours, "Id", "Location", oneTourImage.SingleTourId);
            ViewData["AllImageId"] = new SelectList(_context.Images, "Id", "Source", oneTourImage.AllImageId);
            return View(oneTourImage);
        }

        // POST: OneTourImages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SingleTourId,AllImageId,IsIntro,IsDeleted")] OneTourImage oneTourImage)
        {
            if (id != oneTourImage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(oneTourImage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OneTourImageExists(oneTourImage.Id))
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
            ViewData["SingleTourId"] = new SelectList(_context.SingleTours, "Id", "Location", oneTourImage.SingleTourId);
            ViewData["AllImageId"] = new SelectList(_context.Images, "Id", "Source", oneTourImage.AllImageId);
            return View(oneTourImage);
        }

        // GET: OneTourImages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oneTourImage = await _context.OneTourImages
                .Include(o => o.SingleTour)
                .Include(o => o.myImage)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (oneTourImage == null)
            {
                return NotFound();
            }

            return View(oneTourImage);
        }

        // POST: OneTourImages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var oneTourImage = await _context.OneTourImages.FindAsync(id);
            _context.OneTourImages.Remove(oneTourImage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OneTourImageExists(int id)
        {
            return _context.OneTourImages.Any(e => e.Id == id);
        }
    }
}
