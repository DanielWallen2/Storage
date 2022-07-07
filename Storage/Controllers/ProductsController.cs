using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Storage.Data;
using Storage.Models;

namespace Storage.Controllers
{
    public class ProductsController : Controller
    {
        private readonly StorageContext _context;

        public ProductsController(StorageContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            return View(await _context.Product.ToListAsync());
        }

        // GET: Products
        public async Task<IActionResult> Index2()
        {
            var viewModel = await _context.Product.Select(e => new ProductViewModel
            {
                Id  = e.Id,
                Name = e.Name,
                Price = e.Price,
                Count = e.Count,
                InventoryValue = e.Price * e.Count

            }).ToListAsync();

            //var m = new TestViewModel
            //{
            //    Products = viewModel,
            //    TotalValue = viewModel.Select(v => v.InventoryValue).Sum()
            //};
            ViewData["TotalValue"] = viewModel.Select(v => v.InventoryValue).Sum();
            
            return View(viewModel);
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            if(product == null) return NotFound();

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,Orderdate,Category,Shelf,Count,Description")] Product product)
        {
            if(ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null) return NotFound();

            var product = await _context.Product.FindAsync(id);
            if(product == null) return NotFound();

            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,Orderdate,Category,Shelf,Count,Description")] Product product)
        {
            if(id != product.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null) return NotFound();

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Id == id);
        }

        public async Task<IActionResult> Filter(string name, int? category)
        {
            var model = string.IsNullOrWhiteSpace(name) ?
                                    _context.Product :
                                    _context.Product.Where(m => m.Name!.StartsWith(name));

            model = category == null ?
                             model :
                             model.Where(m => (int)m.Category == category);

            return View(nameof(Index), await model.ToListAsync());

        }

        public async Task<IActionResult> Filter2(string name, int? category)
        {
            var model = string.IsNullOrWhiteSpace(name) ?
                                    _context.Product :
                                    _context.Product.Where(m => m.Name!.StartsWith(name));

            model = category == null ?
                             model :
                             model.Where(m => (int)m.Category == category);

            // Måste omvandla från Product till ProductViewModel
            var viewModel = model.Select(e => new ProductViewModel
            {
                Id = e.Id,
                Name = e.Name,
                Price = e.Price,
                Count = e.Count,
                InventoryValue = e.Price * e.Count

            }).ToListAsync();

            return View(nameof(Index2), await viewModel);

        }

        //public async Task<IActionResult> FilterByCategory(string sCategory)
        //{
        //    var viewModel = await _context.Product.Where(p => p.Category == sCategory).Select(e => new Product
        //    {
        //        Id = e.Id,
        //        Name = e.Name,
        //        Category = e.Category,
        //        Price = e.Price,
        //        Count = e.Count,
        //        Orderdate = e.Orderdate,
        //        Shelf = e.Shelf,
        //        Description = e.Description

        //    }).ToListAsync();

        //    return View(nameof(Index), viewModel);
        //}

        //public async Task<IActionResult> FilterByCategory2(string sCategory)
        //{
        //    var viewModel = await _context.Product.Where(p => p.Category == sCategory).Select(e => new ProductViewModel
        //    {
        //        Id = e.Id,
        //        Name = e.Name,
        //        Category = e.Category,
        //        Price = e.Price,
        //        Count = e.Count,
        //        InventoryValue = e.Price * e.Count

        //    }).ToListAsync();

        //    return View(nameof(Index2), viewModel );
        //}

    }
}
