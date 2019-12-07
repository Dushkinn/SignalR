using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalR.Models;
namespace SignalR.Services.Authors
{
    public interface IBookRepository
    {
        Task<List<Author>> getList();
        void Add(Author author);
        void Update(Author author);
        void Remove(Author author);
        Author Find(Guid id);

    }


}
