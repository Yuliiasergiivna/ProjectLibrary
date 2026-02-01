using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLibrary.BLL.Entities
{
    public class UserProfile
    {
        public Guid Id { get;  }
        public string LastName { get;  }
        public string FirstName { get;  }
        public DateTime BirthDate { get;  }
        public DateTime RegistrationDate { get; }

        public string? Biography { get; set; }
        public int? ReadingLevel { get; set; }
        public bool NewsLetter { get; set; }
        private DateTime? DeactivationDate { get;  set; }
        //construct minimum
        public UserProfile( string lastName, string firstName, DateTime birthDate, bool newsLetter = true)
        {
            Id = Guid.NewGuid();
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
            NewsLetter = newsLetter;
            RegistrationDate = DateTime.Now;
        }
        //construct full
        public UserProfile( Guid id, string lastName, string firstName, DateTime birthDate, DateTime registrationDate, string? biography = null, int? readingLevel = null, bool newsLetter = true, DateTime? deactivationDate = null)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
            Biography = biography;
            ReadingLevel = readingLevel;
            NewsLetter = newsLetter;
            RegistrationDate = registrationDate;
            DeactivationDate = deactivationDate;
        }
        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age = now.Year - BirthDate.Year;
                if (now  < BirthDate.AddYears(age))
                {
                    age--;
                }
                return age;
            }
        }
        public int Seniority => (DateTime.Now - RegistrationDate).Days;
        public void Deactivate()
        {
            DeactivationDate = DateTime.Now;
        }
    }
}
