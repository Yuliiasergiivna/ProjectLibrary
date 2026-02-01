using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using ClassLibrary;
using ClassLibrary.Entities;


namespace ProjectLibrary.BLL.Services
{
    public class UserService
    {
        private readonly IUserProfileRepository _repository;
        public UserService(IUserProfileRepository repository)
        {
            _repository = repository;
        }
    }

    public UserProfile GetById(Guid id)
     {
            var entity = _repository.GetById(id);
            if (entity == null)
            {
                throw new KeyNotFoundException($"UserProfile with Id {id} not found.");
            }
            return entity.ToBLL();
     }
        public UserProfile Create(UserProfile userProfile)
        { 
            _repository.Insert(new ClassLibrary.Entities.UserProfile
            {
                Id = userProfile.Id,
                LastName = userProfile.LastName,
                FirstName = userProfile.FirstName,
                BirthDate = userProfile.BirthDate,
                Biography = userProfile.Biography,
                ReadingLevel = userProfile.ReadingLevel,
                NewsLetter = userProfile.NewsLetter,
                RegistrationDate = userProfile.RegistrationDate,
                DeactivationDate = userProfile.DeactivationDate
            });
        }
    }
    }
