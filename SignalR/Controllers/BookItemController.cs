using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SignalR.Models;
using SignalR.Models.ViewModel;

namespace SignalR.Controllers
{
    public class BookItemController : Controller
    {
        private readonly ApplicationContext _dbContext;

        public BookItemController(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: Language
        public async Task<IActionResult> Index()
        {
            var bookItems = _dbContext.BookItems.Include(c => c.Book).Include(c => c.State).ToList();

            return View(bookItems);
        }

        // GET: Language/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Language/Create
        public ActionResult Create()
        {
            var books = _dbContext.Books.ToList();
            var states = _dbContext.StateTypes.ToList();

            ViewBag.Books = new MultiSelectList(books, "ID", "Name");
            ViewBag.States = new MultiSelectList(states, "Id", "StateName");

            return View(new BookItemViewModel
            {
                ID = Guid.NewGuid()
            });
        }

        // POST: Language/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BookItemViewModel bookItemViewModel)
        {
            try
            {
                Book book = _dbContext.Books.Find(bookItemViewModel.selectedBook);
                StateType state = _dbContext.StateTypes.Find(bookItemViewModel.selectedState);

                BookItem bookItem = new BookItem
                {
                    ID = bookItemViewModel.ID,
                    State = state,
                    Book = book
                };
                _dbContext.BookItems.Add(bookItem);
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
            BookItem bookItem = _dbContext.BookItems.Where(c => c.ID == id).Include(c => c.Book).Include(c => c.State).First();

            var books = _dbContext.Books.ToList();
            var states = _dbContext.StateTypes.ToList();

            ViewBag.Books = new MultiSelectList(books, "ID", "Name");
            ViewBag.States = new MultiSelectList(states, "Id", "StateName");
            return View(new BookItemViewModel
            {
                ID = bookItem.ID

            });
        }

        // POST: Language/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BookItemViewModel bookItemViewModel)
        {
            try
            {
                Book book = _dbContext.Books.Find(bookItemViewModel.selectedBook);
                StateType state = _dbContext.StateTypes.Find(bookItemViewModel.selectedState);

                BookItem bookItem = new BookItem
                {
                    ID = bookItemViewModel.ID,
                    Book = book,
                    State = state
                };
                _dbContext.BookItems.Update(bookItem);
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

            return View(new BookType { ID = id });
        }

        //POST: Language/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteBookItem(Guid id)
        {
            try
            {
                BookItem bookItem = new BookItem { ID = id };
                _dbContext.BookItems.Remove(bookItem);
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