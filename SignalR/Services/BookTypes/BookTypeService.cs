using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalR.Models;

namespace SignalR.Services.BookTypes
{
    public class BookTypeService
    {
        private readonly IBookTypeRepository _bookTypeRepository;

        public BookTypeService(IBookTypeRepository bookTypeRepository)
        {
            _bookTypeRepository = bookTypeRepository;
        }
        public Task<List<BookType>> GetList()
        {
            return _bookTypeRepository.getList();
        }
        public void Create(BookType bookType)
        {
            _bookTypeRepository.Add(bookType);
        }
        public void Edit(Guid id, BookType bookType)
        {
            bookType.ID = id;
            _bookTypeRepository.Update(bookType);
        }
        public BookType Get(Guid id)
        {
            return _bookTypeRepository.Find(id);
        }

        public void Remove(Guid id)
        {
            BookType bookType = new BookType { ID = id };
            _bookTypeRepository.Remove(bookType);
        }
    }
}
