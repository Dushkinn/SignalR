using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.Models;
using SignalR.Models.ViewModel;

namespace SignalR.Controllers
{
    [Authorize]
    public class TagController : Controller
    {
        private readonly ApplicationContext _dbContext;

        public TagController(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: Tag
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var tags = await _dbContext.Tags.ToListAsync();
            ViewBag.List = tags;
            return View("TagList",new TagsListModel {
                TagsList = tags
            } );
        }

        // GET: Tag/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tag/Create
        public  ActionResult Create()
        {
            return View("Create");
        }

        // POST: Tag/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<IActionResult> Create(Tag  Tag)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(Tag);
                }

                _dbContext.Tags.Add(Tag);
                await _dbContext.SaveChangesAsync();

                return RedirectToPage("/Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: Tag/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tag/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction();
            }
            catch
            {
                return View();
            }
        }

        // GET: Tag/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(new Tag { ID = id });
        }

        // POST: Tag/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteTag(Guid id)
        {
            try
            {
                Tag tag = new Tag { ID = id };
                _dbContext.Tags.Remove(tag);
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