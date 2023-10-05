using Fenyx_Project.WebService.Contracts;
using Fenyx_Project.WebService.Dao.Impl;
using Fenyx_Project.WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Fenyx_Project.WebService.Services
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "UserService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez UserService.svc ou UserService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class UserService : IUserService
    {
        public List<UserListItemContract> FindAllUsers()
        {
            List<UserListItemContract> userListItemContract = null;
            var usersFromDb = new UserDaoImpl().GetAll();

            userListItemContract = new List<UserListItemContract>(
                usersFromDb.Select(user =>
                new UserListItemContract
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Birthdate = user.Birthdate,
                    PhotoUrl = user.PhotoUrl
                })
            );

            return userListItemContract;
        }

        public UserContract FindUser(Guid id)
        {
            UserContract userContract = null;
            var usersFromDb = new UserDaoImpl().Get(id);

            userContract = new UserContract
            {
                Id = usersFromDb.Id,
                FirstName = usersFromDb.FirstName,
                LastName = usersFromDb.LastName,
                Birthdate = usersFromDb.Birthdate,
                PhotoUrl = usersFromDb.PhotoUrl,
                AddressStreet = usersFromDb.Address.Street,
                AddressZipcode = usersFromDb.Address.Zipcode,
                AddressCity = usersFromDb.Address.City
            };

            return userContract;
        }

        public UserContract AddUser(UserContract p)
        {
            User userSaved = new User
            {
                FirstName = p.FirstName,
                LastName = p.LastName,
                Birthdate = p.Birthdate,
                PhotoUrl = p.PhotoUrl,
                Address = new Address()
                {
                    Street = p.AddressStreet,
                    Zipcode = p.AddressZipcode,
                    City = p.AddressCity
                }
            };

            new UserDaoImpl().Create(userSaved);
            return p;
        }

        public UserContract UpdateUser(UserContract p)
        {
            User userSaved = new User
            {
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName,
                Birthdate = p.Birthdate,
                PhotoUrl = p.PhotoUrl,
                Address = new Address()
                {
                    Street = p.AddressStreet,
                    Zipcode = p.AddressZipcode,
                    City = p.AddressCity
                }
            };

            new UserDaoImpl().Update(userSaved);
            return p;
        }

        public void DeleteUser(Guid id)
        {
            new UserDaoImpl().Delete(id);
        }
    }
}
