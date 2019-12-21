using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SignalR.Models;
using SignalR.Models.ViewModel;

namespace SignalR.Controllers
{
    [Authorize]
    public class UserController : Controller
    {

        [TempData]
        public string Message { get; set; }
        private readonly ApplicationContext _dbContext;

        public UserController(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: Language
        public async Task<IActionResult> Index()
        {
            var user = _dbContext.Users.Include(c => c.Role).ToList();

            return View(user);
        }

        // GET: Language/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Language/Create
        public ActionResult Create()
        {
            var roles = _dbContext.UserRoles.ToList();

            ViewBag.Roles = new MultiSelectList(roles, "Role", "Name");

            return View(new UserViewModel
            {
                ID = Guid.NewGuid()
            });
        }

        // POST: Language/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserViewModel userViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var roles = _dbContext.UserRoles.ToList();
                    ViewBag.Roles = new MultiSelectList(roles, "Role", "Name");
                    return View("Create", userViewModel);
                }
                UserRole userRole = _dbContext.UserRoles.Find(userViewModel.selectedRole);

                User user = new User
                {
                    FullName = userViewModel.FullName,
                    Password = userViewModel.Password,
                    Role = userRole
                };

                HttpContext.Session.SetString("User", user.FullName);
                
                _dbContext.Users.Add(user);
                
                await _dbContext.SaveChangesAsync();
                Message = $"Customer {user.FullName} added";
                
                HttpContext.Session.SetString("Message", $"Customer {user.FullName} added");
                return RedirectToPage("/Index");


            }
            catch
            {
                return View();
            }
        }

        // GET: Language/Edit/5
        //public ActionResult Edit(Guid id)
        //{
        //    User user = _dbContext.Users.Where(c => c.ID == id).Include(c => c.Role).First();
        //    var roles = _dbContext.UserRoles.ToList();

        //    ViewBag.Roles = new MultiSelectList(roles, "Role", "Name");

        //    return View(new UserViewModel
        //    {
        //        ID = Guid.NewGuid(),
        //        FullName = user.FullName,
        //        Password = user.Password,
        //        UserRole = user.Role

        //    });
        //}

        // POST: Language/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserViewModel userViewModel)
        {
            try
            {
                UserRole userRole = _dbContext.UserRoles.Find(userViewModel.selectedRole);

                User user = new User
                {
                    FullName = userViewModel.FullName,
                    Password = userViewModel.Password,
                    Role = userRole
                };
                _dbContext.Users.Update(user);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Language/Delete/5
        //public ActionResult Delete(Guid id)
        //{

        //    return View(new User { ID = id });
        //}

        //POST: Language/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteUser(Guid id)
        //{
        //    try
        //    {
        //        User user = new User { ID = id };
        //        _dbContext.Users.Remove(user);
        //        _dbContext.SaveChanges();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}