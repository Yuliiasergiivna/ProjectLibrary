using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Entities
{
    public class Book
    {
        public Guid BookId { get; set; }
        public string Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime RegisteredDate {get;set;}

        public DateTime? DisabledDate{ get;set;}
    }
}
