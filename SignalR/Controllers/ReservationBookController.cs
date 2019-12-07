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
    public class ReservationBookController : Controller
    {
        private readonly ApplicationContext _dbContext;

        public ReservationBookController(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: Language
        public async Task<IActionResult> Index()
        {
            var reservationBooks = _dbContext.ReservationBooks.Include(c => c.BookItem).Include(c => c.User).ToList();

            return View(reservationBooks);
        }

        // GET: Language/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Language/Create
        public ActionResult Create()
        {
            var BookItems = _dbContext.BookItems.ToList();
            var User = _dbContext.Users.ToList();

            ViewBag.BookItems = new MultiSelectList(BookItems, "ID", "ID");
            ViewBag.Users  = new MultiSelectList(User, "ID", "FullName");

            return View(new ReservationBookViewModel
            {
                ID = Guid.NewGuid()
            });
        }

        // POST: Language/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ReservationBookViewModel reservationBookViewModel)
        {
            try
            {
                BookItem bookItem = _dbContext.BookItems.Find(reservationBookViewModel.selectedBookItem);
                User user = _dbContext.Users.Find(reservationBookViewModel.selectedUser);

                ReservationBook reservationBook = new ReservationBook
                {
                    ID = reservationBookViewModel.ID,
                    BookItem = bookItem,
                    User = user
                };
                _dbContext.ReservationBooks.Add(reservationBook);
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
            ReservationBook reservationBook = _dbContext.ReservationBooks.Where(c => c.ID == id).Include(c => c.BookItem).Include(c => c.User).First();

            var bookItem = _dbContext.BookItems.ToList();
            var users = _dbContext.Users.ToList();

            ViewBag.BookItems = new MultiSelectList(bookItem, "ID", "ID");
            ViewBag.Users = new MultiSelectList(users, "ID", "FullName");
            return View(new ReservationBookViewModel
            {
                ID = reservationBook.ID

            });
        }

        // POST: Language/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ReservationBookViewModel reservationBookViewModel)
        {
            try
            {
                BookItem bookItem = _dbContext.BookItems.Find(reservationBookViewModel.selectedBookItem);
                User user = _dbContext.Users.Find(reservationBookViewModel.selectedUser);

                ReservationBook reservationBook = new ReservationBook
                {
                    ID = reservationBookViewModel.ID,
                    BookItem = bookItem,
                    User = user
                };
                _dbContext.ReservationBooks.Update(reservationBook);
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

            return View(new ReservationBook { ID = id });
        }

        //POST: Language/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteReservationBook(Guid id)
        {
            try
            {
                ReservationBook reservationBook = new ReservationBook { ID = id };
                _dbContext.ReservationBooks.Remove(reservationBook);
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