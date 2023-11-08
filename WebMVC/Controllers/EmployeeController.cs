using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebMVC.Data;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class EmployeeController: Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _context.Employee.ToListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonID,FullName, Address, Phone, EmployeeID, Age")] Employee Emp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Emp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Emp);
        }
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Employee == null)
            {
                return NotFound();
            }

            var Emp = await _context.Employee.FindAsync(id);
            if (Emp == null)
            {
                return NotFound();
            }
            return View(Emp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonID,FullName, Address, Phone, EmployeeID, Age")] Employee Emp)
        {
            if (id != Emp.PersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Emp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonExists(Emp.PersonID))
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
            return View(Emp);
        }
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Employee == null)
            {
                return NotFound();
            }

            var Emp = await _context.Employee.FirstOrDefaultAsync(m => m.PersonID == id);
            if (Emp == null)
            {
                return NotFound();
            }
            return View(Emp);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Employee == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Person' is null.");
            }

            var Emp = await _context.Employee.FindAsync(id);
            if (Emp != null)
            {
                _context.Employee.Remove(Emp);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool PersonExists(string id)
        {
            return (_context.Employee?.Any(e =>e.PersonID == id)).GetValueOrDefault();
        }

    }
}