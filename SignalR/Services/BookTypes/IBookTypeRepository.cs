using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalR.Models;

namespace SignalR.Services.BookTypes
{
    public interface IBookTypeRepository
    {
        Task<List<BookType>> getList();
        void Add(BookType author);
        void Update(BookType author);
        void Remove(BookType author);
        BookType Find(Guid id);

    }
}
