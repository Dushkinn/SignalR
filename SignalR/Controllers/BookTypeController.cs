using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.Models;
using SignalR.Services.BookTypes;

namespace SignalR.Controllers
{
    public class BookTypeController : Controller
    {
        private readonly BookTypeService _bookTypeService;

        public BookTypeController(BookTypeService bookTypeService)
        {
            _bookTypeService = bookTypeService;
        }
        // GET: BookType
        public async Task<IActionResult> Index()
        {
            var bookTypes = await _bookTypeService.GetList();

            return View(bookTypes);
        }

        // GET: BookType/Details/5
        public ActionResult Details(int id)
        {
            return View();  
        }

        // GET: BookType/Create
        public ActionResult Create()
        {
            BookType bookType = new BookType();
            bookType.ID = Guid.NewGuid();
            return View(bookType);
        }

        // POST: BookType/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BookType bookType)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View(bookType);
                }

                _bookTypeService.Create(bookType);

                return RedirectToPage("/Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: BookType/Edit/5
        public ActionResult Edit(Guid id)
        {
            BookType bookType = _bookTypeService.Get(id);

            return View(bookType);
        }

        // POST: BookType/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, BookType bookType)
        {
            try
            {
                _bookTypeService.Edit( id,  bookType);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookType/Delete/5
        public ActionResult Delete(Guid id)
        {

            return View(new BookType { ID = id });
        }

        // POST: BookType/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteBookType(Guid id)
        {
            try
            {
                _bookTypeService.Remove(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }

}