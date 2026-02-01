
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Entities
{
    public  class UserProfile
    {
        public Guid Id { get; set;}
        public string LastName { get; set;}
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Biography { get; set; }
        public int? ReadingLevel { get; set; }
        public bool NewsLetter { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime? DeactivationDate { get; set; }

    }
}
