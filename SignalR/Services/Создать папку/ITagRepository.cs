using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SignalR.Models;

namespace SignalR.Services.Создатьпапку
{
    public interface ITagRepository
    {
        Task<List<Tag>> getList();
        void Add(Tag language);
        void Update(Tag language);
        void Remove(Tag language);
        Tag Find(Guid id);
    }
}
