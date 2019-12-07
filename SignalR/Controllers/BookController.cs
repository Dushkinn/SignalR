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
    public class BookController : Controller
    {

        private readonly ApplicationContext _dbContext;

        public BookController(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: Language
        public async Task<IActionResult> Index()
        {
            var book = _dbContext.Books.Include(c => c.Language).Include(c => c.BookType).ToList();

            return View(book);
        }

        // GET: Language/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Language/Create
        public ActionResult Create()
        {
            var languages = _dbContext.Languages.ToList();
            var bookType = _dbContext.BookTypes.ToList();
            
            ViewBag.Languages = new MultiSelectList(languages, "ID" ,"LanguageName");
            ViewBag.BookTypes = new MultiSelectList(bookType, "ID" , "Discription");

            return View(new BookViewModel {
            ID = Guid.NewGuid()
        });
        }

        // POST: Language/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BookViewModel bookViewModel)
        {
            try
            {
                Language language = _dbContext.Languages.Find(bookViewModel.selectedLanguage);
                BookType bookType = _dbContext.BookTypes.Find(bookViewModel.selectedBookType);

                Book book = new Book
                {
                    ID = bookViewModel.ID,
                    Name = bookViewModel.Name,
                    Discription = bookViewModel.Discription,
                    BookType = bookType,
                    Language = language
                };
                _dbContext.Books.Add(book);
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
            Book book = _dbContext.Books.Where(c => c.ID == id).Include(c => c.BookType).Include(c => c.Language).First();
      
            var languages = _dbContext.Languages.ToList();
            var bookType = _dbContext.BookTypes.ToList();
            
            ViewBag.Languages = new MultiSelectList(languages, "ID", "LanguageName");
            ViewBag.BookTypes = new MultiSelectList(bookType, "ID", "Discription");
            return View(new BookViewModel {
            ID = book.ID,
            Name = book.Name,
            Discription = book.Discription,
            
            });
        }

        // POST: Language/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BookViewModel bookViewModel)
        {
            try
            {
                Language language = _dbContext.Languages.Find(bookViewModel.selectedLanguage);
                BookType bookType = _dbContext.BookTypes.Find(bookViewModel.selectedBookType);

                Book book = new Book
                {
                    ID = bookViewModel.ID,
                    Name = bookViewModel.Name,
                    Discription = bookViewModel.Discription,
                    BookType = bookType,
                    Language = language
                };
                _dbContext.Books.Update(book);
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
        public ActionResult DeleteBook(Guid id)
        {
            try
            {
                Book Book = new Book { ID = id };
                _dbContext.Books.Remove(Book);
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