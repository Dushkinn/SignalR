using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalR.Models;

namespace SignalR.Services.Authors
{
    public class AuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        public Task<List<Author>> GetAuthors() 
        {
            return _authorRepository.getList();
        }
        public void CreateAuthor(Author author) {
            _authorRepository.Add(author);
        }
        public void EditAuthor(Guid id, Author author) {
            author.Id = id;
            _authorRepository.Update(author);
        }
        public Author GetAuthor(Guid id) {
            return _authorRepository.Find(id);
        }

        public void RemoveAuthor(Guid id) {
            Author author = new Author { Id = id };
            _authorRepository.Remove(author);
        }

    }
}
