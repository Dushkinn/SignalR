using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SignalR.Models;

namespace SignalR.Services.Создатьпапку
{
    public class TagService
    {
        private readonly ITagRepository _tagRepository;

        public TagService(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }
        public Task<List<Tag>> GetList()
        {
            return _tagRepository.getList();
        }
        public void Create(Tag tag)
        {
            _tagRepository.Add(tag);
        }
        public void Edit(Guid id, Tag tag)
        {
            tag.ID = id;
            _tagRepository.Update(tag);
        }
        public Tag Get(Guid id)
        {
            return _tagRepository.Find(id);
        }

        public void Remove(Guid id)
        {
            Tag language = new Tag { ID = id };
            _tagRepository.Remove(language);
        }
    }
}
