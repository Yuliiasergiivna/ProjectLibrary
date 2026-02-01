using System;
using System.Collections.Generic;
using System.Text;
using BLLEntities = ProjectLibrary.BLL.Entities;
using DALEntities =ClassLibrary.Entities;

namespace ProjectLibrary.BLL.Mappers
{
    public static class UserMapper
    {
        public static BLLEntities.UserProfile ToBLL(this DALEntities.UserProfile entity)
        {
            return new BLLEntities.UserProfile(
                entity.Id,
                entity.LastName,
                entity.FirstName,
                entity.BirthDate,
                entity.RegistrationDate,
                entity.Biography,
                entity.ReadingLevel,
                entity.NewsLetter,
                entity.DeactivationDate
            );
        }

    }
}
