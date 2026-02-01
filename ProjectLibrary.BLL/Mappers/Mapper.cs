using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLibrary.BLL.Mappers
{
    internal static class Mapper
    {
        public static BLL.Entities.Book ToBLL(this ClassLibrary.Entities.Book entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            return new BLL.Entities.Book(
                entity.BookId,
                entity.Title,
                entity.Author,
                entity.ISBN,
                entity.ReleaseDate,
                entity.RegisteredDate,
                entity.DisabledDate
                );
        }
        public static ClassLibrary.Entities.Book ToDAL(this BLL.Entities.Book entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            return new ClassLibrary.Entities.Book
            {
                BookId = entity.BookId,
                Title = entity.Title,
                Author = entity.Author,
                ISBN = entity.ISBN,
                ReleaseDate = entity.ReleaseDate,
                RegisteredDate = entity.RegisteredDate,
                //DisabledDate =(entity.IsActive) ? null : (DateTime?)DateTime.Now
            };
        }
    }
}
