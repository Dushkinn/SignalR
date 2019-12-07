using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalR.Controllers;
using SignalR.Models;

namespace SignalR.Services.BookTypes
{
    public class BookTypeRepository : IBookTypeRepository
    {
        private readonly ApplicationContext _dbContext;
        public BookTypeRepository(ApplicationContext context)
        {
            _dbContext = context;
        }
        public void Add(BookType bookType)
        {
            _dbContext.BookTypes.Add(bookType);
            _dbContext.SaveChanges();
        }

        public BookType Find(Guid id)
        {
            return _dbContext.BookTypes.Find(id);
        }

        public Task<List<BookType>> getList()
        {
            return _dbContext.BookTypes.ToListAsync();
        }

        public void Remove(BookType bookType)
        {
            _dbContext.BookTypes.Remove(bookType);
            _dbContext.SaveChanges();
        }

        public void Update(BookType bookType)
        {
            _dbContext.BookTypes.Update(bookType);
            _dbContext.SaveChanges();
        }
    }
}
