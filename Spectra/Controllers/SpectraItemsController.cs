//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;
//using Spectra.Data;

//namespace Spectra.Controllers
//{
//    [ApiController]
//    [Route("/SpectraItems")]
//    public class SpectraItemsController : Controller
//    {
//        private readonly SpectraDbContext _context;

//        public SpectraItemsController(SpectraDbContext context)
//        {
//            _context = context;
//        }

//        // GET: SpectraItems
//        [HttpGet(Name = "GetSpectraItems")]
//        public async Task<IActionResult> Index()
//        {
//            return Ok(await _context.SpectraItems.ToListAsync());
//        }

//        // GET: SpectraItems/Details/5
//        [HttpGet("{id}", Name = "GetSpectraItemDetails")]
//        public async Task<IActionResult> Details(int? id)
//        {
//            var SpectraItem = await _context.SpectraItems.FindAsync(id);
//            if (SpectraItem == null)
//            {
//                return NotFound();
//            }

//            return Ok(SpectraItem);
//            //if (id == null)
//            //{
//            //    return NotFound();
//            //}

//            //var SpectraItem = await _context.SpectraItems
//            //    .FirstOrDefaultAsync(m => m.Id == id);
//            //if (SpectraItem == null)
//            //{
//            //    return NotFound();
//            //}

//            //return View(SpectraItem);
//        }

//        [HttpPost(Name = "CreateSpectraItem")]
//        public async Task<IActionResult> Create([FromBody] SpectraItem SpectraItem)
//        {
//            if (SpectraItem == null || string.IsNullOrWhiteSpace(SpectraItem.Name))
//            {
//                return BadRequest("Name is required.");
//            }

//            _context.SpectraItems.Add(SpectraItem);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction(nameof(Details), new { id = SpectraItem.Id }, SpectraItem);
//        }

//        // GET: SpectraItems/Create
//        //public IActionResult Create()
//        //{
//        //    return View();
//        //}

//        // POST: SpectraItems/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        //[HttpPost(Name = "CreateItem")]
//        //[ValidateAntiForgeryToken]
//        //public async Task<IActionResult> Create([Bind("Id,Name,Description")] SpectraItem SpectraItem)
//        //{
//        //    if (ModelState.IsValid)
//        //    {
//        //        _context.Add(SpectraItem);
//        //        await _context.SaveChangesAsync();
//        //        return RedirectToAction(nameof(Index));
//        //    }
//        //    return View(SpectraItem);
//        //}

//        //// GET: SpectraItems/Edit/5
//        //public async Task<IActionResult> Edit(int? id)
//        //{
//        //    if (id == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    var SpectraItem = await _context.SpectraItems.FindAsync(id);
//        //    if (SpectraItem == null)
//        //    {
//        //        return NotFound();
//        //    }
//        //    return View(SpectraItem);
//        //}

//        //// POST: SpectraItems/Edit/5
//        //// To protect from overposting attacks, enable the specific properties you want to bind to.
//        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        //[HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] SpectraItem SpectraItem)
//        //{
//        //    if (id != SpectraItem.Id)
//        //    {
//        //        return NotFound();
//        //    }

//        //    if (ModelState.IsValid)
//        //    {
//        //        try
//        //        {
//        //            _context.Update(SpectraItem);
//        //            await _context.SaveChangesAsync();
//        //        }
//        //        catch (DbUpdateConcurrencyException)
//        //        {
//        //            if (!SpectraItemExists(SpectraItem.Id))
//        //            {
//        //                return NotFound();
//        //            }
//        //            else
//        //            {
//        //                throw;
//        //            }
//        //        }
//        //        return RedirectToAction(nameof(Index));
//        //    }
//        //    return View(SpectraItem);
//        //}

//        //// GET: SpectraItems/Delete/5
//        //public async Task<IActionResult> Delete(int? id)
//        //{
//        //    if (id == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    var SpectraItem = await _context.SpectraItems
//        //        .FirstOrDefaultAsync(m => m.Id == id);
//        //    if (SpectraItem == null)
//        //    {
//        //        return NotFound();
//        //    }

//        //    return View(SpectraItem);
//        //}

//        //// POST: SpectraItems/Delete/5
//        //[HttpPost, ActionName("Delete")]
//        //[ValidateAntiForgeryToken]
//        //public async Task<IActionResult> DeleteConfirmed(int id)
//        //{
//        //    var SpectraItem = await _context.SpectraItems.FindAsync(id);
//        //    if (SpectraItem != null)
//        //    {
//        //        _context.SpectraItems.Remove(SpectraItem);
//        //    }

//        //    await _context.SaveChangesAsync();
//        //    return RedirectToAction(nameof(Index));
//        //}

//        private bool SpectraItemExists(int id)
//        {
//            return _context.SpectraItems.Any(e => e.Id == id);
//        }
//    }
//}
