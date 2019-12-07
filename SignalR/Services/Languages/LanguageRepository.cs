
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalR.Controllers;
using SignalR.Models;

namespace SignalR.Services.Languages
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly ApplicationContext _dbContext;
        public LanguageRepository(ApplicationContext context)
        {
            _dbContext = context;
        }
        public void Add(Language language)
        {
            _dbContext.Languages.Add(language);
            _dbContext.SaveChanges();
        }

        public Language Find(Guid id)
        {
            return _dbContext.Languages.Find(id);
        }

        public Task<List<Language>> getList()
        {
            return _dbContext.Languages.ToListAsync();
        }

        public void Remove(Language language)
        {
            _dbContext.Languages.Remove(language);
            _dbContext.SaveChanges();
        }

        public void Update(Language language)
        {
            _dbContext.Languages.Update(language);
            _dbContext.SaveChanges();
        }
    }
}
