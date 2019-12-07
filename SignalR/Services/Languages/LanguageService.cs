using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalR.Models;

namespace SignalR.Services.Languages
{
    public class LanguageService
    {
        private readonly ILanguageRepository _languageRepository;

        public LanguageService(ILanguageRepository languageRepository)
        {
            _languageRepository = languageRepository;
        }
        public Task<List<Language>> GetList()
        {
            return _languageRepository.getList();
        }
        public void Create(Language language)
        {
            _languageRepository.Add(language);
        }
        public void Edit(Guid id, Language language)
        {
            language.ID = id;
            _languageRepository.Update(language);
        }
        public Language Get(Guid id)
        {
            return _languageRepository.Find(id);
        }

        public void Remove(Guid id)
        {
            Language language = new Language { ID = id };
            _languageRepository.Remove(language);
        }
    }
}
