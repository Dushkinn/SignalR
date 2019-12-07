using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.Models;

namespace SignalR.Controllers
{
    public class StateTypeController : Controller
    {
        private readonly ApplicationContext _dbContext;

        public StateTypeController(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: Language
        public async Task<IActionResult> Index()
        {
            var stateTypes = await _dbContext.StateTypes.ToListAsync();

            return View(stateTypes);
        }

        // GET: Language/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Language/Create
        public ActionResult Create()
        {
            StateType stateType = new StateType();
            stateType.Id = Guid.NewGuid();
            return View(stateType);
        }

        // POST: Language/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(StateType stateType)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View(stateType);
                }

                _dbContext.StateTypes.Add(stateType);
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
            StateType stateType = _dbContext.StateTypes.Find(id);

            return View(stateType);
        }

        // POST: Language/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, StateType stateType)
        {
            try
            {
                stateType.Id = id;
                _dbContext.StateTypes.Update(stateType);
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

            return View(new StateType { Id = id });
        }

        // POST: Language/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteStateType(Guid id)
        {
            try
            {
                StateType stateType = new StateType { Id = id };
                _dbContext.StateTypes.Remove(stateType);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}