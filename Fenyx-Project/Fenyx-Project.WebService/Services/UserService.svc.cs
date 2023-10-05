using AppForm.WebServices.Utils;
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
            var usersFromDb = new UserDaoImpl().GetAll();

            List<UserListItemContract> userListItemContract = MapperConfig
                .ModelMapper.Map<List<UserListItemContract>>(usersFromDb);

            return userListItemContract;
        }

        public UserContract FindUser(Guid id)
        {
            var usersFromDb = new UserDaoImpl().Get(id);

            UserContract userContract = MapperConfig
                .ModelMapper.Map<UserContract>(usersFromDb);
            
            return userContract;
        }

        public UserContract AddUser(UserContract p)
        {
            User userSaved = MapperConfig
                .ModelMapper.Map<User>(p);

            new UserDaoImpl().Create(userSaved);
            return p;
        }

        public UserContract UpdateUser(UserContract p)
        {
            User userSaved = MapperConfig
              .ModelMapper.Map<User>(p);

            new UserDaoImpl().Update(userSaved);
            return p;
        }

        public void DeleteUser(Guid id)
        {
            new UserDaoImpl().Delete(id);
        }
    }
}
