using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Spectra.Data;

namespace Spectra.Controllers
{
    [ApiController]
    [Route("/SpectreItems")]
    public class SpectreItemsController : Controller
    {
        private readonly SpectreDbContext _context;

        public SpectreItemsController(SpectreDbContext context)
        {
            _context = context;
        }

        // GET: SpectreItems
        [HttpGet(Name = "GetSpectreItems")]
        public async Task<IActionResult> Index()
        {
            return Ok(await _context.SpectreItems.ToListAsync());
        }

        // GET: SpectreItems/Details/5
        [HttpGet("{id}", Name = "GetSpectreItemDetails")]
        public async Task<IActionResult> Details(int? id)
        {
            var spectreItem = await _context.SpectreItems.FindAsync(id);
            if (spectreItem == null)
            {
                return NotFound();
            }

            return Ok(spectreItem);
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var spectreItem = await _context.SpectreItems
            //    .FirstOrDefaultAsync(m => m.Id == id);
            //if (spectreItem == null)
            //{
            //    return NotFound();
            //}

            //return View(spectreItem);
        }

        [HttpPost(Name = "CreateSpectreItem")]
        public async Task<IActionResult> Create([FromBody] SpectreItem spectreItem)
        {
            if (spectreItem == null || string.IsNullOrWhiteSpace(spectreItem.Name))
            {
                return BadRequest("Name is required.");
            }

            _context.SpectreItems.Add(spectreItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Details), new { id = spectreItem.Id }, spectreItem);
        }

        // GET: SpectreItems/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        // POST: SpectreItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost(Name = "CreateItem")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Name,Description")] SpectreItem spectreItem)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(spectreItem);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(spectreItem);
        //}

        //// GET: SpectreItems/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var spectreItem = await _context.SpectreItems.FindAsync(id);
        //    if (spectreItem == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(spectreItem);
        //}

        //// POST: SpectreItems/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] SpectreItem spectreItem)
        //{
        //    if (id != spectreItem.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(spectreItem);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!SpectreItemExists(spectreItem.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(spectreItem);
        //}

        //// GET: SpectreItems/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var spectreItem = await _context.SpectreItems
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (spectreItem == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(spectreItem);
        //}

        //// POST: SpectreItems/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var spectreItem = await _context.SpectreItems.FindAsync(id);
        //    if (spectreItem != null)
        //    {
        //        _context.SpectreItems.Remove(spectreItem);
        //    }

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool SpectreItemExists(int id)
        {
            return _context.SpectreItems.Any(e => e.Id == id);
        }
    }
}
