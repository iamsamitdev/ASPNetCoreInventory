using ASPNetCoreInventory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreInventory.Controllers
{
    // [SessionCheck]
    public class BackendController : Controller
    {

        private readonly InventoryDBContext _context;

        public BackendController(InventoryDBContext context)
        {
            _context = context;
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        // GET: Products
        public async Task<IActionResult> Product()
        {
            return View("~/Views/Products/Index.cshtml", await _context.products.ToListAsync());
        }

        // GET: Products/Details/5
        [Route("Backend/Product/Details/{id?}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.products
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View("~/Views/Products/Details.cshtml", product);
        }

        // GET: Products/Create
        [Route("Backend/Product/Create")]
        public IActionResult Create()
        {
            return View("~/Views/Products/Create.cshtml");
        }

        // POST: Products/Create
        [HttpPost]
        [Route("Backend/Product/Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductID,CategoryID,ProductName,UnitPrice,ProductPicture,UnitInStock,CreatedDate,ModifiedDate")] product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction("Product","Backend");
            }
            return View(product);
        }

        // GET: Products/Edit/5
        [Route("Backend/Product/Edit/{id?}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View("~/Views/Products/Edit.cshtml", product);
        }

        // POST: Products/Edit/5
        [HttpPost]
        [Route("Backend/Product/Edit/{id?}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductID,CategoryID,ProductName,UnitPrice,ProductPicture,UnitInStock,CreatedDate,ModifiedDate")] product product)
        {
            if (id != product.ProductID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!productExists(product.ProductID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Product","Backend");
            }
            return View("~/Views/Products/Edit.cshtml", product);
        }

        // GET: Products/Delete/5
        [Route("Backend/Product/Delete/{id?}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.products
                .FirstOrDefaultAsync(m => m.ProductID == id);
            if (product == null)
            {
                return NotFound();
            }

            return View("~/Views/Products/Delete.cshtml",product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [Route("Backend/Product/Delete/{id?}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.products.FindAsync(id);
            _context.products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Product","Backend");
        }

        private bool productExists(int id)
        {
            return _context.products.Any(e => e.ProductID == id);
        }

        public ActionResult Logout()
        {
            // Remove Session
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Frontend");
        }

    }
}
