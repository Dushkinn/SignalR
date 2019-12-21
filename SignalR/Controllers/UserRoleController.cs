using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.Models;

namespace SignalR.Controllers
{
    [Authorize]
    public class UserRoleController : Controller
    {
        private readonly ApplicationContext _dbContext;

        public UserRoleController(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var author = await _dbContext.UserRoles.ToListAsync();

            return View(author);
        }

        // GET: Language/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Language/Create
        public ActionResult Create()
        {
            UserRole userRole = new UserRole();
            userRole.Role = Guid.NewGuid();
            return View(userRole);
        }

        // POST: Language/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserRole userRole)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View(userRole);
                }

                _dbContext.UserRoles.Add(userRole);
                await _dbContext.SaveChangesAsync();

                return RedirectToPage("/Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: Language/Edit/5
        public ActionResult Edit(Guid id)
        {
            UserRole userRole = _dbContext.UserRoles.Find(id);

            return View(userRole);
        }

        // POST: Language/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, UserRole userRole)
        {
            try
            {
                userRole.Role = id;
                _dbContext.UserRoles.Update(userRole);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Language/Delete/5
        public ActionResult Delete(Guid id)
        {
           
            return View(new UserRole { Role = id });
        }

        // POST: Language/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteUserRole(Guid role)
        {
            
                UserRole userRole = new UserRole { Role = role };
                _dbContext.UserRoles.Remove(userRole);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
          
        }
    }
}
