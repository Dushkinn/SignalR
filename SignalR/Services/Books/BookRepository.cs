using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalR.Controllers;
using SignalR.Models;
using SignalR.Services.Authors;

namespace SignalR.Services
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationContext _dbContext;
        public BookRepository(ApplicationContext context)
        {
            _dbContext = context;
        }
        public void Add(Author author)
        {
            _dbContext.Authors.Add(author);
            _dbContext.SaveChanges();
        }

        public Author Find(Guid id)
        {
            return _dbContext.Authors.Find(id);
        }

        public Task<List<Author>> getList()
        {
            return _dbContext.Authors.ToListAsync(); 
        }

        public void Remove(Author author)
        {
            _dbContext.Authors.Remove(author);
            _dbContext.SaveChanges();
        }

        public void Update(Author author)
        {
            _dbContext.Authors.Update(author);
            _dbContext.SaveChanges();
        }

    }
}
