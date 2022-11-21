using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LocalBusinessWebApiUsingMVC.Models;

namespace LocalBusinessWebApiUsingMVC.Controllers
{
    public class Users2Controller : Controller
    {
        private readonly localbusinessdbaContext _context;

        public Users2Controller(localbusinessdbaContext context)
        {
            _context = context;
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Users2 User)
        {
            if(ModelState.IsValid)
            {
                var suma = _context.Users2s.Where(a => a.Email.Equals(User.Email) && a.Password.Equals(User.Password)).FirstOrDefault();
                if(suma!= null)
                {
                    ViewData["Email"] = User.Email.ToString();
                    ViewData["Password"]=User.Password.ToString();
                    return RedirectToAction("UserDashBoard");
                }
            }
            return View(User);
        }
        public ActionResult UserDashBoard()
        {
            if (ViewData["Email"]!=null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }


        // GET: Users2
        public async Task<IActionResult> Index()
        {
            var localbusinessdbaContext = _context.Users2s.Include(u => u.Role);
            return View(await localbusinessdbaContext.ToListAsync());
        }

        // GET: Users2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Users2s == null)
            {
                return NotFound();
            }

            var users2 = await _context.Users2s
                .Include(u => u.Role)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (users2 == null)
            {
                return NotFound();
            }

            return View(users2);
        }

        // GET: Users2/Create
        public IActionResult Create()
        {
            ViewData["RoleId"] = new SelectList(_context.Roles1s, "Roleid", "Roleid");
            return View();
        }

        // POST: Users2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Mobile,City,Location,Address,Zipcode,Password,RoleId")] Users2 users2)
        {
            if (ModelState.IsValid)
            {
                _context.Add(users2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_context.Roles1s, "Roleid", "Roleid", users2.RoleId);
            return View(users2);
        }

        // GET: Users2/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Users2s == null)
            {
                return NotFound();
            }

            var users2 = await _context.Users2s.FindAsync(id);
            if (users2 == null)
            {
                return NotFound();
            }
            ViewData["RoleId"] = new SelectList(_context.Roles1s, "Roleid", "Roleid", users2.RoleId);
            return View(users2);
        }

        // POST: Users2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Mobile,City,Location,Address,Zipcode,Password,RoleId")] Users2 users2)
        {
            if (id != users2.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(users2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Users2Exists(users2.Id))
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
            ViewData["RoleId"] = new SelectList(_context.Roles1s, "Roleid", "Roleid", users2.RoleId);
            return View(users2);
        }

        // GET: Users2/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Users2s == null)
            {
                return NotFound();
            }

            var users2 = await _context.Users2s
                .Include(u => u.Role)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (users2 == null)
            {
                return NotFound();
            }

            return View(users2);
        }

        // POST: Users2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Users2s == null)
            {
                return Problem("Entity set 'localbusinessdbaContext.Users2s'  is null.");
            }
            var users2 = await _context.Users2s.FindAsync(id);
            if (users2 != null)
            {
                _context.Users2s.Remove(users2);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Users2Exists(int id)
        {
          return _context.Users2s.Any(e => e.Id == id);
        }
    }
}
