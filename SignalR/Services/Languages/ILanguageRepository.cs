using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalR.Models;

namespace SignalR.Services.Languages
{
    public interface ILanguageRepository
    {
        Task<List<Language>> getList();
        void Add(Language language);
        void Update(Language language);
        void Remove(Language language);
        Language Find(Guid id);
    }
}
