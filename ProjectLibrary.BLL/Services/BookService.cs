using ClassLibrary.Entities;
using ProjectLibrary.BLL.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ProjectLibrary.BLL.Services
{
    public class BookService
    {
        private readonly ClassLibrary.Services.BookServices _dalService;
        public BookService(ClassLibrary.Services.BookServices dalService)
        {
            _dalService = dalService;
        }
        public IEnumerable<Book> Get()
        {
            return _dalService.Get().Select(book => book.ToBLL);
        }
        public Book Get(Guid bookId)
        {
            return _dalService.Get(bookId).ToBLL();
        }
        public Book Create(Book entity)
        {
            return _dalService.Create(entity.ToDAL);
        }
        public void Update(Guid bookId, Book newData)
        {
            _dalService.Update(bookId, newData.ToDAL());
        }
        public void Delete(Guid bookId)
        {
            _dalService.Delete(bookId);
        }
    }



}
