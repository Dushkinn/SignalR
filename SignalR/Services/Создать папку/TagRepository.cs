using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SignalR.Controllers;
using SignalR.Models;

namespace SignalR.Services.Создатьпапку
{
    public class TagRepository
    {
        
        private readonly ApplicationContext _dbContext;
        public TagRepository(ApplicationContext context)
        {
            _dbContext = context;
        }
        public void Add(Tag tag)
        {
            _dbContext.Tags.Add(tag);
            _dbContext.SaveChanges();
        }

        public Language Find(Guid id)
        {
            return _dbContext.Languages.Find(id);
        }

        public Task<List<Tag>> getList()
        {
            return _dbContext.Tags.ToListAsync();
        }

        public void Remove(Tag language)
        {
            _dbContext.Tags.Remove(language);
            _dbContext.SaveChanges();
        }

        public void Update(Tag language)
        {
            _dbContext.Tags.Update(language);
            _dbContext.SaveChanges();
        }
    }
}
